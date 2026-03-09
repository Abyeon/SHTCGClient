#### [SHTCGClient](index.md 'index')
### [SHTCGClient](SHTCGClient.md 'SHTCGClient').[ClientService](SHTCGClient.ClientService.md 'SHTCGClient\.ClientService')

## ClientService\.SellCard\(int, int\) Method

Sell a card

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Vendors.CardSellResponse?> SellCard(int cardId, int vendorId);
```
#### Parameters

<a name='SHTCGClient.ClientService.SellCard(int,int).cardId'></a>

`cardId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The card ID

<a name='SHTCGClient.ClientService.SellCard(int,int).vendorId'></a>

`vendorId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The vendor ID to sell to

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[CardSellResponse](SHTCGClient.Models.Vendors.CardSellResponse.md 'SHTCGClient\.Models\.Vendors\.CardSellResponse')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Sale information