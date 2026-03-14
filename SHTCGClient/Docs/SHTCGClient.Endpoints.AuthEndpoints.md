#### [SHTCGClient](index.md 'index')
### [SHTCGClient\.Endpoints](index.md#SHTCGClient.Endpoints 'SHTCGClient\.Endpoints')

## AuthEndpoints Class

Class for interacting with the auth endpoint

```csharp
public class AuthEndpoints
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; AuthEndpoints
### Constructors

<a name='SHTCGClient.Endpoints.AuthEndpoints.AuthEndpoints(SHTCGClient.ClientService)'></a>

## AuthEndpoints\(ClientService\) Constructor

Class for interacting with the auth endpoint

```csharp
public AuthEndpoints(SHTCGClient.ClientService client);
```
#### Parameters

<a name='SHTCGClient.Endpoints.AuthEndpoints.AuthEndpoints(SHTCGClient.ClientService).client'></a>

`client` [ClientService](SHTCGClient.ClientService.md 'SHTCGClient\.ClientService')
### Methods

<a name='SHTCGClient.Endpoints.AuthEndpoints.Login(SHTCGClient.Credentials)'></a>

## AuthEndpoints\.Login\(Credentials\) Method

Log in to the game

```csharp
public System.Threading.Tasks.Task<bool> Login(SHTCGClient.Credentials credentials);
```
#### Parameters

<a name='SHTCGClient.Endpoints.AuthEndpoints.Login(SHTCGClient.Credentials).credentials'></a>

`credentials` [Credentials](SHTCGClient.Credentials.md 'SHTCGClient\.Credentials')

Login credentials

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Success

<a name='SHTCGClient.Endpoints.AuthEndpoints.Login(string,string)'></a>

## AuthEndpoints\.Login\(string, string\) Method

Log in to the game

```csharp
public System.Threading.Tasks.Task<bool> Login(string username, string password);
```
#### Parameters

<a name='SHTCGClient.Endpoints.AuthEndpoints.Login(string,string).username'></a>

`username` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

Your username

<a name='SHTCGClient.Endpoints.AuthEndpoints.Login(string,string).password'></a>

`password` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

Your password

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Success