using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace TeisterM.Models
{
    public class TeisterMDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public TeisterMDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
            options.UseSqlServer(Configuration.GetConnectionString("Default"));
        }

        public DbSet<Task> Tasks { get; set; }
    }
}
