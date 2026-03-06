using System.Text.Json.Serialization;

namespace SHTCGClient.Models.Cards;

public class CardRollResponse
{
    [JsonPropertyName("card")]
    public Card Card { get; set; } = null!;

    [JsonPropertyName("rarity")]
    public string Rarity { get; set; } = null!;

    [JsonPropertyName("roll_info")]
    public RollInfo RollInfo { get; set; } = null!;
}