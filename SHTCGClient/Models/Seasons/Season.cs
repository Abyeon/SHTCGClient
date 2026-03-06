using System.Text.Json.Serialization;
using SHTCGClient.Models.Cards;

namespace SHTCGClient.Models.Seasons;

public class Season
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;
    
    [JsonPropertyName("description")]
    public string Description { get; set; } = null!;
    
    [JsonPropertyName("start_date")]
    public DateTime StartDate { get; set; }
    
    [JsonPropertyName("end_date")]
    public DateTime EndDate { get; set; }
    
    [JsonPropertyName("hours_till_end")]
    public double HoursTillEnd { get; set; }
    
    [JsonPropertyName("is_active")]
    public bool IsActive { get; set; }

    [JsonPropertyName("cards")]
    public Card[] Cards { get; set; } = null!;
}