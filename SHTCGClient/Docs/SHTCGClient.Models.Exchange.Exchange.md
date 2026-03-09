#### [SHTCGClient](index.md 'index')
### [SHTCGClient\.Models\.Exchange](index.md#SHTCGClient.Models.Exchange 'SHTCGClient\.Models\.Exchange')

## Exchange Class

Stock information

```csharp
public class Exchange
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; Exchange
### Properties

<a name='SHTCGClient.Models.Exchange.Exchange.CreatedAt'></a>

## Exchange\.CreatedAt Property

```csharp
public System.DateTime CreatedAt { get; init; }
```

#### Property Value
[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

<a name='SHTCGClient.Models.Exchange.Exchange.Description'></a>

## Exchange\.Description Property

```csharp
public string Description { get; init; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='SHTCGClient.Models.Exchange.Exchange.High24Hours'></a>

## Exchange\.High24Hours Property

```csharp
public double High24Hours { get; init; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='SHTCGClient.Models.Exchange.Exchange.Id'></a>

## Exchange\.Id Property

```csharp
public int Id { get; init; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='SHTCGClient.Models.Exchange.Exchange.IsActive'></a>

## Exchange\.IsActive Property

```csharp
public bool IsActive { get; init; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='SHTCGClient.Models.Exchange.Exchange.LatestPrice'></a>

## Exchange\.LatestPrice Property

```csharp
public double LatestPrice { get; init; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='SHTCGClient.Models.Exchange.Exchange.Low24Hours'></a>

## Exchange\.Low24Hours Property

```csharp
public double Low24Hours { get; init; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='SHTCGClient.Models.Exchange.Exchange.Name'></a>

## Exchange\.Name Property

```csharp
public string Name { get; init; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='SHTCGClient.Models.Exchange.Exchange.Symbol'></a>

## Exchange\.Symbol Property

```csharp
public SHTCGClient.Models.Exchange.Symbol Symbol { get; init; }
```

#### Property Value
[Symbol](SHTCGClient.Models.Exchange.Symbol.md 'SHTCGClient\.Models\.Exchange\.Symbol')

<a name='SHTCGClient.Models.Exchange.Exchange.Volume24Hours'></a>

## Exchange\.Volume24Hours Property

```csharp
public int Volume24Hours { get; init; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')
### Methods

<a name='SHTCGClient.Models.Exchange.Exchange.GetCandles(SHTCGClient.ClientService,int,int)'></a>

## Exchange\.GetCandles\(ClientService, int, int\) Method

Get the candle graph for this exchange

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Exchange.Candle[]?> GetCandles(SHTCGClient.ClientService client, int interval=5, int limit=288);
```
#### Parameters

<a name='SHTCGClient.Models.Exchange.Exchange.GetCandles(SHTCGClient.ClientService,int,int).client'></a>

`client` [ClientService](SHTCGClient.ClientService.md 'SHTCGClient\.ClientService')

Your client

<a name='SHTCGClient.Models.Exchange.Exchange.GetCandles(SHTCGClient.ClientService,int,int).interval'></a>

`interval` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

Every x minutes for candles

<a name='SHTCGClient.Models.Exchange.Exchange.GetCandles(SHTCGClient.ClientService,int,int).limit'></a>

`limit` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

Limit how many candles you get

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Candle](SHTCGClient.Models.Exchange.Candle.md 'SHTCGClient\.Models\.Exchange\.Candle')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')