using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace codermvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.abc = "Hii coder";
            ViewBag.test = 1234;
            ViewBag.test1 = 23.5f;
            ViewBag.test2 = DateTime.Now;
            ViewBag.list = new List<string>()
            {
                "India",
                "Pak",
                "USA"
            };

            ViewData["abc"] = "View Data value";
            ViewData["test"] = 8888;
            ViewData["test1"] = 11.7f;
            ViewData["test2"] = 34.98;
            ViewData["test3"] = DateTime.Now;
            ViewData["ListData"] = new List<String>()
            {
                "India",
                "Pak",
                "USA"
            };

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();

        }
        public ActionResult Test()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}