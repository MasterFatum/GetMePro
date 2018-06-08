using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GetMePro.Controllers
{
    public class HomeController : Controller
    {
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
    }
}