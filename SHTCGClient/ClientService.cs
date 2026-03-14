using System.Net;
using System.Text;
using System.Text.Json;
using SHTCGClient.Endpoints;
using SHTCGClient.Models;
using SHTCGClient.Models.Cards;
using SHTCGClient.Models.Companions;
using SHTCGClient.Models.Exchange;
using SHTCGClient.Models.Features;
using SHTCGClient.Models.Seasons;
using SHTCGClient.Models.Users;
using SHTCGClient.Models.Users.Leaderboards;
using SHTCGClient.Models.Vendors;

namespace SHTCGClient;

/// <summary>
/// An object for storing user login credentials.
/// </summary>
public struct Credentials
{
    /// <summary>
    /// Your username
    /// </summary>
    public string Username { get; set; }
    
    /// <summary>
    /// Your password
    /// </summary>
    public string Password { get; set; }
}

/// <summary>
/// The main service for interacting with the Something Happened TCG API.
/// </summary>
public class ClientService : IAsyncDisposable
{
    public readonly CookieContainer CookieContainer;
    public readonly HttpClientHandler Handler;
    public readonly HttpClient Client;
    
    public readonly ThrottledProcessor Processor;

    /// <summary>
    /// Login, logout, etc
    /// </summary>
    public readonly AuthEndpoints Auth;
    
    /// <summary>
    /// Roll, roll status, user's cards, etc
    /// </summary>
    public readonly CardsEndpoints Cards;
    
    /// <summary>
    /// Equip, unequip companions, etc.
    /// </summary>
    public readonly CompanionsEndpoints Companions;
    
    /// <summary>
    /// Buy, sell, view stocks, etc.
    /// </summary>
    public readonly ExchangeEndpoints Exchange;
    
    /// <summary>
    /// Feature voting
    /// </summary>
    public readonly FeaturesEndpoints Features;
    
    /// <summary>
    /// Season information, deck management, etc.
    /// </summary>
    public readonly SeasonsEndpoints Seasons;
    
    /// <summary>
    /// Socials, net worth leaderboard, etc.
    /// </summary>
    public readonly UsersEndpoints Users;
    
    /// <summary>
    /// Buy and sell cards/companions.
    /// </summary>
    public readonly VendorsEndpoints Vendors;

    /// <summary>
    /// If the client is logged in or not
    /// </summary>
    public bool LoggedIn;
    
    private const string ApiUrl = "https://api.tcg.robswc.me/api/";
    
    public ClientService(ThrottledProcessor processor)
    {
        Processor = processor;
        
        CookieContainer = new CookieContainer();
        
        Handler = new HttpClientHandler
        {
            CookieContainer = CookieContainer,
            AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate | DecompressionMethods.Brotli
        };
        
        Client = new HttpClient(Handler);
        Client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:148.0) Gecko/20100101 Firefox/148.0");
        Client.DefaultRequestHeaders.Add("Referer", "https://app.tcg.robswc.me/");
        Client.DefaultRequestHeaders.Add("Origin", "https://app.tcg.robswc.me");

        Auth = new AuthEndpoints(this);
        Cards = new CardsEndpoints(this);
        Companions = new CompanionsEndpoints(this);
        Exchange = new ExchangeEndpoints(this);
        Features = new FeaturesEndpoints(this);
        Seasons = new SeasonsEndpoints(this);
        Users = new UsersEndpoints(this);
        Vendors = new VendorsEndpoints(this);

