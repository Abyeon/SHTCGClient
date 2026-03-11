#### [SHTCGClient](index.md 'index')
### [SHTCGClient\.Models\.Users\.Leaderboards](index.md#SHTCGClient.Models.Users.Leaderboards 'SHTCGClient\.Models\.Users\.Leaderboards')

## Leaderboard Class

Player leaderboard for net worth / total cards

```csharp
public class Leaderboard
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; Leaderboard
### Properties

<a name='SHTCGClient.Models.Users.Leaderboards.Leaderboard.Entries'></a>

## Leaderboard\.Entries Property

Array of player rankings, sorted by the LeaderboardType

```csharp
public SHTCGClient.Models.Users.Leaderboards.LeaderboardEntry[] Entries { get; set; }
```

#### Property Value
[LeaderboardEntry](SHTCGClient.Models.Users.Leaderboards.LeaderboardEntry.md 'SHTCGClient\.Models\.Users\.Leaderboards\.LeaderboardEntry')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='SHTCGClient.Models.Users.Leaderboards.Leaderboard.LeaderboardType'></a>

## Leaderboard\.LeaderboardType Property

The type of leaderboard

```csharp
public string LeaderboardType { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')