#### [SHTCGClient](index.md 'index')
### [SHTCGClient\.Models\.Auction](index.md#SHTCGClient.Models.Auction 'SHTCGClient\.Models\.Auction')

## Checkout Class

The response for purchasing items at the auction house

```csharp
public class Checkout
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; Checkout
### Properties

<a name='SHTCGClient.Models.Auction.Checkout.Failed'></a>

## Checkout\.Failed Property

Array of listing Ids that failed to be purchased

```csharp
public int[]? Failed { get; set; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='SHTCGClient.Models.Auction.Checkout.Message'></a>

## Checkout\.Message Property

The response message

```csharp
public string Message { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='SHTCGClient.Models.Auction.Checkout.Purchased'></a>

## Checkout\.Purchased Property

Array of listing Ids purchased

```csharp
public int[]? Purchased { get; set; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='SHTCGClient.Models.Auction.Checkout.TotalSpent'></a>

## Checkout\.TotalSpent Property

The total money spent on this purchase

```csharp
public System.Nullable<double> TotalSpent { get; set; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')