#### [SHTCGClient](index.md 'index')
### [SHTCGClient\.Models\.Features](index.md#SHTCGClient.Models.Features 'SHTCGClient\.Models\.Features')

## Feature Class

Represents a voting object for a potential new feature to the game\.

```csharp
public class Feature
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; Feature
### Properties

<a name='SHTCGClient.Models.Features.Feature.CreatedAt'></a>

## Feature\.CreatedAt Property

The date this feature was added to the voting system\.

```csharp
public System.DateTime CreatedAt { get; set; }
```

#### Property Value
[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

<a name='SHTCGClient.Models.Features.Feature.Description'></a>

## Feature\.Description Property

The description of what this feature will accomplish\.

```csharp
public string Description { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='SHTCGClient.Models.Features.Feature.Id'></a>

## Feature\.Id Property

Identifier of this feature\.

```csharp
public int Id { get; set; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='SHTCGClient.Models.Features.Feature.Name'></a>

## Feature\.Name Property

This feature's name\.

```csharp
public string Name { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='SHTCGClient.Models.Features.Feature.UserHasVoted'></a>

## Feature\.UserHasVoted Property

Whether the user has voted for this feature\.

```csharp
public bool UserHasVoted { get; set; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='SHTCGClient.Models.Features.Feature.VoteCount'></a>

## Feature\.VoteCount Property

How many votes ths feature has received\.

```csharp
public int VoteCount { get; set; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')