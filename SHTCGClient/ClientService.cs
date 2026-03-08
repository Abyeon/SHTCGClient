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

public struct Credentials
{
    public string Username { get; set; }
    public string Password { get; set; }
}

public class ClientService : IAsyncDisposable
{
    public readonly CookieContainer CookieContainer;
    public readonly HttpClientHandler Handler;
    public readonly HttpClient Client;
    public readonly ThrottledProcessor Processor;

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

    public async Task<bool> Login(string username, string password) => await Login(new Credentials {Username = username, Password = password});
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

    public async Task<bool> Logout() => await Request(HttpMethod.Post, "users/auth/logout");
    public async Task<RollInfo?> Status() => await Request<RollInfo>(HttpMethod.Get, "cards/roll/status");
    public async Task<CardRollResponse?> Roll() => await Request<CardRollResponse>(HttpMethod.Post, "cards/roll");
    
    public async Task<User[]?> SearchForUser(string name) => await Request<User[]>(HttpMethod.Get, $"users/users?search={name}");
    
    public async Task<Season?> GetSeason(int id) => await Request<Season>(HttpMethod.Get, $"seasons/{id}");
    public async Task<Season?> GetCurrentSeason() => await Request<Season>(HttpMethod.Get, "seasons/active/current");
    public async Task<Deck[]?> GetLeaderboard() => await Request<Deck[]>(HttpMethod.Get, "seasons/decks/leaderboard");
    
    public async Task<Deck[]?> GetDecks() => await Request<Deck[]>(HttpMethod.Get, "seasons/decks");
    public async Task<Card[]?> GetDeckCards(int deckId) => await Request<Card[]>(HttpMethod.Get, $"seasons/decks/{deckId}/cards");
    public async Task DeleteDeckCard(int deckId, int id) => await Request(HttpMethod.Delete, $"seasons/decks/{deckId}/cards/{id}");
    
    public async Task<Exchange[]?> GetExchanges() => await Request<Exchange[]>(HttpMethod.Get, "exchange");
    public async Task<Candle[]?> GetCandles(int exchangeId, int interval, int limit) => await Request<Candle[]>(HttpMethod.Get, $"exchange/{exchangeId}/candles?interval={interval}m&limit={limit}");
    public async Task<Position[]?> GetPositions() => await Request<Position[]>(HttpMethod.Get, "exchange/positions");
    
    public async Task<Vendor[]?> GetVendors() => await Request<Vendor[]>(HttpMethod.Get, "vendors/list");
    public async Task<Companion[]?> GetCompanions() => await Request<Companion[]>(HttpMethod.Get, "companions");
    public async Task<bool> UnequipCompanion() => await Request(HttpMethod.Post, "companions/unequip");
    public async Task<Companion?> EquipCompanion(int id) => await Request<Companion>(HttpMethod.Post, $"companions/{id}/equip");

    public async Task AddDeckCard(int deckId, int id)
    {
        var cardData = new
        {
            card_id = id
        };
        
        await Request(HttpMethod.Post,  $"seasons/decks/{deckId}/cards", cardData);
    }

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

    public async Task<bool> Request<T>(HttpMethod method, string url, T data)
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