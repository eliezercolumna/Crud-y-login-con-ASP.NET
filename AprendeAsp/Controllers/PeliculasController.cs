using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AprendeAsp.Models;

namespace AprendeAsp.Models
{
    public class PeliculasController : Controller
    {
        // GET: Peliculas
        public ActionResult Index()
        {
            var data = new PeliculasModel().get();
            return View(data);
        }

        // GET: Peliculas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Peliculas/Create
        [HttpPost]
        public ActionResult Create(PeliculasModel model)
        {
            new PeliculasModel().Insert(model);
            return RedirectToAction("Index","Peliculas");
        }

        // GET: Peliculas/Edit/5
        public ActionResult Edit(int id)
        {
            var data = new PeliculasModel().getId(id);
            return View(data);
        }

        // POST: Peliculas/Edit/5
        [HttpPost]
        public ActionResult Edit(PeliculasModel model)
        {
            new PeliculasModel().Update(model);
            return RedirectToAction("Index", "Peliculas");
        }

        // GET: Peliculas/Delete/5
        // GET: Controller/Action/id
        public ActionResult Delete(int id)
        {
            new PeliculasModel().Delete(id);
            return RedirectToAction("Index","Peliculas");
        }
    }
}
