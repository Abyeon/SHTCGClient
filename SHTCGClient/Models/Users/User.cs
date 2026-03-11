using System.Text.Json.Serialization;

namespace SHTCGClient.Models.Users;

/// <summary>
/// User information.
/// </summary>
public class User : IEquatable<User>
{
    /// <summary>
    /// This User's ID
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// This User's name.
    /// </summary>
    [JsonPropertyName("username")]
    public string Username { get; init; } = null!;
    
    /// <summary>
    /// This user's email, if available.
    /// </summary>
    [JsonPropertyName("email")]
    public string? Email { get; init; }
    
    /// <summary>
    /// If this player is currently active
    /// </summary>
    [JsonPropertyName("is_active")]
    public bool IsActive { get; init; }
    
    /// <summary>
    /// The date this user joined the game.
    /// </summary>
    [JsonPropertyName("date_joined")]
    public DateTime DateJoined { get; init; }
    
    /// <summary>
    /// This user's current balance.
    /// </summary>
    [JsonPropertyName("net_worth")]
    public double? NetWorth { get; init; }

    /// <inheritdoc />
    public bool Equals(User? other)
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
        return obj.GetType() == GetType() && Equals((User)obj);
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        return Id;
    }
}