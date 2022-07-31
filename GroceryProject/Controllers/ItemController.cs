using GroceryProject.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;

namespace GroceryProject.Controllers
{
    public class ItemController: Controller
    {
        ItemRepository itemRepository = new ItemRepository();

        public IActionResult Index()
        {   
            return View(itemRepository.GetList("Category"));
        }
    }
}
