#### [SHTCGClient](index.md 'index')
### [SHTCGClient](index.md#SHTCGClient 'SHTCGClient').[ThrottledProcessor](SHTCGClient.ThrottledProcessor.md 'SHTCGClient\.ThrottledProcessor')

## ThrottledProcessor\.\_channel Field

```csharp
private readonly Channel<Func<CancellationToken,Task>> _channel;
```

#### Field Value
[System\.Threading\.Channels\.Channel&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.channels.channel-1 'System\.Threading\.Channels\.Channel\`1')[System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Threading\.Tasks\.Task](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task 'System\.Threading\.Tasks\.Task')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.channels.channel-1 'System\.Threading\.Channels\.Channel\`1')