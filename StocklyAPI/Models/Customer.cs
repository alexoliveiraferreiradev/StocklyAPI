using Microsoft.AspNetCore.Identity;

namespace StocklyAPI.Models
{
    public class Customer : IdentityUser
    {
        public string FullName { get; set; }
        public string ShippingAddress { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool IsEmailVerified { get; set; }
        public List<Order> Orders { get; set; }
        public bool IsActive { get; set; }
    }
}
