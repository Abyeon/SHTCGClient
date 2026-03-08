using System.Text.Json.Serialization;
using SHTCGClient.Models.Cards;

namespace SHTCGClient.Models.Seasons;

public class Season : IEquatable<Season>
{
    [JsonPropertyName("id")]
    public int Id { get; init; }
    
    [JsonPropertyName("name")]
    public string Name { get; init; } = null!;
    
    [JsonPropertyName("description")]
    public string Description { get; init; } = null!;
    
    [JsonPropertyName("start_date")]
    public DateTime StartDate { get; init; }
    
    [JsonPropertyName("end_date")]
    public DateTime EndDate { get; init; }
    
    [JsonPropertyName("hours_till_end")]
    public double HoursTillEnd { get; init; }
    
    [JsonPropertyName("is_active")]
    public bool IsActive { get; init; }

    [JsonPropertyName("cards")]
    public Card[] Cards { get; init; } = null!;

    public bool Equals(Season? other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;
        return Id == other.Id;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        return obj.GetType() == GetType() && Equals((Season)obj);
    }

    public override int GetHashCode()
    {
        return Id;
    }
}