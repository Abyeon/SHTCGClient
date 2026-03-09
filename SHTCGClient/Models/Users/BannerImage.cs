using System.Text.Json.Serialization;

namespace SHTCGClient.Models.Users;

/// <summary>
/// Banner information for a profile. This is what appears above player's names in their profile page.
/// </summary>
public class BannerImage
{
    [JsonPropertyName("id")]
    public int Id { get; init; }

    [JsonPropertyName("name")]
    public string Name { get; init; } = null!;

    [JsonPropertyName("code")]
    public string Code { get; init; } = null!;
    
    [JsonPropertyName("image_url")]
    public string ImageUrl { get; init; } = null!;
    
    [JsonPropertyName("focus")]
    public int Focus { get; init; }
}