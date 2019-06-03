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
        ICommentService commentService;
        public HomeController(IFoodService serv, ICommentService commentServ)
        {
            foodService = serv;
            commentService = commentServ;
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
                food = food.Where(s => s.Name.ToLower().Contains(searchString.ToLower())
                                       || s.Componets.ToLower().Contains(searchString.ToLower())
                                       || s.ExtraInfo.ToLower().Contains(searchString.ToLower())).ToList();
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

            // comments
            IEnumerable<CommentDto> commentDtos = commentService.Get();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<CommentDto, CommentViewModel>()).CreateMapper();
            var comments = mapper.Map<IEnumerable<CommentDto>, List<CommentViewModel>>(commentDtos);
            var _comments = new List<CommentViewModel>();
            foreach (var com in comments)
            {
                if (com.FoodId == order.Id)
                {
                    _comments.Add(com);
                }
            }
            _comments = _comments.OrderBy(x => x.Date).ToList();
            order.comments = _comments;
            return View(order);
        }

        public IActionResult Cart(string Id)
        {
            return this.RedirectToAction("Add", "Cart", new { id = Id });
        }

        public IActionResult CartIndex()
        {
            return this.RedirectToAction("Index", "Cart");
        }
        [HttpPost]
        public IActionResult Comment(CommentViewModel vm)
        {
            vm.Date = DateTime.Now;
            vm.UserName = User.Identity.Name;
            if (ModelState.IsValid)
            {
                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<CommentViewModel, CommentDto>()).CreateMapper();
                var _comment = mapper.Map<CommentViewModel, CommentDto>(vm);
                commentService.Add(_comment);
                return RedirectToAction(vm.FoodId.ToString(), "Home/FoodDetail");
            }
            else
            {
                return View(vm.FoodId.ToString(), "Home/FoodDetail");
            }
        }

        public IActionResult Delete(int id, string postId)
        {
            string _postId = postId;
            commentService.Remove(id.ToString());
            return this.RedirectToAction( _postId, "Home/FoodDetail");
        }
    }
}

