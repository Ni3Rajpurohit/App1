using Microsoft.AspNetCore.Mvc;

namespace DotNetApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { Weather = "Sunny", Temperature = 25 });
        }
    }
}
