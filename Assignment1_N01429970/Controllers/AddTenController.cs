using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_N01429970.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// This method returns 10 more than the integer input {id} when receiving a get request
        /// <example>GET api/AddTen/{id}</example>
        /// </summary>
        /// <returns>id + 10</returns>
        public int Get(int id)
        {
            return id + 10;
        }
    }
}
