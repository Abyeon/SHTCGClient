using System.Text.Json.Serialization;

namespace SHTCGClient.Models.Exchange;

public class Symbol
{
    [JsonPropertyName("id")]
    public int Id { get; init; }
    
    [JsonPropertyName("name")]
    public string Name { get; init; } = null!;
    
    [JsonPropertyName("base_card_id")]
    public int BaseCardId { get; init; }

    [JsonPropertyName("base_card_name")]
    public string BaseCardName { get; init; } = null!;
    
    [JsonPropertyName("base_card_image_url")]
    public string BaseCardImageUrl { get; init; } = null!;
}