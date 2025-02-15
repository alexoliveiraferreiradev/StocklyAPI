using Microsoft.EntityFrameworkCore;
using StocklyAPI.Interfaces;
using StocklyAPI.Models;

namespace StocklyAPI.Data.Repository
{
    public class AdminRepository : IAdminRepository<Admin>
    {
        private readonly StocklyDbContext _context;
        public AdminRepository(StocklyDbContext context)
        {
            _context = context; 
        }
        public async Task Add(Admin pAdmin)
        {
            _context.Admins.Add(pAdmin);
            await _context.SaveChangesAsync();  
        }

        public async Task Delete(Admin pAdmin)
        {
            _context.Admins.Remove(pAdmin); 
            await _context.SaveChangesAsync();  
        }

        public async Task<Admin?> Get(int id)
        {
           return await _context.Admins.Where(
               x=>x.Id.Equals(id)).FirstOrDefaultAsync() ?? null;   
        }

        public async Task Update(Admin pNemAdmin)
        {
            var admin = await Get(pNemAdmin.Id);    
            if(admin !=null)
            {
                _context.Admins.Entry(admin).CurrentValues.SetValues(pNemAdmin);
                await _context.SaveChangesAsync();
            }
        }
    }
}
