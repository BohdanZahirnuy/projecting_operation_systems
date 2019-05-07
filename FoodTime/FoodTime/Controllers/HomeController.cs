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
        public IActionResult Index()
        {

            IEnumerable<FoodDto> foodDtos = foodService.Get();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<FoodDto, FoodViewModel>()).CreateMapper();
            var food = mapper.Map<IEnumerable<FoodDto>, List<FoodViewModel>>(foodDtos);
            return  View(food);

        }


    }
}
