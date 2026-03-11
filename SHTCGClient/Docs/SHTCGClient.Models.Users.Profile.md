#### [SHTCGClient](index.md 'index')
### [SHTCGClient\.Models\.Users](index.md#SHTCGClient.Models.Users 'SHTCGClient\.Models\.Users')

## Profile Class

Additional user information, used on the profile page, leaderboard, and roll history

```csharp
public class Profile : System.IEquatable<SHTCGClient.Models.Users.Profile>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; Profile

Implements [System\.IEquatable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')[Profile](SHTCGClient.Models.Users.Profile.md 'SHTCGClient\.Models\.Users\.Profile')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')
### Properties

<a name='SHTCGClient.Models.Users.Profile.Avatar'></a>

## Profile\.Avatar Property

```csharp
public string? Avatar { get; init; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='SHTCGClient.Models.Users.Profile.BannerColor'></a>

## Profile\.BannerColor Property

```csharp
public string? BannerColor { get; init; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='SHTCGClient.Models.Users.Profile.Bio'></a>

## Profile\.Bio Property

```csharp
public string? Bio { get; init; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='SHTCGClient.Models.Users.Profile.DisplayName'></a>

## Profile\.DisplayName Property

This User's display name\.

```csharp
public string? DisplayName { get; init; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='SHTCGClient.Models.Users.Profile.EquippedBannerImage'></a>

## Profile\.EquippedBannerImage Property

```csharp
public SHTCGClient.Models.Users.BannerImage? EquippedBannerImage { get; init; }
```

#### Property Value
[BannerImage](SHTCGClient.Models.Users.BannerImage.md 'SHTCGClient\.Models\.Users\.BannerImage')

<a name='SHTCGClient.Models.Users.Profile.EquippedTitle'></a>

## Profile\.EquippedTitle Property

```csharp
public string? EquippedTitle { get; init; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='SHTCGClient.Models.Users.Profile.Id'></a>

## Profile\.Id Property

This User's ID

```csharp
public int Id { get; init; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='SHTCGClient.Models.Users.Profile.IsAnonymous'></a>

## Profile\.IsAnonymous Property

```csharp
public System.Nullable<bool> IsAnonymous { get; init; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='SHTCGClient.Models.Users.Profile.ProfileColor'></a>

## Profile\.ProfileColor Property

```csharp
public string? ProfileColor { get; init; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='SHTCGClient.Models.Users.Profile.Username'></a>

## Profile\.Username Property

This User's name\.

```csharp
public string? Username { get; init; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')
### Methods

<a name='SHTCGClient.Models.Users.Profile.Equals(object)'></a>

## Profile\.Equals\(object\) Method

Determines whether the specified object is equal to the current object\.

```csharp
public override bool Equals(object? obj);
```
#### Parameters

<a name='SHTCGClient.Models.Users.Profile.Equals(object).obj'></a>

`obj` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to compare with the current object\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the specified object  is equal to the current object; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='SHTCGClient.Models.Users.Profile.Equals(SHTCGClient.Models.Users.Profile)'></a>

## Profile\.Equals\(Profile\) Method

```csharp
public bool Equals(SHTCGClient.Models.Users.Profile? other);
```
#### Parameters

<a name='SHTCGClient.Models.Users.Profile.Equals(SHTCGClient.Models.Users.Profile).other'></a>

`other` [Profile](SHTCGClient.Models.Users.Profile.md 'SHTCGClient\.Models\.Users\.Profile')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='SHTCGClient.Models.Users.Profile.GetHashCode()'></a>

## Profile\.GetHashCode\(\) Method

Serves as the default hash function\.

```csharp
public override int GetHashCode();
```

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
A hash code for the current object\.