﻿using Game_MVC.Models.Entities;
using Game_MVC.Models.Vms;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Game_MVC.Models.Dto
{
    public class GameUpdateDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please type into category name")]
        [MinLength(3, ErrorMessage = "Minimum length is 3")]
        [RegularExpression(@"[a-zA-Z ]+$", ErrorMessage = "Only letters ars allowed")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Please type into category name")]
        [MinLength(3, ErrorMessage = "Minimum length is 3")]
        [RegularExpression(@"[a-zA-Z ]+$", ErrorMessage = "Only letters ars allowed")]

        public string Platform { get; set; }


        [Required(ErrorMessage = "Please type into category name")]
        [MinLength(3, ErrorMessage = "Minimum length is 3")]
        [RegularExpression(@"[a-zA-Z ]+$", ErrorMessage = "Only letters ars allowed")]

        public string Dimension { get; set; }


        [Required(ErrorMessage = "Please type into category name")]
        [MinLength(3, ErrorMessage = "Minimum length is 3")]
        [RegularExpression(@"[a-zA-Z ]+$", ErrorMessage = "Only letters ars allowed")]
        public string Release_Date { get; set; }


        [Required(ErrorMessage = "Please type into category name")]
        [MinLength(3, ErrorMessage = "Minimum length is 3")]
        [RegularExpression(@"[a-zA-Z ]+$", ErrorMessage = "Only letters ars allowed")]

        public string Language { get; set; }


        [Required(ErrorMessage = "Please type into category name")]
        [MinLength(3, ErrorMessage = "Minimum length is 3")]
        [RegularExpression(@"[a-zA-Z ]+$", ErrorMessage = "Only letters ars allowed")]

        public string Developer_Company { get; set; }


        public DateTime UpdateDate => DateTime.Now;

        public Status Status => Status.Modified;



        public int CategoryId { get; set; }
        public IEnumerable<CategoryListVM> Categories { get; set; }



    }
}