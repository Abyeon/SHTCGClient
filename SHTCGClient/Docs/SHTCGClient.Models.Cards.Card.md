#### [SHTCGClient](index.md 'index')
### [SHTCGClient\.Models\.Cards](index.md#SHTCGClient.Models.Cards 'SHTCGClient\.Models\.Cards')

## Card Class

A Trading Card

```csharp
public class Card : System.IEquatable<SHTCGClient.Models.Cards.Card>, System.Text.Json.Serialization.IJsonOnDeserialized
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; Card

Implements [System\.IEquatable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')[Card](SHTCGClient.Models.Cards.Card.md 'SHTCGClient\.Models\.Cards\.Card')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1'), [System\.Text\.Json\.Serialization\.IJsonOnDeserialized](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.serialization.ijsonondeserialized 'System\.Text\.Json\.Serialization\.IJsonOnDeserialized')
### Properties

<a name='SHTCGClient.Models.Cards.Card.BaseCardId'></a>

## Card\.BaseCardId Property

```csharp
public int BaseCardId { get; init; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='SHTCGClient.Models.Cards.Card.CardSetId'></a>

## Card\.CardSetId Property

```csharp
public System.Nullable<int> CardSetId { get; init; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='SHTCGClient.Models.Cards.Card.CollectionId'></a>

## Card\.CollectionId Property

```csharp
public System.Nullable<int> CollectionId { get; init; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='SHTCGClient.Models.Cards.Card.CreatedAt'></a>

## Card\.CreatedAt Property

```csharp
public System.DateTime CreatedAt { get; init; }
```

#### Property Value
[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

<a name='SHTCGClient.Models.Cards.Card.Description'></a>

## Card\.Description Property

```csharp
public string? Description { get; init; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='SHTCGClient.Models.Cards.Card.DropChance'></a>

## Card\.DropChance Property

```csharp
public double DropChance { get; init; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='SHTCGClient.Models.Cards.Card.EstimatedValue'></a>

## Card\.EstimatedValue Property

```csharp
public double EstimatedValue { get; init; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='SHTCGClient.Models.Cards.Card.ExtensionData'></a>

## Card\.ExtensionData Property

```csharp
public System.Collections.Generic.Dictionary<string,System.Text.Json.JsonElement>? ExtensionData { get; init; }
```

#### Property Value
[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.Text\.Json\.JsonElement](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.jsonelement 'System\.Text\.Json\.JsonElement')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')

<a name='SHTCGClient.Models.Cards.Card.Foil'></a>

## Card\.Foil Property

```csharp
public string Foil { get; init; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='SHTCGClient.Models.Cards.Card.Grade'></a>

## Card\.Grade Property

```csharp
public System.Nullable<double> Grade { get; init; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='SHTCGClient.Models.Cards.Card.Id'></a>

## Card\.Id Property

```csharp
public int Id { get; init; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='SHTCGClient.Models.Cards.Card.ImageUrl'></a>

## Card\.ImageUrl Property

```csharp
public string ImageUrl { get; init; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='SHTCGClient.Models.Cards.Card.IsLocked'></a>

## Card\.IsLocked Property

```csharp
public bool IsLocked { get; set; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='SHTCGClient.Models.Cards.Card.IsRequestUser'></a>

## Card\.IsRequestUser Property

```csharp
public System.Nullable<bool> IsRequestUser { get; init; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='SHTCGClient.Models.Cards.Card.Name'></a>

## Card\.Name Property

```csharp
public string Name { get; init; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='SHTCGClient.Models.Cards.Card.Owner'></a>

## Card\.Owner Property

```csharp
public SHTCGClient.Models.Users.Profile? Owner { get; }
```

#### Property Value
[Profile](SHTCGClient.Models.Users.Profile.md 'SHTCGClient\.Models\.Users\.Profile')

<a name='SHTCGClient.Models.Cards.Card.Rarity'></a>

## Card\.Rarity Property

```csharp
public string Rarity { get; init; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='SHTCGClient.Models.Cards.Card.ReleaseDate'></a>

## Card\.ReleaseDate Property

```csharp
public string ReleaseDate { get; init; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='SHTCGClient.Models.Cards.Card.Stack'></a>

## Card\.Stack Property

```csharp
public int Stack { get; set; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='SHTCGClient.Models.Cards.Card.Trim'></a>

## Card\.Trim Property

```csharp
public string Trim { get; init; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='SHTCGClient.Models.Cards.Card.UpdatedAt'></a>

## Card\.UpdatedAt Property

```csharp
public System.Nullable<System.DateTime> UpdatedAt { get; init; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')
### Methods

<a name='SHTCGClient.Models.Cards.Card.Equals(object)'></a>

## Card\.Equals\(object\) Method

```csharp
public override bool Equals(object? obj);
```
#### Parameters

<a name='SHTCGClient.Models.Cards.Card.Equals(object).obj'></a>

`obj` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='SHTCGClient.Models.Cards.Card.Equals(SHTCGClient.Models.Cards.Card)'></a>

## Card\.Equals\(Card\) Method

```csharp
public bool Equals(SHTCGClient.Models.Cards.Card? other);
```
#### Parameters

<a name='SHTCGClient.Models.Cards.Card.Equals(SHTCGClient.Models.Cards.Card).other'></a>

`other` [Card](SHTCGClient.Models.Cards.Card.md 'SHTCGClient\.Models\.Cards\.Card')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='SHTCGClient.Models.Cards.Card.GetHashCode()'></a>

## Card\.GetHashCode\(\) Method

```csharp
public override int GetHashCode();
```

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='SHTCGClient.Models.Cards.Card.OnDeserialized()'></a>

## Card\.OnDeserialized\(\) Method

```csharp
public void OnDeserialized();
```

Implements [OnDeserialized\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.serialization.ijsonondeserialized.ondeserialized 'System\.Text\.Json\.Serialization\.IJsonOnDeserialized\.OnDeserialized')

<a name='SHTCGClient.Models.Cards.Card.Sell(SHTCGClient.ClientService)'></a>

## Card\.Sell\(ClientService\) Method

Sell this card

```csharp
public System.Threading.Tasks.Task<SHTCGClient.Models.Vendors.CardSellResponse?> Sell(SHTCGClient.ClientService client);
```
#### Parameters

<a name='SHTCGClient.Models.Cards.Card.Sell(SHTCGClient.ClientService).client'></a>

`client` [ClientService](SHTCGClient.ClientService.md 'SHTCGClient\.ClientService')

Your client

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[CardSellResponse](SHTCGClient.Models.Vendors.CardSellResponse.md 'SHTCGClient\.Models\.Vendors\.CardSellResponse')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
Information regarding your sale\.