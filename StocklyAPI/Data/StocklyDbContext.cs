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
    }
}
