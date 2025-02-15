using Microsoft.EntityFrameworkCore;
using StocklyAPI.Models;

namespace StocklyAPI.Data
{
    public class StocklyDbContext : DbContext
    {
        public StocklyDbContext()
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

                var connectionString = configuration.GetConnectionString("StocklyConnection");

                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }    
        public DbSet<SalesPerson> SalesPersons { get; set; } 
    }
}
