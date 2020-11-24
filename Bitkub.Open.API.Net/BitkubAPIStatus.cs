using Bitkub.Open.API.Net.Services;
using System.Threading.Tasks;

namespace Bitkub.Open.API.Net
{
    public partial class BitkubAPIStatus : IBitkubAPIStatus
    {
        private readonly IAPIService _apiService = new APIService();

        /// <summary>
        /// Get endpoint status. When status is not ok, it is highly recommended to wait until the status changes back to ok
        /// </summary>
        /// <returns>Endpoint status</returns>
        public virtual async Task<string> GetStatusAsync()
        {
            return await _apiService.EndpointStatusAsync();
        }

        /// <summary>
        /// Get server timestamp
        /// </summary>
        /// <returns>Server timestamp</returns>
        public virtual async Task<string> GetServerTimeAsync()
        {
            return await _apiService.EndpointServerTimeAsync();
        }
    }
}
