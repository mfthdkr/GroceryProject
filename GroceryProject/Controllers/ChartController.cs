using System.Collections.Generic;
using System.Linq;
using GroceryProject.Dal.Entities;
using GroceryProject.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace GroceryProject.Controllers
{
    public class ChartController : Controller
    {   
        ItemRepository itemRepository = new ItemRepository();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult VisualizeItem()
        {
            return Json(ItemList());
        }

        public List<Chart> ItemList()
        {
            List<Chart> charts = new List<Chart>();
            charts = itemRepository.GetList().Select(p => new Chart
            {
                ItemName = p.Name,
                Stock = p.Stock,
            }).ToList();

            return charts;
        }

    }
}
