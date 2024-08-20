using Microsoft.AspNetCore.Components.Web;
using WebApplication1.Data.Models;

namespace WebApplication1.Repository
{
    public class SummariesRepozitory : IRepozitory<WeatherForecast>
    {
        public List<WeatherForecast> Summaries { get; set; } = new()
        {
            new WeatherForecast { Date = DateTime.Now.AddDays(1), Temperature = 25, Summary = "Hot" },
            new WeatherForecast { Date = DateTime.Now.AddDays(2), Temperature = 15, Summary = "Cold" },
            new WeatherForecast { Date = DateTime.Now.AddDays(3), Temperature = 20, Summary = "Warm" },
            new WeatherForecast { Date = DateTime.Now.AddDays(4), Temperature = 30, Summary = "Very Hot" },
            new WeatherForecast { Date = DateTime.Now.AddDays(5), Temperature = 10, Summary = "Very Cold" }
        };

        

        


        //va trebui ulterior de adaugt logica aditionala pentru verificarea 
        public WeatherForecast GetByName(string name)
        {
            return Summaries.FirstOrDefault(x => x.Summary == name);
        }
        public List<WeatherForecast> GetAll()
        {
            return Summaries;
        }
        public void Add(WeatherForecast entity)
        {
            Summaries.Add(entity);
        }
        public void AddMultiple(List<WeatherForecast> list)
        {
            foreach (WeatherForecast weather in list)
            {
                Add(weather);
            }
        }

        public bool DeleteByName(string name)
        {
            var temp = Summaries.FirstOrDefault(x => x.Summary == name);
            if (temp != null)
            {
                Summaries.Remove(temp);
                return true;
            }
            return false;

        }

        public bool UpdateByName(WeatherForecast entity)
        {
            int index = Summaries.FindIndex(x=>x.Summary == entity.Summary);
            if (index == -1)
            {
                return false;
            }
            else
            {
                Summaries[index].Temperature = entity.Temperature;
                Summaries[index].Date = entity.Date;
            }
            return true;
        }
    }
}
