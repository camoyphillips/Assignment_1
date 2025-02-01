using Microsoft.AspNetCore.Mvc;

namespace Assignment_1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class travel7
    {
        /// <summary>
        /// Returns a string representation of the date adjusted by the specified number of days.
        /// </summary>
        /// <param name="days">The number of days to adjust the current date by</param>
        /// <returns>The adjusted date</returns>
        /// <example>GET /api/q7/timemachine?days=1</example>
        [HttpGet("timemachine")]
        public string TimeMachine(int days)
        {
            var newDate = DateTime.Today.AddDays(days).ToString("yyyy-MM-dd");
            return (newDate);

        }
    }
}

