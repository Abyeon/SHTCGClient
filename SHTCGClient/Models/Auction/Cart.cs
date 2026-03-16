using System.Text.Json.Serialization;

namespace SHTCGClient.Models.Auction;

/// <summary>
/// The user's auction cart
/// </summary>
public class Cart
{
    /// <summary>
    /// Array of items to be purchased
    /// </summary>
    [JsonPropertyName("items")]
    public CartItem[] Items { get; set; }

    /// <summary>
    /// The total of this purchase
    /// </summary>
    [JsonPropertyName("total")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public double Total { get; set; }
}