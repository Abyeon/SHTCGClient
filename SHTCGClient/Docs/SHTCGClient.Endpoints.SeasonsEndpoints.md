#### [SHTCGClient](index.md 'index')
### [SHTCGClient\.Endpoints](index.md#SHTCGClient.Endpoints 'SHTCGClient\.Endpoints')

## SeasonsEndpoints Class

Class for interacting with the seasons endpoint

```csharp
public class SeasonsEndpoints
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; SeasonsEndpoints
### Constructors

<a name='SHTCGClient.Endpoints.SeasonsEndpoints.SeasonsEndpoints(SHTCGClient.ClientService)'></a>

## SeasonsEndpoints\(ClientService\) Constructor

Class for interacting with the seasons endpoint

```csharp
public SeasonsEndpoints(SHTCGClient.ClientService client);
```
#### Parameters

<a name='SHTCGClient.Endpoints.SeasonsEndpoints.SeasonsEndpoints(SHTCGClient.ClientService).client'></a>

`client` [ClientService](SHTCGClient.ClientService.md 'SHTCGClient\.ClientService')
### Fields

<a name='SHTCGClient.Endpoints.SeasonsEndpoints.Decks'></a>

## SeasonsEndpoints\.Decks Field

The seasons/decks endpoint

```csharp
public readonly DecksEndpoints Decks;
```

#### Field Value
[DecksEndpoints](SHTCGClient.Endpoints.DecksEndpoints.md 'SHTCGClient\.Endpoints\.DecksEndpoints')
### Methods

<a name='SHTCGClient.Endpoints.SeasonsEndpoints.ById(int)'></a>

## SeasonsEndpoints\.ById\(int\) Method

Get season by id

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Seasons.Season?> ById(int id);
```
#### Parameters

<a name='SHTCGClient.Endpoints.SeasonsEndpoints.ById(int).id'></a>

`id` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The season's id

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Season](SHTCGClient.Models.Seasons.Season.md 'SHTCGClient\.Models\.Seasons\.Season')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Season

<a name='SHTCGClient.Endpoints.SeasonsEndpoints.Current()'></a>

## SeasonsEndpoints\.Current\(\) Method

Get the currently active season

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Seasons.Season?> Current();
```

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Season](SHTCGClient.Models.Seasons.Season.md 'SHTCGClient\.Models\.Seasons\.Season')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
The active season

<a name='SHTCGClient.Endpoints.SeasonsEndpoints.LowestDropChance()'></a>

## SeasonsEndpoints\.LowestDropChance\(\) Method

Gets the Lowest Drop Chance \(GTO\) cards for the current season\.

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Cards.Card[]?> LowestDropChance();
```

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Card](SHTCGClient.Models.Cards.Card.md 'SHTCGClient\.Models\.Cards\.Card')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Array of GTO cards\.