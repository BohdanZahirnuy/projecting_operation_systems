using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FoodTime.Controllers
{
    public class EntranceController : Controller
    {
        // initialize database, when it'll be ready
        public IActionResult SignIn()
        {
           
            return View();
        }
    }
}