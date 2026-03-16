using System.Text.Json.Serialization;

namespace SHTCGClient.Models.Auction;

/// <summary>
/// The response for purchasing items at the auction house
/// </summary>
public class Checkout
{
    /// <summary>
    /// Array of listing Ids purchased
    /// </summary>
    [JsonPropertyName("purchased")]
    public int[]? Purchased { get; set; }
    
    /// <summary>
    /// Array of listing Ids that failed to be purchased
    /// </summary>
    [JsonPropertyName("failed")]
    public int[]? Failed { get; set; }

    /// <summary>
    /// The total money spent on this purchase
    /// </summary>
    [JsonPropertyName("total_spent")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public double? TotalSpent { get; set; }

    /// <summary>
    /// The response message
    /// </summary>
    [JsonPropertyName("message")]
    public string Message { get; set; } = null!;
}