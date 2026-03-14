#### [SHTCGClient](index.md 'index')
### [SHTCGClient\.Endpoints](index.md#SHTCGClient.Endpoints 'SHTCGClient\.Endpoints')

## CompanionsEndpoints Class

Class for interacting with the companions endpoint

```csharp
public class CompanionsEndpoints
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; CompanionsEndpoints
### Constructors

<a name='SHTCGClient.Endpoints.CompanionsEndpoints.CompanionsEndpoints(SHTCGClient.ClientService)'></a>

## CompanionsEndpoints\(ClientService\) Constructor

Class for interacting with the companions endpoint

```csharp
public CompanionsEndpoints(SHTCGClient.ClientService client);
```
#### Parameters

<a name='SHTCGClient.Endpoints.CompanionsEndpoints.CompanionsEndpoints(SHTCGClient.ClientService).client'></a>

`client` [ClientService](SHTCGClient.ClientService.md 'SHTCGClient\.ClientService')
### Methods

<a name='SHTCGClient.Endpoints.CompanionsEndpoints.EquipCompanion(int)'></a>

## CompanionsEndpoints\.EquipCompanion\(int\) Method

Equip a companion by ID

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Companions.Companion?> EquipCompanion(int id);
```
#### Parameters

<a name='SHTCGClient.Endpoints.CompanionsEndpoints.EquipCompanion(int).id'></a>

`id` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The ID of the companion to equip

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Companion](SHTCGClient.Models.Companions.Companion.md 'SHTCGClient\.Models\.Companions\.Companion')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
The equipped companion

<a name='SHTCGClient.Endpoints.CompanionsEndpoints.GetActiveCompanion()'></a>

## CompanionsEndpoints\.GetActiveCompanion\(\) Method

Get the user's currently active companion

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Companions.Companion?> GetActiveCompanion();
```

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Companion](SHTCGClient.Models.Companions.Companion.md 'SHTCGClient\.Models\.Companions\.Companion')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
The active companion

<a name='SHTCGClient.Endpoints.CompanionsEndpoints.GetCompanions()'></a>

## CompanionsEndpoints\.GetCompanions\(\) Method

Get the user's owned companions

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Companions.Companion[]?> GetCompanions();
```

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Companion](SHTCGClient.Models.Companions.Companion.md 'SHTCGClient\.Models\.Companions\.Companion')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Array of companions

<a name='SHTCGClient.Endpoints.CompanionsEndpoints.UnequipCompanion()'></a>

## CompanionsEndpoints\.UnequipCompanion\(\) Method

Unequip the currently active companion

```csharp
public System.Threading.Tasks.Task<bool> UnequipCompanion();
```

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Success