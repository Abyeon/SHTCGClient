using SHTCGClient.Models.Features;

namespace SHTCGClient.Endpoints;

/// <summary>
/// Class for interacting with the features endpoint
/// </summary>
/// <param name="client"></param>
public class FeaturesEndpoints (ClientService client)
{
    /// <summary>
    /// Get the current features available for voting.
    /// Check if the user is able to vote with <see cref="VoteStatus"/> before attempting to vote.
    /// </summary>
    /// <returns>Array of features</returns>
    public async Task<Feature[]?> Features() => await client.Request<Feature[]>(HttpMethod.Get, "features");
    
    /// <summary>
    /// Gets the users voting eligibility and the next time they may vote.
    /// </summary>
    /// <returns>User's VoteStatus</returns>
    public async Task<VoteStatus?> VoteStatus() => await client.Request<VoteStatus>(HttpMethod.Get, "features/vote-status");
}