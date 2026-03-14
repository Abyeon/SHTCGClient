namespace SHTCGClient.Endpoints;

/// <summary>
/// Class for interacting with the auth endpoint
/// </summary>
public class AuthEndpoints (ClientService client)
{
    /// <summary>
    /// Log in to the game
    /// </summary>
    /// <param name="username">Your username</param>
    /// <param name="password">Your password</param>
    /// <returns>Success</returns>
    public async Task<bool> Login(string username, string password) => await Login(new Credentials {Username = username, Password = password});
    
    /// <summary>
    /// Log in to the game
    /// </summary>
    /// <param name="credentials">Login credentials</param>
    /// <returns>Success</returns>
    public async Task<bool> Login(Credentials credentials)
    {
        var loginData = new 
        {
            username = credentials.Username, 
            password = credentials.Password 
        };
        
        bool success = await client.Request(HttpMethod.Post, "users/auth/login", loginData);

        client.LoggedIn = success;
        
        return success;
    }

    /// <summary>
    /// Log out of the game.
    /// </summary>
    /// <returns>Success</returns>
    internal async Task<bool> Logout() => await client.Request(HttpMethod.Post, "users/auth/logout");
}