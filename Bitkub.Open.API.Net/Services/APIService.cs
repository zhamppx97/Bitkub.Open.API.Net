using Bitkub.Open.API.Net.Infrastructure;
using Newtonsoft.Json;
using RestSharp;
using System.Threading.Tasks;

namespace Bitkub.Open.API.Net.Services
{
    public partial class APIService : IAPIService
    {
        private readonly BitkubAPI _bitkubAPI = new BitkubAPI();
        private readonly string _serviceBaseUrl;

        public APIService()
        {
            _serviceBaseUrl = $"{_bitkubAPI.BaseApiUrl}";
        }

        public virtual async Task<string> EndpointStatusAsync()
        {
            var url = Endpoints.API.Status(_serviceBaseUrl);
            var client = new RestClient(url)
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.GET);      
            var response = await client.ExecuteAsync(request);
            var responseJsonString = JsonConvert.SerializeObject(response.Content);
            return responseJsonString;
        }

        public virtual async Task<string> EndpointServerTimeAsync()
        {
            var url = Endpoints.API.ServerTime(_serviceBaseUrl);
            var client = new RestClient(url)
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.GET);
            var response = await client.ExecuteAsync(request);
            var responseJsonString = JsonConvert.SerializeObject(response.Content);
            return responseJsonString;
        }

        public virtual async Task<string> EndpointMarketSymbolsAsync()
        {
            var url = Endpoints.Market.Symbols(_serviceBaseUrl);
            var client = new RestClient(url)
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.GET);
            var response = await client.ExecuteAsync(request);
            var responseJsonString = JsonConvert.SerializeObject(response.Content);
            return responseJsonString;
        }

        public virtual async Task<string> EndpointMarketTickerAsync(string symbol)
        {
            var url = Endpoints.Market.Ticker(_serviceBaseUrl);
            var client = new RestClient(url)
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.GET);
            request.AddParameter("sym", symbol, ParameterType.QueryString);
            var response = await client.ExecuteAsync(request);
            var responseJsonString = JsonConvert.SerializeObject(response.Content);
            return responseJsonString;
        }

        public virtual async Task<string> EndpointMarketTradesAsync(string symbol, int limit)
        {
            var url = Endpoints.Market.Trades(_serviceBaseUrl);
            var client = new RestClient(url)
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.GET);
            request.AddParameter("sym", symbol, ParameterType.QueryString);
            request.AddParameter("lmt", limit, ParameterType.QueryString);
            var response = await client.ExecuteAsync(request);
            var responseJsonString = JsonConvert.SerializeObject(response.Content);
            return responseJsonString;
        }
    }
}
