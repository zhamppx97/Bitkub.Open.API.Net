using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitkub.Open.API.Net.Models
{
    public partial class BalancesPayload
    {
        public int ts { get; set; }
    }

    public partial class BalancesPayloadWithSig
    {
        public int ts { get; set; }
        public string sig { get; set; }
    }
}
