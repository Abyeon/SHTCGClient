using System.Text.Json.Serialization;

namespace SHTCGClient.Models.Vendors;

public class Vendor : IEquatable<Vendor>
{
    [JsonPropertyName("id")]
    public int Id { get; init; }

    [JsonPropertyName("slug")]
    public string Slug { get; init; } = null!;

    [JsonPropertyName("name")]
    public string Name { get; init; } = null!;

    [JsonPropertyName("title")]
    public string Title { get; init; } = null!;

    [JsonPropertyName("avatar")]
    public string Avatar { get; init; } = null!;
    
    [JsonPropertyName("avatar_small")]
    public string? AvatarSmall { get; init; }

    [JsonPropertyName("background")]
    public string Background { get; init; } = null!;

    [JsonPropertyName("description")]
    public string Description { get; init; } = null!;

    [JsonPropertyName("url")]
    public string Url { get; init; } = null!;
    
    [JsonPropertyName("locked")]
    public bool IsLocked { get; init; }

    public bool Equals(Vendor? other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;
        return Id == other.Id;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != GetType()) return false;
        return Equals((Vendor)obj);
    }

    public override int GetHashCode()
    {
        return Id;
    }
}