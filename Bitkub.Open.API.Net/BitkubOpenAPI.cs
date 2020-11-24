using Bitkub.Open.API.Net.Services;
using System;
using System.Threading.Tasks;

namespace Bitkub.Open.API.Net
{
    public class BitkubOpenAPI
    {
        private static readonly IAPIService _apiService = new APIService();

        public class API
        {
            public async Task<string> GetStatusAsync()
            {
                return await _apiService.EndpointStatusAsync();
            }

            public async Task<string> GetServerTimeAsync()
            {
                return await _apiService.EndpointServerTimeAsync();
            }
        }

        public class Market
        {
            public async Task<string> GetSymbolsAsync()
            {
                return await _apiService.EndpointMarketSymbolsAsync();
            }
        }
    }
}
