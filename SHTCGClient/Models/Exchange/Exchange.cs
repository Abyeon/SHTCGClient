using System.Text.Json.Serialization;

namespace SHTCGClient.Models.Exchange;

/// <summary>
/// Stock information
/// </summary>
public class Exchange
{
    [JsonPropertyName("id")]
    public int Id { get; init; }
    
    [JsonPropertyName("name")]
    public string Name { get; init; } = null!;

    [JsonPropertyName("description")]
    public string Description { get; init; } = null!;

    [JsonPropertyName("symbol")]
    public Symbol Symbol { get; init; } = null!;
    
    [JsonPropertyName("is_active")]
    public bool IsActive { get; init; }
    
    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; init; }
    
    [JsonPropertyName("latest_price")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public double LatestPrice { get; init; }
    
    [JsonPropertyName("volume_24h")]
    public int Volume24Hours { get; init; }
    
    [JsonPropertyName("high_24h")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public double High24Hours { get; init; }
    
    [JsonPropertyName("low_24h")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public double Low24Hours { get; init; }

    /// <summary>
    /// Get the candle graph for this exchange
    /// </summary>
    /// <param name="client">Your client</param>
    /// <param name="interval">Every x minutes for candles</param>
    /// <param name="limit">Limit how many candles you get</param>
    /// <returns></returns>
    public async Task<Candle[]?> GetCandles(ClientService client, int interval = 5, int limit = 288) => await client.Exchange.Candles(Id, interval, limit);
}