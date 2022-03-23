using Game_MVC.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Game_MVC.DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
            Database.Connection.ConnectionString = @"Server= DESKTOP-97DV3CH\SQLEXPRESS; Database = Game_Db_Mvc ;Integrated Security=True;";
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Game> Games { get; set; }
    }
}