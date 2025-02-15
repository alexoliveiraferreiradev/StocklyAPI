using StocklyAPI.Models;

namespace StocklyAPI.Interfaces
{
    public interface IAdminRepository<T> where T : Admin
    {
        Task Add(T pAdmin);
        Task Delete(T pAdmin);
        Task<T?> Get(string id);
        Task Update(T pAdmin);
    }
}
