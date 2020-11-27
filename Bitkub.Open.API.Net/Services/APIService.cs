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

        public virtual async Task<string> EndpointMarketBidsAsync(string symbol, int limit)
        {
            var url = Endpoints.Market.Bids(_serviceBaseUrl);
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

        public virtual async Task<string> EndpointMarketAsksAsync(string symbol, int limit)
        {
            var url = Endpoints.Market.Asks(_serviceBaseUrl);
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

        public virtual async Task<string> EndpointMarketBooksAsync(string symbol, int limit)
        {
            var url = Endpoints.Market.Books(_serviceBaseUrl);
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

        public virtual async Task<string> EndpointMarketTradingviewAsync(string symbol, int chartInterval, int timeStampFrom, int timeStampTo)
        {
            var url = Endpoints.Market.Tradingview(_serviceBaseUrl);
            var client = new RestClient(url)
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.GET);
            request.AddParameter("sym", symbol, ParameterType.QueryString);
            request.AddParameter("int", chartInterval, ParameterType.QueryString);
            request.AddParameter("frm", timeStampFrom, ParameterType.QueryString);
            request.AddParameter("to", timeStampTo, ParameterType.QueryString);
            var response = await client.ExecuteAsync(request);
            var responseJsonString = JsonConvert.SerializeObject(response.Content);
            return responseJsonString;
        }

        public virtual async Task<string> EndpointMarketDepthAsync(string symbol, int limit)
        {
            var url = Endpoints.Market.Depth(_serviceBaseUrl);
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
