#### [SHTCGClient](index.md 'index')
### [SHTCGClient\.Endpoints](index.md#SHTCGClient.Endpoints 'SHTCGClient\.Endpoints')

## UsersEndpoints Class

Class for interacting with the users endpoint

```csharp
public class UsersEndpoints
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; UsersEndpoints
### Constructors

<a name='SHTCGClient.Endpoints.UsersEndpoints.UsersEndpoints(SHTCGClient.ClientService)'></a>

## UsersEndpoints\(ClientService\) Constructor

Class for interacting with the users endpoint

```csharp
public UsersEndpoints(SHTCGClient.ClientService client);
```
#### Parameters

<a name='SHTCGClient.Endpoints.UsersEndpoints.UsersEndpoints(SHTCGClient.ClientService).client'></a>

`client` [ClientService](SHTCGClient.ClientService.md 'SHTCGClient\.ClientService')
### Methods

<a name='SHTCGClient.Endpoints.UsersEndpoints.Friends()'></a>

## UsersEndpoints\.Friends\(\) Method

Get your friends

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Users.User[]?> Friends();
```

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[User](SHTCGClient.Models.Users.User.md 'SHTCGClient\.Models\.Users\.User')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Array of users

<a name='SHTCGClient.Endpoints.UsersEndpoints.Leaderboard(string,int)'></a>

## UsersEndpoints\.Leaderboard\(string, int\) Method

Fetch the leaderboard

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Users.Leaderboards.Leaderboard?> Leaderboard(string type, int limit);
```
#### Parameters

<a name='SHTCGClient.Endpoints.UsersEndpoints.Leaderboard(string,int).type'></a>

`type` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The value to sort by

<a name='SHTCGClient.Endpoints.UsersEndpoints.Leaderboard(string,int).limit'></a>

`limit` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The max entries to fetch

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Leaderboard](SHTCGClient.Models.Users.Leaderboards.Leaderboard.md 'SHTCGClient\.Models\.Users\.Leaderboards\.Leaderboard')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
The leaderboard sorted by input type

<a name='SHTCGClient.Endpoints.UsersEndpoints.UserByName(string)'></a>

## UsersEndpoints\.UserByName\(string\) Method

Search for a user by name

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Users.User[]?> UserByName(string name);
```
#### Parameters

<a name='SHTCGClient.Endpoints.UsersEndpoints.UserByName(string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The username to search for

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[User](SHTCGClient.Models.Users.User.md 'SHTCGClient\.Models\.Users\.User')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Array of users