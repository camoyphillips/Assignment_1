using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class Store8Controller : ControllerBase
{
    /// <summary>
    /// Returns a checkout summary for an order of SquashFellows plushies.
    /// </summary>
    /// <param name="Small">The number of small plushies ordered</param>
    /// <param name="Large">The number of large plushies ordered</param>
    /// <returns>The checkout summary with prices, taxes, and total</returns>
    /// <example>POST /api/store8/squashfellows with body Small=1&Large=1</example>
    [HttpPost("squashfellows")]
    public IActionResult Checkout([FromForm] int Small, [FromForm] int Large)
    {
        double smallPrice = 25.50;
        double largePrice = 45.50;
        double subtotal = (Small * smallPrice) + (Large * largePrice);
        double tax = subtotal * 0.13;
        double total = subtotal + tax;

        var response = new
        {
            SmallPrice = smallPrice,
            LargePrice = largePrice,
            SmallQuantity = Small,
            LargeQuantity = Large,
            Subtotal = Math.Round(subtotal, 2),
            Tax = Math.Round(tax, 2),
            Total = Math.Round(total, 2)
        };

        return Ok(response);
    }
}