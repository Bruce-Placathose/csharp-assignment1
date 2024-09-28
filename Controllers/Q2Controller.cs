using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace csharp_assignment1.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class GreetingController : ControllerBase
    {
         /// <summary>
        /// Send GET request with a name at the end of the endpoint and receive "Hi {name}".
        /// </summary>
        /// <returns>
        /// Returns only a string for the sending a request at endpoint
        /// </returns>
        /// <example>
        /// GET api/q2/greeting?name=Gary -> Received a response string Hi Gary!
        /// </example>
        [HttpGet(template:"greeting")]
        public string GetGreeting([FromQuery] string name)
        {
            return $"Hi {name}!";
        }
    }
}