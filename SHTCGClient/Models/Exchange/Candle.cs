using System.Text.Json.Serialization;

namespace SHTCGClient.Models.Exchange;

public class Candle
{
    [JsonPropertyName("timestamp")]
    public DateTime Timestamp { get; init; }
    
    [JsonPropertyName("open")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public double Open { get; init; }
    
    [JsonPropertyName("high")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public double High { get; init; }
    
    [JsonPropertyName("low")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public double Low { get; init; }
    
    [JsonPropertyName("close")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public double Close { get; init; }
    
    [JsonPropertyName("volume")]
    public int Volume { get; init; }
}