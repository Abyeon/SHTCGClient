using System.Text.Json.Serialization;

namespace SHTCGClient.Models.Features;

/// <summary>
/// Information on when the user may vote for a feature again.
/// </summary>
public class VoteStatus
{
    /// <summary>
    /// Whether the user may vote currently
    /// </summary>
    [JsonPropertyName("can_vote")]
    public bool CanVote { get; set; }

    /// <summary>
    /// The last time the user voted
    /// </summary>
    [JsonPropertyName("last_vote_at")]
    public DateTime LastVoteAt { get; set; }

    /// <summary>
    /// The next time the user may vote
    /// </summary>
    [JsonPropertyName("next_vote_at")]
    public DateTime NextVoteAt { get; set; }

    /// <summary>
    /// The hours until the user is able to vote again
    /// </summary>
    [JsonPropertyName("hours_until_next_vote")]
    public double HoursUntilNextVote { get; set; }
    
    /// <summary>
    /// The days until the user is able to vote again
    /// </summary>
    [JsonPropertyName("days_until_next_vote")]
    public double DaysUntilNextVote { get; set; }
}