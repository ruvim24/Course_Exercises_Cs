using Microsoft.AspNetCore.Mvc;

namespace WebAPITest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        private List<Person> _users = new List<Person>()
        {
            new Person(){ Name ="ion", Address = "stefan cel mare", Id = 321},
            new Person(){ Id = 123, Address = "unkown", Name = "ruvim"},
            new Person(){ Name = "ionatan", Address = "eminescu", Id = 234}

        };

        

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        
        [HttpGet("{name}")]
        public string Get(string name)
        {
            return $"test string: {name}";
        }
    }

    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private static List<Person> _users = new List<Person>()
        {
            new Person(){ Name ="ion", Address = "stefan cel mare", Id = 1},
            new Person(){ Id = 2, Address = "unkown", Name = "ruvim"},
            new Person(){ Name = "ionatan", Address = "eminescu", Id = 3}

        };

        [HttpGet(Name = "GetAllUsers")]
        public List<Person> Get()
        {
            return _users;
        }
        [HttpGet("{id}", Name = "GetByName")]
        public IActionResult Get(int id)
        {
            var user = _users.FirstOrDefault(x => x.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);

        }
        [HttpPost(Name = "CreateUser")]
        public IActionResult Post([FromBody] Person person)
        {
            if (person == null)
            {
                return BadRequest();

            }

            var temp = _users.Any(x => x.Name == person.Name);
            if (temp)
            {
                return Conflict("Exista deja utilizator");
            }

            _users.Add(person);
            return Ok();
        }
    }

}


public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
}
