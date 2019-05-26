using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
namespace Services.Dto
{
    public class UserDto : IdentityUser
    {
        public string Address { get; set; }
    }
}

