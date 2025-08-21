using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CalculatorController : ControllerBase
{
    // GET /api/calculator/sum?a=5&b=7
    [HttpGet("sum")]
    public IActionResult Sum([FromQuery] double a, [FromQuery] double b)
    {
        return Ok(new { operation = "sum", a, b, result = a + b });
    }
}