using Microsoft.EntityFrameworkCore;
using StocklyAPI.Interfaces;
using StocklyAPI.Models;

namespace StocklyAPI.Data.Repository
{
    public class ProductRepository : IProductRepository<Product>
    {
        private readonly StocklyDbContext _context;
        public ProductRepository(StocklyDbContext context)
        {
            _context = context;
        }
        public async Task Add(Product pProduct)
        {
            _context.Products.Add(pProduct);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Product pProduct)
        {
            _context.Products.Remove(pProduct);
            await _context.SaveChangesAsync();
        }

        public async Task<Product> Get(int id)
        {
            return await _context.Products.Where(x =>
            x.Id.Equals(id)).FirstOrDefaultAsync() ?? new Product();
        }

        public Task Update(Product pProduct)
        {
            throw new NotImplementedException();
        }
    }
}
