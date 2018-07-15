using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls.Expressions;
using GetMePro.Models;

namespace GetMePro.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "(ТУТ БУДЕТ ИНФОРМАЦИЯ О ПРОЕКТЕ)";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Контактная информация:";

            return View();
        }

        [HttpGet]
        public ActionResult SpecialistPanel()
        { 

            return View();
        }

        [HttpGet]
        public ActionResult SearchSpecialist()
        {
            ListsDropDownModels items = new ListsDropDownModels();

            ViewBag.ItemsArea = items.ItemsArea;
            ViewBag.ItemsCategoryServises = items.ItemsCategoryServise;
            ViewBag.ItemsCategoryWork = items.ItemsCategoryWork;

            return View();
        }

        [HttpPost]
        public ActionResult SearchSpecialist(SearchViewModels model)
        {
            IEnumerable<ApplicationUser> users;

            if (model.Area == "Все районы")
            {
                 users = context.Users.OrderByDescending(x => x.CreateDate);
            }
            else
            {
                 users = context.Users.Where(u => u.Area == model.Area).OrderByDescending(x => x.CreateDate);
            }

            ViewBag.UsersCount = users.Count();
            
            return View("SearchSpecialistResult", users);
        }

        public ActionResult ForSpecialistInfo()
        {
            return View();
        }

        public ActionResult ForApplicantInfo()
        {
            return View();
        }

        public ActionResult OtherInfo()
        {
            return View();
        }

        public ActionResult LegalInformation()
        {
            return View();
        }
    }
}