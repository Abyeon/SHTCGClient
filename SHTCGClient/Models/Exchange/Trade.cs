using System.Text.Json.Serialization;

namespace SHTCGClient.Models.Exchange;

public class Trade
{
    [JsonPropertyName("id")] public int Id { get; set; }
    
    [JsonPropertyName("price")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public double Price { get; set; }

    [JsonPropertyName("quantity")] public int Quantity { get; set; }

    [JsonPropertyName("is_simulated")] public bool IsSimulated { get; set; }

    [JsonPropertyName("executed_at")] public DateTime ExecutedAt { get; set; }
}