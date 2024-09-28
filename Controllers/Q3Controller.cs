using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace csharp_assignment1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CubeController : ControllerBase
    {
         /// <summary>
        /// Send GET request with an integer at the end of the endpoint the cube of the integer}".
        /// </summary>
        /// <returns>
        /// Returns only an integer
        /// </returns>
        /// <example>
        /// GET api/q3/cube/10 -> 1000 
        /// GET api/q3/cube/4 -> 64 
        /// </example>
        [HttpGet(template:"cube/{baseValue}")]
        public int GetCube(int baseValue)
        {
            int cubeOfBase = baseValue * baseValue * baseValue;
            return Math.Abs(cubeOfBase);
        }
    }
}