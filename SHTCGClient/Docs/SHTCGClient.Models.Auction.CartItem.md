#### [SHTCGClient](index.md 'index')
### [SHTCGClient\.Models\.Auction](index.md#SHTCGClient.Models.Auction 'SHTCGClient\.Models\.Auction')

## CartItem Class

Object representing an item to be purchased

```csharp
public class CartItem
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; CartItem
### Properties

<a name='SHTCGClient.Models.Auction.CartItem.AddedAt'></a>

## CartItem\.AddedAt Property

The date this item was added to the cart

```csharp
public System.DateTime AddedAt { get; set; }
```

#### Property Value
[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

<a name='SHTCGClient.Models.Auction.CartItem.Id'></a>

## CartItem\.Id Property

This ID of this cart item

```csharp
public int Id { get; set; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='SHTCGClient.Models.Auction.CartItem.Listing'></a>

## CartItem\.Listing Property

The listing to be purchased

```csharp
public SHTCGClient.Models.Auction.Listing Listing { get; set; }
```

#### Property Value
[Listing](SHTCGClient.Models.Auction.Listing.md 'SHTCGClient\.Models\.Auction\.Listing')