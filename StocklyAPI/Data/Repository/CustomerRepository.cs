using StocklyAPI.Interfaces;
using StocklyAPI.Models;

namespace StocklyAPI.Data.Repository
{
    public class CustomerRepository : ICustomerRepository<Customer>
    {
        private readonly StocklyDbContext _context;
        public CustomerRepository(StocklyDbContext context)
        {
            _context = context;
        }
        public Task Add(Customer pUser)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Customer pUser)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Customer pUser)
        {
            throw new NotImplementedException();
        }
    }
}
