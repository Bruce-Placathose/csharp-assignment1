using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace csharp_assignment1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Q6Controller : ControllerBase
    {
         /// <summary>
        /// Send GET request with a length and get the area of hexagon".
        /// </summary>
        /// <returns>
        /// Returns a double number 
        /// </returns>
        /// <example>
        /// GET api/q5/hexagon?side= 1.5 -> 5.84......
        /// GET api/q5/hexagon?side= 1 -> 2.59......
        /// GET api/q5/hexagon?side= 20 -> 1039.23...
        /// </example>
        [HttpGet(template:"hexagon")]
        public double HexagonArea([FromQuery] double side)
        {
            double areaOfHexagon = 3 * Math.Sqrt(3) / 2 * Math.Pow(side, 2);
            return areaOfHexagon;
        }
    }
}