#### [SHTCGClient](index.md 'index')
### [SHTCGClient](SHTCGClient.md 'SHTCGClient').[ClientService](SHTCGClient.ClientService.md 'SHTCGClient\.ClientService')

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