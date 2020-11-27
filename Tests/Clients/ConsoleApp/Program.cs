using Bitkub.Open.API.Net;
using System;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            //StatusAsync().Wait();
            //ServerTimeAsync().Wait();
            //MarketSymbolsAsync().Wait();
            //MarketTickerAsync().Wait();
            //MarketBidsAsync().Wait();
            //MarketAsksAsync().Wait();
            //MarketBooksAsync().Wait();
            //MarketTradingviewAsync().Wait();
            MarketDepthAsync().Wait();
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

        static async Task MarketTickerAsync()
        {
            IBitkubMarket market = new BitkubMarket();
            string sym = null; // ex THB_BTC
            var result = await market.GetTickerAsync(sym);
            Console.WriteLine(result);
        }

        static async Task MarketBidsAsync()
        {
            IBitkubMarket market = new BitkubMarket();
            string sym = "THB_BTC";
            int lmt = 3;
            var result = await market.GetBidsAsync(sym, lmt);
            Console.WriteLine(result);
        }

        static async Task MarketAsksAsync()
        {
            IBitkubMarket market = new BitkubMarket();
            string sym = "THB_BTC";
            int lmt = 3;
            var result = await market.GetAsksAsync(sym, lmt);
            Console.WriteLine(result);
        }

        static async Task MarketBooksAsync()
        {
            IBitkubMarket market = new BitkubMarket();
            string sym = "THB_BTC";
            int lmt = 3;
            var result = await market.GetBooksAsync(sym, lmt);
            Console.WriteLine(result);
        }

        static async Task MarketTradingviewAsync()
        {
            IBitkubMarket market = new BitkubMarket();
            string sym = "THB_BTC";
            int chartInterval = 60;
            int frm = 1577836860;
            int to = 1577836960;
            var result = await market.GetTradingviewAsync(sym, chartInterval, frm, to);
            Console.WriteLine(result);
        }

        static async Task MarketDepthAsync()
        {
            IBitkubMarket market = new BitkubMarket();
            string sym = "THB_BTC";
            int lmt = 3;
            var result = await market.GetDepthAsync(sym, lmt);
            Console.WriteLine(result);
        }
    }
}
