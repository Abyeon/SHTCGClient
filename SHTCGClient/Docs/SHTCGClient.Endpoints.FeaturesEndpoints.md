#### [SHTCGClient](index.md 'index')
### [SHTCGClient\.Endpoints](index.md#SHTCGClient.Endpoints 'SHTCGClient\.Endpoints')

## FeaturesEndpoints Class

Class for interacting with the features endpoint

```csharp
public class FeaturesEndpoints
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; FeaturesEndpoints
### Constructors

<a name='SHTCGClient.Endpoints.FeaturesEndpoints.FeaturesEndpoints(SHTCGClient.ClientService)'></a>

## FeaturesEndpoints\(ClientService\) Constructor

Class for interacting with the features endpoint

```csharp
public FeaturesEndpoints(SHTCGClient.ClientService client);
```
#### Parameters

<a name='SHTCGClient.Endpoints.FeaturesEndpoints.FeaturesEndpoints(SHTCGClient.ClientService).client'></a>

`client` [ClientService](SHTCGClient.ClientService.md 'SHTCGClient\.ClientService')
### Methods

<a name='SHTCGClient.Endpoints.FeaturesEndpoints.Features()'></a>

## FeaturesEndpoints\.Features\(\) Method

Get the current features available for voting\.
Check if the user is able to vote with [VoteStatus\(\)](SHTCGClient.Endpoints.FeaturesEndpoints.md#SHTCGClient.Endpoints.FeaturesEndpoints.VoteStatus() 'SHTCGClient\.Endpoints\.FeaturesEndpoints\.VoteStatus\(\)') before attempting to vote\.

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Features.Feature[]?> Features();
```

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Feature](SHTCGClient.Models.Features.Feature.md 'SHTCGClient\.Models\.Features\.Feature')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Array of features

<a name='SHTCGClient.Endpoints.FeaturesEndpoints.VoteStatus()'></a>

## FeaturesEndpoints\.VoteStatus\(\) Method

Gets the users voting eligibility and the next time they may vote\.

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Features.VoteStatus?> VoteStatus();
```

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[VoteStatus](SHTCGClient.Models.Features.VoteStatus.md 'SHTCGClient\.Models\.Features\.VoteStatus')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
User's VoteStatus