using System.Text.Json.Serialization;

namespace SHTCGClient.Models.Cards;

/// <summary>
/// Information about the card you rolled, it's rarity, and new roll info
/// </summary>
public class CardRollResponse
{
    [JsonPropertyName("card")]
    public Card Card { get; init; } = null!;

    [JsonPropertyName("rarity")]
    public string Rarity { get; init; } = null!;

    [JsonPropertyName("roll_info")]
    public RollInfo RollInfo { get; init; } = null!;
}