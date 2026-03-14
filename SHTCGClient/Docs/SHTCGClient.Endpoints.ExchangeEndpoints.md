#### [SHTCGClient](index.md 'index')
### [SHTCGClient\.Endpoints](index.md#SHTCGClient.Endpoints 'SHTCGClient\.Endpoints')

## ExchangeEndpoints Class

```csharp
public class ExchangeEndpoints
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; ExchangeEndpoints
### Constructors

<a name='SHTCGClient.Endpoints.ExchangeEndpoints.ExchangeEndpoints(SHTCGClient.ClientService)'></a>

## ExchangeEndpoints\(ClientService\) Constructor

```csharp
public ExchangeEndpoints(SHTCGClient.ClientService client);
```
#### Parameters

<a name='SHTCGClient.Endpoints.ExchangeEndpoints.ExchangeEndpoints(SHTCGClient.ClientService).client'></a>

`client` [ClientService](SHTCGClient.ClientService.md 'SHTCGClient\.ClientService')
### Methods

<a name='SHTCGClient.Endpoints.ExchangeEndpoints.Candles(int,int,int)'></a>

## ExchangeEndpoints\.Candles\(int, int, int\) Method

Get the candle graph for an exchange

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Exchange.Candle[]?> Candles(int exchangeId, int interval, int limit);
```
#### Parameters

<a name='SHTCGClient.Endpoints.ExchangeEndpoints.Candles(int,int,int).exchangeId'></a>

`exchangeId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The exchange ID

<a name='SHTCGClient.Endpoints.ExchangeEndpoints.Candles(int,int,int).interval'></a>

`interval` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The interval in minutes

<a name='SHTCGClient.Endpoints.ExchangeEndpoints.Candles(int,int,int).limit'></a>

`limit` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The limit of candles to fetch

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Candle](SHTCGClient.Models.Exchange.Candle.md 'SHTCGClient\.Models\.Exchange\.Candle')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Array of candles

<a name='SHTCGClient.Endpoints.ExchangeEndpoints.Exchanges()'></a>

## ExchangeEndpoints\.Exchanges\(\) Method

Get the currently running exchanges

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Exchange.Exchange[]?> Exchanges();
```

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Exchange](SHTCGClient.Models.Exchange.Exchange.md 'SHTCGClient\.Models\.Exchange\.Exchange')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Array of exchanges

<a name='SHTCGClient.Endpoints.ExchangeEndpoints.Positions()'></a>

## ExchangeEndpoints\.Positions\(\) Method

Get the user's positions in the exchanges

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Exchange.Position[]?> Positions();
```

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Position](SHTCGClient.Models.Exchange.Position.md 'SHTCGClient\.Models\.Exchange\.Position')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Array of positions