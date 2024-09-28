using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace csharp_assignment1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SecretIntController : ControllerBase
    {
         /// <summary>
        /// Send POST request with request body containing a number".
        /// </summary>
        /// <returns>
        /// Returns only a string "Who's there?"
        /// </returns>
        /// <example>
        /// GET api/q5/secret, -d "5" -> "Shh, the secret is: 5"
        /// GET api/q5/secret, -d "-200" -> "Shh, the secret is: -200"
        /// </example>
        [HttpPost(template:"secret")]
        public string SecretInteger([FromBody] int secretNum)
        {
            return $"Shh, the secret is: {secretNum}";
        }
    }
}