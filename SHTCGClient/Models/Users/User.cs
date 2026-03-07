using System.Text.Json.Serialization;

namespace SHTCGClient.Models.Users;

public class User
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("username")]
    public string Username { get; set; } = null!;
    
    [JsonPropertyName("email")]
    public string? Email { get; set; }
    
    [JsonPropertyName("is_active")]
    public bool IsActive { get; set; }
    
    [JsonPropertyName("date_joined")]
    public DateTime DateJoined { get; set; }
    
    [JsonPropertyName("net_worth")]
    public double NetWorth { get; set; }
}