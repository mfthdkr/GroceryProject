using System.Collections.Generic;
using System.Linq;
using GroceryProject.Dal;
using Microsoft.EntityFrameworkCore;

namespace GroceryProject.EntityFramework
{
    public class RepositoryBase<TEntity> where TEntity : class, new()
    {
        private GroceryContext groceryContext = new GroceryContext();

        public TEntity Get(int entityId)
        {
            return groceryContext.Set<TEntity>().Find(entityId);
        }
        public List<TEntity> GetList()
        {
            return groceryContext.Set<TEntity>().ToList();
        }
        public List<TEntity> GetList(string entityToInclude)
        {
            return groceryContext.Set<TEntity>().Include(entityToInclude).ToList();
        }
        public void Add(TEntity tEntity)
        {
            groceryContext.Set<TEntity>().Add(tEntity);
            groceryContext.SaveChanges();
        }

        public void Delete(TEntity tEntity)
        {
            groceryContext.Set<TEntity>().Remove(tEntity);
            groceryContext.SaveChanges();
        }

        public void Update(TEntity tEntity)
        {
            groceryContext.Set<TEntity>().Update(tEntity);
            groceryContext.SaveChanges();
        }
    }
}
