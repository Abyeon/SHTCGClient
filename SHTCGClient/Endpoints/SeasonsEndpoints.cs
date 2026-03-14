using SHTCGClient.Models.Cards;
using SHTCGClient.Models.Seasons;

namespace SHTCGClient.Endpoints;

/// <summary>
/// Class for interacting with the seasons endpoint
/// </summary>
public class SeasonsEndpoints (ClientService client)
{
    /// <summary>
    /// The seasons/decks endpoint
    /// </summary>
    public readonly DecksEndpoints Decks = new(client);
    
    /// <summary>
    /// Get season by id
    /// </summary>
    /// <param name="id">The season's id</param>
    /// <returns>Season</returns>
    public async Task<Season?> ById(int id) => await client.Request<Season>(HttpMethod.Get, $"seasons/{id}");
    
    /// <summary>
    /// Get the currently active season
    /// </summary>
    /// <returns>The active season</returns>
    public async Task<Season?> Current() => await client.Request<Season>(HttpMethod.Get, "seasons/active/current");
}