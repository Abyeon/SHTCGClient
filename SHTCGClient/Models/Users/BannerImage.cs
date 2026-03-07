using System.Text.Json.Serialization;

namespace SHTCGClient.Models.Users;

public class BannerImage
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    [JsonPropertyName("code")]
    public string Code { get; set; } = null!;
    
    [JsonPropertyName("image_url")]
    public string ImageUrl { get; set; } = null!;
    
    [JsonPropertyName("focus")]
    public int Focus { get; set; }
}