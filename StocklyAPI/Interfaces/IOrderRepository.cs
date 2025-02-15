using StocklyAPI.Models;

namespace StocklyAPI.Interfaces
{
    public interface IOrderRepository<T> where T : Order
    {
        Task Add(T pOrder);
        Task Update(T pOrder);
        Task Delete(T pOrder);
        Task<T?> Get(int id);    
        Task<IEnumerable<T>> GetAll(); 
    }
}
