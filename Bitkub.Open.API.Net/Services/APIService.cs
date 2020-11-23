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
    }
}
