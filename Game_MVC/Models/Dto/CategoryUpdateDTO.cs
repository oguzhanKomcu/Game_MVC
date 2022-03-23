using Game_MVC.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Game_MVC.Models.Dto
{
    public class CategoryUpdateDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please type into category name")]
        [MinLength(3, ErrorMessage = "Minimum length is 3")]
        [RegularExpression(@"[a-zA-Z ]+$", ErrorMessage = "Only letters ars allowed")]
        public string Name { get; set; }

        public DateTime UpdateDate => DateTime.Now;

        public Status Status => Status.Modified;
    }
}