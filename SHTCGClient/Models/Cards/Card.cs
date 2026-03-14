using System.Text.Json;
using System.Text.Json.Serialization;
using SHTCGClient.Models.Users;
using SHTCGClient.Models.Vendors;

namespace SHTCGClient.Models.Cards;

/// <summary>
/// A Trading Card
/// </summary>
public class Card : IEquatable<Card>, IJsonOnDeserialized
{
    [JsonPropertyName("id")]
    public int Id { get; init; }
    
    [JsonPropertyName("base_card_id")]
    public int BaseCardId { get; init; }
    
    [JsonPropertyName("name")]
    public string Name { get; init; } = null!;

    [JsonPropertyName("image_url")]
    public string ImageUrl { get; init; } = null!;

    [JsonPropertyName("description")]
    public string? Description { get; init; }

    [JsonPropertyName("rarity")]
    public string Rarity { get; init; } = null!;
    
    [JsonPropertyName("release_date")]
    public string ReleaseDate { get; init; } = null!;
    
    [JsonPropertyName("card_set_id")]
    public int? CardSetId { get; init; }
    
    [JsonPropertyName("trim")]
    public string Trim { get; init; } = null!;
    
    [JsonPropertyName("foil")]
    public string Foil { get; init; } = null!;
    
    [JsonPropertyName("stack")]
    public int Stack { get; init; }
    
    [JsonPropertyName("drop_chance")]
    public double DropChance { get; init; }
    
    [JsonPropertyName("estimated_value")]
    public double EstimatedValue { get; init; }
    
    [JsonPropertyName("collection_id")]
    public int? CollectionId { get; init; }

    [JsonPropertyName("lock")]
    public bool IsLocked { get; init; } = false;
    
    [JsonPropertyName("grade")]
    public double? Grade { get; init; }
    
    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; init; }
    
    [JsonPropertyName("updated_at")]
    public DateTime? UpdatedAt { get; init; }
    
    [JsonPropertyName("is_request_user")]
    public bool? IsRequestUser { get; init; }
    
    [JsonIgnore]
    public Profile? Owner { get; private set; }
    
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? ExtensionData { get; init; }

    /// <summary>
    /// Sell this card
    /// </summary>
    /// <param name="client">Your client</param>
    /// <returns>Information regarding your sale.</returns>
    public async Task<CardSellResponse?> Sell(ClientService client) => await client.Vendors.SellCard(Id, 1);

    public bool Equals(Card? other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;
        return Id == other.Id;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != GetType()) return false;
        return Equals((Card)obj);
    }

    public override int GetHashCode()
    {
        return Id;
    }

    // Reconstruct Profile class due to api providing "owner_" attributes on rolled cards
    public void OnDeserialized()
    {
        if (ExtensionData is null || !ExtensionData.TryGetValue("owner_id", out var ownerIdElement) ||
            ownerIdElement.ValueKind != JsonValueKind.Number)
        {
            return;
        }

        Owner = new Profile
        {
            Id = ownerIdElement.GetInt32(),
            Username = GetStringValue("owner_username"),
            DisplayName = GetStringValue("owner_display_name"),
            Avatar = GetStringValue("owner_avatar"),
            BannerColor = GetStringValue("owner_banner_color"),
            ProfileColor = GetStringValue("owner_profile_color"),
            Bio = GetStringValue("owner_bio"),
            EquippedTitle = GetStringValue("owner_equipped_title_name")
            // honestly just ignoring banner stuff
        };
    }
    
    private string? GetStringValue(string key)
    {
        if (ExtensionData != null && 
            ExtensionData.TryGetValue(key, out var element) && 
            element.ValueKind == JsonValueKind.String)
        {
            return element.GetString();
        }
        return null;
    }
}