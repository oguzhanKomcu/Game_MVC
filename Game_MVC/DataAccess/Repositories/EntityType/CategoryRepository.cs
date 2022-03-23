using Game_MVC.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Game_MVC.DataAccess.Repositories.EntityType
{
    public class CategoryRepository : IBaseRepository<Category>
    {
        AppDbContext db = new AppDbContext();

        public void Create(Category entity)
        {
            db.Categories.Add(entity);
            db.SaveChanges();
        }

        public void Delete(Category entity)
        {
            db.SaveChanges();
        }

        public Category Get(Expression<Func<Category, bool>> exp)
        {
            return db.Categories.FirstOrDefault(exp);
        }

        public List<Category> Gets(Expression<Func<Category, bool>> exp)
        {
            return db.Categories.Where(exp).ToList();
        }

        public void Update(Category entity)
        {
            db.SaveChanges();
        }
    }
}