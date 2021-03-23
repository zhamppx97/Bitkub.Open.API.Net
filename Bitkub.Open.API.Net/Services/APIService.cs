using Bitkub.Open.API.Net.Infrastructure;
using Bitkub.Open.API.Net.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bitkub.Open.API.Net.Services
{
    public partial class APIService : IAPIService
    {
        private readonly BitkubAPI _bitkubAPI = new();
        private readonly string _serviceBaseUrl;

        public APIService()
        {
            _serviceBaseUrl = $"{_bitkubAPI.BaseApiUrl}";
        }

        public virtual async Task<APIResponseStatus> EndpointStatusAsync()
        {
            var url = Endpoints.API.Status(_serviceBaseUrl);
            var client = new RestClient(url)
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.GET);
            var response = await client.ExecuteAsync(request);
            var responseContent = JsonConvert.DeserializeObject<List<StatusResult>>(response.Content);
            var data = new APIResponseStatus
            {
                ErrorDetail = null,
                Result = responseContent
            };
            return data;
        }

        public virtual async Task<APIResponseTimeStamp> EndpointServerTimeAsync()
        {
            var url = Endpoints.API.ServerTime(_serviceBaseUrl);
            var client = new RestClient(url)
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.GET);
            var response = await client.ExecuteAsync(request);
            var responseContent = JsonConvert.DeserializeObject(response.Content);
            var timeStamp = new TimeStampResult { TimeStamp = Convert.ToInt32(responseContent) };
            var data = new APIResponseTimeStamp
            {
                ErrorDetail = null,
                Result = timeStamp
            };
            return data;
        }

        #region Non-Secure endpoints
        public virtual async Task<APIResponseSymbols> EndpointMarketSymbolsAsync()
        {
            var url = Endpoints.Market.Symbols(_serviceBaseUrl);
            var client = new RestClient(url)
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.GET);
            var response = await client.ExecuteAsync(request);
            var responseContent = JsonConvert.DeserializeObject<APIResponseSymbols>(response.Content);
            var errorDetail = new SharedBusinessErrorDetail { Code = responseContent.ErrorId, Description = BusinessErrorCodeService.Description(responseContent.ErrorId) };
            var data = new APIResponseSymbols
            {
                ErrorDetail = errorDetail,
                ErrorId = responseContent.ErrorId,
                Result = responseContent.Result
            };
            return data;
        }

        public virtual async Task<MarketTicker> EndpointMarketTickerAsync(string symbol)
        {
            var url = Endpoints.Market.Ticker(_serviceBaseUrl);
            var client = new RestClient(url)
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.GET);
            request.AddParameter("sym", symbol, ParameterType.QueryString);
            var response = await client.ExecuteAsync(request);
            var responseContent = JsonConvert.DeserializeObject<MarketTicker>(response.Content);
            return responseContent;
        }

        public virtual async Task<Trades> EndpointMarketTradesAsync(string symbol, int limit)
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
            var responseContent = JsonConvert.DeserializeObject<Trades>(response.Content);
            return responseContent;
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
        #endregion
        #region Secure endpoint
        public virtual async Task<string> EndpointMarketWalletAsync(string ApiKey)
        {
            var url = Endpoints.Market.Wallet(_serviceBaseUrl);
            var client = new RestClient(url)
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.POST);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-type", "application/json");
            request.AddHeader("X-BTK-APIKEY", ApiKey);
            //request.AddJsonBody();
            var response = await client.ExecuteAsync(request);
            var responseJsonString = JsonConvert.SerializeObject(response.Content);
            return responseJsonString;
        }
        #endregion
    }
}
