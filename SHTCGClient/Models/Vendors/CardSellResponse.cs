using System.Text.Json.Serialization;

namespace SHTCGClient.Models.Vendors;

/// <summary>
/// Information for a sold card.
/// </summary>
public class CardSellResponse
{
    [JsonPropertyName("message")]
    public string Message { get; set; } = null!;
    
    [JsonPropertyName("total_value")]
    public double TotalValue { get; set; }
    
    [JsonPropertyName("card_count")]
    public int CardCount { get; set; }
    
    [JsonPropertyName("net_worth")]
    public double NetWorth { get; set; }
}