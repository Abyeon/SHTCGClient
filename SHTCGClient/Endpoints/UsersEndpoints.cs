using SHTCGClient.Models.Users;
using SHTCGClient.Models.Users.Leaderboards;

namespace SHTCGClient.Endpoints;

/// <summary>
/// Class for interacting with the users endpoint
/// </summary>
public class UsersEndpoints (ClientService client)
{
    /// <summary>
    /// Get your friends
    /// </summary>
    /// <returns>Array of users</returns>
    public async Task<User[]?> Friends() => await client.Request<User[]>(HttpMethod.Get, "users/me/friends");
    
    /// <summary>
    /// Search for a user by name
    /// </summary>
    /// <param name="name">The username to search for</param>
    /// <returns>Array of users</returns>
    public async Task<User[]?> UserByName(string name) => await client.Request<User[]>(HttpMethod.Get, $"users/users?search={name}");
    
    /// <summary>
    /// Fetch the leaderboard
    /// </summary>
    /// <param name="type">The value to sort by</param>
    /// <param name="limit">The max entries to fetch</param>
    /// <returns>The leaderboard sorted by input type</returns>
    public async Task<Leaderboard?> Leaderboard(string type, int limit) => await client.Request<Leaderboard>(HttpMethod.Get, $"users/leaderboards?type={type}&limit={limit}");
}