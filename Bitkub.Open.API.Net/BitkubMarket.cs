using Bitkub.Open.API.Net.Models;
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
        public virtual async Task<APIResponseSymbols> GetSymbolsAsync()
        {
            return await _apiService.EndpointMarketSymbolsAsync();
        }
        /// <summary>
        /// Get ticker information, String symbol (optional)
        /// List all ticker by the string symbol is empty 
        /// </summary>
        /// <param name="symbol">String The symbol (optional)</param>
        /// <returns>Ticker information</returns>
        public virtual async Task<MarketTicker> GetTickerAsync(string symbol)
        {
            return await _apiService.EndpointMarketTickerAsync(symbol);
        }
        /// <summary>
        /// List recent trades
        /// </summary>
        /// <param name="symbol">The symbol</param>
        /// <param name="limit">No. of limit to query recent trades</param>
        /// <returns>Recent trades</returns>
        public virtual async Task<Trades> GetTradesAsync(string symbol, int limit)
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
        /// <summary>
        /// List all open orders
        /// </summary>
        /// <param name="symbol">The symbol</param>
        /// <param name="limit">No. of limit to query open orders</param>
        /// <returns>All open oders</returns>
        public virtual async Task<string> GetBooksAsync(string symbol, int limit)
        {
            return await _apiService.EndpointMarketBooksAsync(symbol, limit);
        }
        /// <summary>
        /// Get tradingview data for displaying tradingview graph
        /// </summary>
        /// <param name="symbol">The symbol</param>
        /// <param name="chartInterval">Chart interval in seconds (e.g. 60, 900, 3600, 86400)</param>
        /// <param name="timeStampFrom">Timestamp of the starting time (e.g. 1574477162)</param>
        /// <param name="timeStampTo">Timestamp of the ending time (e.g. 1575773222)</param>
        /// <returns>Tradingview data</returns>
        public virtual async Task<string> GetTradingviewAsync(string symbol, int chartInterval, int timeStampFrom, int timeStampTo)
        {
            return await _apiService.EndpointMarketTradingviewAsync(symbol, chartInterval, timeStampFrom, timeStampTo);
        }
        /// <summary>
        /// Get depth information
        /// </summary>
        /// <param name="symbol">The symbol</param>
        /// <param name="limit">Depth size</param>
        /// <returns>Depth information</returns>
        public virtual async Task<string> GetDepthAsync(string symbol, int limit)
        {
            return await _apiService.EndpointMarketDepthAsync(symbol, limit);
        }

        public virtual async Task<string> GetBalancesAsync(string ApiKey, string ApiSecret)
        {
            return await _apiService.EndpointMarketBalancesAsync(ApiKey, ApiSecret);
        }
    }
}
