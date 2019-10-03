using Microsoft.EntityFrameworkCore;

namespace SportsStore.Models
{
    public class SportsStoreContext : DbContext
    {
        public SportsStoreContext(DbContextOptions<SportsStoreContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
