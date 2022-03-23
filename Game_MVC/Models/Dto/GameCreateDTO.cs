using Game_MVC.Models.Entities;
using Game_MVC.Models.Vms;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Game_MVC.Models.Dto
{
    public class GameCreateDTO
    {
       

        [Required(ErrorMessage = "Please type into category name")]
        [MinLength(3, ErrorMessage = "Minimum length is 3")]

        public string Name { get; set; }


        [Required(ErrorMessage = "Please type into category name")]
        [MinLength(3, ErrorMessage = "Minimum length is 3")]

        public string Platform { get; set; }


        [Required(ErrorMessage = "Please type into category name")]
        [MinLength(3, ErrorMessage = "Minimum length is 3")]

        public string Dimension { get; set; }


        [Required(ErrorMessage = "Please type into category name")]
        [MinLength(3, ErrorMessage = "Minimum length is 3")]

        public string Release_Date { get; set; }


        [Required(ErrorMessage = "Please type into category name")]
        [MinLength(3, ErrorMessage = "Minimum length is 3")]
        [RegularExpression(@"[a-zA-Z ]+$", ErrorMessage = "Only letters ars allowed")]


        public string Language { get; set; }


        [Required(ErrorMessage = "Please type into category name")]
        [MinLength(3, ErrorMessage = "Minimum length is 3")]


        public string Developer_Company { get; set; }

        [Required(ErrorMessage = "Please type inti category name")]

        public int CategoryId { get; set; }
        public IEnumerable<CategoryListVM> Categories { get; set; }








    }
}