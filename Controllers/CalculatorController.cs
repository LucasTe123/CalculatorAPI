using Microsoft.AspNetCore.Mvc;

namespace CalculatorAPI.Controllers; // usa tu namespace real

[ApiController]
[Route("api/[controller]")]
public class CalculatorController : ControllerBase
{
    // GET /api/calculator/sum?a=5&b=7
    [HttpGet("sum")]
    public IActionResult Sum([FromQuery] double a, [FromQuery] double b)
        => Ok(new { operation = "sum", a, b, result = a + b });

    // GET /api/calculator/subtract?a=10&b=3
    [HttpGet("subtract")]
    public IActionResult Subtract([FromQuery] double a, [FromQuery] double b)
        => Ok(new { operation = "subtract", a, b, result = a - b });

    // GET /api/calculator/multiply?a=4&b=2.5
    [HttpGet("multiply")]
    public IActionResult Multiply([FromQuery] double a, [FromQuery] double b)
        => Ok(new { operation = "multiply", a, b, result = a * b });

    // GET /api/calculator/divide?a=10&b=2
    [HttpGet("divide")]
    public IActionResult Divide([FromQuery] double a, [FromQuery] double b)
    {
        if (b == 0) return BadRequest(new { error = "Division by zero not allowed." });
        return Ok(new { operation = "divide", a, b, result = a / b });
    }
}