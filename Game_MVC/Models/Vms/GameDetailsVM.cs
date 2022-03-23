using Game_MVC.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Game_MVC.Models.Vms
{
    public class GameDetailsVM
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Platform { get; set; }

        public string Dimension { get; set; }
        public string Release_Date { get; set; }

        public string Language { get; set; }
        public string Developer_Company { get; set; }


        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime DeleteDate { get; set; }

        public Status Status { get; set; }






    }
}