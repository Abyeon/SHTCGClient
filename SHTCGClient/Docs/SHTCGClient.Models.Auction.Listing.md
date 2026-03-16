#### [SHTCGClient](index.md 'index')
### [SHTCGClient\.Models\.Auction](index.md#SHTCGClient.Models.Auction 'SHTCGClient\.Models\.Auction')

## Listing Class

An auction listing

```csharp
public class Listing
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; Listing
### Properties

<a name='SHTCGClient.Models.Auction.Listing.Card'></a>

## Listing\.Card Property

The card being sold

```csharp
public SHTCGClient.Models.Auction.AuctionCard Card { get; set; }
```

#### Property Value
[AuctionCard](SHTCGClient.Models.Auction.AuctionCard.md 'SHTCGClient\.Models\.Auction\.AuctionCard')

<a name='SHTCGClient.Models.Auction.Listing.CreatedAt'></a>

## Listing\.CreatedAt Property

The date this listing was created

```csharp
public System.DateTime CreatedAt { get; set; }
```

#### Property Value
[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

<a name='SHTCGClient.Models.Auction.Listing.ExpiresAt'></a>

## Listing\.ExpiresAt Property

When this listing expires

```csharp
public System.Nullable<System.DateTime> ExpiresAt { get; set; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='SHTCGClient.Models.Auction.Listing.Id'></a>

## Listing\.Id Property

This ID of this listing

```csharp
public int Id { get; set; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='SHTCGClient.Models.Auction.Listing.Price'></a>

## Listing\.Price Property

The price of this card

```csharp
public double Price { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='SHTCGClient.Models.Auction.Listing.Seller'></a>

## Listing\.Seller Property

Information regarding the seller for this listing

```csharp
public SHTCGClient.Models.Auction.Seller Seller { get; set; }
```

#### Property Value
[Seller](SHTCGClient.Models.Auction.Seller.md 'SHTCGClient\.Models\.Auction\.Seller')

<a name='SHTCGClient.Models.Auction.Listing.Status'></a>

## Listing\.Status Property

The status of this listing \(active, inactive\)

```csharp
public string Status { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')