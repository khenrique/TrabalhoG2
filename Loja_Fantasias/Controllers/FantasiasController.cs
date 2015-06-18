
using Fantasias.Data;
using Fantasias.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Loja_Fantasias.Controllers
{
    public class FantasiasController : Controller
    {
        // GET: Fantasias
        public ActionResult Index()
        {
            List<Fantasias.Data.Fantasias> lista = FantasiasRepo.Get();
            return View(lista);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Fantasias.Data.Fantasias Fantasia)
        {
            if (ModelState.IsValid)
            {
                Fantasias.Repository.FantasiasRepo.Create(Fantasia);
                return RedirectToAction("index");
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        public ActionResult Edit(int id, Fantasias.Data.Fantasias Fantasia)
        {
            if (ModelState.IsValid)
            {
                FantasiasRepo.Edit(id, Fantasia);
                return RedirectToAction("index");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Edit()
        {
            return View();
        }

        public ActionResult Delete(int id)
        {
            FantasiasRepo.Delete(id);
            return RedirectToAction("index");
        }
    }
}
