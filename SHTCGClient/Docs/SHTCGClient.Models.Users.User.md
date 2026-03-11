#### [SHTCGClient](index.md 'index')
### [SHTCGClient\.Models\.Users](index.md#SHTCGClient.Models.Users 'SHTCGClient\.Models\.Users')

## User Class

User information\.

```csharp
public class User : System.IEquatable<SHTCGClient.Models.Users.User>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; User

Implements [System\.IEquatable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')[User](SHTCGClient.Models.Users.User.md 'SHTCGClient\.Models\.Users\.User')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')
### Properties

<a name='SHTCGClient.Models.Users.User.DateJoined'></a>

## User\.DateJoined Property

The date this user joined the game\.

```csharp
public System.DateTime DateJoined { get; init; }
```

#### Property Value
[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

<a name='SHTCGClient.Models.Users.User.Email'></a>

## User\.Email Property

This user's email, if available\.

```csharp
public string? Email { get; init; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='SHTCGClient.Models.Users.User.Id'></a>

## User\.Id Property

This User's ID

```csharp
public int Id { get; init; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='SHTCGClient.Models.Users.User.IsActive'></a>

## User\.IsActive Property

If this player is currently active

```csharp
public bool IsActive { get; init; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='SHTCGClient.Models.Users.User.NetWorth'></a>

## User\.NetWorth Property

This user's current balance\.

```csharp
public System.Nullable<double> NetWorth { get; init; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='SHTCGClient.Models.Users.User.Username'></a>

## User\.Username Property

This User's name\.

```csharp
public string Username { get; init; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')
### Methods

<a name='SHTCGClient.Models.Users.User.Equals(object)'></a>

## User\.Equals\(object\) Method

Determines whether the specified object is equal to the current object\.

```csharp
public override bool Equals(object? obj);
```
#### Parameters

<a name='SHTCGClient.Models.Users.User.Equals(object).obj'></a>

`obj` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to compare with the current object\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the specified object  is equal to the current object; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='SHTCGClient.Models.Users.User.Equals(SHTCGClient.Models.Users.User)'></a>

## User\.Equals\(User\) Method

```csharp
public bool Equals(SHTCGClient.Models.Users.User? other);
```
#### Parameters

<a name='SHTCGClient.Models.Users.User.Equals(SHTCGClient.Models.Users.User).other'></a>

`other` [User](SHTCGClient.Models.Users.User.md 'SHTCGClient\.Models\.Users\.User')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='SHTCGClient.Models.Users.User.GetHashCode()'></a>

## User\.GetHashCode\(\) Method

Serves as the default hash function\.

```csharp
public override int GetHashCode();
```

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
A hash code for the current object\.