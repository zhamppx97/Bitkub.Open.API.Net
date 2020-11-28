using System.Collections.Generic;

namespace Bitkub.Open.API.Net.Models
{
    public class APIResponseStatus
    {
        public SharedBusinessErrorDetail ErrorDetail { get; set; }
        public List<StatusResult> Result { get; set; }
    }

    public class StatusResult
    {
        public string Name { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
    }
}
