using System.Text.Json.Serialization;

namespace SHTCGClient.Models.Exchange;

public class Exchange
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    [JsonPropertyName("description")]
    public string Description { get; set; } = null!;

    [JsonPropertyName("symbol")]
    public Symbol Symbol { get; set; } = null!;
    
    [JsonPropertyName("is_active")]
    public bool IsActive { get; set; }
    
    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }
    
    [JsonPropertyName("latest_price")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public double LatestPrice { get; set; }
    
    [JsonPropertyName("volume_24h")]
    public int Volume24Hours { get; set; }
    
    [JsonPropertyName("high_24h")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public double High24Hours { get; set; }
    
    [JsonPropertyName("low_24h")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public double Low24Hours { get; set; }
}