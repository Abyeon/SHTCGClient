using System.Text.Json.Serialization;

namespace SHTCGClient.Models.Exchange;

/// <summary>
/// The user's currently purchases positions in a stock.
/// </summary>
public class Position
{
    [JsonPropertyName("quantity")]
    public int Quantity { get; init; }
    
    [JsonPropertyName("avg_cost")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public double AvgCost { get; init; }
    
    [JsonPropertyName("market_price")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public double MarketPrice { get; init; }
    
    [JsonPropertyName("cost_basis")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public double CostBasis { get; init; }
    
    [JsonPropertyName("market_value")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public double MarketValue { get; init; }
    
    [JsonPropertyName("unrealized_pnl")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public double UnrealizedPnl { get; init; }
    
    [JsonPropertyName("unrealized_pnl_pct")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public double UnrealizedPnlPercentage { get; init; }
    
    [JsonPropertyName("market_id")]
    public int MarketId { get; init; }

    [JsonPropertyName("symbol")]
    public string Symbol { get; init; } = null!;
}