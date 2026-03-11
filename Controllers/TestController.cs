using Microsoft.AspNetCore.Mvc;

namespace MicroservicesSolution.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("CI/CD Test Version 1");
        }
    }
}
