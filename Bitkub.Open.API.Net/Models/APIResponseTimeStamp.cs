
namespace Bitkub.Open.API.Net.Models
{
    public class APIResponseTimeStamp
    {
        public SharedBusinessErrorDetail ErrorDetail { get; set; }
        public TimeStampResult Result { get; set; }
    }

    public class TimeStampResult
    {
        public int TimeStamp { get; set; }
    }
}
