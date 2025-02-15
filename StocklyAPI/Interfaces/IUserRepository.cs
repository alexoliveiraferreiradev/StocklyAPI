using StocklyAPI.Models;

namespace StocklyAPI.Interfaces
{
    public interface IUserRepository<T> where T : User
    {
        Task Add(T pUser);
        Task Update(T pUser);
        Task Delete(T pUser);
        Task<T> Get(int pId);

    }
}
