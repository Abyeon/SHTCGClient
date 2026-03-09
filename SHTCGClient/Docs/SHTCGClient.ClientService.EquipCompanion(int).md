#### [SHTCGClient](index.md 'index')
### [SHTCGClient](SHTCGClient.md 'SHTCGClient').[ClientService](SHTCGClient.ClientService.md 'SHTCGClient\.ClientService')

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