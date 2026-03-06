using System.Text.Json.Serialization;

namespace SHTCGClient.Models.Exchange;

public class Candle
{
    [JsonPropertyName("timestamp")]
    public DateTime Timestamp { get; set; }
    
    [JsonPropertyName("open")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public double Open { get; set; }
    
    [JsonPropertyName("high")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public double High { get; set; }
    
    [JsonPropertyName("low")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public double Low { get; set; }
    
    [JsonPropertyName("close")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public double Close { get; set; }
    
    [JsonPropertyName("volume")]
    public int Volume { get; set; }
}