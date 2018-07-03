using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMvcApp.Controllers
{
    public class BabyController : Controller
    {
        // GET: Baby
        public ActionResult Index()
        {
            return View();
        }
        //embed parameter in URL
        public ActionResult Cry(string baby)
        {
            return Content(baby + "  is crying!");
        }
        //test using query string parameter
        public ActionResult Sleep(string baby, int hours)
        {
            return Content(baby + " was sleeping for " + hours + " hours!");
        }
    }
}