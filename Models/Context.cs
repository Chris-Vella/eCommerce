using Microsoft.EntityFrameworkCore;

namespace eCommerce.Models
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options) { }

        public DbSet<Customer> customers { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Order> orders { get; set; }

    }
}