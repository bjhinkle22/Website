using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "I am learning to code each day more and more by doing simple projects at home.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Feel free to reach me anytime, or connect with me on LinkedIn.";

            return View();
        }
    }
}