#### [SHTCGClient](index.md 'index')
### [SHTCGClient\.Models\.Seasons](SHTCGClient.Models.Seasons.md 'SHTCGClient\.Models\.Seasons').[Deck](SHTCGClient.Models.Seasons.Deck.md 'SHTCGClient\.Models\.Seasons\.Deck')

## Deck\.Remove Method

| Overloads | |
| :--- | :--- |
| [Remove\(ClientService, int\)](SHTCGClient.Models.Seasons.Deck.Remove.md#SHTCGClient.Models.Seasons.Deck.Remove(SHTCGClient.ClientService,int) 'SHTCGClient\.Models\.Seasons\.Deck\.Remove\(SHTCGClient\.ClientService, int\)') | Removes a card from the deck |
| [Remove\(ClientService, Card\)](SHTCGClient.Models.Seasons.Deck.Remove.md#SHTCGClient.Models.Seasons.Deck.Remove(SHTCGClient.ClientService,SHTCGClient.Models.Cards.Card) 'SHTCGClient\.Models\.Seasons\.Deck\.Remove\(SHTCGClient\.ClientService, SHTCGClient\.Models\.Cards\.Card\)') | Removes a card from the deck |

<a name='SHTCGClient.Models.Seasons.Deck.Remove(SHTCGClient.ClientService,int)'></a>

## Deck\.Remove\(ClientService, int\) Method

Removes a card from the deck

```csharp
public System.Threading.Tasks.Task Remove(SHTCGClient.ClientService client, int cardId);
```
#### Parameters

<a name='SHTCGClient.Models.Seasons.Deck.Remove(SHTCGClient.ClientService,int).client'></a>

`client` [ClientService](SHTCGClient.ClientService.md 'SHTCGClient\.ClientService')

Your client

<a name='SHTCGClient.Models.Seasons.Deck.Remove(SHTCGClient.ClientService,int).cardId'></a>

`cardId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

ID of the card to remove

#### Returns
[System\.Threading\.Tasks\.Task](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task 'System\.Threading\.Tasks\.Task')

<a name='SHTCGClient.Models.Seasons.Deck.Remove(SHTCGClient.ClientService,SHTCGClient.Models.Cards.Card)'></a>

## Deck\.Remove\(ClientService, Card\) Method

Removes a card from the deck

```csharp
public System.Threading.Tasks.Task Remove(SHTCGClient.ClientService client, SHTCGClient.Models.Cards.Card card);
```
#### Parameters

<a name='SHTCGClient.Models.Seasons.Deck.Remove(SHTCGClient.ClientService,SHTCGClient.Models.Cards.Card).client'></a>

`client` [ClientService](SHTCGClient.ClientService.md 'SHTCGClient\.ClientService')

Your client

<a name='SHTCGClient.Models.Seasons.Deck.Remove(SHTCGClient.ClientService,SHTCGClient.Models.Cards.Card).card'></a>

`card` [Card](SHTCGClient.Models.Cards.Card.md 'SHTCGClient\.Models\.Cards\.Card')

Card to remove

#### Returns
[System\.Threading\.Tasks\.Task](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task 'System\.Threading\.Tasks\.Task')