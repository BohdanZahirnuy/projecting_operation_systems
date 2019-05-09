using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services.BusinessClasses;
using Services.Interfaces;

namespace FoodTime.Controllers
{
    public class CartController : Controller
    {
        IFoodService serv;
        Cart cart;
        public IActionResult Index( string id)
        {
            //serv = _serv;
            //cart = new Cart(serv);
            //cart.Add(id);
            ViewBag.id = id;
            return View(cart);
        }
    }
}