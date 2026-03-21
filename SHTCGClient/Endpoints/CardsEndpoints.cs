using SHTCGClient.Models;
using SHTCGClient.Models.Cards;
using SHTCGClient.Models.Users;

namespace SHTCGClient.Endpoints;

/// <summary>
/// Class for interacting with the Cards endpoint
/// </summary>
public class CardsEndpoints (ClientService client)
{
    /// <summary>
    /// Get the current roll status
    /// </summary>
    /// <returns>Roll information</returns>
    public async Task<RollInfo?> Status() => await client.Request<RollInfo>(HttpMethod.Get, "cards/roll/status");
    
    /// <summary>
    /// Roll for a card
    /// </summary>
    /// <returns>Roll information</returns>
    public async Task<CardRollResponse?> Roll() => await client.Request<CardRollResponse>(HttpMethod.Post, "cards/roll");
    
    /// <summary>
    /// Refill the user's rolls
    /// </summary>
    /// <returns>Refill information and roll information</returns>
    public async Task<RefillResponse?> Refill() => await client.Request<RefillResponse>(HttpMethod.Post, "cards/roll/refill");
    
    /// <summary>
    /// Get the last x rolls
    /// </summary>
    /// <param name="count">Amount of rolls to fetch</param>
    /// <returns>Array of cards</returns>
    public async Task<Card[]?> RollHistory(int count) => await client.Request<Card[]>(HttpMethod.Get, $"cards/roll-history?count={count}");
    
    /// <summary>
    /// Get all the base versions of the cards in the game.
    /// </summary>
    /// <returns>Array of BaseCards</returns>
    public async Task<BaseCard[]?> BaseCards() => await client.Request<BaseCard[]>(HttpMethod.Get, "cards/base-cards");
    
    /// <summary>
    /// Get the User's owned cards. (This automatically de-paginates the request and gets all cards.)
    /// </summary>
    /// <returns>Array of cards</returns>
    public async Task<Card[]?> MyCards()
    {
        List<Card> cards = [];

        var page = 1;
        while (true)
        {
            var cardPage = await client.Request<PaginatedItem<Card>>(HttpMethod.Get, $"cards/my-cards?page={page}&page_size=250");
            if (cardPage == null) break;
            
            cards.AddRange(cardPage.Data);
            
            if (page == cardPage.TotalPages) break;
            page++;
        }
        
        return cards.ToArray();
    }

    /// <summary>
    /// Get a player's owned cards. (This automatically de-paginates the request and gets all cards.)
    /// </summary>
    /// <param name="id">The ID of the player to fetch</param>
    /// <returns>Array of cards</returns>
    /// <seealso cref="User.Id"/>
    /// <seealso cref="Profile.Id"/>
    public async Task<Card[]?> PlayerCards(int id)
    {
        List<Card> cards = [];
        
        var page = 1;
        while (true)
        {
            var cardPage = await client.Request<PaginatedItem<Card>>(HttpMethod.Get, $"cards/user/{id}/cards?page={page}&page_size=250");
            if (cardPage == null) break;
            
            cards.AddRange(cardPage.Data);
            
            if (page == cardPage.TotalPages) break;
            page++;
        }
        
        return cards.ToArray();
    }
}