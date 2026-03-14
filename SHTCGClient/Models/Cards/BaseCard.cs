using System.Text.Json;
using System.Text.Json.Serialization;
using SHTCGClient.Models.Users;
using SHTCGClient.Models.Vendors;

namespace SHTCGClient.Models.Cards;

/// <summary>
/// The base variant of a card
/// </summary>
public class BaseCard
{
    /// <summary>
    /// The ID of this card. This is equal to <see cref="Card.BaseCardId"/>
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// The name of this card
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; } = null!;

    /// <summary>
    /// The URL for this card's image
    /// </summary>
    [JsonPropertyName("image_url")]
    public string ImageUrl { get; init; } = null!;

    /// <summary>
    /// This card's description
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// How rare this card is
    /// </summary>
    [JsonPropertyName("rarity")]
    public string Rarity { get; init; } = null!;
    
    /// <summary>
    /// The day this card was released.
    /// </summary>
    /// <example>2026-02-12</example>
    [JsonPropertyName("release_date")]
    public string ReleaseDate { get; init; } = null!;
}