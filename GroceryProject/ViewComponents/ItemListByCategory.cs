using System.Linq;
using GroceryProject.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace GroceryProject.ViewComponents
{
    public class ItemListByCategory: ViewComponent
    {
        public IViewComponentResult Invoke(int id )
        {
            ItemRepository itemRepository = new ItemRepository();
            var itemList = itemRepository.GetList(p => p.CategoryId == id);
            return View(itemList);
        }
    }
}
