using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static List<WeatherForecast> Summaries = new List<WeatherForecast>
        {
            new WeatherForecast { Date = DateTime.Now.AddDays(1), Temperature = 25, Summary = "Hot" },
            new WeatherForecast { Date = DateTime.Now.AddDays(2), Temperature = 15, Summary = "Cold" },
            new WeatherForecast { Date = DateTime.Now.AddDays(3), Temperature = 20, Summary = "Warm" },
            new WeatherForecast { Date = DateTime.Now.AddDays(4), Temperature = 30, Summary = "Very Hot" },
            new WeatherForecast { Date = DateTime.Now.AddDays(5), Temperature = 10, Summary = "Very Cold" }
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> GetAll()
        {
            return Summaries;
        }

        [HttpGet("{summary}", Name = "GetWeatherForecastByName")]
        public IActionResult GetpByName(string summary)
        {
            var weather = Summaries.FirstOrDefault(x => x.Summary == summary);
            if (weather == null)
            {
                return NotFound();
            }

            return Ok(weather);
        }

        [HttpPost(Name = "CreateWeatherForecast")]
        public IActionResult Create([FromBody] WeatherForecast weather)
        {
            var weatherFromList = Summaries.FirstOrDefault(x => x.Summary == weather.Summary);
            if (weatherFromList == null)
            {
                Summaries.Add(weather);
                return CreatedAtRoute("GetWeatherForecastByName", new { weather.Summary }, weather);
            }

            return BadRequest("Already Exists");
        }

        /// Create a new endpoint that will create multiple weather forecasts

        [HttpPost("Multiple")]
        public IActionResult CreateWetherForecasts([FromBody]List<WeatherForecast> weathers)
        {
            if (weathers == null)
            {
                return BadRequest();
            }
            else
            {
                foreach (WeatherForecast weather in weathers)
                {
                    Summaries.Add(weather);
                }
            }
            return Ok();

        }

        [HttpDelete("{summary}", Name = "DeleteWeatherForecastByName")]
        public IActionResult DeleteByName(string summary)
        {
            var weather = Summaries.FirstOrDefault(x => x.Summary == summary);
            if (weather == null)
            {
                return NotFound();
            }

            Summaries.Remove(weather);

            return Ok();
        }

        [HttpPut(Name = "UpdateWeatherForecastByName")]
        public IActionResult DeleteByName(WeatherForecast weatherForecast)
        {
            var index = Summaries.FindIndex(x => x.Summary == weatherForecast.Summary);
            if (index == -1)
            {
                return NotFound();
            }

            Summaries[index].Date = weatherForecast.Date;
            Summaries[index].Temperature = weatherForecast.Temperature;

            return Ok();
        }
    }
}
