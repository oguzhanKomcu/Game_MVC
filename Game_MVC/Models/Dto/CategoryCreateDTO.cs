using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Game_MVC.Models.Dto
{
    public class CategoryCreateDTO
    {
        [Required(ErrorMessage = "Please type into category name")]
        [MinLength(3, ErrorMessage = "Minimum length is 3")]
        [RegularExpression(@"[a-zA-Z ]+$", ErrorMessage = "Only letters ars allowed")] 
        [Display(Name = "Category Name")]
        public string Name { get; set; }
    }
}