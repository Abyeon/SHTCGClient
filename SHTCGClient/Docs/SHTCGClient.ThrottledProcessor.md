#### [SHTCGClient](index.md 'index')
### [SHTCGClient](SHTCGClient.md 'SHTCGClient')

## ThrottledProcessor Class

Throttled task processor utilizing threading\.channels\.

```csharp
public class ThrottledProcessor : System.IDisposable
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; ThrottledProcessor

Implements [System\.IDisposable](https://learn.microsoft.com/en-us/dotnet/api/system.idisposable 'System\.IDisposable')

| Constructors | |
| :--- | :--- |
| [ThrottledProcessor\(TimeSpan\)](SHTCGClient.ThrottledProcessor.ThrottledProcessor(System.TimeSpan).md 'SHTCGClient\.ThrottledProcessor\.ThrottledProcessor\(System\.TimeSpan\)') | |

| Fields | |
| :--- | :--- |
| [\_channel](SHTCGClient.ThrottledProcessor._channel.md 'SHTCGClient\.ThrottledProcessor\.\_channel') | |
| [\_cts](SHTCGClient.ThrottledProcessor._cts.md 'SHTCGClient\.ThrottledProcessor\.\_cts') | |
| [\_delay](SHTCGClient.ThrottledProcessor._delay.md 'SHTCGClient\.ThrottledProcessor\.\_delay') | |
| [\_processingTask](SHTCGClient.ThrottledProcessor._processingTask.md 'SHTCGClient\.ThrottledProcessor\.\_processingTask') | |

| Methods | |
| :--- | :--- |
| [Dispose\(\)](SHTCGClient.ThrottledProcessor.Dispose().md 'SHTCGClient\.ThrottledProcessor\.Dispose\(\)') | |
| [EnqueueAsync\(Func&lt;CancellationToken,Task&gt;\)](SHTCGClient.ThrottledProcessor.EnqueueAsync.md#SHTCGClient.ThrottledProcessor.EnqueueAsync(System.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_) 'SHTCGClient\.ThrottledProcessor\.EnqueueAsync\(System\.Func\<System\.Threading\.CancellationToken,System\.Threading\.Tasks\.Task\>\)') | Enqueue a job |
| [EnqueueAsync&lt;T&gt;\(Func&lt;CancellationToken,Task&lt;T&gt;&gt;\)](SHTCGClient.ThrottledProcessor.EnqueueAsync.md#SHTCGClient.ThrottledProcessor.EnqueueAsync_T_(System.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__) 'SHTCGClient\.ThrottledProcessor\.EnqueueAsync\<T\>\(System\.Func\<System\.Threading\.CancellationToken,System\.Threading\.Tasks\.Task\<T\>\>\)') | Enqueue a job with a return type\. |
| [Process\(\)](SHTCGClient.ThrottledProcessor.Process().md 'SHTCGClient\.ThrottledProcessor\.Process\(\)') | |
