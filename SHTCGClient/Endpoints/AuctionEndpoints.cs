using SHTCGClient.Models.Auction;

namespace SHTCGClient.Endpoints;

/// <summary>
/// Class for interacting with the Auction API
/// </summary>
public class AuctionEndpoints (ClientService client)
{
    /// <summary>
    /// Get the Auction listings
    /// </summary>
    /// <param name="status">Active/Inactive</param>
    /// <param name="sortBy">"-created_at", etc</param>
    /// <returns>Array of auction listing</returns>
    public async Task<Listing[]?> Listings(string status, string sortBy) => await client.Request<Listing[]>(HttpMethod.Get, $"auction/listings?status={status}&sort={sortBy}");
    
    /// <summary>
    /// Get user's current cart
    /// </summary>
    /// <returns>The user's cart</returns>
    public async Task<Cart?> Cart() => await client.Request<Cart>(HttpMethod.Get, "auction/cart");
    
    /// <summary>
    /// Checkout the items currently in the user's cart
    /// </summary>
    /// <returns></returns>
    public async Task<Checkout?> Checkout() => await client.Request<Checkout>(HttpMethod.Post, "auction/checkout");
}