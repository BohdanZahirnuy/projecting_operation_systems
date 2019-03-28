using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodTime.Models;
using Microsoft.AspNetCore.Mvc;


namespace FoodTime.Controllers
{
    [Route("food")]
    public class FoodController : Controller
    {
        private DataContext db = new DataContext();

        [Route("")]
        [Route("index")]
        [Route("~/")]
        // initialize database, when it'll be ready
        public IActionResult FoodDetail()
        {
            //uncomment when db'll be ready
            //var food = db.Food.SingleOrDefault(x => x.Id == id);
            //return View(food);
            ViewBag.foods = db.Food.ToList();
            return View();
        }
    }
}