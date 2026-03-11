#### [SHTCGClient](index.md 'index')
### [SHTCGClient](index.md#SHTCGClient 'SHTCGClient')

## ClientService Class

The main service for interacting with the Something Happened TCG API\.

```csharp
public class ClientService : System.IAsyncDisposable
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; ClientService

Implements [System\.IAsyncDisposable](https://learn.microsoft.com/en-us/dotnet/api/system.iasyncdisposable 'System\.IAsyncDisposable')
### Constructors

<a name='SHTCGClient.ClientService.ClientService()'></a>

## ClientService\(\) Constructor

```csharp
public ClientService();
```

<a name='SHTCGClient.ClientService.ClientService(SHTCGClient.ThrottledProcessor)'></a>

## ClientService\(ThrottledProcessor\) Constructor

```csharp
public ClientService(SHTCGClient.ThrottledProcessor processor);
```
#### Parameters

<a name='SHTCGClient.ClientService.ClientService(SHTCGClient.ThrottledProcessor).processor'></a>

`processor` [ThrottledProcessor](SHTCGClient.ThrottledProcessor.md 'SHTCGClient\.ThrottledProcessor')
### Fields

<a name='SHTCGClient.ClientService.Client'></a>

## ClientService\.Client Field

```csharp
public readonly HttpClient Client;
```

#### Field Value
[System\.Net\.Http\.HttpClient](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient 'System\.Net\.Http\.HttpClient')

<a name='SHTCGClient.ClientService.CookieContainer'></a>

## ClientService\.CookieContainer Field

```csharp
public readonly CookieContainer CookieContainer;
```

#### Field Value
[System\.Net\.CookieContainer](https://learn.microsoft.com/en-us/dotnet/api/system.net.cookiecontainer 'System\.Net\.CookieContainer')

<a name='SHTCGClient.ClientService.Handler'></a>

## ClientService\.Handler Field

```csharp
public readonly HttpClientHandler Handler;
```

#### Field Value
[System\.Net\.Http\.HttpClientHandler](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclienthandler 'System\.Net\.Http\.HttpClientHandler')

<a name='SHTCGClient.ClientService.LoggedIn'></a>

## ClientService\.LoggedIn Field

If the client is logged in or not

```csharp
public bool LoggedIn;
```

#### Field Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='SHTCGClient.ClientService.Processor'></a>

## ClientService\.Processor Field

```csharp
public readonly ThrottledProcessor Processor;
```

#### Field Value
[ThrottledProcessor](SHTCGClient.ThrottledProcessor.md 'SHTCGClient\.ThrottledProcessor')
### Methods

<a name='SHTCGClient.ClientService.AddDeckCard(int,int)'></a>

## ClientService\.AddDeckCard\(int, int\) Method

Add a card to a deck

```csharp
public System.Threading.Tasks.Task AddDeckCard(int deckId, int id);
```
#### Parameters

<a name='SHTCGClient.ClientService.AddDeckCard(int,int).deckId'></a>

`deckId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The deck ID

<a name='SHTCGClient.ClientService.AddDeckCard(int,int).id'></a>

`id` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The card ID

#### Returns
[System\.Threading\.Tasks\.Task](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task 'System\.Threading\.Tasks\.Task')

<a name='SHTCGClient.ClientService.DeleteDeckCard(int,int)'></a>

## ClientService\.DeleteDeckCard\(int, int\) Method

Delete a card in a deck

```csharp
public System.Threading.Tasks.Task DeleteDeckCard(int deckId, int id);
```
#### Parameters

<a name='SHTCGClient.ClientService.DeleteDeckCard(int,int).deckId'></a>

`deckId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The deck ID

<a name='SHTCGClient.ClientService.DeleteDeckCard(int,int).id'></a>

`id` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The card ID

#### Returns
[System\.Threading\.Tasks\.Task](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task 'System\.Threading\.Tasks\.Task')

<a name='SHTCGClient.ClientService.DisposeAsync()'></a>

## ClientService\.DisposeAsync\(\) Method

Async disposal\. Put the ClientService in an "await using" block for this to automatically clean up\.

```csharp
public System.Threading.Tasks.ValueTask DisposeAsync();
```

Implements [DisposeAsync\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.iasyncdisposable.disposeasync 'System\.IAsyncDisposable\.DisposeAsync')

#### Returns
[System\.Threading\.Tasks\.ValueTask](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.valuetask 'System\.Threading\.Tasks\.ValueTask')

<a name='SHTCGClient.ClientService.EquipCompanion(int)'></a>

## ClientService\.EquipCompanion\(int\) Method

Equip a companion by ID

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Companions.Companion?> EquipCompanion(int id);
```
#### Parameters

