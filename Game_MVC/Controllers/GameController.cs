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
    public class GameController : Controller
    {
        GameRepository gameRepository = new GameRepository();
        CategoryRepository categoryRepository = new CategoryRepository();   
        AppDbContext db = new AppDbContext();

        [HttpGet]
        public ActionResult Add()
        {
            GameCreateDTO model = new GameCreateDTO();
            model.Categories = categoryRepository.Gets(x => x.Status != Status.Passive)
                .Select(x => new CategoryListVM
                { Id = x.Id, Name = x.Name });





            //return View(model);

            return View(model);
        }

        [HttpPost]
        public ActionResult Add(GameCreateDTO model)
        {
            if (ModelState.IsValid)
            {

                Game game = new Game();
                game.Name = model.Name;
                game.Platform = model.Platform;
                game.Language = model.Language;
                game.Dimension = model.Dimension;
                game.CategoryId = model.CategoryId;
                game.Developer_Company = model.Developer_Company;
                game.Release_Date = model.Release_Date;




                gameRepository.Create(game);
                ViewBag.Condition = 1;
                return RedirectToAction("Add"); // yanlış ve ya doğru olursa direk en baştan add yapıp get methodunu çalıştıracak..Yanlış olma durumunda cetegori boş dönüceği için eklenemiyecek..Bu yüzden tekrar add methodunu cagır dedik.



            }
            else
            {
                ViewBag.Condition = 2;

                return RedirectToAction("Add");
            }




        }
        [HttpGet]
        public ActionResult List()
        {
            
            List<Game> games = gameRepository.Gets(x => x.Status != Status.Passive);



            return View(games);
        }



        [HttpGet]
        public ActionResult Details(int id)
        {
            Game game = gameRepository.Get(x => x.Id == id);
           GameDetailsVM gameDetailsVM = new GameDetailsVM();

            gameDetailsVM.Name = game.Name;
            gameDetailsVM.Platform = game.Platform;
            gameDetailsVM.Dimension = game.Dimension;
            gameDetailsVM.Release_Date = game.Release_Date;
            gameDetailsVM.Language = game.Language;
            gameDetailsVM.Developer_Company = game.Developer_Company;
            gameDetailsVM.CreateDate = game.CreateDate;
            gameDetailsVM.Status = game.Status;


            return View(gameDetailsVM);
        }

        [HttpGet]
        public ActionResult Update(int id)
        {

            Game game = gameRepository.Get(x => x.Id == id);

            GameUpdateDTO model = new GameUpdateDTO();
            model.Categories = categoryRepository.Gets(x => x.Status != Status.Passive)
              .Select(x => new CategoryListVM
              { Id = x.Id, Name = x.Name });
            game.Name = model.Name;
            game.Platform = model.Platform;
            game.Dimension = model.Dimension;
            game.Release_Date = model.Release_Date;
            game.Language = model.Language;
            game.Developer_Company = model.Developer_Company;

            return View(model);

        }

        [HttpPost]
        public ActionResult Update(GameUpdateDTO model)
        {

            if (ModelState.IsValid)
            {
                Game game = gameRepository.Get(x => x.Id == model.Id);
                game.Name = model.Name;
                game.Platform = model.Platform;
                game.Dimension = model.Dimension;
                game.Release_Date = model.Release_Date;
                game.Language = model.Language;
                game.Developer_Company = model.Developer_Company;
                game.UpdateDate = model.UpdateDate;

                game.Status = model.Status;

                ViewBag.Condition = 1;
                gameRepository.Update(game);

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
            Game game = gameRepository.Get(x => x.Id == id);
            game.Status = Status.Passive;
            game.DeleteDate = DateTime.Now;

            gameRepository.Delete(game);
            return RedirectToAction("List");
            // list sayfasını tetikliyecek ve sayfa yenileek otomatikmen... DİKKAT VE LİST METHODUMUZ TEKRAR TETİKLENECEK !!!!!!!!!!!!!!!!!!!!!!!!!!!

        }

    }
}