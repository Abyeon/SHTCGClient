using System.Text.Json.Serialization;

namespace SHTCGClient.Models.Companions;

public class Companion
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    [JsonPropertyName("title")]
    public string Title { get; set; } = null!;

    [JsonPropertyName("sprite_sheet")]
    public SpriteSheet SpriteSheet { get; set; } = null!;
    
    [JsonPropertyName("luck_modifier")]
    public double LuckModifier { get; set; }
    
    [JsonPropertyName("roll_refresh_modifier")]
    public double RollRefreshModifier { get; set; }
    
    [JsonPropertyName("max_rolls_modifier")]
    public double MaxRollsModifier { get; set; }
    
    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }
    
    [JsonPropertyName("updated_at")]
    public DateTime? UpdatedAt { get; set; }
}