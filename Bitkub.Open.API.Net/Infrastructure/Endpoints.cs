
namespace Bitkub.Open.API.Net.Infrastructure
{
    public static class Endpoints
    {
        public static class API
        {
            public static string Status(string baseUrl)
            {
                return $"{baseUrl}/api/status";
            }
            public static string ServerTime(string baseUrl)
            {
                return $"{baseUrl}/api/servertime";
            }
        }

        public static class Market
        {
            public static string Symbols(string baseUrl)
            {
                return $"{baseUrl}/api/market/symbols";
            }
            public static string Ticker(string baseUrl)
            {
                return $"{baseUrl}/api/market/ticker";
            }
            public static string Trades(string baseUrl)
            {
                return $"{baseUrl}/api/market/trades";
            }
            public static string Bids(string baseUrl)
            {
                return $"{baseUrl}/api/market/bids";
            }
            public static string Asks(string baseUrl)
            {
                return $"{baseUrl}/api/market/asks";
            }
            public static string Books(string baseUrl)
            {
                return $"{baseUrl}/api/market/books";
            }
            public static string Tradingview(string baseUrl)
            {
                return $"{baseUrl}/api/market/tradingview";
            }
            public static string Depth(string baseUrl)
            {
                return $"{baseUrl}/api/market/depth";
            }
        }
    }
}
