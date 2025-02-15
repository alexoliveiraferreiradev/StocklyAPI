using Microsoft.EntityFrameworkCore;
using StocklyAPI.Models;

namespace StocklyAPI.Data
{
    public class StocklyDbContext : DbContext
    {
        public StocklyDbContext()
        {

        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }    
        public DbSet<SalesPerson> SalesPersons { get; set;  
    }
}
