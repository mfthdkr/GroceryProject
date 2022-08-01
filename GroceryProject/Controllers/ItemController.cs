using System.Collections.Generic;
using System.Linq;
using GroceryProject.Dal.Entities;
using GroceryProject.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Internal;
using X.PagedList;

namespace GroceryProject.Controllers
{
    public class ItemController: Controller
    {
        ItemRepository itemRepository = new ItemRepository();
        CategoryRepository categoryRepository = new CategoryRepository();
        public IActionResult Index(int page= 1)
        {   
            return View(itemRepository.GetList("Category").ToPagedList(page,3));
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

        public IActionResult Update(int itemId)
        {
            List<SelectListItem> categoryList = categoryRepository.GetList().Select(p => new SelectListItem()
            {
                Text = p.CategoryName,
                Value = p.CategoryId.ToString()
            }).ToList();
            ViewBag.CategoryList = categoryList;

            var entity = itemRepository.Get(itemId);

            return View(entity);
        }
        [HttpPost]
        public IActionResult Update(Item item)
        {
            //var entityToUpdate = itemRepository.Get(item.Id);
            //entityToUpdate.Id = item.Id;
            //entityToUpdate.CategoryId = item.CategoryId;
            //entityToUpdate.ImageUrl = item.ImageUrl;
            //entityToUpdate.Name = item.Name;
            //entityToUpdate.Description = item.Description;
            //entityToUpdate.Price = item.Price;
            //entityToUpdate.Stock = item.Stock;
            itemRepository.Update(item);

            return RedirectToAction("Index");
        }
    }
}
