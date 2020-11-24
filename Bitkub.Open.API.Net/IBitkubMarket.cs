using System.Threading.Tasks;

namespace Bitkub.Open.API.Net
{
    public partial interface IBitkubMarket
    {
        Task<string> GetSymbolsAsync();
    }
}
