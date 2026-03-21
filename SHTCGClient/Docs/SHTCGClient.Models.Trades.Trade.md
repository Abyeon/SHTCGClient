#### [SHTCGClient](index.md 'index')
### [SHTCGClient\.Models\.Trades](index.md#SHTCGClient.Models.Trades 'SHTCGClient\.Models\.Trades')

## Trade Class

```csharp
public class Trade
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; Trade
### Properties

<a name='SHTCGClient.Models.Trades.Trade.CreatedAt'></a>

## Trade\.CreatedAt Property

```csharp
public System.Nullable<System.DateTime> CreatedAt { get; set; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='SHTCGClient.Models.Trades.Trade.Id'></a>

## Trade\.Id Property

```csharp
public int Id { get; set; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='SHTCGClient.Models.Trades.Trade.Initiator'></a>

## Trade\.Initiator Property

```csharp
public SHTCGClient.Models.Trades.TradeParticipant Initiator { get; set; }
```

#### Property Value
[TradeParticipant](SHTCGClient.Models.Trades.TradeParticipant.md 'SHTCGClient\.Models\.Trades\.TradeParticipant')

<a name='SHTCGClient.Models.Trades.Trade.InitiatorCards'></a>

## Trade\.InitiatorCards Property

```csharp
public SHTCGClient.Models.Cards.Card[] InitiatorCards { get; set; }
```

#### Property Value
[Card](SHTCGClient.Models.Cards.Card.md 'SHTCGClient\.Models\.Cards\.Card')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='SHTCGClient.Models.Trades.Trade.InitiatorMoney'></a>

## Trade\.InitiatorMoney Property

```csharp
public double InitiatorMoney { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='SHTCGClient.Models.Trades.Trade.Message'></a>

## Trade\.Message Property

```csharp
public string Message { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='SHTCGClient.Models.Trades.Trade.Receiver'></a>

## Trade\.Receiver Property

```csharp
public SHTCGClient.Models.Trades.TradeParticipant Receiver { get; set; }
```

#### Property Value
[TradeParticipant](SHTCGClient.Models.Trades.TradeParticipant.md 'SHTCGClient\.Models\.Trades\.TradeParticipant')

<a name='SHTCGClient.Models.Trades.Trade.ReceiverCards'></a>

## Trade\.ReceiverCards Property

```csharp
public SHTCGClient.Models.Cards.Card[] ReceiverCards { get; set; }
```

#### Property Value
[Card](SHTCGClient.Models.Cards.Card.md 'SHTCGClient\.Models\.Cards\.Card')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='SHTCGClient.Models.Trades.Trade.ReceiverMoney'></a>

## Trade\.ReceiverMoney Property

```csharp
public double ReceiverMoney { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='SHTCGClient.Models.Trades.Trade.ResolvedAt'></a>

## Trade\.ResolvedAt Property

```csharp
public System.Nullable<System.DateTime> ResolvedAt { get; set; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='SHTCGClient.Models.Trades.Trade.Status'></a>

## Trade\.Status Property

```csharp
public string Status { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='SHTCGClient.Models.Trades.Trade.UpdatedAt'></a>

## Trade\.UpdatedAt Property

```csharp
public System.Nullable<System.DateTime> UpdatedAt { get; set; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')