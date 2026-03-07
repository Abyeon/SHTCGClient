using System.Text.Json.Serialization;

namespace SHTCGClient.Models.Cards;

public class RollInfo
{
    [JsonPropertyName("rolls_available")]
    public int RollsAvailable { get; set; }

    [JsonPropertyName("rolls_accumulated")]
    public double RollsAccumulated { get; set; }

    [JsonPropertyName("max_rolls")]
    public int MaxRolls { get; set; }

    [JsonPropertyName("hours_until_next_roll")]
    public double HoursUntilNextRoll { get; set; }

    [JsonPropertyName("roll_refill_cost")]
    public double RollRefillCost { get; set; }

    [JsonPropertyName("season_card_pack_image_url")]
    public string SeasonCardPackImageUrl { get; set; } = null!;
}