using System.Text.Json.Serialization;

namespace SHTCGClient.Models.Users.Leaderboards;

/// <summary>
/// Player leaderboard for net worth / total cards
/// </summary>
public class Leaderboard
{
    /// <summary>
    /// The type of leaderboard
    /// </summary>
    [JsonPropertyName("leaderboard_type")]
    public string LeaderboardType { get; set; } = null!;

    /// <summary>
    /// Array of player rankings, sorted by the LeaderboardType
    /// </summary>
    [JsonPropertyName("entries")]
    public LeaderboardEntry[] Entries { get; set; } = null!;
}