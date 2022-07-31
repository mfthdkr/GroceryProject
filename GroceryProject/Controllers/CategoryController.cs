using GroceryProject.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace GroceryProject.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {   
            CategoryRepository categoryRepository = new CategoryRepository();
            return View(categoryRepository.GetList());
        }
    }
}
