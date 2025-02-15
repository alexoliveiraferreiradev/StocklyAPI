using StocklyAPI.Models;

namespace StocklyAPI.Interfaces
{
    public interface IProductRepository<T> where T : Product
    {
        Task Add(T pProduct);
        Task Update(T pProduct);
        Task Delete(T pProduct);
        Task<T> Get(int id);
    }
}
