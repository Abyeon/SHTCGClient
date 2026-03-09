#### [SHTCGClient](index.md 'index')
### [SHTCGClient\.Models\.Seasons](index.md#SHTCGClient.Models.Seasons 'SHTCGClient\.Models\.Seasons')

## Deck Class

Object containing cards for a season\.

```csharp
public class Deck : System.IEquatable<SHTCGClient.Models.Seasons.Deck>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; Deck

Implements [System\.IEquatable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')[Deck](SHTCGClient.Models.Seasons.Deck.md 'SHTCGClient\.Models\.Seasons\.Deck')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')
### Properties

<a name='SHTCGClient.Models.Seasons.Deck.CardCount'></a>

## Deck\.CardCount Property

```csharp
public int CardCount { get; init; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='SHTCGClient.Models.Seasons.Deck.CreatedAt'></a>

## Deck\.CreatedAt Property

```csharp
public System.DateTime CreatedAt { get; init; }
```

#### Property Value
[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

<a name='SHTCGClient.Models.Seasons.Deck.Description'></a>

## Deck\.Description Property

```csharp
public string Description { get; init; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='SHTCGClient.Models.Seasons.Deck.Id'></a>

## Deck\.Id Property

```csharp
public int Id { get; init; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='SHTCGClient.Models.Seasons.Deck.Name'></a>

## Deck\.Name Property

```csharp
public string Name { get; init; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='SHTCGClient.Models.Seasons.Deck.Owner'></a>

## Deck\.Owner Property

```csharp
public SHTCGClient.Models.Users.Profile? Owner { get; init; }
```

#### Property Value
[Profile](SHTCGClient.Models.Users.Profile.md 'SHTCGClient\.Models\.Users\.Profile')

<a name='SHTCGClient.Models.Seasons.Deck.OwnerId'></a>

## Deck\.OwnerId Property

```csharp
public int OwnerId { get; init; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='SHTCGClient.Models.Seasons.Deck.Score'></a>

## Deck\.Score Property

```csharp
public double Score { get; init; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='SHTCGClient.Models.Seasons.Deck.ScoreRating'></a>

## Deck\.ScoreRating Property

```csharp
public string ScoreRating { get; init; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='SHTCGClient.Models.Seasons.Deck.SeasonId'></a>

## Deck\.SeasonId Property

```csharp
public int SeasonId { get; init; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='SHTCGClient.Models.Seasons.Deck.UpdatedAt'></a>

## Deck\.UpdatedAt Property

```csharp
public System.DateTime UpdatedAt { get; init; }
```

#### Property Value
[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')
### Methods

<a name='SHTCGClient.Models.Seasons.Deck.Add(SHTCGClient.ClientService,int)'></a>

## Deck\.Add\(ClientService, int\) Method

Adds a card to the deck

```csharp
public System.Threading.Tasks.Task Add(SHTCGClient.ClientService client, int cardId);
```
#### Parameters

<a name='SHTCGClient.Models.Seasons.Deck.Add(SHTCGClient.ClientService,int).client'></a>

`client` [ClientService](SHTCGClient.ClientService.md 'SHTCGClient\.ClientService')

Your client

<a name='SHTCGClient.Models.Seasons.Deck.Add(SHTCGClient.ClientService,int).cardId'></a>

`cardId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

ID of the card to add

#### Returns
[System\.Threading\.Tasks\.Task](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task 'System\.Threading\.Tasks\.Task')

<a name='SHTCGClient.Models.Seasons.Deck.Add(SHTCGClient.ClientService,SHTCGClient.Models.Cards.Card)'></a>

## Deck\.Add\(ClientService, Card\) Method

Adds a card to the deck

```csharp
public System.Threading.Tasks.Task Add(SHTCGClient.ClientService client, SHTCGClient.Models.Cards.Card card);
```
#### Parameters

<a name='SHTCGClient.Models.Seasons.Deck.Add(SHTCGClient.ClientService,SHTCGClient.Models.Cards.Card).client'></a>

`client` [ClientService](SHTCGClient.ClientService.md 'SHTCGClient\.ClientService')

Your client

<a name='SHTCGClient.Models.Seasons.Deck.Add(SHTCGClient.ClientService,SHTCGClient.Models.Cards.Card).card'></a>

`card` [Card](SHTCGClient.Models.Cards.Card.md 'SHTCGClient\.Models\.Cards\.Card')

Card to add

#### Returns
[System\.Threading\.Tasks\.Task](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task 'System\.Threading\.Tasks\.Task')

<a name='SHTCGClient.Models.Seasons.Deck.Equals(object)'></a>

## Deck\.Equals\(object\) Method

```csharp
public override bool Equals(object? obj);
```
#### Parameters

<a name='SHTCGClient.Models.Seasons.Deck.Equals(object).obj'></a>

`obj` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='SHTCGClient.Models.Seasons.Deck.Equals(SHTCGClient.Models.Seasons.Deck)'></a>

## Deck\.Equals\(Deck\) Method

```csharp
public bool Equals(SHTCGClient.Models.Seasons.Deck? other);
```
#### Parameters

<a name='SHTCGClient.Models.Seasons.Deck.Equals(SHTCGClient.Models.Seasons.Deck).other'></a>

`other` [Deck](SHTCGClient.Models.Seasons.Deck.md 'SHTCGClient\.Models\.Seasons\.Deck')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='SHTCGClient.Models.Seasons.Deck.GetHashCode()'></a>

## Deck\.GetHashCode\(\) Method

```csharp
public override int GetHashCode();
```

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='SHTCGClient.Models.Seasons.Deck.Remove(SHTCGClient.ClientService,int)'></a>

## Deck\.Remove\(ClientService, int\) Method

Removes a card from the deck

```csharp
public System.Threading.Tasks.Task Remove(SHTCGClient.ClientService client, int cardId);
```
#### Parameters

<a name='SHTCGClient.Models.Seasons.Deck.Remove(SHTCGClient.ClientService,int).client'></a>

`client` [ClientService](SHTCGClient.ClientService.md 'SHTCGClient\.ClientService')

Your client

<a name='SHTCGClient.Models.Seasons.Deck.Remove(SHTCGClient.ClientService,int).cardId'></a>

`cardId` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

ID of the card to remove

#### Returns
[System\.Threading\.Tasks\.Task](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task 'System\.Threading\.Tasks\.Task')

<a name='SHTCGClient.Models.Seasons.Deck.Remove(SHTCGClient.ClientService,SHTCGClient.Models.Cards.Card)'></a>

## Deck\.Remove\(ClientService, Card\) Method

Removes a card from the deck

```csharp
public System.Threading.Tasks.Task Remove(SHTCGClient.ClientService client, SHTCGClient.Models.Cards.Card card);
```
#### Parameters

<a name='SHTCGClient.Models.Seasons.Deck.Remove(SHTCGClient.ClientService,SHTCGClient.Models.Cards.Card).client'></a>

`client` [ClientService](SHTCGClient.ClientService.md 'SHTCGClient\.ClientService')

Your client

<a name='SHTCGClient.Models.Seasons.Deck.Remove(SHTCGClient.ClientService,SHTCGClient.Models.Cards.Card).card'></a>

`card` [Card](SHTCGClient.Models.Cards.Card.md 'SHTCGClient\.Models\.Cards\.Card')

Card to remove

#### Returns
[System\.Threading\.Tasks\.Task](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task 'System\.Threading\.Tasks\.Task')