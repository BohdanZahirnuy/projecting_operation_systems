using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodTime.Models;
using Microsoft.AspNetCore.Mvc;


namespace FoodTime.Controllers
{
    public class FoodController : Controller
    {
     
        public IActionResult FoodDetail()
        {
            //uncomment when db'll be ready
            //var food = db.Food.SingleOrDefault(x => x.Id == id);
            //return View(food);
            return View();
        }
    }
}