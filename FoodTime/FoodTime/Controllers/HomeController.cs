using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoodTime.Models;
using Services.Dto;
using Services.Implementation;
using Services.Interfaces;
using AutoMapper;

namespace FoodTime.Controllers
{
    public class HomeController : Controller
    {
        IFoodService foodService;
        public HomeController(IFoodService serv)
        {
            foodService = serv;
        }
        public IActionResult Index(string sortOrder, string searchString)
        {
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["PriceSortParm"] = sortOrder == "Price" ? "price_desc" : "Price";
            ViewData["CategorySortParm"] = sortOrder == "Pizza" ? "Sushi" : "Pizza";
            ViewData["CurrentFilter"] = searchString;


            IEnumerable<FoodDto> foodDtos = foodService.Get();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<FoodDto, FoodViewModel>()).CreateMapper();
            var food = mapper.Map<IEnumerable<FoodDto>, List<FoodViewModel>>(foodDtos).ToList();

            if (!String.IsNullOrEmpty(searchString))
            {
                food = food.Where(s => s.Name.Contains(searchString)
                                       || s.Componets.Contains(searchString)
                                       || s.ExtraInfo.Contains(searchString)).ToList();
            }

            switch (sortOrder)
            {
                case "name_desc":
                    food = food.OrderByDescending(s => s.Name).ToList();
                    break;
                case "Price":
                    food = food.OrderBy(s => s.Price).ToList();
                    break;
                case "price_desc":
                    food = food.OrderByDescending(s => s.Price).ToList();
                    break;
                case "Pizza":
                    food = food.Where(x => x.Category == "pizza").Select(x => x).Distinct().ToList();
                    break;
                case "Sushi":
                    food = food.Where(x => x.Category == "sushi").Select(x => x).Distinct().ToList();
                    break;
                default:
                    food = food.OrderBy(s => s.Name).ToList();
                    break;
            }

            return View(food);

        }

        public IActionResult FoodDetail(int? id)
        {
            FoodDto food = foodService.Get(id.ToString());
            var order = new FoodViewModel { Id = food.Id, Category = food.Category, Componets = food.Componets, ExtraInfo = food.ExtraInfo, Name = food.Name, Price = food.Price, Weight = food.Weight };

            return View(order);
        }

        public IActionResult Cart(string Id)
        {
      
          
            return this.RedirectToAction("Index", "Cart",new { id = Id} );
        }
    }
}

