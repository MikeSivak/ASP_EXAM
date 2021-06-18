using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_APP.Controllers
{
    public class FITController : Controller
    {
        // GET: FIT
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Search()
        {
            return View("Search");
        }


        [HttpGet]
        public ActionResult GetParm()
        {
            return View("GetParm");
        }

        [HttpPost]
        public ActionResult ParmSave()
        {
            return View("ParmSave");
        }
    }
}