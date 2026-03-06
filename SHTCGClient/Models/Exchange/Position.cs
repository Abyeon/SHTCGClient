using System.Text.Json.Serialization;

namespace SHTCGClient.Models.Exchange;

public class Position
{
    [JsonPropertyName("quantity")]
    public int Quantity { get; set; }
    
    [JsonPropertyName("avg_cost")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public double AvgCost { get; set; }
    
    [JsonPropertyName("market_price")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public double MarketPrice { get; set; }
    
    [JsonPropertyName("cost_basis")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public double CostBasis { get; set; }
    
    [JsonPropertyName("market_value")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public double MarketValue { get; set; }
    
    [JsonPropertyName("unrealized_pnl")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public double UnrealizedPnl { get; set; }
    
    [JsonPropertyName("unrealized_pnl_pct")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public double UnrealizedPnlPercentage { get; set; }
    
    [JsonPropertyName("market_id")]
    public int MarketId { get; set; }

    [JsonPropertyName("symbol")]
    public string Symbol { get; set; } = null!;
}