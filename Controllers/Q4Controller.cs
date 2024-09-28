using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace csharp_assignment1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class KnockKnockController : ControllerBase
    {
         /// <summary>
        /// Send POST request with an empty request body".
        /// </summary>
        /// <returns>
        /// Returns only a string "Who's there?"
        /// </returns>
        /// <example>
        /// GET api/q4/knockknock -> "Who's there?"
        /// </example>
        [HttpPost(template:"knockknock")]
        public string PostKnockKnock()
        {
            return "Who's there?";
        }
    }
}