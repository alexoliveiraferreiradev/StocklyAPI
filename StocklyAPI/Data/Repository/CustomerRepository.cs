using Microsoft.EntityFrameworkCore;
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
        public async Task Add(Customer pUser)
        {
            _context.Customers.Add(pUser);
            await _context.SaveChangesAsync();  
        }

        public async Task Delete(Customer pUser)
        {
            _context.Customers.Remove(pUser);
            await _context.SaveChangesAsync();  
        }

        public async Task<Customer> Get(int id)
        {
          return await _context.Customers.Where(
              x=>x.Id.Equals(id)).FirstOrDefaultAsync() ?? new Customer();
        }

        public async Task Update(Customer pUser)
        {
            var customer = await Get(pUser.Id);
            if (customer != null) { 
                _context.Entry(customer).CurrentValues.SetValues(pUser); 
                await _context.SaveChangesAsync();   
            }
        }
    }
}
