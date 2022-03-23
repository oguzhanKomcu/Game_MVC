using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Game_MVC.Models.Entities
{

    public class Category : BaseEntity
    {
        public string Name { get; set; }

        public virtual List<Game> Games { get; set; }
    }
}