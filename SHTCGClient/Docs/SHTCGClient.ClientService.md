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

<a name='SHTCGClient.ClientService.ApiUrl'></a>

## ClientService\.ApiUrl Field

```csharp
public const string ApiUrl = "https://api.tcg.robswc.me/api/";
```

#### Field Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='SHTCGClient.ClientService.Auction'></a>

## ClientService\.Auction Field

Auction House buying/selling

```csharp
public readonly AuctionEndpoints Auction;
```

#### Field Value
[AuctionEndpoints](SHTCGClient.Endpoints.AuctionEndpoints.md 'SHTCGClient\.Endpoints\.AuctionEndpoints')

<a name='SHTCGClient.ClientService.Auth'></a>

## ClientService\.Auth Field

Login, logout, etc

```csharp
public readonly AuthEndpoints Auth;
```

#### Field Value
[AuthEndpoints](SHTCGClient.Endpoints.AuthEndpoints.md 'SHTCGClient\.Endpoints\.AuthEndpoints')

<a name='SHTCGClient.ClientService.Cards'></a>

## ClientService\.Cards Field

Roll, roll status, user's cards, etc

```csharp
public readonly CardsEndpoints Cards;
```

#### Field Value
[CardsEndpoints](SHTCGClient.Endpoints.CardsEndpoints.md 'SHTCGClient\.Endpoints\.CardsEndpoints')

<a name='SHTCGClient.ClientService.Client'></a>

## ClientService\.Client Field

```csharp
public readonly HttpClient Client;
```

#### Field Value
[System\.Net\.Http\.HttpClient](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient 'System\.Net\.Http\.HttpClient')

<a name='SHTCGClient.ClientService.Companions'></a>

## ClientService\.Companions Field

Equip, unequip companions, etc\.

```csharp
public readonly CompanionsEndpoints Companions;
```

#### Field Value
[CompanionsEndpoints](SHTCGClient.Endpoints.CompanionsEndpoints.md 'SHTCGClient\.Endpoints\.CompanionsEndpoints')

<a name='SHTCGClient.ClientService.CookieContainer'></a>

## ClientService\.CookieContainer Field

```csharp
public readonly CookieContainer CookieContainer;
```

#### Field Value
[System\.Net\.CookieContainer](https://learn.microsoft.com/en-us/dotnet/api/system.net.cookiecontainer 'System\.Net\.CookieContainer')

<a name='SHTCGClient.ClientService.Exchange'></a>

## ClientService\.Exchange Field

Buy, sell, view stocks, etc\.

```csharp
public readonly ExchangeEndpoints Exchange;
```

#### Field Value
[ExchangeEndpoints](SHTCGClient.Endpoints.ExchangeEndpoints.md 'SHTCGClient\.Endpoints\.ExchangeEndpoints')

<a name='SHTCGClient.ClientService.Features'></a>

## ClientService\.Features Field

Feature voting

```csharp
public readonly FeaturesEndpoints Features;
```

#### Field Value
[FeaturesEndpoints](SHTCGClient.Endpoints.FeaturesEndpoints.md 'SHTCGClient\.Endpoints\.FeaturesEndpoints')

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

<a name='SHTCGClient.ClientService.Seasons'></a>

## ClientService\.Seasons Field

Season information, deck management, etc\.

```csharp
public readonly SeasonsEndpoints Seasons;
```

#### Field Value
[SeasonsEndpoints](SHTCGClient.Endpoints.SeasonsEndpoints.md 'SHTCGClient\.Endpoints\.SeasonsEndpoints')

<a name='SHTCGClient.ClientService.Trades'></a>

## ClientService\.Trades Field

Player card and money trading

```csharp
public readonly TradesEndpoints Trades;
```

#### Field Value
[TradesEndpoints](SHTCGClient.Endpoints.TradesEndpoints.md 'SHTCGClient\.Endpoints\.TradesEndpoints')

<a name='SHTCGClient.ClientService.Users'></a>

## ClientService\.Users Field

Socials, net worth leaderboard, etc\.

```csharp
public readonly UsersEndpoints Users;
```

#### Field Value
[UsersEndpoints](SHTCGClient.Endpoints.UsersEndpoints.md 'SHTCGClient\.Endpoints\.UsersEndpoints')

<a name='SHTCGClient.ClientService.Vendors'></a>

## ClientService\.Vendors Field

Buy and sell cards/companions\.

```csharp
public readonly VendorsEndpoints Vendors;
```

#### Field Value
[VendorsEndpoints](SHTCGClient.Endpoints.VendorsEndpoints.md 'SHTCGClient\.Endpoints\.VendorsEndpoints')
### Methods

<a name='SHTCGClient.ClientService.DisposeAsync()'></a>

## ClientService\.DisposeAsync\(\) Method

Async disposal\. Put the ClientService in an "await using" block for this to automatically clean up\.

```csharp
public System.Threading.Tasks.ValueTask DisposeAsync();
```

Implements [DisposeAsync\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.iasyncdisposable.disposeasync 'System\.IAsyncDisposable\.DisposeAsync')

#### Returns
[System\.Threading\.Tasks\.ValueTask](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.valuetask 'System\.Threading\.Tasks\.ValueTask')

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

<a name='SHTCGClient.ClientService.SendWithToken(System.Net.Http.HttpMethod,string)'></a>

## ClientService\.SendWithToken\(HttpMethod, string\) Method

Send a request to the API with the CSRF token

```csharp
public System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendWithToken(System.Net.Http.HttpMethod method, string url);
```
#### Parameters

<a name='SHTCGClient.ClientService.SendWithToken(System.Net.Http.HttpMethod,string).method'></a>

`method` [System\.Net\.Http\.HttpMethod](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpmethod 'System\.Net\.Http\.HttpMethod')

Method to use

<a name='SHTCGClient.ClientService.SendWithToken(System.Net.Http.HttpMethod,string).url'></a>

`url` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The url, the API url /api/ is prepended already\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Net\.Http\.HttpResponseMessage](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpresponsemessage 'System\.Net\.Http\.HttpResponseMessage')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
HttpResponse task