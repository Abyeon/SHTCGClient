#### [SHTCGClient](index.md 'index')
### [SHTCGClient](index.md#SHTCGClient 'SHTCGClient').[ClientService](SHTCGClient.ClientService.md 'SHTCGClient\.ClientService')

## ClientService\.RollHistory\(int\) Method

Get the last x rolls

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Cards.Card[]?> RollHistory(int count);
```
#### Parameters

<a name='SHTCGClient.ClientService.RollHistory(int).count'></a>

`count` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

Amount of rolls to fetch

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Card](SHTCGClient.Models.Cards.Card.md 'SHTCGClient\.Models\.Cards\.Card')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Array of cards