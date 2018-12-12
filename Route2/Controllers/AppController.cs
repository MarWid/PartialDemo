using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Route2.Controllers
{
    public class AppController : Controller
    {
        [HttpGet]
        [Route("~/")]
        [Route("~/Forside")]
        public ActionResult Index() // <-- Metode
        {
            return View();
        }


        [HttpGet]
        [Route("~/Salg/{kundeid:int}")]
        public ActionResult Salg(int kundeid) // <-- Metode
        {
            ViewBag.kundeid = kundeid;
            return View();
        }

    }
}


