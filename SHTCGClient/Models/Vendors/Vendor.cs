using System.Text.Json.Serialization;

namespace SHTCGClient.Models.Vendors;

public class Vendor
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("slug")]
    public string Slug { get; set; } = null!;

    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    [JsonPropertyName("title")]
    public string Title { get; set; } = null!;

    [JsonPropertyName("avatar")]
    public string Avatar { get; set; } = null!;
    
    [JsonPropertyName("avatar_small")]
    public string? AvatarSmall { get; set; }

    [JsonPropertyName("background")]
    public string Background { get; set; } = null!;

    [JsonPropertyName("description")]
    public string Description { get; set; } = null!;

    [JsonPropertyName("url")]
    public string Url { get; set; } = null!;
    
    [JsonPropertyName("locked")]
    public bool IsLocked { get; set; }
}