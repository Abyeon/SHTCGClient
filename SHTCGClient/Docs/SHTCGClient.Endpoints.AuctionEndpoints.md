#### [SHTCGClient](index.md 'index')
### [SHTCGClient\.Endpoints](index.md#SHTCGClient.Endpoints 'SHTCGClient\.Endpoints')

## AuctionEndpoints Class

Class for interacting with the Auction API

```csharp
public class AuctionEndpoints
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; AuctionEndpoints
### Constructors

<a name='SHTCGClient.Endpoints.AuctionEndpoints.AuctionEndpoints(SHTCGClient.ClientService)'></a>

## AuctionEndpoints\(ClientService\) Constructor

Class for interacting with the Auction API

```csharp
public AuctionEndpoints(SHTCGClient.ClientService client);
```
#### Parameters

<a name='SHTCGClient.Endpoints.AuctionEndpoints.AuctionEndpoints(SHTCGClient.ClientService).client'></a>

`client` [ClientService](SHTCGClient.ClientService.md 'SHTCGClient\.ClientService')
### Methods

<a name='SHTCGClient.Endpoints.AuctionEndpoints.Cart()'></a>

## AuctionEndpoints\.Cart\(\) Method

Get user's current cart

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Auction.Cart?> Cart();
```

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Cart](SHTCGClient.Models.Auction.Cart.md 'SHTCGClient\.Models\.Auction\.Cart')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
The user's cart

<a name='SHTCGClient.Endpoints.AuctionEndpoints.Checkout()'></a>

## AuctionEndpoints\.Checkout\(\) Method

Checkout the items currently in the user's cart

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Auction.Checkout?> Checkout();
```

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Checkout](SHTCGClient.Models.Auction.Checkout.md 'SHTCGClient\.Models\.Auction\.Checkout')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')

<a name='SHTCGClient.Endpoints.AuctionEndpoints.Listings(string,string)'></a>

## AuctionEndpoints\.Listings\(string, string\) Method

Get the Auction listings

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Auction.Listing[]?> Listings(string status, string sortBy);
```
#### Parameters

<a name='SHTCGClient.Endpoints.AuctionEndpoints.Listings(string,string).status'></a>

`status` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

Active/Inactive

<a name='SHTCGClient.Endpoints.AuctionEndpoints.Listings(string,string).sortBy'></a>

`sortBy` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

"\-created\_at", etc

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Listing](SHTCGClient.Models.Auction.Listing.md 'SHTCGClient\.Models\.Auction\.Listing')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Array of auction listing