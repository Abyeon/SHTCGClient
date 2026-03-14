using System.Text.Json.Serialization;
using SHTCGClient.Models.Cards;

namespace SHTCGClient.Models.Companions;

/// <summary>
/// A pet that will provide bonuses and detriments to a user's rolls.
/// </summary>
public class Companion : IEquatable<Companion>
{
    [JsonPropertyName("id")]
    public int Id { get; init; }

    [JsonPropertyName("name")]
    public string Name { get; init; } = null!;

    [JsonPropertyName("title")]
    public string Title { get; init; } = null!;

    [JsonPropertyName("sprite_sheet")]
    public SpriteSheet SpriteSheet { get; init; } = null!;
    
    [JsonPropertyName("luck_modifier")]
    public double LuckModifier { get; init; }
    
    [JsonPropertyName("roll_refresh_modifier")]
    public double RollRefreshModifier { get; init; }
    
    [JsonPropertyName("max_rolls_modifier")]
    public double MaxRollsModifier { get; init; }
    
    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; init; }
    
    [JsonPropertyName("updated_at")]
    public DateTime? UpdatedAt { get; init; }

    /// <summary>
    /// Equips this companion
    /// </summary>
    /// <param name="client">Your client</param>
    /// <returns>The equipped companion (this).</returns>
    public async Task<Companion?> Equip(ClientService client) => await client.Companions.EquipCompanion(Id);

    public bool Equals(Companion? other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;
        return Id == other.Id;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        return obj.GetType() == GetType() && Equals((Companion)obj);
    }

    public override int GetHashCode()
    {
        return Id;
    }
}