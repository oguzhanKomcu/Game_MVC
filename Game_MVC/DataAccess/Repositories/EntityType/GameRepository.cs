using Game_MVC.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Game_MVC.DataAccess.Repositories.EntityType
{
    public class GameRepository : IBaseRepository<Game>
    {
        AppDbContext db = new AppDbContext();

        public void Create(Game entity)
        {
            db.Games.Add(entity);
            db.SaveChanges();
        }

        public void Delete(Game entity)
        {
            db.SaveChanges();
        }

        public Game Get(Expression<Func<Game, bool>> exp)
        {
            return db.Games.FirstOrDefault(exp);
        }

        public List<Game> Gets(Expression<Func<Game, bool>> exp)
        {
            return db.Games.Where(exp).ToList();
        }

        public void Update(Game entity)
        {
            db.SaveChanges();
        }
    }
}