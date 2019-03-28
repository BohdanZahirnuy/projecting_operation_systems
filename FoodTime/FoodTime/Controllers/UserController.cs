using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodTime.Models;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FoodTime.Controllers
{
    [Route("user")]
    public class UserController : Controller
    {
        private DataContext db = new DataContext();

        [Route("")]
        [Route("users")]
        [Route("~/")]
        // GET: /<controller>/
        public IActionResult Index()
        {

            ViewBag.users = db.Users.ToList();
            return View();
        }
    }
}
