#### [SHTCGClient](index.md 'index')
### [SHTCGClient\.Models\.Exchange](SHTCGClient.Models.Exchange.md 'SHTCGClient\.Models\.Exchange').[Exchange](SHTCGClient.Models.Exchange.Exchange.md 'SHTCGClient\.Models\.Exchange\.Exchange')

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
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[SHTCGClient\.Models\.Exchange\.Candle](https://learn.microsoft.com/en-us/dotnet/api/shtcgclient.models.exchange.candle 'SHTCGClient\.Models\.Exchange\.Candle')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')