using GroceryProject.Dal.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.FileProviders;

namespace GroceryProject.Models
{
    public class ItemModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public IFormFile ImageUrl { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

    }
}
