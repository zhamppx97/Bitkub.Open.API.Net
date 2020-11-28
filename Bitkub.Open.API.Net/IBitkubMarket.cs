using Bitkub.Open.API.Net.Models;
using System.Threading.Tasks;

namespace Bitkub.Open.API.Net
{
    public partial interface IBitkubMarket
    {
        /// <summary>
        /// List all available symbols
        /// </summary>
        /// <returns>All available symbols</returns>
        Task<APIResponseSymbols> GetSymbolsAsync();
        /// <summary>
        /// Get ticker information, String symbol (optional)
        /// List all ticker by the string symbol is empty 
        /// </summary>
        /// <param name="symbol">String The symbol (optional)</param>
        /// <returns>Ticker information</returns>
        Task<string> GetTickerAsync(string symbol);
        /// <summary>
        /// List recent trades
        /// </summary>
        /// <param name="symbol">The symbol</param>
        /// <param name="limit">No. of limit to query recent trades</param>
        /// <returns>Recent trades</returns>
        Task<string> GetTradesAsync(string symbol, int limit);
        /// <summary>
        /// List open buy orders
        /// </summary>
        /// <param name="symbol">The symbol</param>
        /// <param name="limit">No. of limit to query open buy orders</param>
        /// <returns>Open buy orders</returns>
        Task<string> GetBidsAsync(string symbol, int limit);
        /// <summary>
        /// List open sell orders
        /// </summary>
        /// <param name="symbol">The symbol</param>
        /// <param name="limit">No. of limit to query open sell orders</param>
        /// <returns>Open sell orders</returns>
        Task<string> GetAsksAsync(string symbol, int limit);
        /// <summary>
        /// List all open orders
        /// </summary>
        /// <param name="symbol">The symbol</param>
        /// <param name="limit">No. of limit to query open orders</param>
        /// <returns>All open oders</returns>
        Task<string> GetBooksAsync(string symbol, int limit);
        /// <summary>
        /// Get tradingview data for displaying tradingview graph
        /// </summary>
        /// <param name="symbol">The symbol</param>
        /// <param name="chartInterval">Chart interval in seconds (e.g. 60, 900, 3600, 86400)</param>
        /// <param name="timeStampFrom">Timestamp of the starting time (e.g. 1574477162)</param>
        /// <param name="timeStampTo">Timestamp of the ending time (e.g. 1575773222)</param>
        /// <returns>Tradingview data</returns>
        Task<string> GetTradingviewAsync(string symbol, int chartInterval, int timeStampFrom, int timeStampTo);
        /// <summary>
        /// Get depth information
        /// </summary>
        /// <param name="symbol">The symbol</param>
        /// <param name="limit">Depth size</param>
        /// <returns>Depth information</returns>
        Task<string> GetDepthAsync(string symbol, int limit);
    }
}
