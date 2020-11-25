﻿using System.Threading.Tasks;

namespace Bitkub.Open.API.Net.Services
{
    public partial interface IAPIService
    {
        Task<string> EndpointStatusAsync();
        Task<string> EndpointServerTimeAsync();

        Task<string> EndpointMarketSymbolsAsync();
        Task<string> EndpointMarketTickerAsync(string symbol);
        Task<string> EndpointMarketTradesAsync(string symbol, int limit);
        Task<string> EndpointMarketBidsAsync(string symbol, int limit);
        Task<string> EndpointMarketAsksAsync(string symbol, int limit);
    }
}
