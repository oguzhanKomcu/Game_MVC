using Game_MVC.DataAccess;
using Game_MVC.DataAccess.Repositories.EntityType;
using Game_MVC.Models.Dto;
using Game_MVC.Models.Entities;
using Game_MVC.Models.Vms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Game_MVC.Controllers
{
    public class CategoryController : Controller
    {
        CategoryRepository categoryRepository = new CategoryRepository();

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(CategoryCreateDTO model)
        {
            if (ModelState.IsValid) 
            {
                
                Category category = new Category();
                category.Name = model.Name;
                categoryRepository.Create(category); 
                ViewBag.Condition = 1;
                return View();
               
            }
            else
            {
                ViewBag.Condition = 2;
                return View(model);
            }
        }


        public ActionResult List()
        {
            IEnumerable<CategoryListVM> categories = categoryRepository.Gets(x => x.Status != Status.Passive)
                                                                    .Select(x => new CategoryListVM
                                                                    {
                                                                        Id = x.Id,
                                                                        Name = x.Name
                                                                    });

            return View(categories);
        }

        public ActionResult Details(int id)
        {
            
            Category category = categoryRepository.Get(x => x.Id == id);
           
            CategoryDetailsVM detailsVM = new CategoryDetailsVM();
            detailsVM.Id = category.Id;
            detailsVM.Name = category.Name;
            detailsVM.Status = category.Status;
            detailsVM.CreateDate = category.CreateDate;
            return View(detailsVM);
        }

     
        [HttpGet] 
        public ActionResult Update(int id)
        {
            Category category = categoryRepository.Get(x => x.Id == id);

          
            CategoryUpdateDTO model = new CategoryUpdateDTO();
            model.Id = category.Id;
            model.Name = category.Name;

            return View(model);
        }

      
        [HttpPost]
        public ActionResult Update(CategoryUpdateDTO model)
        {
            if (ModelState.IsValid)
            {
                Category category = categoryRepository.Get(x => x.Id == model.Id);
                category.Name = model.Name;
                category.UpdateDate = model.UpdateDate;
                category.Status = model.Status;
                ViewBag.Condition = 1;
                categoryRepository.Update(category);
                return RedirectToAction("List");
            }
            else
            {
                ViewBag.Condition = 2;
                return View(model);
            }
        }


        public ActionResult Delete(int id)
        {
            Category category = categoryRepository.Get(x => x.Id == id);
            category.Status = Status.Passive;
            category.DeleteDate = DateTime.Now;
            ViewBag.Condition = 1;
            categoryRepository.Delete(category);

            return RedirectToAction("List");
        }
    }
}