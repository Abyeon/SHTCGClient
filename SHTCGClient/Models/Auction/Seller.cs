using System.Text.Json.Serialization;
using SHTCGClient.Models.Users;

namespace SHTCGClient.Models.Auction;

/// <summary>
/// Seller of an auction item
/// </summary>
public class Seller
{
    /// <summary>
    /// This seller's <see cref="User.Id"/>
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// This seller's Username
    /// </summary>
    [JsonPropertyName("username")]
    public string Username { get; set; } = null!;
}