using Bitkub.Open.API.Net;
using System;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StatusAsync().Wait();
        }

        static async Task StatusAsync()
        {
            BitkubOpenAPI.API bitkubOpenApi = new BitkubOpenAPI.API();

            var result = await bitkubOpenApi.GetStatusAsync();
            Console.WriteLine(result);
        }
    }
}
