using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Repository;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IRepozitory<WeatherForecast> Summaries;

        public WeatherForecastController(IRepozitory<WeatherForecast> repozitory)
        {
            Summaries = repozitory;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public List<WeatherForecast> GetAll()
        {
            return Summaries.GetAll();
        }
        [HttpGet("{index}, {PageSize}")]
        public IActionResult GetPage(int index, int pageSize )
        {
            var pageList = Summaries.Summaries.OrderBy(x => x.Temperature)
                .Skip((index-1) * pageSize)
                .Take(pageSize)
                .ToList();
            var page = new Paginator<WeatherForecast>()
            {
                list = pageList,
                index = index,
                pageSize = pageSize,
                totalCount = Summaries.Summaries.Count()
            };
            return Ok(page);

        }

        [HttpGet("{summary}", Name = "GetWeatherForecastByName")]
        public IActionResult GetpByName(string summary)
        {
            var weather = Summaries.GetByName(summary);
            if (weather == null)
            {
                return NotFound();
            }

            return Ok(weather);
        }

        [HttpPost(Name = "CreateWeatherForecast")]
        public IActionResult Create([FromBody] WeatherForecast weather)
        {
            var weatherFromList = Summaries.GetByName(weather.Summary);
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
                Summaries.AddMultiple(weathers);
            }
            return Ok();

        }

        [HttpDelete("{summary}", Name = "DeleteWeatherForecastByName")]
        public IActionResult DeleteByName(string summary)
        {
            if(Summaries.DeleteByName(summary))
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }            
        }

        [HttpPut(Name = "UpdateWeatherForecastByName")]
        public IActionResult UpdateByName(WeatherForecast weatherForecast)
        {
            if(Summaries.UpdateByName(weatherForecast))
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
