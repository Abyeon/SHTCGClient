using System.Text.Json.Serialization;
using SHTCGClient.Models.Cards;
using SHTCGClient.Models.Users;

namespace SHTCGClient.Models.Seasons;

/// <summary>
/// Object containing cards for a season.
/// </summary>
public class Deck : IEquatable<Deck>
{
    [JsonPropertyName("id")]
    public int Id { get; init; }
    
    [JsonPropertyName("name")]
    public string Name { get; init; } = null!;
    
    [JsonPropertyName("description")]
    public string Description { get; init; } = null!;
    
    [JsonPropertyName("owner_id")]
    public int OwnerId { get; init; }
    
    [JsonPropertyName("season_id")]
    public int SeasonId { get; init; }
    
    [JsonPropertyName("score")]
    public double Score { get; init; }

    [JsonPropertyName("score_rating")]
    public string ScoreRating { get; init; } = null!;

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; init; }
    
    [JsonPropertyName("updated_at")]
    public DateTime UpdatedAt { get; init; }
    
    [JsonPropertyName("card_count")]
    public int CardCount { get; init; }
    
    [JsonPropertyName("owner")]
    public Profile? Owner { get; init; }

    /// <summary>
    /// Removes a card from the deck
    /// </summary>
    /// <param name="client">Your client</param>
    /// <param name="cardId">ID of the card to remove</param>
    public async Task Remove(ClientService client, int cardId)
    {
        await client.Seasons.Decks.DeleteCard(Id, cardId);
    }
    
    /// <summary>
    /// Removes a card from the deck
    /// </summary>
    /// <param name="client">Your client</param>
    /// <param name="card">Card to remove</param>
    public async Task Remove(ClientService client, Card card) => await Remove(client, card.Id);

    /// <summary>
    /// Adds a card to the deck
    /// </summary>
    /// <param name="client">Your client</param>
    /// <param name="cardId">ID of the card to add</param>
    public async Task Add(ClientService client, int cardId)
    {
        await client.Seasons.Decks.AddCard(Id, cardId);
    }
    
    /// <summary>
    /// Adds a card to the deck
    /// </summary>
    /// <param name="client">Your client</param>
    /// <param name="card">Card to add</param>
    public async Task Add(ClientService client, Card card) => await Add(client, card.Id);

    public bool Equals(Deck? other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;
        return Id == other.Id;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        return obj.GetType() == GetType() && Equals((Deck)obj);
    }

    public override int GetHashCode()
    {
        return Id;
    }
}