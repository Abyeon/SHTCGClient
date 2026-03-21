#### [SHTCGClient](index.md 'index')
### [SHTCGClient\.Extensions](index.md#SHTCGClient.Extensions 'SHTCGClient\.Extensions')

## CardExtensions Class

```csharp
public static class CardExtensions
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; CardExtensions
### Methods

<a name='SHTCGClient.Extensions.CardExtensions.Sell(SHTCGClient.ClientService)'></a>

## CardExtensions\.Sell\(ClientService\) Method

Helper method for selling an array of cards\.
Provides more information than just providing an array of IDs to the API\.

```csharp
public static System.Threading.Tasks.Task<SHTCGClient.Models.Cards.Card[]> Sell(SHTCGClient.ClientService client);
```
#### Parameters

<a name='SHTCGClient.Extensions.CardExtensions.Sell(SHTCGClient.ClientService).client'></a>

`client` [ClientService](SHTCGClient.ClientService.md 'SHTCGClient\.ClientService')

Your client

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Card](SHTCGClient.Models.Cards.Card.md 'SHTCGClient\.Models\.Cards\.Card')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Array of sold cards