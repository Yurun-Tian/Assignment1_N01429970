using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_N01429970.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// This method returns the square of the integer input {id} when receiving a get request
        /// <example>GET api/Square/{id}</example>
        /// </summary>
        /// <returns>id*id</returns>
        public int Get(int id)
        {
            return (int)Math.Pow(id, 2);
        }
    }
}
