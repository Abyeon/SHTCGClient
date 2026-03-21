using SHTCGClient.Models.Cards;
using SHTCGClient.Models.Vendors;

namespace SHTCGClient.Extensions;

public static class CardExtensions
{
    extension(Card[] card)
    {
        /// <summary>
        /// Helper method for selling an array of cards.
        /// Provides more information than just providing an array of IDs to the API.
        /// </summary>
        /// <param name="client">Your client</param>
        /// <returns>Array of sold cards</returns>
        public static async Task<Card[]> Sell(ClientService client)
        {
            
            
            return [];
        }
    }
}