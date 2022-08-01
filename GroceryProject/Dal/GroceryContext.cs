using GroceryProject.Dal.Entities;
using Microsoft.EntityFrameworkCore;

namespace GroceryProject.Dal
{
    public class GroceryContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"server=(localdb)\MSSQLLocalDB;database= GroceryDb; integrated security = true");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
