using System.Text.Json.Serialization;

namespace SHTCGClient.Models.Users;

public class Profile
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("username")]
    public string? Username { get; set; }
    
    [JsonPropertyName("display_name")]
    public string? DisplayName { get; set; }
    
    [JsonPropertyName("avatar")]
    public string? Avatar { get; set; }
    
    [JsonPropertyName("banner_color")]
    public string? BannerColor { get; set; }
    
    [JsonPropertyName("profile_color")]
    public string? ProfileColor { get; set; }
    
    [JsonPropertyName("is_anon")]
    public bool? IsAnonymous { get; set; }
    
    [JsonPropertyName("bio")]
    public string? Bio { get; set; }
    
    [JsonPropertyName("equipped_title")]
    public string? EquippedTitle { get; set; }
    
    [JsonPropertyName("equipped_banner_image")]
    public BannerImage? EquippedBannerImage { get; set; }
}