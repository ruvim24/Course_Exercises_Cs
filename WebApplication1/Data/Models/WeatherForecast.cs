using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Data.Models
{
    public class WeatherForecast
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int MyProperty { get; set; }

        public int Temperature { get; set; }

        public int TemperatureF;  //=> 32 + (int)(Temperature / 0.5556) ;

        public string? Summary { get; set; }
    }
}
