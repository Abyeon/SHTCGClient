#### [SHTCGClient](index.md 'index')
### [SHTCGClient](index.md#SHTCGClient 'SHTCGClient')

## ClientService Class

The main service for interacting with the Something Happened TCG API\.

```csharp
public class ClientService : System.IAsyncDisposable
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; ClientService

Implements [System\.IAsyncDisposable](https://learn.microsoft.com/en-us/dotnet/api/system.iasyncdisposable 'System\.IAsyncDisposable')

| Constructors | |
| :--- | :--- |
| [ClientService\(\)](SHTCGClient.ClientService.#ctor.md#SHTCGClient.ClientService.ClientService() 'SHTCGClient\.ClientService\.ClientService\(\)') | |
| [ClientService\(ThrottledProcessor\)](SHTCGClient.ClientService.#ctor.md#SHTCGClient.ClientService.ClientService(SHTCGClient.ThrottledProcessor) 'SHTCGClient\.ClientService\.ClientService\(SHTCGClient\.ThrottledProcessor\)') | |

| Fields | |
| :--- | :--- |
| [Client](SHTCGClient.ClientService.Client.md 'SHTCGClient\.ClientService\.Client') | |
| [CookieContainer](SHTCGClient.ClientService.CookieContainer.md 'SHTCGClient\.ClientService\.CookieContainer') | |
| [Handler](SHTCGClient.ClientService.Handler.md 'SHTCGClient\.ClientService\.Handler') | |
| [LoggedIn](SHTCGClient.ClientService.LoggedIn.md 'SHTCGClient\.ClientService\.LoggedIn') | If the client is logged in or not |
| [Processor](SHTCGClient.ClientService.Processor.md 'SHTCGClient\.ClientService\.Processor') | |

| Methods | |
| :--- | :--- |
| [AddDeckCard\(int, int\)](SHTCGClient.ClientService.AddDeckCard(int,int).md 'SHTCGClient\.ClientService\.AddDeckCard\(int, int\)') | Add a card to a deck |
| [DeleteDeckCard\(int, int\)](SHTCGClient.ClientService.DeleteDeckCard(int,int).md 'SHTCGClient\.ClientService\.DeleteDeckCard\(int, int\)') | Delete a card in a deck |
| [DisposeAsync\(\)](SHTCGClient.ClientService.DisposeAsync().md 'SHTCGClient\.ClientService\.DisposeAsync\(\)') | Async disposal\. Put the ClientService in an "await using" block for this to automatically clean up\. |
| [EquipCompanion\(int\)](SHTCGClient.ClientService.EquipCompanion(int).md 'SHTCGClient\.ClientService\.EquipCompanion\(int\)') | Equip a companion by ID |
| [GetActiveCompanion\(\)](SHTCGClient.ClientService.GetActiveCompanion().md 'SHTCGClient\.ClientService\.GetActiveCompanion\(\)') | Get the user's currently active companion |
| [GetCandles\(int, int, int\)](SHTCGClient.ClientService.GetCandles(int,int,int).md 'SHTCGClient\.ClientService\.GetCandles\(int, int, int\)') | Get the candle graph for an exchange |
| [GetCards\(\)](SHTCGClient.ClientService.GetCards().md 'SHTCGClient\.ClientService\.GetCards\(\)') | Get the User's owned cards\. \(This automatically de\-paginates the request and gets all cards\.\) |
| [GetCompanions\(\)](SHTCGClient.ClientService.GetCompanions().md 'SHTCGClient\.ClientService\.GetCompanions\(\)') | Get the user's owned companions |
| [GetCurrentSeason\(\)](SHTCGClient.ClientService.GetCurrentSeason().md 'SHTCGClient\.ClientService\.GetCurrentSeason\(\)') | Get the currently active season |
| [GetDeckCards\(int\)](SHTCGClient.ClientService.GetDeckCards(int).md 'SHTCGClient\.ClientService\.GetDeckCards\(int\)') | Get the cards for a deck by id |
| [GetDecks\(\)](SHTCGClient.ClientService.GetDecks().md 'SHTCGClient\.ClientService\.GetDecks\(\)') | Get the user's decks |
| [GetExchanges\(\)](SHTCGClient.ClientService.GetExchanges().md 'SHTCGClient\.ClientService\.GetExchanges\(\)') | Get the currently running exchanges |
| [GetFriends\(\)](SHTCGClient.ClientService.GetFriends().md 'SHTCGClient\.ClientService\.GetFriends\(\)') | Get your friends |
| [GetLeaderboard\(\)](SHTCGClient.ClientService.GetLeaderboard().md 'SHTCGClient\.ClientService\.GetLeaderboard\(\)') | Get the deck leaderboard for the current season |
| [GetPositions\(\)](SHTCGClient.ClientService.GetPositions().md 'SHTCGClient\.ClientService\.GetPositions\(\)') | Get the user's positions in the exchanges |
| [GetSeason\(int\)](SHTCGClient.ClientService.GetSeason(int).md 'SHTCGClient\.ClientService\.GetSeason\(int\)') | Get season by id |
| [GetUserByName\(string\)](SHTCGClient.ClientService.GetUserByName(string).md 'SHTCGClient\.ClientService\.GetUserByName\(string\)') | Search for a user by name |
| [GetVendors\(\)](SHTCGClient.ClientService.GetVendors().md 'SHTCGClient\.ClientService\.GetVendors\(\)') | Get the current vendors |
| [Login\(Credentials\)](SHTCGClient.ClientService.Login.md#SHTCGClient.ClientService.Login(SHTCGClient.Credentials) 'SHTCGClient\.ClientService\.Login\(SHTCGClient\.Credentials\)') | Log in to the game |
| [Login\(string, string\)](SHTCGClient.ClientService.Login.md#SHTCGClient.ClientService.Login(string,string) 'SHTCGClient\.ClientService\.Login\(string, string\)') | Log in to the game |
| [Request\(HttpMethod, string\)](SHTCGClient.ClientService.Request.md#SHTCGClient.ClientService.Request(System.Net.Http.HttpMethod,string) 'SHTCGClient\.ClientService\.Request\(System\.Net\.Http\.HttpMethod, string\)') | A helper method for sending a request to the API |
| [Request\(HttpMethod, string, object\)](SHTCGClient.ClientService.Request.md#SHTCGClient.ClientService.Request(System.Net.Http.HttpMethod,string,object) 'SHTCGClient\.ClientService\.Request\(System\.Net\.Http\.HttpMethod, string, object\)') | A helper method for sending a request to the API |
| [Request&lt;T&gt;\(HttpMethod, string\)](SHTCGClient.ClientService.Request.md#SHTCGClient.ClientService.Request_T_(System.Net.Http.HttpMethod,string) 'SHTCGClient\.ClientService\.Request\<T\>\(System\.Net\.Http\.HttpMethod, string\)') | A helper method for sending a request to the API |
| [Request&lt;T&gt;\(HttpMethod, string, object\)](SHTCGClient.ClientService.Request.md#SHTCGClient.ClientService.Request_T_(System.Net.Http.HttpMethod,string,object) 'SHTCGClient\.ClientService\.Request\<T\>\(System\.Net\.Http\.HttpMethod, string, object\)') | A helper method for sending a request to the API |
| [Roll\(\)](SHTCGClient.ClientService.Roll().md 'SHTCGClient\.ClientService\.Roll\(\)') | Roll for a card |
| [RollHistory\(int\)](SHTCGClient.ClientService.RollHistory(int).md 'SHTCGClient\.ClientService\.RollHistory\(int\)') | Get the last x rolls |
| [SellCard\(int, int\)](SHTCGClient.ClientService.SellCard(int,int).md 'SHTCGClient\.ClientService\.SellCard\(int, int\)') | Sell a card |
| [SellCards\(int\[\], int\)](SHTCGClient.ClientService.SellCards(int[],int).md 'SHTCGClient\.ClientService\.SellCards\(int\[\], int\)') | Sell cards |
| [Status\(\)](SHTCGClient.ClientService.Status().md 'SHTCGClient\.ClientService\.Status\(\)') | Get the current roll status |
| [UnequipCompanion\(\)](SHTCGClient.ClientService.UnequipCompanion().md 'SHTCGClient\.ClientService\.UnequipCompanion\(\)') | Unequip the currently active companion |
