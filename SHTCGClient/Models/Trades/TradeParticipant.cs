using System.Text.Json.Serialization;

namespace SHTCGClient.Models.Trades;

public class TradeParticipant
{
    [JsonPropertyName("id")] public int Id { get; set; }

    [JsonPropertyName("username")] public string Username { get; set; } = null!;
}