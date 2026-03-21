using SHTCGClient.Models.Vendors;

namespace SHTCGClient.Endpoints;

/// <summary>
/// Class for interacting with the vendors endpoint.
/// </summary>
public class VendorsEndpoints (ClientService client)
{
    /// <summary>
    /// Sell a card
    /// </summary>
    /// <param name="cardId">The card ID</param>
    /// <param name="vendorId">The vendor ID to sell to</param>
    /// <returns>Sale information</returns>
    public async Task<CardSellResponse?> SellCard(int cardId, int vendorId) => await SellCards([cardId], vendorId);
    
    /// <summary>
    /// Sell cards
    /// </summary>
    /// <param name="cardIds">The card IDs</param>
    /// <param name="vendorId">The vendor ID to sell to</param>
    /// <returns>Sale information</returns>
    public async Task<CardSellResponse?> SellCards(int[] cardIds, int vendorId)
    {
        var data = new
        {
            cards_to_sell_ids = cardIds,
            vendor_id = vendorId
        };
        
        return await client.Request<CardSellResponse>(HttpMethod.Post, "vendors/sell", data);
    }
    
    /// <summary>
    /// Get the current vendors
    /// </summary>
    /// <returns>Array of vendors</returns>
    public async Task<Vendor[]?> GetVendors() => await client.Request<Vendor[]>(HttpMethod.Get, "vendors/list");
    
    public async Task<GradeResponse?> Grade(int id) => await client.Request<GradeResponse>(HttpMethod.Post, "vendors/card-grader/jadd/grade", new { card_id = id });
}