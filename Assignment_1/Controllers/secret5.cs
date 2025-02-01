using Microsoft.AspNetCore.Mvc;

namespace Assignment_1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class secret5
    {
        /// <summary>
        /// Returns an acknowledgement of the provided secret integer.
        /// </summary>
        /// <param name="secret">The secret integer to acknowledge</param>
        /// <returns>A string containing the secret message</returns>
        /// <example>POST /api/q5/secret with body { "secret": 5 }</example>
        [HttpPost("secret")]
        public string Secret([FromBody] int secret)
        {
            return ($"Shh.. the secret is {secret}");


        }
    }
}
