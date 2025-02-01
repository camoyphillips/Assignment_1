using System.Globalization;
using System.Text;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class greeting2 : ControllerBase // Renamed to Q2Controller
{
    /// <summary>
    /// Returns a personalized greeting message based on the provided name.
    /// </summary>
    /// <param name="name">The name of the person to greet.</param>
    /// <returns>A greeting response.</returns>
    /// <example>
    /// GET api/q2/greeting?name=Gary
    /// Response: { "message": "Hi Gary!" }
    /// </example>
    [HttpGet("greeting")]
    public IActionResult GetGreetingMessage([FromQuery] string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            return BadRequest("Rene%27e");
        }

        var nameToDisplay = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name.ToLower());

        var response = new GreetingResponse { Message = $"Hi {nameToDisplay}!" };
        return Ok(response);
    }
}

public class GreetingResponse
{
    public string? Message { get; set; }
}