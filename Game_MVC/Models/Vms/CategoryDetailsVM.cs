using Game_MVC.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Game_MVC.Models.Vms
{
    public class CategoryDetailsVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public Status Status { get; set; }
    }
}