using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace www.bitcoin.com.au.Controllers
{
    public class GuidesController : Controller
    {
        //
        // GET: /Guides/

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Certificate_Authority()
        {
            return View();
        }

    }
}
