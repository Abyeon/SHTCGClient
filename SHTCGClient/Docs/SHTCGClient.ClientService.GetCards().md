#### [SHTCGClient](index.md 'index')
### [SHTCGClient](SHTCGClient.md 'SHTCGClient').[ClientService](SHTCGClient.ClientService.md 'SHTCGClient\.ClientService')

## ClientService\.GetCards\(\) Method

Get the User's owned cards\. \(This automatically de\-paginates the request and gets all cards\.\)

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Cards.Card[]?> GetCards();
```

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Card](SHTCGClient.Models.Cards.Card.md 'SHTCGClient\.Models\.Cards\.Card')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Array of cards