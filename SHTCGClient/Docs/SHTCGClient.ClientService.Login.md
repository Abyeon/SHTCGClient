#### [SHTCGClient](index.md 'index')
### [SHTCGClient](SHTCGClient.md 'SHTCGClient').[ClientService](SHTCGClient.ClientService.md 'SHTCGClient\.ClientService')

## ClientService\.Login Method

| Overloads | |
| :--- | :--- |
| [Login\(Credentials\)](SHTCGClient.ClientService.Login.md#SHTCGClient.ClientService.Login(SHTCGClient.Credentials) 'SHTCGClient\.ClientService\.Login\(SHTCGClient\.Credentials\)') | Log in to the game |
| [Login\(string, string\)](SHTCGClient.ClientService.Login.md#SHTCGClient.ClientService.Login(string,string) 'SHTCGClient\.ClientService\.Login\(string, string\)') | Log in to the game |

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