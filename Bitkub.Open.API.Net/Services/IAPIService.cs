using System.Threading.Tasks;

namespace Bitkub.Open.API.Net.Services
{
    public partial interface IAPIService
    {
        Task<string> EndpointStatusAsync();
        Task<string> EndpointServerTimeAsync();

        Task<string> EndpointMarketSymbolsAsync();
    }
}
