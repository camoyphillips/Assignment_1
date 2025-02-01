using Microsoft.AspNetCore.Mvc;

namespace Assignment_1.Controllers
{
    [Route("api/hello1")]
    [ApiController]

    public class hello1
    {
        /// <summary>
        /// Gets a welcome message.
        /// </summary>
        /// <returns>
        /// A string "Welcome to 5125!".
        /// </returns>
        /// <example>
        /// GET http://localhost:xx/api/q1/welcome
        /// Response: "Welcome to 5125!"
        /// </example>
        [HttpGet("welcome")]
        public string GetWelcomeMessage()
        {
            return "Welcome to 5125!";

        }
    }
}
