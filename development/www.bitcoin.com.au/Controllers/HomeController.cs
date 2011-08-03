using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace www.bitcoin.com.au.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to the Bitcoin Australia Site";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult CA()
        {
            return View();
        }
    }
}
