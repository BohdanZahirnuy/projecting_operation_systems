using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Services.BusinessClasses;
using Microsoft.AspNetCore.Http;
using Services.Implementation;
using Services.Dto;
using AutoMapper;
using System.Collections.Generic;
using System;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;

namespace FoodTime.Controllers
{
    public class CartController : Controller
    {
        IFoodService foodService;
        ICartMService cartMService;
        UserManager<IdentityUser> userManager;
        Cart cart = new Cart();
        public CartController(IFoodService serv, ICartMService cartMs, UserManager<IdentityUser> _userManager)
        {

            foodService = serv;
            cartMService = cartMs;
            userManager = _userManager;
        }

        public async Task<IActionResult> Index()
        {

            var user = await userManager.GetUserAsync(User);
            string email = user.Email;
            List<CartLine> cl = new List<CartLine>();
            if (cartMService.GetList(email) != null)
            {
                IEnumerable<CartMDto> cartMDtos = cartMService.GetList(email);
                foreach (var v in cartMDtos)
                {
                    CartLine l = new CartLine();
                    l.Food = foodService.Get(v.FoodId.ToString());
                    l.Quantity = v.Quanity;
                    cl.Add(l);
                }
                cart.Lines = cl;
            }
            else
            {
                return View("EmptyCart");
            }
            return View(cart);
            //return View();
        }
        public async Task<IActionResult> Add(string id)
        {

            var user = await userManager.GetUserAsync(User);
            string email = user.Email;
            List<CartLine> cl = new List<CartLine>();

            if (cartMService.GetFood(id, email) != null)
            {
                CartMDto temp = cartMService.GetFood(id, email);
                temp.Quanity += 1;
                cartMService.Update(temp);
            }
            else
            {
                CartMDto temp = new CartMDto();
                temp.FoodId = Convert.ToInt32(id);
                temp.UserId = email;
                temp.Quanity = 1;
                cartMService.Add(temp);
            }

            return this.RedirectToAction("Index");

        }
        public async Task<IActionResult> Remove(string id)
        {

            var user = await userManager.GetUserAsync(User);
            string email = user.Email;
            List<CartLine> cl = new List<CartLine>();


            CartMDto temp = cartMService.GetFood(id, email);
            cartMService.RemoveFood(id, email);


            return this.RedirectToAction("Index");

        }

    }
}