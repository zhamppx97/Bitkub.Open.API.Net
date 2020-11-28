using System.Collections.Generic;

namespace Bitkub.Open.API.Net.Models
{
    public class APIResponseSymbols
    {
        public SharedBusinessErrorDetail ErrorDetail { get; set; }
        public int ErrorId { get; set; }
        public List<SymbolsResult> Result { get; set; }
    }

    public class SymbolsResult
    {
        public int Id { get; set; }
        public string Symbol { get; set; }
        public string Info { get; set; }
    }
}
