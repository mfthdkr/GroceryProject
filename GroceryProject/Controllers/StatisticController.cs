using System.Linq;
using GroceryProject.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace GroceryProject.Controllers
{
    public class StatisticController : Controller
    {   
        ItemRepository itemRepository = new ItemRepository();
        CategoryRepository categoryRepository= new CategoryRepository();
        public IActionResult Index()
        {
            ViewBag.vb1 = itemRepository.GetList().Count;
            ViewBag.vb2 =categoryRepository.GetList().Count;
            ViewBag.vb3 = itemRepository.GetList("Category").Where(p => p.Category.CategoryName == "Fruit").ToList().Count;
            ViewBag.vb4 = itemRepository.GetList("Category").Where(p => p.Category.CategoryName == "Fruit").Sum(p=>p.Stock);
            return View();
        }
    }
}
