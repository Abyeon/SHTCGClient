#### [SHTCGClient](index.md 'index')
### [SHTCGClient\.Endpoints](index.md#SHTCGClient.Endpoints 'SHTCGClient\.Endpoints')

## DecksEndpoints Class

Class for interacting with the seasons/decks endpoint\.

```csharp
public class DecksEndpoints
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; DecksEndpoints
### Constructors

<a name='SHTCGClient.Endpoints.DecksEndpoints.DecksEndpoints(SHTCGClient.ClientService)'></a>

## DecksEndpoints\(ClientService\) Constructor

Class for interacting with the seasons/decks endpoint\.

```csharp
public DecksEndpoints(SHTCGClient.ClientService client);
```
#### Parameters

<a name='SHTCGClient.Endpoints.DecksEndpoints.DecksEndpoints(SHTCGClient.ClientService).client'></a>

`client` [ClientService](SHTCGClient.ClientService.md 'SHTCGClient\.ClientService')
### Methods

<a name='SHTCGClient.Endpoints.DecksEndpoints.AddCard(int,int)'></a>

## DecksEndpoints\.AddCard\(int, int\) Method

Add a card to a deck

```csharp
public System.Threading.Tasks.Task AddCard(int deckId, int id);
```
#### Parameters

<a name='SHTCGClient.Endpoints.DecksEndpoints.AddCard(int,int).deckId'></a>

`deckId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The deck ID

<a name='SHTCGClient.Endpoints.DecksEndpoints.AddCard(int,int).id'></a>

`id` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The card ID

#### Returns
[System\.Threading\.Tasks\.Task](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task 'System\.Threading\.Tasks\.Task')

<a name='SHTCGClient.Endpoints.DecksEndpoints.DeleteCard(int,int)'></a>

## DecksEndpoints\.DeleteCard\(int, int\) Method

Delete a card in a deck

```csharp
public System.Threading.Tasks.Task DeleteCard(int deckId, int id);
```
#### Parameters

<a name='SHTCGClient.Endpoints.DecksEndpoints.DeleteCard(int,int).deckId'></a>

`deckId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The deck ID

<a name='SHTCGClient.Endpoints.DecksEndpoints.DeleteCard(int,int).id'></a>

`id` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The card ID

#### Returns
[System\.Threading\.Tasks\.Task](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task 'System\.Threading\.Tasks\.Task')

<a name='SHTCGClient.Endpoints.DecksEndpoints.GetCards(int)'></a>

## DecksEndpoints\.GetCards\(int\) Method

Get the cards for a deck by id

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Cards.Card[]?> GetCards(int deckId);
```
#### Parameters

<a name='SHTCGClient.Endpoints.DecksEndpoints.GetCards(int).deckId'></a>

`deckId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The deck ID

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Card](SHTCGClient.Models.Cards.Card.md 'SHTCGClient\.Models\.Cards\.Card')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Array of cards

<a name='SHTCGClient.Endpoints.DecksEndpoints.GetDecks()'></a>

## DecksEndpoints\.GetDecks\(\) Method

Get the user's decks

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Seasons.Deck[]?> GetDecks();
```

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Deck](SHTCGClient.Models.Seasons.Deck.md 'SHTCGClient\.Models\.Seasons\.Deck')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Array of decks

<a name='SHTCGClient.Endpoints.DecksEndpoints.GetLeaderboardDeckCards(int)'></a>

## DecksEndpoints\.GetLeaderboardDeckCards\(int\) Method

Get the cards for a deck on the season leaderboard\.

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Cards.Card[]?> GetLeaderboardDeckCards(int id);
```
#### Parameters

<a name='SHTCGClient.Endpoints.DecksEndpoints.GetLeaderboardDeckCards(int).id'></a>

`id` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The Deck ID

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Card](SHTCGClient.Models.Cards.Card.md 'SHTCGClient\.Models\.Cards\.Card')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Array of cards

<a name='SHTCGClient.Endpoints.DecksEndpoints.Leaderboard()'></a>

## DecksEndpoints\.Leaderboard\(\) Method

Get the deck leaderboard for the current season

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Seasons.Deck[]?> Leaderboard();
```

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Deck](SHTCGClient.Models.Seasons.Deck.md 'SHTCGClient\.Models\.Seasons\.Deck')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Array of decks