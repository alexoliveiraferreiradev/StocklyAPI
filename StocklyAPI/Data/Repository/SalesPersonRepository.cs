using Microsoft.EntityFrameworkCore;
using StocklyAPI.Interfaces;
using StocklyAPI.Models;

namespace StocklyAPI.Data.Repository
{
    public class SalesPersonRepository : ISalesPersonRepository<SalesPerson>
    {
        private readonly StocklyDbContext _context;

        public SalesPersonRepository(StocklyDbContext context)
        {
            _context = context;
        }

        public async Task Add(SalesPerson pSalesPerson)
        {
            _context.SalesPersons.Add(pSalesPerson);    
            await _context.SaveChangesAsync();
        }

        public async Task Delete(SalesPerson pSalesPerson)
        {
            _context.SalesPersons.Remove(pSalesPerson); 
           await _context.SaveChangesAsync();   
        }

        public async Task<SalesPerson?> Get(int pId)
        {
            return await _context.SalesPersons.Where(
                x => x.Id.Equals(pId)).FirstOrDefaultAsync() ?? null;
        }

        public async Task Update(SalesPerson pNemSalesPerson)
        {
           var saler = await Get(pNemSalesPerson.Id);
            if (saler != null)
            {
                _context.Entry(saler).CurrentValues.SetValues(pNemSalesPerson);
                await _context.SaveChangesAsync();
            }
        }
    }
}
