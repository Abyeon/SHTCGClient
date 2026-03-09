using System.Text.Json.Serialization;

namespace SHTCGClient.Models.Users;

/// <summary>
/// User information.
/// </summary>
public class User : IEquatable<User>
{
    [JsonPropertyName("id")]
    public int Id { get; init; }

    [JsonPropertyName("username")]
    public string Username { get; init; } = null!;
    
    [JsonPropertyName("email")]
    public string? Email { get; init; }
    
    [JsonPropertyName("is_active")]
    public bool IsActive { get; init; }
    
    [JsonPropertyName("date_joined")]
    public DateTime DateJoined { get; init; }
    
    [JsonPropertyName("net_worth")]
    public double? NetWorth { get; init; }

    public bool Equals(User? other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;
        return Id == other.Id;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        return obj.GetType() == GetType() && Equals((User)obj);
    }

    public override int GetHashCode()
    {
        return Id;
    }
}