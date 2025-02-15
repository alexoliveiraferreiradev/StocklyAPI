using Microsoft.AspNetCore.Identity;

namespace StocklyAPI.Models
{
    public class SalesPerson : IdentityUser
    {
        public string FullName { get; set; }
        public int SalesCount { get; set; }
        public decimal TotalSales { get; set; }
        public DateTime HireDate { get; set; }
        public bool IsActive { get; set; }
        public string ContactNumber { get; set; }

        public bool HasElevatedPrivileges { get; set; }
    }
}
