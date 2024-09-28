using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace csharp_assignment1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Q8Controller : ControllerBase
    {
        /// <summary>
        /// Send POST with a request body having two parameter 
        /// </summary>
        /// <returns>
        /// Returns a string that has many variables shown as money and need to be format to 2decimal place.
        /// </returns>
        /// <example>
        /// GET api/q8/squashfellows, -H "x-www-form-urlencoded" -d "Small=1Large=1" 
        /// GET api/q8/squashfellows, -H "x-www-form-urlencoded" -d "Small=2Large=1"
        /// GET api/q8/squashfellows, -H "x-www-form-urlencoded" -d "Small=100Large=100"
        /// </example>
        [HttpPost(template:"squashfellows")]
        public string Cart([FromForm]int Small, [FromForm]int Large ) 
        {
            double smallPlushesPrice = 25.50;
            double largePlushesPrice = 40.50;
            double Subtotal = (smallPlushesPrice * Small) + (largePlushesPrice * Large);
            double TaxRate = 0.13;
            double TaxAmount = TaxRate * Subtotal;
            double Total = Subtotal + TaxAmount;

            return $"{Small} Small @ $25.50 = ${smallPlushesPrice:F2}; {Large} Large @ 45.50 = ${largePlushesPrice:F2}; Subtotal = ${Subtotal:F2}; Tax = ${TaxAmount:F2} HST; Total = ${Total:F2}"; 
        }
    }
}