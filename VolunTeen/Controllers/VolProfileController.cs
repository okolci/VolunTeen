using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VolunTeen.Models;

namespace VolunTeen.Controllers
{
    public class VolProfileController : Controller
    {
        // GET: VolProfile
        public ActionResult Index()
        {
            //VolProfileDBHandle dbhandle = new VolProfileDBHandle();
            //ModelState.Clear();
            return View();/*(dbhandle.GetVol());*/
        }

        // GET: VolProfile/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        public ActionResult AddProfile()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddProfile(VolProfileModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    VolProfileDBHandle sdb = new VolProfileDBHandle();
                    if (sdb.AddVolProfile(model))
                    {
                        ViewData["Msg"] = "Details Added Successfully";
                        ModelState.Clear();
                    }
                    else
                    {
                        ViewData["Msg"] = "Failed...!!!";
                    }
                }
                return View();
            }
            catch
            {
                return View();
            }
        }
        // GET: VolProfile/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VolProfile/Create
        [HttpPost]
        public ActionResult Create(VolProfileModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    VolProfileDBHandle sdb = new VolProfileDBHandle();
                    if (sdb.AddVolProfile(model))
                    {
                        ViewData["Msg"] = "Details Added Successfully";
                        ModelState.Clear();
                    }
                    else
                    {
                        ViewData["Msg"] = "Failed...!!!";
                    }
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: VolProfile/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VolProfile/Edit/5
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

        // GET: VolProfile/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VolProfile/Delete/5
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
