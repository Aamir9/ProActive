using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProActive.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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
        public ActionResult Faqs()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Gallery()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Services()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Single()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }



        public ActionResult Accomodation()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Property()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Relocation()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Management()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult PRS()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}