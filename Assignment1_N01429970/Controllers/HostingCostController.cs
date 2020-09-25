using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_N01429970.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// This method returns 3 strings which describe the total hosting cost when receiving a get request
        /// <example>GET api/HostingCost/0</example>
        /// </summary>
        /// <returns>[“0 fortnights at $5.50/FN = $5.50 CAD”, “HST 13% = $0.72 CAD”, “Total = $6.22 CAD”]</returns>
        public IEnumerable<string> Get(int id)
        {
            int fortnights = id / 14;
            double cost = Math.Round((fortnights + 1) * 5.50, 2);
            double hst = Math.Round(cost * 0.13, 2);
            double total = cost + hst;
            return new string[] { $"{fortnights} fortnights at $5.50/FN = ${cost:0.00} CAD", $"HST 13% = ${hst} CAD", $"Total = ${total} CAD" };

        }
    }
}
