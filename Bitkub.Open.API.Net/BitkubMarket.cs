using Bitkub.Open.API.Net.Services;
using System.Threading.Tasks;

namespace Bitkub.Open.API.Net
{
    public partial class BitkubMarket : IBitkubMarket
    {
        private readonly IAPIService _apiService = new APIService();

        /// <summary>
        /// List all available symbols
        /// </summary>
        /// <returns>All available symbols</returns>
        public virtual async Task<string> GetSymbolsAsync()
        {
            return await _apiService.EndpointMarketSymbolsAsync();
        }
        /// <summary>
        /// Get ticker information, String symbol (optional)
        /// List all ticker by the string symbol is empty 
        /// </summary>
        /// <param name="symbol">String The symbol (optional)</param>
        /// <returns>Ticker information</returns>
        public virtual async Task<string> GetTickerAsync(string symbol)
        {
            return await _apiService.EndpointMarketTickerAsync(symbol);
        }
    }
}
