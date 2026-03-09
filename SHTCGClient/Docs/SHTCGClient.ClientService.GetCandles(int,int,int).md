#### [SHTCGClient](index.md 'index')
### [SHTCGClient](SHTCGClient.md 'SHTCGClient').[ClientService](SHTCGClient.ClientService.md 'SHTCGClient\.ClientService')

## ClientService\.GetCandles\(int, int, int\) Method

Get the candle graph for an exchange

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Exchange.Candle[]?> GetCandles(int exchangeId, int interval, int limit);
```
#### Parameters

<a name='SHTCGClient.ClientService.GetCandles(int,int,int).exchangeId'></a>

`exchangeId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The exchange ID

<a name='SHTCGClient.ClientService.GetCandles(int,int,int).interval'></a>

`interval` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The interval in minutes

<a name='SHTCGClient.ClientService.GetCandles(int,int,int).limit'></a>

`limit` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The limit of candles to fetch

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[SHTCGClient\.Models\.Exchange\.Candle](https://learn.microsoft.com/en-us/dotnet/api/shtcgclient.models.exchange.candle 'SHTCGClient\.Models\.Exchange\.Candle')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Array of candles