<a name='SHTCGClient.ClientService.EquipCompanion(int).id'></a>

`id` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The ID of the companion to equip

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Companion](SHTCGClient.Models.Companions.Companion.md 'SHTCGClient\.Models\.Companions\.Companion')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
The equipped companion

<a name='SHTCGClient.ClientService.GetActiveCompanion()'></a>

## ClientService\.GetActiveCompanion\(\) Method

Get the user's currently active companion

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Companions.Companion?> GetActiveCompanion();
```

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Companion](SHTCGClient.Models.Companions.Companion.md 'SHTCGClient\.Models\.Companions\.Companion')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
The active companion

<a name='SHTCGClient.ClientService.GetCandles(int,int,int)'></a>

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
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Candle](SHTCGClient.Models.Exchange.Candle.md 'SHTCGClient\.Models\.Exchange\.Candle')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Array of candles

<a name='SHTCGClient.ClientService.GetCards()'></a>

## ClientService\.GetCards\(\) Method

Get the User's owned cards\. \(This automatically de\-paginates the request and gets all cards\.\)

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Cards.Card[]?> GetCards();
```

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Card](SHTCGClient.Models.Cards.Card.md 'SHTCGClient\.Models\.Cards\.Card')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Array of cards

<a name='SHTCGClient.ClientService.GetCompanions()'></a>

## ClientService\.GetCompanions\(\) Method

Get the user's owned companions

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Companions.Companion[]?> GetCompanions();
```

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Companion](SHTCGClient.Models.Companions.Companion.md 'SHTCGClient\.Models\.Companions\.Companion')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Array of companions

<a name='SHTCGClient.ClientService.GetCurrentSeason()'></a>

## ClientService\.GetCurrentSeason\(\) Method

Get the currently active season

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Seasons.Season?> GetCurrentSeason();
```

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Season](SHTCGClient.Models.Seasons.Season.md 'SHTCGClient\.Models\.Seasons\.Season')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
The active season

<a name='SHTCGClient.ClientService.GetDeckCards(int)'></a>

## ClientService\.GetDeckCards\(int\) Method

Get the cards for a deck by id

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Cards.Card[]?> GetDeckCards(int deckId);
```
#### Parameters

<a name='SHTCGClient.ClientService.GetDeckCards(int).deckId'></a>

`deckId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The deck ID

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Card](SHTCGClient.Models.Cards.Card.md 'SHTCGClient\.Models\.Cards\.Card')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Array of cards

<a name='SHTCGClient.ClientService.GetDecks()'></a>

## ClientService\.GetDecks\(\) Method

Get the user's decks

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Seasons.Deck[]?> GetDecks();
```

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Deck](SHTCGClient.Models.Seasons.Deck.md 'SHTCGClient\.Models\.Seasons\.Deck')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Array of decks

<a name='SHTCGClient.ClientService.GetExchanges()'></a>

## ClientService\.GetExchanges\(\) Method

Get the currently running exchanges

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Exchange.Exchange[]?> GetExchanges();
```

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Exchange](SHTCGClient.Models.Exchange.Exchange.md 'SHTCGClient\.Models\.Exchange\.Exchange')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Array of exchanges

<a name='SHTCGClient.ClientService.GetFriends()'></a>

## ClientService\.GetFriends\(\) Method

Get your friends

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Users.User[]?> GetFriends();
```

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[User](SHTCGClient.Models.Users.User.md 'SHTCGClient\.Models\.Users\.User')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Array of users

<a name='SHTCGClient.ClientService.GetLeaderboard(string,int)'></a>

## ClientService\.GetLeaderboard\(string, int\) Method

Fetch the leaderboard

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Users.Leaderboards.Leaderboard?> GetLeaderboard(string type, int limit);
```
#### Parameters

<a name='SHTCGClient.ClientService.GetLeaderboard(string,int).type'></a>

`type` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The value to sort by

<a name='SHTCGClient.ClientService.GetLeaderboard(string,int).limit'></a>

`limit` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The max entries to fetch

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Leaderboard](SHTCGClient.Models.Users.Leaderboards.Leaderboard.md 'SHTCGClient\.Models\.Users\.Leaderboards\.Leaderboard')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
The leaderboard sorted by input type

<a name='SHTCGClient.ClientService.GetPositions()'></a>

## ClientService\.GetPositions\(\) Method

Get the user's positions in the exchanges

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Exchange.Position[]?> GetPositions();
```

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Position](SHTCGClient.Models.Exchange.Position.md 'SHTCGClient\.Models\.Exchange\.Position')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Array of positions

<a name='SHTCGClient.ClientService.GetSeason(int)'></a>

## ClientService\.GetSeason\(int\) Method

Get season by id

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Seasons.Season?> GetSeason(int id);
```
#### Parameters

