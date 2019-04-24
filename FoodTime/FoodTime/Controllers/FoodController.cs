using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodTime.Models;
using Microsoft.AspNetCore.Mvc;
using FoodTime.DTO;
using FoodTime.Data;

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

        public IQueryable<FoodDTO> GetFood()
        {
            FoodContext db = new FoodContext();
            var foods = from b in db.Food
                        select new FoodDTO()
                        {
                            Id = b.Id,
                            Name = b.Name,
                            Category = b.Category,
                            Componets = b.Componets,
                            Weight = b.Weight,
                            Price = b.Price,
                            ExtraInfo = b.ExtraInfo,
                        };

            return foods;
        }

    }
}