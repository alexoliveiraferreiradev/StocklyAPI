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
        public Task Add(Product pProduct)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Product pProduct)
        {
            throw new NotImplementedException();
        }

        public Task<Product> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Product pProduct)
        {
            throw new NotImplementedException();
        }
    }
}
