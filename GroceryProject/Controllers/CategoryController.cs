using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using GroceryProject.Dal.Entities;
using GroceryProject.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GroceryProject.Controllers
{
    [Authorize]

    public class CategoryController : Controller
    {
        CategoryRepository categoryRepository = new CategoryRepository();
        public IActionResult Index()
        {   
            return View(categoryRepository.GetList().Where(p=>p.Status==true).ToList());
        }

        public IActionResult Create()
        {   
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category category)
        {   
            if(!ModelState.IsValid) return View("Create");

            categoryRepository.Add(category);
            return RedirectToAction("Index");
        }

        public IActionResult Update(int categoryId)
        {
            var entity = categoryRepository.Get(categoryId);
            
            return View(entity);
        }

        [HttpPost]
        public IActionResult Update(Category category)
        {
            //var entity = categoryRepository.Get(category.CategoryId);
            //entity.CategoryName= category.CategoryName;
            //entity.Description = category.Description;
            //entity.Status = true;
            category.Status = true;
            categoryRepository.Update(category);
            
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int categoryId)
        {
            var category = categoryRepository.Get(categoryId);
            category.Status =false;
            categoryRepository.Update(category);
            return RedirectToAction("Index");
        }
    }
}
