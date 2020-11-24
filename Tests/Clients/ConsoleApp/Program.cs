using Bitkub.Open.API.Net;
using System;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            StatusAsync().Wait();
            ServerTimeAsync().Wait();
            MarketSymbolsAsync().Wait();
        }

        static async Task StatusAsync()
        {
            BitkubOpenAPI.API api = new BitkubOpenAPI.API();
            var result = await api.GetStatusAsync();
            Console.WriteLine(result);
        }

        static async Task ServerTimeAsync()
        {
            BitkubOpenAPI.API api = new BitkubOpenAPI.API();
            var result = await api.GetServerTimeAsync();
            Console.WriteLine(result);
        }

        static async Task MarketSymbolsAsync()
        {
            BitkubOpenAPI.Market market = new BitkubOpenAPI.Market();
            var result = await market.GetSymbolsAsync();
            Console.WriteLine(result);
        }
    }
}
