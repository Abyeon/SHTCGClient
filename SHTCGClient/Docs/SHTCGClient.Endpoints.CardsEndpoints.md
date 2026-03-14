#### [SHTCGClient](index.md 'index')
### [SHTCGClient\.Endpoints](index.md#SHTCGClient.Endpoints 'SHTCGClient\.Endpoints')

## CardsEndpoints Class

Class for interacting with the Cards endpoint

```csharp
public class CardsEndpoints
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; CardsEndpoints
### Constructors

<a name='SHTCGClient.Endpoints.CardsEndpoints.CardsEndpoints(SHTCGClient.ClientService)'></a>

## CardsEndpoints\(ClientService\) Constructor

Class for interacting with the Cards endpoint

```csharp
public CardsEndpoints(SHTCGClient.ClientService client);
```
#### Parameters

<a name='SHTCGClient.Endpoints.CardsEndpoints.CardsEndpoints(SHTCGClient.ClientService).client'></a>

`client` [ClientService](SHTCGClient.ClientService.md 'SHTCGClient\.ClientService')
### Methods

<a name='SHTCGClient.Endpoints.CardsEndpoints.BaseCards()'></a>

## CardsEndpoints\.BaseCards\(\) Method

Get all the base versions of the cards in the game\.

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Cards.BaseCard[]?> BaseCards();
```

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[BaseCard](SHTCGClient.Models.Cards.BaseCard.md 'SHTCGClient\.Models\.Cards\.BaseCard')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Array of BaseCards

<a name='SHTCGClient.Endpoints.CardsEndpoints.MyCards()'></a>

## CardsEndpoints\.MyCards\(\) Method

Get the User's owned cards\. \(This automatically de\-paginates the request and gets all cards\.\)

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Cards.Card[]?> MyCards();
```

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Card](SHTCGClient.Models.Cards.Card.md 'SHTCGClient\.Models\.Cards\.Card')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Array of cards

<a name='SHTCGClient.Endpoints.CardsEndpoints.PlayerCards(int)'></a>

## CardsEndpoints\.PlayerCards\(int\) Method

Get a player's owned cards\. \(This automatically de\-paginates the request and gets all cards\.\)

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Cards.Card[]?> PlayerCards(int id);
```
#### Parameters

<a name='SHTCGClient.Endpoints.CardsEndpoints.PlayerCards(int).id'></a>

`id` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The ID of the player to fetch

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Card](SHTCGClient.Models.Cards.Card.md 'SHTCGClient\.Models\.Cards\.Card')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Array of cards

### See Also
- [Id](SHTCGClient.Models.Users.User.md#SHTCGClient.Models.Users.User.Id 'SHTCGClient\.Models\.Users\.User\.Id')
- [Id](SHTCGClient.Models.Users.Profile.md#SHTCGClient.Models.Users.Profile.Id 'SHTCGClient\.Models\.Users\.Profile\.Id')

<a name='SHTCGClient.Endpoints.CardsEndpoints.Roll()'></a>

## CardsEndpoints\.Roll\(\) Method

Roll for a card

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Cards.CardRollResponse?> Roll();
```

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[CardRollResponse](SHTCGClient.Models.Cards.CardRollResponse.md 'SHTCGClient\.Models\.Cards\.CardRollResponse')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Roll information

<a name='SHTCGClient.Endpoints.CardsEndpoints.RollHistory(int)'></a>

## CardsEndpoints\.RollHistory\(int\) Method

Get the last x rolls

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Cards.Card[]?> RollHistory(int count);
```
#### Parameters

<a name='SHTCGClient.Endpoints.CardsEndpoints.RollHistory(int).count'></a>

`count` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

Amount of rolls to fetch

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Card](SHTCGClient.Models.Cards.Card.md 'SHTCGClient\.Models\.Cards\.Card')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Array of cards

<a name='SHTCGClient.Endpoints.CardsEndpoints.Status()'></a>

## CardsEndpoints\.Status\(\) Method

Get the current roll status

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Cards.RollInfo?> Status();
```

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[RollInfo](SHTCGClient.Models.Cards.RollInfo.md 'SHTCGClient\.Models\.Cards\.RollInfo')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Roll information