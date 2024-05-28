using Microsoft.EntityFrameworkCore;
using TravelPortalBlazorCRUD.Entity;

namespace TravelPortalBlazorCRUD.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options) 
        { 

        }

        public DbSet<City> City { get; set; }
    }
}
