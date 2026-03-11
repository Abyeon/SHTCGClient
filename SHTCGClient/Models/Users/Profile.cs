using System.Text.Json.Serialization;

namespace SHTCGClient.Models.Users;

/// <summary>
/// Additional user information, used on the profile page, leaderboard, and roll history
/// </summary>
public class Profile : IEquatable<Profile>
{
    /// <inheritdoc cref="User.Id"/>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <inheritdoc cref="User.Username"/>
    [JsonPropertyName("username")]
    public string? Username { get; init; }
    
    /// <summary>
    /// This User's display name.
    /// </summary>
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

    /// <inheritdoc />
    public bool Equals(Profile? other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;
        return Id == other.Id;
    }
    
    /// <inheritdoc />
    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        return obj.GetType() == GetType() && Equals((Profile)obj);
    }
    
    /// <inheritdoc />
    public override int GetHashCode()
    {
        return Id;
    }
}