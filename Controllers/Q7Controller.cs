using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace csharp_assignment1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Q7Controller : ControllerBase
    {
         /// <summary>
        /// Send GET request with an integer in the endpoint to get current date + date at integer".
        /// </summary>
        /// <returns>
        /// Returns a string that has been format with a ToString showing year-month-date
        /// </returns>
        /// <example>
        /// GET api/q7/timemachine?days = 1 -> 2024-09-28
        /// GET api/q7/timemachine?days =  -9 -> 2024-09-18
        /// GET api/q7/timemachine?days =  300 -> 2025-07-24
        /// </example>
        [HttpGet(template:"timemachine")]
        public string CurrentDate(int days)
        {
            DateTime dateToday = DateTime.Today;
            DateTime getDate = dateToday.AddDays(days);
            return getDate.ToString("yyyy-MM-dd");
        }
    }
}