using Microsoft.AspNetCore.Identity;

namespace FoodTime.Data.Models
{
    public class User : IdentityUser
    {
        public string Address { get; set; }
    }
}