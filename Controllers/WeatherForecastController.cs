using Microsoft.AspNetCore.Mvc;

namespace MicroservicesSolution.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }


        [HttpGet]
        public IActionResult Get()
        {
            return Ok("CI/CD Test Version 2git add .\r\ngit commit -m \"updated CI/CD to self hosted runner\"\r\ngit push origin dev");
        }

    }
}
