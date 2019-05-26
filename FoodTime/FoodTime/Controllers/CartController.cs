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
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http;

namespace FoodTime.Controllers
{
    public class CartController : Controller
    {
        IFoodService foodService;
        ICartMService cartMService;
        UserManager<IdentityUser> userManager;
        IOrderService orderService;
        IUserService userService;
        Cart cart = new Cart();
        public CartController(IFoodService serv, ICartMService cartMs, UserManager<IdentityUser> _userManager, IOrderService _orderService, IUserService _userService)
        {
            orderService = _orderService;
            foodService = serv;
            cartMService = cartMs;
            userManager = _userManager;
            userService = _userService;
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
        public async Task<IActionResult> PlusQuantity(string id)
        {
            var user = await userManager.GetUserAsync(User);
            string email = user.Email;
            CartMDto temp = cartMService.GetFood(id, email);
            temp.Quanity += 1;
            cartMService.Update(temp);
            return this.RedirectToAction("Index");
        }
        public async Task<IActionResult> MinusQuantity(string id)
        {
            var user = await userManager.GetUserAsync(User);
            string email = user.Email;
            CartMDto temp = cartMService.GetFood(id, email);
            if (temp.Quanity > 1)
                temp.Quanity -= 1;
            else
                return this.RedirectToAction("Index");
            cartMService.Update(temp);
            return this.RedirectToAction("Index");
        }

        public async Task<IActionResult> MakeOrder()
        {
            var user = await userManager.GetUserAsync(User);
            string name = user.UserName;
            OrderDto order = new OrderDto();
            UserDto userdto = new UserDto();
            userdto = userService.Get(user.UserName);
            order.User = userdto.UserName;
            order.Address = userdto.Address;
            order.Date = DateTime.Now;
            string info = "";
            List<CartMDto> cl = cartMService.GetList(userdto.Email).ToList();
            for (int i = 0; i < cl.Count(); i++)
            {
                info += foodService.Get(cl[i].FoodId.ToString()).Name + " x" + cl[i].Quanity.ToString() + ' ';
            }
            order.Info = info;
            orderService.Add(order);
            cartMService.RemoveList(userdto.Email);
            return View("Order");
        }
    }
}