using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GroceryProject.Dal.Entities
{
    public class Category
    {

        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Boş geçilemez")]
        [StringLength(20,ErrorMessage = "En fazla 20 karakter kullanınız.")]
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public List<Item> Items { get; set; }
    }
}
