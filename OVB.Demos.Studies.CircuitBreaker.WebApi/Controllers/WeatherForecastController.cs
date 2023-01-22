using Microsoft.AspNetCore.Mvc;

namespace OVB.Demos.Studies.CircuitBreaker.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> PostController()
    {
        return await Task.FromResult(StatusCode(503));
    }
}