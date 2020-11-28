
namespace Bitkub.Open.API.Net.Services
{
    public static class BusinessErrorCodeService
    {
        public static string Description(int Code)
        {
            string desc = "";
            switch (Code)
            {
                case 0:
                    desc = "No error";
                    break;
                case 1:
                    desc = "Invalid JSON payload";
                    break;
                case 2:
                    desc = "Missing X-BTK-APIKEY";
                    break;
                case 3:
                    desc = "Invalid API key";
                    break;
                case 4:
                    desc = "API pending for activation";
                    break;
                case 5:
                    desc = "IP not allowed";
                    break;
                case 6:
                    desc = "Missing / invalid signature";
                    break;
                case 7:
                    desc = "Missing timestamp";
                    break;
                case 8:
                    desc = "Invalid timestamp";
                    break;
                case 9:
                    desc = "Invalid user";
                    break;
                case 10:
                    desc = "Invalid parameter";
                    break;
                case 11:
                    desc = "Invalid symbol";
                    break;
                case 12:
                    desc = "Invalid amount";
                    break;
                case 13:
                    desc = "Invalid rate";
                    break;
                case 14:
                    desc = "Improper rate";
                    break;
                case 15:
                    desc = "Amount too low";
                    break;
                case 16:
                    desc = "Failed to get balance";
                    break;
                case 17:
                    desc = "Wallet is empty";
                    break;
                case 18:
                    desc = "Insufficient balance";
                    break;
                case 19:
                    desc = "Failed to insert order into db";
                    break;
                case 20:
                    desc = "Failed to deduct balance";
                    break;
                case 21:
                    desc = "Invalid order for cancellation";
                    break;
                case 22:
                    desc = "Invalid side";
                    break;
                case 23:
                    desc = "Failed to update order status";
                    break;
                case 24:
                    desc = "Invalid order for lookup (or cancelled)";
                    break;
                case 25:
                    desc = "KYC level 1 is required to proceed";
                    break;
                case 30:
                    desc = "Limit exceeds";
                    break;
                case 40:
                    desc = "Pending withdrawal exists";
                    break;
                case 41:
                    desc = "Invalid currency for withdrawal";
                    break;
                case 42:
                    desc = "Address is not in whitelist";
                    break;
                case 43:
                    desc = "Failed to deduct crypto";
                    break;
                case 44:
                    desc = "Failed to create withdrawal record";
                    break;
                case 45:
                    desc = "Nonce has to be numeric";
                    break;
                case 46:
                    desc = "Invalid nonce";
                    break;
                case 47:
                    desc = "Withdrawal limit exceeds";
                    break;
                case 48:
                    desc = "Invalid bank account";
                    break;
                case 49:
                    desc = "Bank limit exceeds";
                    break;
                case 50:
                    desc = "Pending withdrawal exists";
                    break;
                case 51:
                    desc = "Withdrawal is under maintenance";
                    break;
                case 90:
                    desc = "Server error (please contact support)";
                    break;
                default:
                    break;
            }

            return desc;
        }
    }
}
