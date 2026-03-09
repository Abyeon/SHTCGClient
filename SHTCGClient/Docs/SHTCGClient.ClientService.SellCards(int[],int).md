#### [SHTCGClient](index.md 'index')
### [SHTCGClient](SHTCGClient.md 'SHTCGClient').[ClientService](SHTCGClient.ClientService.md 'SHTCGClient\.ClientService')

## ClientService\.SellCards\(int\[\], int\) Method

Sell cards

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Vendors.CardSellResponse?> SellCards(int[] cardIds, int vendorId);
```
#### Parameters

<a name='SHTCGClient.ClientService.SellCards(int[],int).cardIds'></a>

`cardIds` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The card IDs

<a name='SHTCGClient.ClientService.SellCards(int[],int).vendorId'></a>

`vendorId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The vendor ID to sell to

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[CardSellResponse](SHTCGClient.Models.Vendors.CardSellResponse.md 'SHTCGClient\.Models\.Vendors\.CardSellResponse')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Sale information