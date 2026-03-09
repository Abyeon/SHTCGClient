#### [SHTCGClient](index.md 'index')
### [SHTCGClient\.Models\.Companions](index.md#SHTCGClient.Models.Companions 'SHTCGClient\.Models\.Companions')

## Companion Class

A pet that will provide bonuses and detriments to a user's rolls\.

```csharp
public class Companion : System.IEquatable<SHTCGClient.Models.Companions.Companion>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; Companion

Implements [System\.IEquatable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')[Companion](SHTCGClient.Models.Companions.Companion.md 'SHTCGClient\.Models\.Companions\.Companion')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')
### Properties

<a name='SHTCGClient.Models.Companions.Companion.CreatedAt'></a>

## Companion\.CreatedAt Property

```csharp
public System.Nullable<System.DateTime> CreatedAt { get; init; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='SHTCGClient.Models.Companions.Companion.Id'></a>

## Companion\.Id Property

```csharp
public int Id { get; init; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='SHTCGClient.Models.Companions.Companion.LuckModifier'></a>

## Companion\.LuckModifier Property

```csharp
public double LuckModifier { get; init; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='SHTCGClient.Models.Companions.Companion.MaxRollsModifier'></a>

## Companion\.MaxRollsModifier Property

```csharp
public double MaxRollsModifier { get; init; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='SHTCGClient.Models.Companions.Companion.Name'></a>

## Companion\.Name Property

```csharp
public string Name { get; init; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='SHTCGClient.Models.Companions.Companion.RollRefreshModifier'></a>

## Companion\.RollRefreshModifier Property

```csharp
public double RollRefreshModifier { get; init; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='SHTCGClient.Models.Companions.Companion.SpriteSheet'></a>

## Companion\.SpriteSheet Property

```csharp
public SHTCGClient.Models.Companions.SpriteSheet SpriteSheet { get; init; }
```

#### Property Value
[SpriteSheet](SHTCGClient.Models.Companions.SpriteSheet.md 'SHTCGClient\.Models\.Companions\.SpriteSheet')

<a name='SHTCGClient.Models.Companions.Companion.Title'></a>

## Companion\.Title Property

```csharp
public string Title { get; init; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='SHTCGClient.Models.Companions.Companion.UpdatedAt'></a>

## Companion\.UpdatedAt Property

```csharp
public System.Nullable<System.DateTime> UpdatedAt { get; init; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')
### Methods

<a name='SHTCGClient.Models.Companions.Companion.Equals(object)'></a>

## Companion\.Equals\(object\) Method

```csharp
public override bool Equals(object? obj);
```
#### Parameters

<a name='SHTCGClient.Models.Companions.Companion.Equals(object).obj'></a>

`obj` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='SHTCGClient.Models.Companions.Companion.Equals(SHTCGClient.Models.Companions.Companion)'></a>

## Companion\.Equals\(Companion\) Method

```csharp
public bool Equals(SHTCGClient.Models.Companions.Companion? other);
```
#### Parameters

<a name='SHTCGClient.Models.Companions.Companion.Equals(SHTCGClient.Models.Companions.Companion).other'></a>

`other` [Companion](SHTCGClient.Models.Companions.Companion.md 'SHTCGClient\.Models\.Companions\.Companion')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='SHTCGClient.Models.Companions.Companion.Equip(SHTCGClient.ClientService)'></a>

## Companion\.Equip\(ClientService\) Method

Equips this companion

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Companions.Companion?> Equip(SHTCGClient.ClientService client);
```
#### Parameters

<a name='SHTCGClient.Models.Companions.Companion.Equip(SHTCGClient.ClientService).client'></a>

`client` [ClientService](SHTCGClient.ClientService.md 'SHTCGClient\.ClientService')

Your client

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[Companion](SHTCGClient.Models.Companions.Companion.md 'SHTCGClient\.Models\.Companions\.Companion')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
The equipped companion \(this\)\.

<a name='SHTCGClient.Models.Companions.Companion.GetHashCode()'></a>

## Companion\.GetHashCode\(\) Method

```csharp
public override int GetHashCode();
```

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')