<a name='SHTCGClient.ClientService.GetSeason(int).id'></a>

`id` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The season's id

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Season](SHTCGClient.Models.Seasons.Season.md 'SHTCGClient\.Models\.Seasons\.Season')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Season

<a name='SHTCGClient.ClientService.GetSeasonLeaderboard()'></a>

## ClientService\.GetSeasonLeaderboard\(\) Method

Get the deck leaderboard for the current season

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Seasons.Deck[]?> GetSeasonLeaderboard();
```

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Deck](SHTCGClient.Models.Seasons.Deck.md 'SHTCGClient\.Models\.Seasons\.Deck')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Array of decks

<a name='SHTCGClient.ClientService.GetUserByName(string)'></a>

## ClientService\.GetUserByName\(string\) Method

Search for a user by name

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Users.User[]?> GetUserByName(string name);
```
#### Parameters

<a name='SHTCGClient.ClientService.GetUserByName(string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The username to search for

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[User](SHTCGClient.Models.Users.User.md 'SHTCGClient\.Models\.Users\.User')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Array of users

<a name='SHTCGClient.ClientService.GetVendors()'></a>

## ClientService\.GetVendors\(\) Method

Get the current vendors

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Vendors.Vendor[]?> GetVendors();
```

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Vendor](SHTCGClient.Models.Vendors.Vendor.md 'SHTCGClient\.Models\.Vendors\.Vendor')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Array of vendors

<a name='SHTCGClient.ClientService.Login(SHTCGClient.Credentials)'></a>

## ClientService\.Login\(Credentials\) Method

Log in to the game

```csharp
public System.Threading.Tasks.Task<bool> Login(SHTCGClient.Credentials credentials);
```
#### Parameters

<a name='SHTCGClient.ClientService.Login(SHTCGClient.Credentials).credentials'></a>

`credentials` [Credentials](SHTCGClient.Credentials.md 'SHTCGClient\.Credentials')

Login credentials

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Success

<a name='SHTCGClient.ClientService.Login(string,string)'></a>

## ClientService\.Login\(string, string\) Method

Log in to the game

```csharp
public System.Threading.Tasks.Task<bool> Login(string username, string password);
```
#### Parameters

<a name='SHTCGClient.ClientService.Login(string,string).username'></a>

`username` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

Your username

<a name='SHTCGClient.ClientService.Login(string,string).password'></a>

`password` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

Your password

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Success

<a name='SHTCGClient.ClientService.Request(System.Net.Http.HttpMethod,string)'></a>

## ClientService\.Request\(HttpMethod, string\) Method

A helper method for sending a request to the API

```csharp
public System.Threading.Tasks.Task<bool> Request(System.Net.Http.HttpMethod method, string url);
```
#### Parameters

<a name='SHTCGClient.ClientService.Request(System.Net.Http.HttpMethod,string).method'></a>

`method` [System\.Net\.Http\.HttpMethod](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpmethod 'System\.Net\.Http\.HttpMethod')

Method to use

<a name='SHTCGClient.ClientService.Request(System.Net.Http.HttpMethod,string).url'></a>

`url` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The url, the API url /api/ is prepended already\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Success

<a name='SHTCGClient.ClientService.Request(System.Net.Http.HttpMethod,string,object)'></a>

## ClientService\.Request\(HttpMethod, string, object\) Method

A helper method for sending a request to the API

```csharp
public System.Threading.Tasks.Task<bool> Request(System.Net.Http.HttpMethod method, string url, object data);
```
#### Parameters

<a name='SHTCGClient.ClientService.Request(System.Net.Http.HttpMethod,string,object).method'></a>

`method` [System\.Net\.Http\.HttpMethod](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpmethod 'System\.Net\.Http\.HttpMethod')

Method to use

<a name='SHTCGClient.ClientService.Request(System.Net.Http.HttpMethod,string,object).url'></a>

`url` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The url, the API url /api/ is prepended already\.

<a name='SHTCGClient.ClientService.Request(System.Net.Http.HttpMethod,string,object).data'></a>

`data` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The data do send

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Success

<a name='SHTCGClient.ClientService.Request_T_(System.Net.Http.HttpMethod,string)'></a>

## ClientService\.Request\<T\>\(HttpMethod, string\) Method

A helper method for sending a request to the API

```csharp
public System.Threading.Tasks.Task<T?> Request<T>(System.Net.Http.HttpMethod method, string url);
```
#### Type parameters

<a name='SHTCGClient.ClientService.Request_T_(System.Net.Http.HttpMethod,string).T'></a>

`T`
#### Parameters

<a name='SHTCGClient.ClientService.Request_T_(System.Net.Http.HttpMethod,string).method'></a>

`method` [System\.Net\.Http\.HttpMethod](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpmethod 'System\.Net\.Http\.HttpMethod')

Method to use

<a name='SHTCGClient.ClientService.Request_T_(System.Net.Http.HttpMethod,string).url'></a>

`url` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The url, the API url /api/ is prepended already\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[T](SHTCGClient.ClientService.md#SHTCGClient.ClientService.Request_T_(System.Net.Http.HttpMethod,string).T 'SHTCGClient\.ClientService\.Request\<T\>\(System\.Net\.Http\.HttpMethod, string\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
The response object

<a name='SHTCGClient.ClientService.Request_T_(System.Net.Http.HttpMethod,string,object)'></a>

## ClientService\.Request\<T\>\(HttpMethod, string, object\) Method

A helper method for sending a request to the API

```csharp
public System.Threading.Tasks.Task<T?> Request<T>(System.Net.Http.HttpMethod method, string url, object data);
```
#### Type parameters

<a name='SHTCGClient.ClientService.Request_T_(System.Net.Http.HttpMethod,string,object).T'></a>

`T`
#### Parameters

<a name='SHTCGClient.ClientService.Request_T_(System.Net.Http.HttpMethod,string,object).method'></a>

`method` [System\.Net\.Http\.HttpMethod](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpmethod 'System\.Net\.Http\.HttpMethod')

Method to use

<a name='SHTCGClient.ClientService.Request_T_(System.Net.Http.HttpMethod,string,object).url'></a>

`url` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The url, the API url /api/ is prepended already\.

<a name='SHTCGClient.ClientService.Request_T_(System.Net.Http.HttpMethod,string,object).data'></a>

`data` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The data do send

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[T](SHTCGClient.ClientService.md#SHTCGClient.ClientService.Request_T_(System.Net.Http.HttpMethod,string,object).T 'SHTCGClient\.ClientService\.Request\<T\>\(System\.Net\.Http\.HttpMethod, string, object\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
The response object

<a name='SHTCGClient.ClientService.Roll()'></a>

## ClientService\.Roll\(\) Method

Roll for a card

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Cards.CardRollResponse?> Roll();
```

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[CardRollResponse](SHTCGClient.Models.Cards.CardRollResponse.md 'SHTCGClient\.Models\.Cards\.CardRollResponse')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Roll information

