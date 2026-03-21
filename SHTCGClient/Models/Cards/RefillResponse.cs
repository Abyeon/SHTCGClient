using System.Text.Json.Serialization;

namespace SHTCGClient.Models.Cards;

public class RefillResponse
{
    [JsonPropertyName("message")] public string Message { get; set; } = null!;

    [JsonPropertyName("cost")] public double Cost { get; set; }

    [JsonPropertyName("net_worth")] public double NetWorth { get; set; }
    
    [JsonPropertyName("roll_info")] public RollInfo? RollInfo { get; set; }
}