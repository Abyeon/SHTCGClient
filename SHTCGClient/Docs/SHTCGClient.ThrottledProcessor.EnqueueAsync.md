#### [SHTCGClient](index.md 'index')
### [SHTCGClient](SHTCGClient.md 'SHTCGClient').[ThrottledProcessor](SHTCGClient.ThrottledProcessor.md 'SHTCGClient\.ThrottledProcessor')

## ThrottledProcessor\.EnqueueAsync Method

| Overloads | |
| :--- | :--- |
| [EnqueueAsync\(Func&lt;CancellationToken,Task&gt;\)](SHTCGClient.ThrottledProcessor.EnqueueAsync.md#SHTCGClient.ThrottledProcessor.EnqueueAsync(System.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_) 'SHTCGClient\.ThrottledProcessor\.EnqueueAsync\(System\.Func\<System\.Threading\.CancellationToken,System\.Threading\.Tasks\.Task\>\)') | Enqueue a job |
| [EnqueueAsync&lt;T&gt;\(Func&lt;CancellationToken,Task&lt;T&gt;&gt;\)](SHTCGClient.ThrottledProcessor.EnqueueAsync.md#SHTCGClient.ThrottledProcessor.EnqueueAsync_T_(System.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__) 'SHTCGClient\.ThrottledProcessor\.EnqueueAsync\<T\>\(System\.Func\<System\.Threading\.CancellationToken,System\.Threading\.Tasks\.Task\<T\>\>\)') | Enqueue a job with a return type\. |

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