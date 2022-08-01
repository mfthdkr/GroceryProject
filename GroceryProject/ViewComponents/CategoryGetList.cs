using GroceryProject.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace GroceryProject.ViewComponents
{
    public class CategoryGetList : ViewComponent
    {
        CategoryRepository categoryRepository = new CategoryRepository();

        public IViewComponentResult Invoke()
        {
            var result = categoryRepository.GetList();
            return View(result);
        }
    }
}
