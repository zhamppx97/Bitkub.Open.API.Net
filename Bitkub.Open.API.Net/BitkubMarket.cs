using Bitkub.Open.API.Net.Services;
using System.Threading.Tasks;

namespace Bitkub.Open.API.Net
{
    public partial class BitkubMarket : IBitkubMarket
    {
        private readonly IAPIService _apiService = new APIService();

        public virtual async Task<string> GetSymbolsAsync()
        {
            return await _apiService.EndpointMarketSymbolsAsync();
        }
    }
}
