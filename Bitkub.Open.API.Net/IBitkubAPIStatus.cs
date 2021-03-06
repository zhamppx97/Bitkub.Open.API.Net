﻿using Bitkub.Open.API.Net.Models;
using System.Threading.Tasks;

namespace Bitkub.Open.API.Net
{
    public partial interface IBitkubAPIStatus
    {
        /// <summary>
        /// Get endpoint status. When status is not ok, it is highly recommended to wait until the status changes back to ok
        /// </summary>
        /// <returns>Endpoint status</returns>
        Task<APIResponseStatus> GetStatusAsync();
        /// <summary>
        /// Get server timestamp
        /// </summary>
        /// <returns>Server timestamp</returns>
        Task<APIResponseTimeStamp> GetServerTimeAsync();
    }
}
