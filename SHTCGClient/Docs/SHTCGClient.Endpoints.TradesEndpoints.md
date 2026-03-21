#### [SHTCGClient](index.md 'index')
### [SHTCGClient\.Endpoints](index.md#SHTCGClient.Endpoints 'SHTCGClient\.Endpoints')

## TradesEndpoints Class

```csharp
public class TradesEndpoints
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; TradesEndpoints
### Constructors

<a name='SHTCGClient.Endpoints.TradesEndpoints.TradesEndpoints(SHTCGClient.ClientService)'></a>

## TradesEndpoints\(ClientService\) Constructor

```csharp
public TradesEndpoints(SHTCGClient.ClientService client);
```
#### Parameters

<a name='SHTCGClient.Endpoints.TradesEndpoints.TradesEndpoints(SHTCGClient.ClientService).client'></a>

`client` [ClientService](SHTCGClient.ClientService.md 'SHTCGClient\.ClientService')
### Methods

<a name='SHTCGClient.Endpoints.TradesEndpoints.GetTrade(int)'></a>

## TradesEndpoints\.GetTrade\(int\) Method

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Trades.Trade?> GetTrade(int id);
```
#### Parameters

<a name='SHTCGClient.Endpoints.TradesEndpoints.GetTrade(int).id'></a>

`id` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Trade](SHTCGClient.Models.Trades.Trade.md 'SHTCGClient\.Models\.Trades\.Trade')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')

<a name='SHTCGClient.Endpoints.TradesEndpoints.MyTrades()'></a>

## TradesEndpoints\.MyTrades\(\) Method

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Trades.Trade[]?> MyTrades();
```

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Trade](SHTCGClient.Models.Trades.Trade.md 'SHTCGClient\.Models\.Trades\.Trade')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')