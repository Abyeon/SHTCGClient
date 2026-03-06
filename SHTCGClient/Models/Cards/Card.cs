using System.Text.Json.Serialization;

namespace SHTCGClient.Models.Cards;

public class Card
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    [JsonPropertyName("base_card_id")]
    public int BaseCardId { get; set; }
    
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    [JsonPropertyName("image_url")]
    public string ImageUrl { get; set; } = null!;

    [JsonPropertyName("description")]
    public string Description { get; set; } = null!;

    [JsonPropertyName("rarity")]
    public string Rarity { get; set; } = null!;
    
    [JsonPropertyName("release_date")]
    public string ReleaseDate { get; set; } = null!;
    
    [JsonPropertyName("card_set_id")]
    public int? CardSetId { get; set; }
    
    [JsonPropertyName("trim")]
    public string Trim { get; set; } = null!;
    
    [JsonPropertyName("foil")]
    public string Foil { get; set; } = null!;
    
    [JsonPropertyName("stack")]
    public int Stack { get; set; }
    
    [JsonPropertyName("drop_chance")]
    public double DropChance { get; set; }
    
    [JsonPropertyName("estimated_value")]
    public double EstimatedValue { get; set; }
    
    [JsonPropertyName("collection_id")]
    public int? CollectionId { get; set; }
    
    [JsonPropertyName("lock")]
    public bool IsLocked { get; set; }
    
    [JsonPropertyName("grade")]
    public double? Grade { get; set; }
    
    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }
    
    [JsonPropertyName("updated_at")]
    public DateTime UpdatedAt { get; set; }
}