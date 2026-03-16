using System.Text.Json.Serialization;

namespace SHTCGClient.Models.Auction;

/// <summary>
/// An auction listing
/// </summary>
public class Listing
{
    /// <summary>
    /// This ID of this listing
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// Information regarding the seller for this listing
    /// </summary>
    [JsonPropertyName("seller")]
    public Seller Seller { get; set; }
    
    /// <summary>
    /// The card being sold
    /// </summary>
    [JsonPropertyName("card")]
    public AuctionCard Card { get; set; }
    
    /// <summary>
    /// The price of this card
    /// </summary>
    [JsonPropertyName("price")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public double Price { get; set; }

    /// <summary>
    /// The status of this listing (active, inactive)
    /// </summary>
    [JsonPropertyName("status")]
    public string Status { get; set; } = null!;

    /// <summary>
    /// The date this listing was created
    /// </summary>
    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }
    
    /// <summary>
    /// When this listing expires
    /// </summary>
    [JsonPropertyName("expires_at")]
    public DateTime? ExpiresAt { get; set; }
}