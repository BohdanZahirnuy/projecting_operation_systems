using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Services.BusinessClasses;
using Microsoft.AspNetCore.Http;

namespace FoodTime.Controllers
{
    public class CartController : Controller
    {
        IFoodService foodService;
        Cart cart = new Cart();
        public CartController(IFoodService serv)
        {
            foodService = serv;

        }

        public IActionResult Index(string id)
        {


            cart.AddItem(foodService.Get(id), 1);
            return View(cart);
        }

    }
}