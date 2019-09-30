using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Biblioteca_Jogos.Controllers
{
    public class usuarioController : Controller
    {
        // GET: usuario
        public ActionResult Index()
        {
            return View();
        }

        // GET: usuario/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: usuario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: usuario/Create
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

        // GET: usuario/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: usuario/Edit/5
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

        // GET: usuario/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: usuario/Delete/5
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
