using System.Text.Json.Serialization;

namespace SHTCGClient.Models.Vendors;

/// <summary>
/// Response for grading a card
/// </summary>
public class GradeResponse
{
    [JsonPropertyName("card_id")] public int CardId { get; set; }
    
    [JsonPropertyName("grade")] public int Grade { get; set; }

    [JsonPropertyName("estimated_value")] public double EstimatedValue { get; set; }

    [JsonPropertyName("message")] public string Message { get; set; } = null!;
}