using System.Text.Json.Serialization;
using SHTCGClient.Models.Cards;

namespace SHTCGClient.Models.Trades;

public class Trade
{
    [JsonPropertyName("id")] public int Id { get; set; }

    [JsonPropertyName("initiator")] public TradeParticipant Initiator { get; set; }

    [JsonPropertyName("receiver")] public TradeParticipant Receiver { get; set; }
    
    [JsonPropertyName("initiator_cards")] public Card[] InitiatorCards { get; set; }
    
    [JsonPropertyName("receiver_cards")] public Card[] ReceiverCards { get; set; }

    [JsonPropertyName("initiator_money")] public double InitiatorMoney { get; set; }

    [JsonPropertyName("receiver_money")] public double ReceiverMoney { get; set; }

    [JsonPropertyName("status")] public string Status { get; set; } = null!;

    [JsonPropertyName("message")] public string Message { get; set; } = null!;

    [JsonPropertyName("created_at")] public DateTime? CreatedAt { get; set; }

    [JsonPropertyName("updated_at")] public DateTime? UpdatedAt { get; set; }
    
    [JsonPropertyName("resolved_at")] public DateTime? ResolvedAt { get; set; }
}