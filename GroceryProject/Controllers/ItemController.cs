using System.Collections.Generic;
using System.Linq;
using GroceryProject.Dal.Entities;
using GroceryProject.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Internal;

namespace GroceryProject.Controllers
{
    public class ItemController: Controller
    {
        ItemRepository itemRepository = new ItemRepository();
        CategoryRepository categoryRepository = new CategoryRepository();
        public IActionResult Index()
        {   
            return View(itemRepository.GetList("Category"));
        }

        public IActionResult Create()
        {
            List<SelectListItem> categoryList = categoryRepository.GetList().Select(p => new SelectListItem()
            {
                Text = p.CategoryName,
                Value = p.CategoryId.ToString()
            }).ToList();
            ViewBag.CategoryList = categoryList;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Item item)
        {
            itemRepository.Add(item);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int itemId)
        {
            itemRepository.Delete(new Item{Id = itemId});
            return RedirectToAction("Index");
        }
    }
}
