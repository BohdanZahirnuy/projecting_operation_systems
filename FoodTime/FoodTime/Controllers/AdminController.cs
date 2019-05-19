using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoodTime.Models;
using Services.Dto;
using Services.Implementation;
using Services.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;

namespace FoodTime.Controllers
{

    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
        IFoodService foodService;

        public AdminController(IFoodService serv)
        {
            foodService = serv;
        }
        public IActionResult Index()
        {
            IEnumerable<FoodDto> foodDtos = foodService.Get();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<FoodDto, FoodViewModel>()).CreateMapper();
            var food = mapper.Map<IEnumerable<FoodDto>, List<FoodViewModel>>(foodDtos);
            return View(food);
        }
        [HttpGet]
        public ViewResult Edit(int id)
        {
            FoodDto food = foodService.Get(id.ToString());
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<FoodDto, FoodViewModel>()).CreateMapper();
            var _food = mapper.Map<FoodDto, FoodViewModel>(food);
            return View(_food);

        }

        [HttpPost]
        public ActionResult Edit(FoodViewModel food)
        {
            if (ModelState.IsValid)
            {
                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<FoodViewModel, FoodDto>()).CreateMapper();
                var _food = mapper.Map<FoodViewModel, FoodDto>(food);
                foodService.Update(_food);
                return RedirectToAction("Index");
            }
            else
            {
                return View(food);
            }
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View("Edit", new FoodViewModel());
        }
        [HttpPost]
        public ActionResult Create(FoodViewModel food)
        {
            if (ModelState.IsValid)
            {
                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<FoodViewModel, FoodDto>()).CreateMapper();
                var _food = mapper.Map<FoodViewModel, FoodDto>(food);
                foodService.Add(_food);
                return RedirectToAction("Index");
            }
            else
            {
                return View(food);
            }
        }

        public IActionResult Delete(int id)
        {
            foodService.Remove(id.ToString());
            return RedirectToAction("Index");
        }

        public IActionResult Details(int? id)
        {
            FoodDto food = foodService.Get(id.ToString());
            var order = new FoodViewModel { Id = food.Id, Category = food.Category, Componets = food.Componets, ExtraInfo = food.ExtraInfo, Name = food.Name, Price = food.Price, Weight = food.Weight };

            return View(order);
        }
    }
}