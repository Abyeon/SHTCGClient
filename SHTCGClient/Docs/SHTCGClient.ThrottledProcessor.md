#### [SHTCGClient](index.md 'index')
### [SHTCGClient](index.md#SHTCGClient 'SHTCGClient')

## ThrottledProcessor Class

Throttled task processor utilizing threading\.channels\.

```csharp
public class ThrottledProcessor : System.IDisposable
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; ThrottledProcessor

Implements [System\.IDisposable](https://learn.microsoft.com/en-us/dotnet/api/system.idisposable 'System\.IDisposable')
### Constructors

<a name='SHTCGClient.ThrottledProcessor.ThrottledProcessor(System.TimeSpan)'></a>

## ThrottledProcessor\(TimeSpan\) Constructor

```csharp
public ThrottledProcessor(System.TimeSpan delay);
```
#### Parameters

<a name='SHTCGClient.ThrottledProcessor.ThrottledProcessor(System.TimeSpan).delay'></a>

`delay` [System\.TimeSpan](https://learn.microsoft.com/en-us/dotnet/api/system.timespan 'System\.TimeSpan')
### Methods

<a name='SHTCGClient.ThrottledProcessor.Dispose()'></a>

## ThrottledProcessor\.Dispose\(\) Method

```csharp
public void Dispose();
```

Implements [Dispose\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.idisposable.dispose 'System\.IDisposable\.Dispose')

<a name='SHTCGClient.ThrottledProcessor.EnqueueAsync(System.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_)'></a>

## ThrottledProcessor\.EnqueueAsync\(Func\<CancellationToken,Task\>\) Method

Enqueue a job

```csharp
public System.Threading.Tasks.Task EnqueueAsync(System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task> job);
```
#### Parameters

<a name='SHTCGClient.ThrottledProcessor.EnqueueAsync(System.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_).job'></a>

`job` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Threading\.Tasks\.Task](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task 'System\.Threading\.Tasks\.Task')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

The job to process

#### Returns
[System\.Threading\.Tasks\.Task](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task 'System\.Threading\.Tasks\.Task')  
The task for this job\.

<a name='SHTCGClient.ThrottledProcessor.EnqueueAsync_T_(System.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__)'></a>

## ThrottledProcessor\.EnqueueAsync\<T\>\(Func\<CancellationToken,Task\<T\>\>\) Method

Enqueue a job with a return type\.

```csharp
public System.Threading.Tasks.Task<T> EnqueueAsync<T>(System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<T>> job);
```
#### Type parameters

<a name='SHTCGClient.ThrottledProcessor.EnqueueAsync_T_(System.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__).T'></a>

`T`

The type to return
#### Parameters

<a name='SHTCGClient.ThrottledProcessor.EnqueueAsync_T_(System.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__).job'></a>

`job` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[T](SHTCGClient.ThrottledProcessor.md#SHTCGClient.ThrottledProcessor.EnqueueAsync_T_(System.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__).T 'SHTCGClient\.ThrottledProcessor\.EnqueueAsync\<T\>\(System\.Func\<System\.Threading\.CancellationToken,System\.Threading\.Tasks\.Task\<T\>\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

The job to process

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[T](SHTCGClient.ThrottledProcessor.md#SHTCGClient.ThrottledProcessor.EnqueueAsync_T_(System.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__).T 'SHTCGClient\.ThrottledProcessor\.EnqueueAsync\<T\>\(System\.Func\<System\.Threading\.CancellationToken,System\.Threading\.Tasks\.Task\<T\>\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
The job's returned object\.