using Bitkub.Open.API.Net.Models;
using System.Threading.Tasks;

namespace Bitkub.Open.API.Net.Services
{
    public partial interface IAPIService
    {
        Task<APIResponseStatus> EndpointStatusAsync();
        Task<APIResponseTimeStamp> EndpointServerTimeAsync();

        #region Non-Secure endpoints
        Task<APIResponseSymbols> EndpointMarketSymbolsAsync();
        Task<MarketTicker> EndpointMarketTickerAsync(string symbol);
        Task<Trades> EndpointMarketTradesAsync(string symbol, int limit);
        Task<string> EndpointMarketBidsAsync(string symbol, int limit);
        Task<string> EndpointMarketAsksAsync(string symbol, int limit);
        Task<string> EndpointMarketBooksAsync(string symbol, int limit);
        Task<string> EndpointMarketTradingviewAsync(string symbol, int chartInterval, int timeStampFrom, int timeStampTo);
        Task<string> EndpointMarketDepthAsync(string symbol, int limit);
        #endregion
        #region Secure endpoint
        Task<string> EndpointMarketWalletAsync(string ApiKey);
        #endregion
    }
}
