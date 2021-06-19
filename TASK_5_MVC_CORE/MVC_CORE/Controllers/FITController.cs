using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_CORE.Controllers
{
    public class FITController : Controller
    {
        // GET: FITController
        [HttpGet("/Index")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet("/Search/{s?}")]
        public ActionResult Search()
        {
            return View("Search");
        }

        [HttpGet("/GetParm")]
        public ActionResult GetParm()
        {
            return View("GetParm");
        }

        [HttpPost("/ParmSave")]
        public ActionResult ParmSave()
        {
            return View("ParmSave");
        }

        // GET: FITController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FITController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FITController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FITController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FITController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FITController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FITController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
