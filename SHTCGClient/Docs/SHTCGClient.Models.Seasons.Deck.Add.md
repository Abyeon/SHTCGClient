#### [SHTCGClient](index.md 'index')
### [SHTCGClient\.Models\.Seasons](index.md#SHTCGClient.Models.Seasons 'SHTCGClient\.Models\.Seasons').[Deck](SHTCGClient.Models.Seasons.Deck.md 'SHTCGClient\.Models\.Seasons\.Deck')

## Deck\.Add Method

| Overloads | |
| :--- | :--- |
| [Add\(ClientService, int\)](SHTCGClient.Models.Seasons.Deck.Add.md#SHTCGClient.Models.Seasons.Deck.Add(SHTCGClient.ClientService,int) 'SHTCGClient\.Models\.Seasons\.Deck\.Add\(SHTCGClient\.ClientService, int\)') | Adds a card to the deck |
| [Add\(ClientService, Card\)](SHTCGClient.Models.Seasons.Deck.Add.md#SHTCGClient.Models.Seasons.Deck.Add(SHTCGClient.ClientService,SHTCGClient.Models.Cards.Card) 'SHTCGClient\.Models\.Seasons\.Deck\.Add\(SHTCGClient\.ClientService, SHTCGClient\.Models\.Cards\.Card\)') | Adds a card to the deck |

<a name='SHTCGClient.Models.Seasons.Deck.Add(SHTCGClient.ClientService,int)'></a>

## Deck\.Add\(ClientService, int\) Method

Adds a card to the deck

```csharp
public System.Threading.Tasks.Task Add(SHTCGClient.ClientService client, int cardId);
```
#### Parameters

<a name='SHTCGClient.Models.Seasons.Deck.Add(SHTCGClient.ClientService,int).client'></a>

`client` [ClientService](SHTCGClient.ClientService.md 'SHTCGClient\.ClientService')

Your client

<a name='SHTCGClient.Models.Seasons.Deck.Add(SHTCGClient.ClientService,int).cardId'></a>

`cardId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

ID of the card to add

#### Returns
[System\.Threading\.Tasks\.Task](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task 'System\.Threading\.Tasks\.Task')

<a name='SHTCGClient.Models.Seasons.Deck.Add(SHTCGClient.ClientService,SHTCGClient.Models.Cards.Card)'></a>

## Deck\.Add\(ClientService, Card\) Method

Adds a card to the deck

```csharp
public System.Threading.Tasks.Task Add(SHTCGClient.ClientService client, SHTCGClient.Models.Cards.Card card);
```
#### Parameters

<a name='SHTCGClient.Models.Seasons.Deck.Add(SHTCGClient.ClientService,SHTCGClient.Models.Cards.Card).client'></a>

`client` [ClientService](SHTCGClient.ClientService.md 'SHTCGClient\.ClientService')

Your client

<a name='SHTCGClient.Models.Seasons.Deck.Add(SHTCGClient.ClientService,SHTCGClient.Models.Cards.Card).card'></a>

`card` [Card](SHTCGClient.Models.Cards.Card.md 'SHTCGClient\.Models\.Cards\.Card')

Card to add

#### Returns
[System\.Threading\.Tasks\.Task](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task 'System\.Threading\.Tasks\.Task')