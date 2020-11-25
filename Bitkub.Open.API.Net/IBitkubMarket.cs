using System.Threading.Tasks;

namespace Bitkub.Open.API.Net
{
    public partial interface IBitkubMarket
    {
        /// <summary>
        /// List all available symbols
        /// </summary>
        /// <returns>All available symbols</returns>
        Task<string> GetSymbolsAsync();
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
    }
}
