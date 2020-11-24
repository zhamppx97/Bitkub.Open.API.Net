using Bitkub.Open.API.Net.Services;
using System;
using System.Threading.Tasks;

namespace Bitkub.Open.API.Net
{
    public class BitkubOpenAPI
    {
        public class API
        {
            private readonly IAPIService _apiService = new APIService();

            public async Task<string> GetStatusAsync()
            {
                return await _apiService.EndpointStatusAsync();
            }

            public async Task<string> GetServerTime()
            {
                return await _apiService.EndpointServerTimeAsync();
            }
        }
    }
}
