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

namespace FoodTime.Controllers
{
    public class HomeController : Controller
    {
       /* IFoodService foodService;
        public HomeController(IFoodService serv)
        {
            foodService = serv;
        }*/
        public IActionResult Index()
        {
            // IEnumerable<FoodDto> foodDtos = foodService.Get("");
            return  View("Index");

        }


    }
}
