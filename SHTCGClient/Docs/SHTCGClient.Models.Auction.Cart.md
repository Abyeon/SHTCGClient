#### [SHTCGClient](index.md 'index')
### [SHTCGClient\.Models\.Auction](index.md#SHTCGClient.Models.Auction 'SHTCGClient\.Models\.Auction')

## Cart Class

The user's auction cart

```csharp
public class Cart
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; Cart
### Properties

<a name='SHTCGClient.Models.Auction.Cart.Items'></a>

## Cart\.Items Property

Array of items to be purchased

```csharp
public SHTCGClient.Models.Auction.CartItem[] Items { get; set; }
```

#### Property Value
[CartItem](SHTCGClient.Models.Auction.CartItem.md 'SHTCGClient\.Models\.Auction\.CartItem')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='SHTCGClient.Models.Auction.Cart.Total'></a>

## Cart\.Total Property

The total of this purchase

```csharp
public double Total { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')