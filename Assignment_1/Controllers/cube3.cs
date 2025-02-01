using Microsoft.AspNetCore.Mvc;

namespace Assignment_1.Controllers
{
    [Route("api/cube3")]
    [ApiController]
    public class cube3
    {
        /// <summary>
        /// Calculates the cube of the given number.
        /// </summary>
        /// <param name="baseNumber">The base number to cube.
        ///         a=4
        ///         b=-4
        ///         c=10
        ///         total=1000+64+64
        /// 
        /// </param>
        /// <returns>
        /// The cube of the base number.
        /// </returns>
        /// <example>
        /// GET http://localhost:xx/api/q3/cube/3
        /// Response: 1070.4
        /// </example>
        [HttpGet("cube/{baseNumber}")]
        public string GetCube(int baseNumber)
        {
            int cube = (int)Math.Pow(baseNumber, 3);
            return "cube";

        }
    }
    }
