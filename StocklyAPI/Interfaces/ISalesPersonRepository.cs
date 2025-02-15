using StocklyAPI.Models;

namespace StocklyAPI.Interfaces
{
    public interface ISalesPersonRepository<T> where T : SalesPerson
    {
        Task Add(T pSalesPerson);
        Task Update(T pSalesPerson);
        Task<T> Get(int pId);
        Task Delete(T pSalesPerson);
    }
}
