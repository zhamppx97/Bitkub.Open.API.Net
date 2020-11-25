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
        /// <summary>
        /// List recent trades
        /// </summary>
        /// <param name="symbol">The symbol</param>
        /// <param name="limit">No. of limit to query recent trades</param>
        /// <returns>Recent trades</returns>
        public virtual async Task<string> GetTradesAsync(string symbol, int limit)
        {
            return await _apiService.EndpointMarketTradesAsync(symbol, limit);
        }
        /// <summary>
        /// List open buy orders
        /// </summary>
        /// <param name="symbol">The symbol</param>
        /// <param name="limit">No. of limit to query open buy orders</param>
        /// <returns>Open buy orders</returns>
        public virtual async Task<string> GetBidsAsync(string symbol, int limit)
        {
            return await _apiService.EndpointMarketBidsAsync(symbol, limit);
        }
        /// <summary>
        /// List open sell orders
        /// </summary>
        /// <param name="symbol">The symbol</param>
        /// <param name="limit">No. of limit to query open sell orders</param>
        /// <returns>Open sell orders</returns>
        public virtual async Task<string> GetAsksAsync(string symbol, int limit)
        {
            return await _apiService.EndpointMarketAsksAsync(symbol, limit);
        }
    }
}
