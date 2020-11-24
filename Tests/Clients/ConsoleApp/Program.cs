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
            IBitkubAPIStatus api = new BitkubAPIStatus();
            var result = await api.GetStatusAsync();
            Console.WriteLine(result);
        }

        static async Task ServerTimeAsync()
        {
            IBitkubAPIStatus api = new BitkubAPIStatus();
            var result = await api.GetServerTimeAsync();
            Console.WriteLine(result);
        }

        static async Task MarketSymbolsAsync()
        {
            IBitkubMarket market = new BitkubMarket();
            var result = await market.GetSymbolsAsync();
            Console.WriteLine(result);
        }
    }
}
