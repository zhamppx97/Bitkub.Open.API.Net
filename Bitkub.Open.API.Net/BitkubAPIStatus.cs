using Bitkub.Open.API.Net.Services;
using System.Threading.Tasks;

namespace Bitkub.Open.API.Net
{
    public partial class BitkubAPIStatus : IBitkubAPIStatus
    {
        private readonly IAPIService _apiService = new APIService();

        public virtual async Task<string> GetStatusAsync()
        {
            return await _apiService.EndpointStatusAsync();
        }

        public virtual async Task<string> GetServerTimeAsync()
        {
            return await _apiService.EndpointServerTimeAsync();
        }
    }
}
