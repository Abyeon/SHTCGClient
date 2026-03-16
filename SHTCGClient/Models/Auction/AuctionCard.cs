using System.Text.Json.Serialization;
using SHTCGClient.Models.Cards;

namespace SHTCGClient.Models.Auction;

/// <summary>
/// A class specific to Auction listed cards
/// </summary>
public class AuctionCard
{
    /// <inheritdoc cref="Card.Id" />
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <inheritdoc cref="Card.Name" />
    [JsonPropertyName("base_card_name")]
    public string BaseCardName { get; set; } = null!;

    /// <inheritdoc cref="Card.BaseCardId" />
    [JsonPropertyName("base_card_id")]
    public int BaseCardId { get; set; }

    /// <inheritdoc cref="Card.Stack" />
    [JsonPropertyName("stack")]
    public int Stack { get; set; }

    /// <inheritdoc cref="Card.Rarity" />
    [JsonPropertyName("rarity")]
    public string Rarity { get; set; } = null!;

    /// <inheritdoc cref="Card.Trim" />
    [JsonPropertyName("trim")]
    public string Trim { get; set; } = null!;
    
    /// <inheritdoc cref="Card.Foil" />
    [JsonPropertyName("foil")]
    public string Foil { get; set; } = null!;

    /// <inheritdoc cref="Card.EstimatedValue" />
    [JsonPropertyName("estimated_value")]
    public double EstimatedValue { get; set; }

    /// <inheritdoc cref="Card.ImageUrl" />
    [JsonPropertyName("image")]
    public string Image { get; set; } = null!;
}