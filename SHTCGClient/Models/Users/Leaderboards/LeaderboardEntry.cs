using System.Text.Json.Serialization;

namespace SHTCGClient.Models.Users.Leaderboards;

/// <summary>
/// Player rank entry on the leaderboard
/// </summary>
public class LeaderboardEntry
{
    /// <summary>
    /// This player's position on the leaderboard
    /// </summary>
    [JsonPropertyName("rank")]
    public int Rank { get; set; }
    
    /// <inheritdoc cref="User.Id"/>
    [JsonPropertyName("user_id")]
    public int UserId { get; set; }

    /// <inheritdoc cref="User.Username"/>
    [JsonPropertyName("username")]
    public string Username { get; set; } = null!;

    /// <summary>
    /// This player's display name
    /// </summary>
    [JsonPropertyName("leaderboard_name")]
    public string LeaderboardName { get; set; } = null!;
    
    /// <inheritdoc cref="User.NetWorth"/>
    [JsonPropertyName("net_worth")]
    public double NetWorth { get; set; }
    
    /// <summary>
    /// This player's total owned cards.
    /// </summary>
    [JsonPropertyName("total_cards")]
    public int TotalCards { get; set; }
}