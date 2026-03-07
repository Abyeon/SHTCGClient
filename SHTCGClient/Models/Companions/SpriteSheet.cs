using System.Text.Json.Serialization;

namespace SHTCGClient.Models.Companions;

public class SpriteSheet
{
    [JsonPropertyName("neutral_1")]
    public string? Neutral1 { get; set; }
    
    [JsonPropertyName("neutral_2")]
    public string? Neutral2 { get; set; }
    
    [JsonPropertyName("happy_1")]
    public string? Happy1 { get; set; }
    
    [JsonPropertyName("happy_2")]
    public string? Happy2 { get; set; }
    
    [JsonPropertyName("sad_1")]
    public string? Sad1 { get; set; }
    
    [JsonPropertyName("sad_2")]
    public string? Sad2 { get; set; }
    
    [JsonPropertyName("love_1")]
    public string? Love1 { get; set; }
    
    [JsonPropertyName("love_2")]
    public string? Love2 { get; set; }

    [JsonPropertyName("angry_1")]
    public string? Angry1 { get; set; }
    
    [JsonPropertyName("angry_2")]
    public string? Angry2 { get; set; }
}