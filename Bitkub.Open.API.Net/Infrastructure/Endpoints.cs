
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
            #region Non-Secure endpoints
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
            #endregion
            #region Secure endpoints
            public static string Wallet(string baseUrl)
            {
                return $"{baseUrl}/api/market/wallet";
            }
            public static string Balances(string baseUrl)
            {
                return $"{baseUrl}/api/market/balances";
            }
            public static string PlaceBid(string baseUrl)
            {
                return $"{baseUrl}/api/market/place-bid";
            }
            public static string PlaceBidTest(string baseUrl)
            {
                return $"{baseUrl}/api/market/place-bid/test";
            }
            public static string PlaceAsk(string baseUrl)
            {
                return $"{baseUrl}/api/market/place-ask";
            }
            public static string PlaceAskTest(string baseUrl)
            {
                return $"{baseUrl}/api/market/place-ask/test";
            }
            public static string PlaceAskByFiat(string baseUrl)
            {
                return $"{baseUrl}/api/market/place-ask-by-fiat";
            }
            public static string CancelOrder(string baseUrl)
            {
                return $"{baseUrl}/api/market/cancel-order";
            }
            public static string MyOpenOrder(string baseUrl)
            {
                return $"{baseUrl}/api/market/my-open-orders";
            }
            public static string MyOrderHistory(string baseUrl)
            {
                return $"{baseUrl}/api/market/my-order-history";
            }
            public static string OrderInfo(string baseUrl)
            {
                return $"{baseUrl}/api/market/order-info";
            }
            public static string WebSocketToken(string baseUrl)
            {
                return $"{baseUrl}/api/market/wstoken";
            }
            #endregion
        }

        public static class Crypto
        {
            public static string Addresses(string baseUrl)
            {
                return $"{baseUrl}/api/crypto/addresses";
            }
            public static string Withdraw(string baseUrl)
            {
                return $"{baseUrl}/api/crypto/withdraw";
            }
            public static string DepositHistory(string baseUrl)
            {
                return $"{baseUrl}/api/crypto/deposit-history";
            }
            public static string WithdrawHistory(string baseUrl)
            {
                return $"{baseUrl}/api/crypto/withdraw-history";
            }
            public static string GenerateAddress(string baseUrl)
            {
                return $"{baseUrl}/api/crypto/generate-address";
            }
        }

        public static class Fiat
        {
            public static string Accounts(string baseUrl)
            {
                return $"{baseUrl}/api/fiat/accounts";
            }
            public static string Withdraw(string baseUrl)
            {
                return $"{baseUrl}/api/fiat/withdraw";
            }
            public static string DepositHistory(string baseUrl)
            {
                return $"{baseUrl}/api/fiat/deposit-history";
            }
            public static string WithdrawHistory(string baseUrl)
            {
                return $"{baseUrl}/api/fiat/withdraw-history";
            }
        }

        public static class User
        {
            public static string Limits(string baseUrl)
            {
                return $"{baseUrl}/api/user/limits";
            }
            public static string TradingCredits(string baseUrl)
            {
                return $"{baseUrl}/api/user/trading-credits";
            }
        }
    }
}
