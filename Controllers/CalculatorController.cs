using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[ApiController]
[Route("api/[controller]")]              // => /api/calculator
public class CalculatorController : ControllerBase
{
    // GET /api/calculator/sum?a=5&b=7
    [HttpGet("sum")]
    public IActionResult GetSum([FromQuery] int a, [FromQuery] int b)
    {
        var result = a + b;
        return Ok(new { a, b, result });
    }

    // GET /api/calculator/subtract?a=10&b=3
    [HttpGet("subtract")]
    public IActionResult Subtract([FromQuery] int a, [FromQuery] int b)
    {
        var result = a - b;
        return Ok(new { a, b, result });
    }

    // GET /api/calculator/multiply?a=4&b=2
    [HttpGet("multiply")]
    public IActionResult Multiply([FromQuery] int a, [FromQuery] int b)
    {
        var result = a * b;
        return Ok(new { a, b, result });
    }

    // GET /api/calculator/divide?a=10&b=2
    [HttpGet("divide")]
    public IActionResult Divide([FromQuery] int a, [FromQuery] int b)
    {
        if (b == 0) return BadRequest(new { error = "Division by zero not allowed." });
        var result = a / b; // división entera (igual que en el PDF)
        return Ok(new { a, b, result });
    }
}