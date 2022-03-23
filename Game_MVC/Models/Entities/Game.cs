using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Game_MVC.Models.Entities
{
    public class Game :BaseEntity
    {

        public string Name { get; set; }

        public string Platform { get; set; }

        public string Dimension { get; set; }
        public string Release_Date { get; set; }

        public string Language { get; set; }
        public string Developer_Company { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }







    }
}