        bool result = Handshake().Result;
        if (!result) throw new Exception("Handshake failed");
    }
    
    public ClientService() : this(new ThrottledProcessor(TimeSpan.FromMilliseconds(200))) { }

    private async Task<bool> Handshake()
    {
        var response = await Client.GetAsync(ApiUrl + "users/csrf");
        return response.IsSuccessStatusCode;
    }
    
    private string GetCsrf()
    {
        var uri = new Uri("https://api.tcg.robswc.me/");
        var cookies = CookieContainer.GetCookies(uri);
        return cookies.FirstOrDefault(c => c.Name == "csrftoken")?.Value ?? string.Empty;
    }

    /// <summary>
    /// A helper method for sending a request to the API
    /// </summary>
    /// <param name="method">Method to use</param>
    /// <param name="url">The url, the API url /api/ is prepended already.</param>
    /// <param name="data">The data do send</param>
    /// <returns>Success</returns>
    public async Task<bool> Request(HttpMethod method, string url, object data)
    {
        string token = GetCsrf();
        
        var request = new HttpRequestMessage(method, ApiUrl + url);
        
        string json = JsonSerializer.Serialize(data);
        request.Content = new StringContent(json, Encoding.UTF8, "application/json");
            
        if (!string.IsNullOrEmpty(token))
        {
            request.Headers.Add("X-CSRFToken", token);
        }
            
        var response = await SendAsync(request);
        return response.IsSuccessStatusCode;
    }
    
    /// <summary>
    /// A helper method for sending a request to the API
    /// </summary>
    /// <param name="method">Method to use</param>
    /// <param name="url">The url, the API url /api/ is prepended already.</param>
    /// <param name="data">The data do send</param>
    /// <returns>The response object</returns>
    public async Task<T?> Request<T>(HttpMethod method, string url, object data)
    {
        string token = GetCsrf();
        
        var request = new HttpRequestMessage(method, ApiUrl + url);
        
        string json = JsonSerializer.Serialize(data);
        request.Content = new StringContent(json, Encoding.UTF8, "application/json");
            
        if (!string.IsNullOrEmpty(token))
        {
            request.Headers.Add("X-CSRFToken", token);
        }
            
        var response = await SendAsync(request);
        if (!response.IsSuccessStatusCode)
        {
            throw new Exception(response.Content.ReadAsStringAsync().Result);
        }
        
        string responseJson = await response.Content.ReadAsStringAsync();
        
        return JsonSerializer.Deserialize<T>(responseJson);
    }

    
    /// <summary>
    /// A helper method for sending a request to the API
    /// </summary>
    /// <param name="method">Method to use</param>
    /// <param name="url">The url, the API url /api/ is prepended already.</param>
    /// <returns>Success</returns>
    public async Task<bool> Request(HttpMethod method, string url)
    {
        string token = GetCsrf();
        var request = new HttpRequestMessage(method, ApiUrl + url);
            
        if (!string.IsNullOrEmpty(token))
        {
            request.Headers.Add("X-CSRFToken", token);
        }
            
        var response = await SendAsync(request);
        return response.IsSuccessStatusCode;
    }

    /// <summary>
    /// A helper method for sending a request to the API
    /// </summary>
    /// <param name="method">Method to use</param>
    /// <param name="url">The url, the API url /api/ is prepended already.</param>
    /// <returns>The response object</returns>
    public async Task<T?> Request<T>(HttpMethod method, string url)
    {
        string token = GetCsrf();
        var request = new HttpRequestMessage(method, ApiUrl + url);
            
        if (!string.IsNullOrEmpty(token))
        {
            request.Headers.Add("X-CSRFToken", token);
        }
            
        var response = await SendAsync(request);
        if (!response.IsSuccessStatusCode)
        {
            throw new Exception(response.Content.ReadAsStringAsync().Result);
        }
        
        string json = await response.Content.ReadAsStringAsync();
        
        // Console.WriteLine(json);
        return JsonSerializer.Deserialize<T>(json);
    }

    private async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request) => await Processor.EnqueueAsync<HttpResponseMessage>(async token => await Client.SendAsync(request, token));

    /// <summary>
    /// Async disposal. Put the ClientService in an "await using" block for this to automatically clean up.
    /// </summary>
    public async ValueTask DisposeAsync()
    {
        if (LoggedIn) LoggedIn = await Auth.Logout();
        
        await CastAndDispose(Handler);
        await CastAndDispose(Client);
        await CastAndDispose(Processor);
        
        GC.SuppressFinalize(this);
        return;

        static async ValueTask CastAndDispose(IDisposable resource)
        {
            if (resource is IAsyncDisposable resourceAsyncDisposable)
                await resourceAsyncDisposable.DisposeAsync();
            else
                resource.Dispose();
        }
    }
}