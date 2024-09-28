using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace csharp_assignment1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WelcomeController: ControllerBase
    {
        /// <summary>
        /// Send GET request and provides a response message saying "Welcome to 5125".
        /// </summary>
        /// <returns>
        /// Returns only a string for the sending a request at endpoint
        /// </returns>
        /// <example>
        /// GET api/q1/welcome -> Received a response string
        /// </example>
        [HttpGet(template:"welcome")]
        public string GetWelcome()
        {
            return "Welcome to 5125!";
        }

    }
}