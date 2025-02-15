using Microsoft.AspNetCore.Identity;
using System;

namespace StocklyAPI.Models
{
    public class Admin : IdentityUser 
    {        
        public string Name { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool HasElevatedPrivileges { get; set; }
    }
}
