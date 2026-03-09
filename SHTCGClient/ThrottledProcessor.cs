using System.Threading.Channels;

namespace SHTCGClient;

/// <summary>
/// Throttled task processor utilizing threading.channels.
/// </summary>
public class ThrottledProcessor : IDisposable
{
    private readonly Channel<Func<CancellationToken, Task>> _channel;
    private readonly CancellationTokenSource _cts = new();
    private readonly Task _processingTask;
    private readonly TimeSpan _delay;

    public ThrottledProcessor(TimeSpan delay)
    {
        _delay = delay;
        _channel = Channel.CreateUnbounded<Func<CancellationToken, Task>>();
        _processingTask = Task.Run(Process);
    }

    /// <summary>
    /// Enqueue a job with a return type.
    /// </summary>
    /// <param name="job">The job to process</param>
    /// <typeparam name="T">The type to return</typeparam>
    /// <returns>The job's returned object.</returns>
    public Task<T> EnqueueAsync<T>(Func<CancellationToken, Task<T>> job)
    {
        var tcs = new TaskCompletionSource<T>(TaskCreationOptions.RunContinuationsAsynchronously);

        _channel.Writer.TryWrite(QueueItem);
        return tcs.Task;

        async Task QueueItem(CancellationToken token)
        {
            try
            {
                T result = await job(token);
                tcs.SetResult(result);
            }
            catch (OperationCanceledException) when (token.IsCancellationRequested)
            {
                tcs.SetCanceled(token);
            }
            catch (Exception e)
            {
                tcs.SetException(e);
            }
        }
    }
    
    /// <summary>
    /// Enqueue a job
    /// </summary>
    /// <param name="job">The job to process</param>
    /// <returns>The task for this job.</returns>
    public Task EnqueueAsync(Func<CancellationToken, Task> job)
    {
        var tcs = new TaskCompletionSource(TaskCreationOptions.RunContinuationsAsynchronously);

        _channel.Writer.TryWrite(QueueItem);
        return tcs.Task;

        async Task QueueItem(CancellationToken token)
        {
            try
            {
                await job(token);
                tcs.SetResult();
            }
            catch (OperationCanceledException) when (token.IsCancellationRequested)
            {
                tcs.SetCanceled(token);
            }
            catch (Exception ex)
            {
                tcs.SetException(ex);
            }
        }
    }

    private async Task Process()
    {
        try
        {
            await foreach (var job in _channel.Reader.ReadAllAsync(_cts.Token))
            {
                await job(_cts.Token);
                await Task.Delay(_delay, _cts.Token);
            }
        }
        catch (OperationCanceledException)
        {
            // ignore
        }
    }

    public void Dispose()
    {
        _channel.Writer.TryComplete();
        _cts.Cancel();
        GC.SuppressFinalize(this);
    }
}