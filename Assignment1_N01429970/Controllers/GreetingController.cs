using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_N01429970.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// This method returns the string when receiving a post request
        /// <example>Post api/Greeting</example>
        /// </summary>
        /// <returns>“Hello World!”</returns>
        public string Post()
        {
            return "Hello World!";
        }

        /// <summary>
        /// This method returns the string where id is an integer value when receiving a get request
        /// <example>GET api/Greeting/{id}</example>
        /// </summary>
        /// <returns>“Greetings to {id} people!”</returns>
        public string Get(int id)
        {
            return $"Greetings to {id} people!";
        }
    }
}
