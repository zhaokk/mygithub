using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_321.Controllers
{
    public class HomeController : Controller
    {
        //action methods
        public ActionResult Index()
        {
            return View();
        }

        public string  About()
        {
           // ViewBag.Message = "Your application description page.";

            return "this is the home contoller";
        }

        public ActionResult userlist()
        {
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            ViewBag.Message2 = "hahahah";

            return View();
        }
    }
}