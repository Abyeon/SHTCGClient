#### [SHTCGClient](index.md 'index')
### [SHTCGClient\.Models\.Features](index.md#SHTCGClient.Models.Features 'SHTCGClient\.Models\.Features')

## VoteStatus Class

Information on when the user may vote for a feature again\.

```csharp
public class VoteStatus
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; VoteStatus
### Properties

<a name='SHTCGClient.Models.Features.VoteStatus.CanVote'></a>

## VoteStatus\.CanVote Property

Whether the user may vote currently

```csharp
public bool CanVote { get; set; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='SHTCGClient.Models.Features.VoteStatus.DaysUntilNextVote'></a>

## VoteStatus\.DaysUntilNextVote Property

The days until the user is able to vote again

```csharp
public double DaysUntilNextVote { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='SHTCGClient.Models.Features.VoteStatus.HoursUntilNextVote'></a>

## VoteStatus\.HoursUntilNextVote Property

The hours until the user is able to vote again

```csharp
public double HoursUntilNextVote { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='SHTCGClient.Models.Features.VoteStatus.LastVoteAt'></a>

## VoteStatus\.LastVoteAt Property

The last time the user voted

```csharp
public System.DateTime LastVoteAt { get; set; }
```

#### Property Value
[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')

<a name='SHTCGClient.Models.Features.VoteStatus.NextVoteAt'></a>

## VoteStatus\.NextVoteAt Property

The next time the user may vote

```csharp
public System.DateTime NextVoteAt { get; set; }
```

#### Property Value
[System\.DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime 'System\.DateTime')