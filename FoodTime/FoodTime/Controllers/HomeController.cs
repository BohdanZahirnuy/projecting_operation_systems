using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoodTime.Models;
using FoodTime.Data;
using FoodTime.Data.Models;

namespace FoodTime.Controllers
{
    public class HomeController : Controller
    {
        FoodContext db = new FoodContext();
        public IActionResult Index()
        {
            IEnumerable<Food> foods =  db.Food;
            ViewBag.Foods = foods;
            return View();
        }
    }
}
