using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstMvcApp.Models;

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
        public ActionResult Cry(string baby, int sleepTime)
        {
            //return Content(baby + "  is crying!");
            //return View();
            var myBaby = new Baby()
            {
                Name = baby,
                SleepTime = sleepTime

            };
            return View(myBaby);

        }
        //test using query string parameter
        public ActionResult Sleep(string baby, int hours)
        {
            //return Content(baby + " was sleeping for " + hours + " hours!");
            var babySleepTime = new Baby()
            {
                Name = baby,
                SleepTime = hours
            };
            return View(babySleepTime);
        }
    }
}