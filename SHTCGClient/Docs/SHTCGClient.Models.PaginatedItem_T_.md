#### [SHTCGClient](index.md 'index')
### [SHTCGClient\.Models](index.md#SHTCGClient.Models 'SHTCGClient\.Models')

## PaginatedItem\<T\> Class

Generic object representing a paginated response

```csharp
public class PaginatedItem<T>
```
#### Type parameters

<a name='SHTCGClient.Models.PaginatedItem_T_.T'></a>

`T`

Type for the data array

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; PaginatedItem\<T\>
### Properties

<a name='SHTCGClient.Models.PaginatedItem_T_.Data'></a>

## PaginatedItem\<T\>\.Data Property

```csharp
public T[] Data { get; }
```

#### Property Value
[T](SHTCGClient.Models.PaginatedItem_T_.md#SHTCGClient.Models.PaginatedItem_T_.T 'SHTCGClient\.Models\.PaginatedItem\<T\>\.T')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='SHTCGClient.Models.PaginatedItem_T_.ExtensionData'></a>

## PaginatedItem\<T\>\.ExtensionData Property

```csharp
public System.Collections.Generic.IDictionary<string,System.Text.Json.JsonElement>? ExtensionData { get; init; }
```

#### Property Value
[System\.Collections\.Generic\.IDictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')[System\.Text\.Json\.JsonElement](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.jsonelement 'System\.Text\.Json\.JsonElement')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')

<a name='SHTCGClient.Models.PaginatedItem_T_.Page'></a>

## PaginatedItem\<T\>\.Page Property

```csharp
public int Page { get; init; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='SHTCGClient.Models.PaginatedItem_T_.PageSize'></a>

## PaginatedItem\<T\>\.PageSize Property

```csharp
public int PageSize { get; init; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='SHTCGClient.Models.PaginatedItem_T_.Total'></a>

## PaginatedItem\<T\>\.Total Property

```csharp
public int Total { get; init; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='SHTCGClient.Models.PaginatedItem_T_.TotalPages'></a>

## PaginatedItem\<T\>\.TotalPages Property

```csharp
public int TotalPages { get; init; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')