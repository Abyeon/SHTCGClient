using System.Text.Json.Serialization;

namespace SHTCGClient.Models.Cards;

public class Card : IEquatable<Card>
{
    [JsonPropertyName("id")]
    public int Id { get; init; }
    
    [JsonPropertyName("base_card_id")]
    public int BaseCardId { get; init; }
    
    [JsonPropertyName("name")]
    public string Name { get; init; } = null!;

    [JsonPropertyName("image_url")]
    public string ImageUrl { get; init; } = null!;

    [JsonPropertyName("description")]
    public string Description { get; init; } = null!;

    [JsonPropertyName("rarity")]
    public string Rarity { get; init; } = null!;
    
    [JsonPropertyName("release_date")]
    public string ReleaseDate { get; init; } = null!;
    
    [JsonPropertyName("card_set_id")]
    public int? CardSetId { get; init; }
    
    [JsonPropertyName("trim")]
    public string Trim { get; init; } = null!;
    
    [JsonPropertyName("foil")]
    public string Foil { get; init; } = null!;
    
    [JsonPropertyName("stack")]
    public int Stack { get; init; }
    
    [JsonPropertyName("drop_chance")]
    public double DropChance { get; init; }
    
    [JsonPropertyName("estimated_value")]
    public double EstimatedValue { get; init; }
    
    [JsonPropertyName("collection_id")]
    public int? CollectionId { get; init; }
    
    [JsonPropertyName("lock")]
    public bool IsLocked { get; init; }
    
    [JsonPropertyName("grade")]
    public double? Grade { get; init; }
    
    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; init; }
    
    [JsonPropertyName("updated_at")]
    public DateTime UpdatedAt { get; init; }

    public bool Equals(Card? other)
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
        return Equals((Card)obj);
    }

    public override int GetHashCode()
    {
        return Id;
    }
}