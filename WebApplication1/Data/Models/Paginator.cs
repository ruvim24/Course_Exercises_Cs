using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Data.Models
{
    public class Paginator
    {
        public List<WeatherForecast> list;
        public int index;
        public int totalPages; //=> (int)Math.Ceiling((totalCount - 1) / (double)pageSize);
        public int pageSize;
        public int totalCount;

    }
}
