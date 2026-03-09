#### [SHTCGClient](index.md 'index')
### [SHTCGClient](index.md#SHTCGClient 'SHTCGClient')

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

| Methods | |
| :--- | :--- |
| [Dispose\(\)](SHTCGClient.ThrottledProcessor.Dispose().md 'SHTCGClient\.ThrottledProcessor\.Dispose\(\)') | |
| [EnqueueAsync\(Func&lt;CancellationToken,Task&gt;\)](SHTCGClient.ThrottledProcessor.EnqueueAsync.md#SHTCGClient.ThrottledProcessor.EnqueueAsync(System.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_) 'SHTCGClient\.ThrottledProcessor\.EnqueueAsync\(System\.Func\<System\.Threading\.CancellationToken,System\.Threading\.Tasks\.Task\>\)') | Enqueue a job |
| [EnqueueAsync&lt;T&gt;\(Func&lt;CancellationToken,Task&lt;T&gt;&gt;\)](SHTCGClient.ThrottledProcessor.EnqueueAsync.md#SHTCGClient.ThrottledProcessor.EnqueueAsync_T_(System.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__) 'SHTCGClient\.ThrottledProcessor\.EnqueueAsync\<T\>\(System\.Func\<System\.Threading\.CancellationToken,System\.Threading\.Tasks\.Task\<T\>\>\)') | Enqueue a job with a return type\. |
