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

namespace FoodTime.Controllers
{
    public class CartController : Controller
    {
        IFoodService foodService;
        ICartMService cartMService;

        Cart cart = new Cart();
        public CartController(IFoodService serv, ICartMService cartMs)
        {
            foodService = serv;
            cartMService = cartMs;
        }

        public IActionResult Index(string id)
        {

            List<CartLine> cl = new List<CartLine>();
            if (cartMService.Get() != null)
            {
                List<FoodDto> foodDtos = new List<FoodDto>();
                IEnumerable<CartMDto> cartDtos = cartMService.Get();

                List<int> quantities = new List<int>();
                foreach (CartMDto c in cartDtos)
                    quantities.Add(c.Quanity);
                foreach (CartMDto c in cartDtos)
                    foodDtos.Add(foodService.Get(c.Id.ToString()));

                for (int i = 0; i < foodDtos.Count; i++)
                {
                    CartLine l = new CartLine();
                    l.Food = foodDtos[i];
                    l.Quantity = quantities[i];
                    cl.Add(l);
                }
            }
            else
            {
                cl = null;
            }
            if (cartMService.Get(id.ToString()) != null)
            {
                CartMDto temp = cartMService.Get(id.ToString());
                temp.Quanity += 1;
                cartMService.Update(temp);
            }
            else
            {
                CartMDto temp = new CartMDto();
                temp.Id = Convert.ToInt32(id);
                temp.Quanity = 1;
                cartMService.Add(temp);
            }
            cart.AddItem(foodService.Get(id), 1, cl);
            return View(cart);
        }

    }
}