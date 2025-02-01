using Microsoft.AspNetCore.Mvc;

namespace Assignment_1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class joke4
    {
        /// <summary>
        /// Returns the start of a knock-knock joke.
        /// </summary>
        /// <returns>A string containing the start of a knock-knock joke</returns>
        /// <example>POST /api/q4/knockknock</example>
        [HttpPost("knockknock")]
        public string KnockKnock()
        {
            return "Who’s there?";
        }
    }
}
