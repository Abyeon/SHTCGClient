using System.Text.Json.Serialization;

namespace SHTCGClient.Models.Users;

public class Profile : IEquatable<Profile>
{
    [JsonPropertyName("id")]
    public int Id { get; init; }

    [JsonPropertyName("username")]
    public string? Username { get; init; }
    
    [JsonPropertyName("display_name")]
    public string? DisplayName { get; init; }
    
    [JsonPropertyName("avatar")]
    public string? Avatar { get; init; }
    
    [JsonPropertyName("banner_color")]
    public string? BannerColor { get; init; }
    
    [JsonPropertyName("profile_color")]
    public string? ProfileColor { get; init; }
    
    [JsonPropertyName("is_anon")]
    public bool? IsAnonymous { get; init; }
    
    [JsonPropertyName("bio")]
    public string? Bio { get; init; }
    
    [JsonPropertyName("equipped_title")]
    public string? EquippedTitle { get; init; }
    
    [JsonPropertyName("equipped_banner_image")]
    public BannerImage? EquippedBannerImage { get; init; }

    public bool Equals(Profile? other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;
        return Id == other.Id;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        return obj.GetType() == GetType() && Equals((Profile)obj);
    }

    public override int GetHashCode()
    {
        return Id;
    }
}