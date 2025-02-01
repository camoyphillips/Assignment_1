using Microsoft.AspNetCore.Mvc;

namespace Assignment_1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Hexagon6Controller : ControllerBase
    {

        /// <summary>
        /// Returns the area of a regular hexagon with a given side length.
        /// </summary>
        /// <param name="side">The length of one side of the hexagon</param>
        /// <returns>The area of the hexagon</returns>
        /// <example>GET /api/hexagon6/hexagon?side=1.5</example>
        [HttpGet("hexagon")]
        public IActionResult GetHexagonArea([FromQuery] double side)
        {
            if (side <= 0)
            {
                return BadRequest("Side length must be a positive number.");
            }

            double area = (3 * Math.Sqrt(3) * Math.Pow(side, 2)) / 2;

            var response = new
            {
                SideLength = side,
                Area = Math.Round(area, 2)
            };

            return Ok(response);
        }
    }
}