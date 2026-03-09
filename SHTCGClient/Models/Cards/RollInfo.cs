using System.Text.Json.Serialization;

namespace SHTCGClient.Models.Cards;

/// <summary>
/// Status information for user's accumulated rolls, max rolls, etc.
/// </summary>
public class RollInfo
{
    [JsonPropertyName("rolls_available")]
    public int RollsAvailable { get; init; }

    [JsonPropertyName("rolls_accumulated")]
    public double RollsAccumulated { get; init; }

    [JsonPropertyName("max_rolls")]
    public int MaxRolls { get; init; }

    [JsonPropertyName("hours_until_next_roll")]
    public double HoursUntilNextRoll { get; init; }

    [JsonPropertyName("roll_refill_cost")]
    public double RollRefillCost { get; init; }

    [JsonPropertyName("season_card_pack_image_url")]
    public string SeasonCardPackImageUrl { get; init; } = null!;
}