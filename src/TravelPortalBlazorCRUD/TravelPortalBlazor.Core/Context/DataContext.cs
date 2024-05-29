using Microsoft.EntityFrameworkCore;
using TravelPortalBlazor.Core.Entity;

namespace TravelPortalBlazor.Core.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }

        public DbSet<City> City { get; set; }
        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<PlaceFamous> PlaceFamous { get; set; }


    }
}
