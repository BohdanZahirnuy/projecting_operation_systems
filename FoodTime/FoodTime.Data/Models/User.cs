using Microsoft.AspNetCore.Identity;

namespace FoodTime.Data.Models
{
    public class User : IdentityUser
    {
        public int Year { get; set; }
    }
}