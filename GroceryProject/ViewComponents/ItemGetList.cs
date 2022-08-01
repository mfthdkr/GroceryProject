using GroceryProject.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace GroceryProject.ViewComponents
{
    public class ItemGetList : ViewComponent
    {
        private ItemRepository itemRepository = new ItemRepository();

        public IViewComponentResult Invoke()
        {
            var result = itemRepository.GetList();
            return View(result);
        }
    }
}
