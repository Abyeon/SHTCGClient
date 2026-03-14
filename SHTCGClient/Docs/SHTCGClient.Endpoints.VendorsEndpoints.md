#### [SHTCGClient](index.md 'index')
### [SHTCGClient\.Endpoints](index.md#SHTCGClient.Endpoints 'SHTCGClient\.Endpoints')

## VendorsEndpoints Class

Class for interacting with the vendors endpoint\.

```csharp
public class VendorsEndpoints
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; VendorsEndpoints
### Constructors

<a name='SHTCGClient.Endpoints.VendorsEndpoints.VendorsEndpoints(SHTCGClient.ClientService)'></a>

## VendorsEndpoints\(ClientService\) Constructor

Class for interacting with the vendors endpoint\.

```csharp
public VendorsEndpoints(SHTCGClient.ClientService client);
```
#### Parameters

<a name='SHTCGClient.Endpoints.VendorsEndpoints.VendorsEndpoints(SHTCGClient.ClientService).client'></a>

`client` [ClientService](SHTCGClient.ClientService.md 'SHTCGClient\.ClientService')
### Methods

<a name='SHTCGClient.Endpoints.VendorsEndpoints.GetVendors()'></a>

## VendorsEndpoints\.GetVendors\(\) Method

Get the current vendors

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Vendors.Vendor[]?> GetVendors();
```

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Vendor](SHTCGClient.Models.Vendors.Vendor.md 'SHTCGClient\.Models\.Vendors\.Vendor')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Array of vendors

<a name='SHTCGClient.Endpoints.VendorsEndpoints.SellCard(int,int)'></a>

## VendorsEndpoints\.SellCard\(int, int\) Method

Sell a card

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Vendors.CardSellResponse?> SellCard(int cardId, int vendorId);
```
#### Parameters

<a name='SHTCGClient.Endpoints.VendorsEndpoints.SellCard(int,int).cardId'></a>

`cardId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The card ID

<a name='SHTCGClient.Endpoints.VendorsEndpoints.SellCard(int,int).vendorId'></a>

`vendorId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The vendor ID to sell to

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[CardSellResponse](SHTCGClient.Models.Vendors.CardSellResponse.md 'SHTCGClient\.Models\.Vendors\.CardSellResponse')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Sale information

<a name='SHTCGClient.Endpoints.VendorsEndpoints.SellCards(int[],int)'></a>

## VendorsEndpoints\.SellCards\(int\[\], int\) Method

Sell cards

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Vendors.CardSellResponse?> SellCards(int[] cardIds, int vendorId);
```
#### Parameters

<a name='SHTCGClient.Endpoints.VendorsEndpoints.SellCards(int[],int).cardIds'></a>

`cardIds` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The card IDs

<a name='SHTCGClient.Endpoints.VendorsEndpoints.SellCards(int[],int).vendorId'></a>

`vendorId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The vendor ID to sell to

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[CardSellResponse](SHTCGClient.Models.Vendors.CardSellResponse.md 'SHTCGClient\.Models\.Vendors\.CardSellResponse')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Sale information