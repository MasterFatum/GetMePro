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

        [HttpGet]
        public ActionResult SpecialistPanel()
        { 

            return View();
        }

        [HttpGet]
        public ActionResult SearchSpecialist()
        {
            return View();
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
    }
}