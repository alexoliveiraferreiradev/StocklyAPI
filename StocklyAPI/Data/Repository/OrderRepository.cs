using Microsoft.EntityFrameworkCore;
using StocklyAPI.Interfaces;
using StocklyAPI.Models;

namespace StocklyAPI.Data.Repository
{
    public class OrderRepository : IOrderRepository<Order>
    {
        private readonly StocklyDbContext _context;
        public OrderRepository(StocklyDbContext context)
        {
            _context = context;
        }
        public async Task Add(Order pOrder)
        {
            _context.Orders.Add(pOrder);
            await _context.SaveChangesAsync();  
        }

        public async Task Delete(Order pOrder)
        {
            _context.Orders.Remove(pOrder);
            await _context.SaveChangesAsync();  
        }

        public async Task<Order?> Get(int id)
        {
           return await _context.Orders.Where(
               x=>x.Id.Equals(id)).FirstOrDefaultAsync() ?? null;
        }

        public async Task<IEnumerable<Order>> GetAll()
        {
            return await _context.Orders.ToListAsync();
        }

        public async Task Update(Order pNewOrder)
        {
            var order = await Get(pNewOrder.Id);
            if(order != null)
            {
                _context.Entry(order).CurrentValues.SetValues(pNewOrder);
                await _context.SaveChangesAsync();
            }
        }
    }
}
