using System.Text.Json.Serialization;

namespace SHTCGClient.Models.Exchange;

public class Symbol
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;
    
    [JsonPropertyName("base_card_id")]
    public int BaseCardId { get; set; }

    [JsonPropertyName("base_card_name")]
    public string BaseCardName { get; set; } = null!;
    
    [JsonPropertyName("base_card_image_url")]
    public string BaseCardImageUrl { get; set; } = null!;
}