using SHTCGClient.Models.Exchange;

namespace SHTCGClient.Endpoints;

public class ExchangeEndpoints (ClientService client)
{
    /// <summary>
    /// Get the currently running exchanges
    /// </summary>
    /// <returns>Array of exchanges</returns>
    public async Task<Exchange[]?> Exchanges() => await client.Request<Exchange[]>(HttpMethod.Get, "exchange");
    
    /// <summary>
    /// Get the candle graph for an exchange
    /// </summary>
    /// <param name="exchangeId">The exchange ID</param>
    /// <param name="interval">The interval in minutes</param>
    /// <param name="limit">The limit of candles to fetch</param>
    /// <returns>Array of candles</returns>
    public async Task<Candle[]?> Candles(int exchangeId, int interval, int limit) => await client.Request<Candle[]>(HttpMethod.Get, $"exchange/{exchangeId}/candles?interval={interval}m&limit={limit}");
    
    /// <summary>
    /// Get the user's positions in the exchanges
    /// </summary>
    /// <returns>Array of positions</returns>
    public async Task<Position[]?> Positions() => await client.Request<Position[]>(HttpMethod.Get, "exchange/positions");
}