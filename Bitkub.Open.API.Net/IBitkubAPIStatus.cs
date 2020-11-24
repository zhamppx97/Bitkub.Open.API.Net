using System.Threading.Tasks;

namespace Bitkub.Open.API.Net
{
    public partial interface IBitkubAPIStatus
    {
        Task<string> GetStatusAsync();
        Task<string> GetServerTimeAsync();
    }
}