<a name='SHTCGClient.ClientService.RollHistory(int)'></a>

## ClientService\.RollHistory\(int\) Method

Get the last x rolls

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Cards.Card[]?> RollHistory(int count);
```
#### Parameters

<a name='SHTCGClient.ClientService.RollHistory(int).count'></a>

`count` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

Amount of rolls to fetch

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Card](SHTCGClient.Models.Cards.Card.md 'SHTCGClient\.Models\.Cards\.Card')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Array of cards

<a name='SHTCGClient.ClientService.SellCard(int,int)'></a>

## ClientService\.SellCard\(int, int\) Method

Sell a card

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Vendors.CardSellResponse?> SellCard(int cardId, int vendorId);
```
#### Parameters

<a name='SHTCGClient.ClientService.SellCard(int,int).cardId'></a>

`cardId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The card ID

<a name='SHTCGClient.ClientService.SellCard(int,int).vendorId'></a>

`vendorId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The vendor ID to sell to

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[CardSellResponse](SHTCGClient.Models.Vendors.CardSellResponse.md 'SHTCGClient\.Models\.Vendors\.CardSellResponse')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Sale information

<a name='SHTCGClient.ClientService.SellCards(int[],int)'></a>

## ClientService\.SellCards\(int\[\], int\) Method

Sell cards

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Vendors.CardSellResponse?> SellCards(int[] cardIds, int vendorId);
```
#### Parameters

<a name='SHTCGClient.ClientService.SellCards(int[],int).cardIds'></a>

`cardIds` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The card IDs

<a name='SHTCGClient.ClientService.SellCards(int[],int).vendorId'></a>

`vendorId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The vendor ID to sell to

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[CardSellResponse](SHTCGClient.Models.Vendors.CardSellResponse.md 'SHTCGClient\.Models\.Vendors\.CardSellResponse')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Sale information

<a name='SHTCGClient.ClientService.Status()'></a>

## ClientService\.Status\(\) Method

Get the current roll status

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Cards.RollInfo?> Status();
```

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[RollInfo](SHTCGClient.Models.Cards.RollInfo.md 'SHTCGClient\.Models\.Cards\.RollInfo')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Roll information

<a name='SHTCGClient.ClientService.UnequipCompanion()'></a>

## ClientService\.UnequipCompanion\(\) Method

Unequip the currently active companion

```csharp
public System.Threading.Tasks.Task<bool> UnequipCompanion();
```

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Success