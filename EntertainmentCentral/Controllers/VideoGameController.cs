using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntertainmentCentral.Controllers
{
    public class VideoGameController : Controller
    {
        // GET: VideoGame
        public ActionResult Home()
        {
            return View();
        }

        // GET: VideoGame/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VideoGame/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VideoGame/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: VideoGame/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VideoGame/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: VideoGame/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VideoGame/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
