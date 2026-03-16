using System.Text.Json.Serialization;

namespace SHTCGClient.Models.Auction;

/// <summary>
/// Object representing an item to be purchased
/// </summary>
public class CartItem
{
    /// <summary>
    /// This ID of this cart item
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    /// <summary>
    /// The listing to be purchased
    /// </summary>
    [JsonPropertyName("listing")]
    public Listing Listing { get; set; }
    
    /// <summary>
    /// The date this item was added to the cart
    /// </summary>
    [JsonPropertyName("added_at")]
    public DateTime AddedAt { get; set; }
}