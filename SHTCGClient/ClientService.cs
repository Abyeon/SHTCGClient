using System.Net;
using System.Text;
using System.Text.Json;
using SHTCGClient.Models;
using SHTCGClient.Models.Cards;
using SHTCGClient.Models.Companions;
using SHTCGClient.Models.Exchange;
using SHTCGClient.Models.Seasons;
using SHTCGClient.Models.Users;
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

        bool result = Handshake().Result;
        if (!result) throw new Exception("Handshake failed");
    }
    
    public ClientService()
    {
        Processor = new ThrottledProcessor(TimeSpan.FromMilliseconds(200));
        
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

        bool result = Handshake().Result;
        if (!result) throw new Exception("Handshake failed");
    }

    private async Task<bool> Handshake()
    {
        var response = await Client.GetAsync(ApiUrl + "users/csrf");
        return response.IsSuccessStatusCode;
    }

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
        
        bool success = await Request(HttpMethod.Post, "users/auth/login", loginData);

        LoggedIn = success;
        
        return success;
    }

    private async Task<bool> Logout() => await Request(HttpMethod.Post, "users/auth/logout");
    
    // --- Cards/rolls ---
    
    /// <summary>
    /// Get the current roll status
    /// </summary>
    /// <returns>Roll information</returns>
    public async Task<RollInfo?> Status() => await Request<RollInfo>(HttpMethod.Get, "cards/roll/status");
    
    /// <summary>
    /// Roll for a card
    /// </summary>
    /// <returns>Roll information</returns>
    public async Task<CardRollResponse?> Roll() => await Request<CardRollResponse>(HttpMethod.Post, "cards/roll");
    
    /// <summary>
    /// Get the last x rolls
    /// </summary>
    /// <param name="count">Amount of rolls to fetch</param>
    /// <returns>Array of cards</returns>
    public async Task<Card[]?> RollHistory(int count) => await Request<Card[]>(HttpMethod.Get, $"cards/roll-history?count={count}");
    
    // --- Social ---
    
    /// <summary>
    /// Get your friends
    /// </summary>
    /// <returns>Array of users</returns>
    public async Task<User[]?> GetFriends() => await Request<User[]>(HttpMethod.Get, "users/me/friends");
    
    /// <summary>
    /// Search for a user by name
    /// </summary>
    /// <param name="name">The username to search for</param>
    /// <returns>Array of users</returns>
    public async Task<User[]?> GetUserByName(string name) => await Request<User[]>(HttpMethod.Get, $"users/users?search={name}");
    
    // --- Season/leaderboard ---
    
    /// <summary>
    /// Get season by id
    /// </summary>
    /// <param name="id">The season's id</param>
    /// <returns>Season</returns>
    public async Task<Season?> GetSeason(int id) => await Request<Season>(HttpMethod.Get, $"seasons/{id}");
    
    /// <summary>
    /// Get the currently active season
    /// </summary>
    /// <returns>The active season</returns>
    public async Task<Season?> GetCurrentSeason() => await Request<Season>(HttpMethod.Get, "seasons/active/current");
    
    /// <summary>
    /// Get the deck leaderboard for the current season
    /// </summary>
    /// <returns>Array of decks</returns>
    public async Task<Deck[]?> GetLeaderboard() => await Request<Deck[]>(HttpMethod.Get, "seasons/decks/leaderboard");
    
    
    // --- Decks ---
    
    /// <summary>
    /// Get the user's decks
    /// </summary>
    /// <returns>Array of decks</returns>
    public async Task<Deck[]?> GetDecks() => await Request<Deck[]>(HttpMethod.Get, "seasons/decks");
    
    /// <summary>
    /// Get the cards for a deck by id
    /// </summary>
    /// <param name="deckId">The deck ID</param>
    /// <returns>Array of cards</returns>
    public async Task<Card[]?> GetDeckCards(int deckId) => await Request<Card[]>(HttpMethod.Get, $"seasons/decks/{deckId}/cards");
    
    /// <summary>
    /// Delete a card in a deck
    /// </summary>
    /// <param name="deckId">The deck ID</param>
    /// <param name="id">The card ID</param>
    public async Task DeleteDeckCard(int deckId, int id) => await Request(HttpMethod.Delete, $"seasons/decks/{deckId}/cards/{id}");
    
    /// <summary>
    /// Add a card to a deck
    /// </summary>
    /// <param name="deckId">The deck ID</param>
    /// <param name="id">The card ID</param>
    public async Task AddDeckCard(int deckId, int id)
    {
        var cardData = new
        {
            card_id = id
        };
        
        await Request(HttpMethod.Post,  $"seasons/decks/{deckId}/cards", cardData);
    }
    
    // --- Exchanges ---
    
    /// <summary>
    /// Get the currently running exchanges
    /// </summary>
    /// <returns>Array of exchanges</returns>
    public async Task<Exchange[]?> GetExchanges() => await Request<Exchange[]>(HttpMethod.Get, "exchange");
    
    /// <summary>
    /// Get the candle graph for an exchange
    /// </summary>
    /// <param name="exchangeId">The exchange ID</param>
    /// <param name="interval">The interval in minutes</param>
    /// <param name="limit">The limit of candles to fetch</param>
    /// <returns>Array of candles</returns>
    public async Task<Candle[]?> GetCandles(int exchangeId, int interval, int limit) => await Request<Candle[]>(HttpMethod.Get, $"exchange/{exchangeId}/candles?interval={interval}m&limit={limit}");
    
    /// <summary>
    /// Get the user's positions in the exchanges
    /// </summary>
    /// <returns>Array of positions</returns>
    public async Task<Position[]?> GetPositions() => await Request<Position[]>(HttpMethod.Get, "exchange/positions");
    
    // --- Stores ---
    
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
        
        return await Request<CardSellResponse>(HttpMethod.Post, "vendors/sell", data);
    }
    
    /// <summary>
    /// Get the current vendors
    /// </summary>
    /// <returns>Array of vendors</returns>
    public async Task<Vendor[]?> GetVendors() => await Request<Vendor[]>(HttpMethod.Get, "vendors/list");
    
    // --- Companions ---
    
    /// <summary>
    /// Get the user's owned companions
    /// </summary>
    /// <returns>Array of companions</returns>
    public async Task<Companion[]?> GetCompanions() => await Request<Companion[]>(HttpMethod.Get, "companions");
    
    /// <summary>
    /// Get the user's currently active companion
    /// </summary>
    /// <returns>The active companion</returns>
    public async Task<Companion?> GetActiveCompanion() => await Request<Companion>(HttpMethod.Get, "companions/active");
    
    /// <summary>
    /// Unequip the currently active companion
    /// </summary>
    /// <returns>Success</returns>
    public async Task<bool> UnequipCompanion() => await Request(HttpMethod.Post, "companions/unequip");
    
    /// <summary>
    /// Equip a companion by ID
    /// </summary>
    /// <param name="id">The ID of the companion to equip</param>
    /// <returns>The equipped companion</returns>
    public async Task<Companion?> EquipCompanion(int id) => await Request<Companion>(HttpMethod.Post, $"companions/{id}/equip");

    /// <summary>
    /// Get the User's owned cards. (This automatically de-paginates the request and gets all cards.)
    /// </summary>
    /// <returns>Array of cards</returns>
    public async Task<Card[]?> GetCards()
    {
        List<Card> cards = [];

        var page = 1;
        while (true)
        {
            var cardPage = await Request<PaginatedItem<Card>>(HttpMethod.Get, $"cards/my-cards?page={page}&page_size=24");
            if (cardPage == null) break;
            
            cards.AddRange(cardPage.Data);
            
            if (page == cardPage.TotalPages) break;
            page++;
        }
        
        return cards.ToArray();
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
        if (LoggedIn) LoggedIn = await Logout();
        
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