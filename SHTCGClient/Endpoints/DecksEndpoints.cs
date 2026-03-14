using SHTCGClient.Models.Cards;
using SHTCGClient.Models.Seasons;

namespace SHTCGClient.Endpoints;

/// <summary>
/// Class for interacting with the seasons/decks endpoint.
/// </summary>
/// <param name="client"></param>
public class DecksEndpoints (ClientService client)
{
    /// <summary>
    /// Get the user's decks
    /// </summary>
    /// <returns>Array of decks</returns>
    public async Task<Deck[]?> GetDecks() => await client.Request<Deck[]>(HttpMethod.Get, "seasons/decks");
    
    /// <summary>
    /// Get the cards for a deck by id
    /// </summary>
    /// <param name="deckId">The deck ID</param>
    /// <returns>Array of cards</returns>
    public async Task<Card[]?> GetCards(int deckId) => await client.Request<Card[]>(HttpMethod.Get, $"seasons/decks/{deckId}/cards");
    
    /// <summary>
    /// Delete a card in a deck
    /// </summary>
    /// <param name="deckId">The deck ID</param>
    /// <param name="id">The card ID</param>
    public async Task DeleteCard(int deckId, int id) => await client.Request(HttpMethod.Delete, $"seasons/decks/{deckId}/cards/{id}");
    
    /// <summary>
    /// Add a card to a deck
    /// </summary>
    /// <param name="deckId">The deck ID</param>
    /// <param name="id">The card ID</param>
    public async Task AddCard(int deckId, int id)
    {
        var cardData = new
        {
            card_id = id
        };
        
        await client.Request(HttpMethod.Post,  $"seasons/decks/{deckId}/cards", cardData);
    }
    
    /// <summary>
    /// Get the deck leaderboard for the current season
    /// </summary>
    /// <returns>Array of decks</returns>
    public async Task<Deck[]?> Leaderboard() => await client.Request<Deck[]>(HttpMethod.Get, "seasons/decks/leaderboard");
    
    /// <summary>
    /// Get the cards for a deck on the season leaderboard.
    /// </summary>
    /// <param name="id">The Deck ID</param>
    /// <returns>Array of cards</returns>
    public async Task<Card[]?> GetLeaderboardDeckCards(int id) => await client.Request<Card[]>(HttpMethod.Get, $"seasons/decks/leaderboard/{id}/cards");
}