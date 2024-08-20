using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class AplicationDbContext : DbContext
    {
        public DbSet<WeatherForecast> weatherForecasts { get; set; }

        public DbSet<Summary> summarys { get; set; }

        public AplicationDbContext()
        {
            
        }

        string DbPath = "\"C:\\CsProjects\\DB\\WebAplicationDb.db\"";

        //string DbPath = "Data Source=\"C:\\CsProjects\\DB\\WebAplicationDb.db\";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
        }
        
    }
}
