using SHTCGClient.Models.Trades;

namespace SHTCGClient.Endpoints;

public class TradesEndpoints (ClientService client)
{
    public async Task<Trade?> GetTrade(int id) => await client.Request<Trade>(HttpMethod.Get, $"trades/{id}");
    
    public async Task<Trade[]?> MyTrades() => await client.Request<Trade[]>(HttpMethod.Get, "trades");
}