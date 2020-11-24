
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
        }
    }
}
