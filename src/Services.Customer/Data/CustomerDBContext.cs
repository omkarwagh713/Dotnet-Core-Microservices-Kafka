using Microsoft.EntityFrameworkCore;

namespace Services.Customer.Data
{
    public class CustomerDBContext : DbContext
    {
        public CustomerDBContext(DbContextOptions<CustomerDBContext> options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("customer");
            modelBuilder.Entity<Customer>().ToTable("customers");
        }
    }
}
