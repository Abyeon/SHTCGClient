using System.Text.Json.Serialization;

namespace SHTCGClient.Models.Features;

/// <summary>
/// Represents a voting object for a potential new feature to the game.
/// </summary>
public class Feature
{
    /// <summary>
    /// Identifier of this feature.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// This feature's name.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    /// <summary>
    /// The description of what this feature will accomplish.
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; } = null!;

    /// <summary>
    /// How many votes ths feature has received.
    /// </summary>
    [JsonPropertyName("vote_count")]
    public int VoteCount { get; set; }
    
    /// <summary>
    /// Whether the user has voted for this feature.
    /// </summary>
    [JsonPropertyName("user_has_voted")]
    public bool UserHasVoted { get; set; }
    
    /// <summary>
    /// The date this feature was added to the voting system.
    /// </summary>
    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }
}