using WebApplication1.Data.Models;

namespace WebApplication1.Repository
{
    public interface IRepozitory<T> where T : class
    {
        public List<T> Summaries { get; set; }
        T GetByName(string name);
        List<T>GetAll();

        void Add(T entity);
        void AddMultiple(List<T> entities);
        bool UpdateByName(WeatherForecast weatherForecast);
        bool DeleteByName(string name);

    }
}
