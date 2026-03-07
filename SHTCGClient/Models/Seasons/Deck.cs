using System.Text.Json.Serialization;
using SHTCGClient.Models.Users;

namespace SHTCGClient.Models.Seasons;

public class Deck
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;
    
    [JsonPropertyName("description")]
    public string Description { get; set; } = null!;
    
    [JsonPropertyName("owner_id")]
    public int OwnerId { get; set; }
    
    [JsonPropertyName("season_id")]
    public int SeasonId { get; set; }
    
    [JsonPropertyName("score")]
    public double Score { get; set; }

    [JsonPropertyName("score_rating")]
    public string ScoreRating { get; set; } = null!;

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }
    
    [JsonPropertyName("updated_at")]
    public DateTime UpdatedAt { get; set; }
    
    [JsonPropertyName("card_count")]
    public int CardCount { get; set; }
    
    [JsonPropertyName("owner")]
    public Profile? Owner { get; set; }
}