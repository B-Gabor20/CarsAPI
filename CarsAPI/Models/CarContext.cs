using Microsoft.EntityFrameworkCore;

namespace CarsAPI.Models
{
    public class CarContext : DbContext
    {
        public CarContext() 
        {            

        }


        public CarContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=192.168.50.11; database=carDB; user=root; password=987654321", 
                    ServerVersion.AutoDetect("server=192.168.50.11; database=CarDB; user=root; password=987654321"));
            }
        }
        public DbSet<Car> Cars { get; set; } = null;
    }
}
