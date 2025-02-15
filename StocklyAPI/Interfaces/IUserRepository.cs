using StocklyAPI.Models;

namespace StocklyAPI.Interfaces
{
    public interface ICustomerRepository<T> where T : Customer
    {
        Task Add(T pUser);
        Task Update(T pUser);
        Task Delete(T pUser);
        Task<T> Get(int id);
    }
}
