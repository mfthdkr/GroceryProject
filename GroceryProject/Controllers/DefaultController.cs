using System.Linq;
using GroceryProject.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GroceryProject.Controllers
{
    public class DefaultController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult CategoryDetails(int id)
        {
            ViewBag.vb1= id;

            return View();
        }
    }
}
