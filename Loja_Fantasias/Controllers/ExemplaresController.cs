using Fantasias.Data;
using Fantasias.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Loja_Fantasias.Controllers
{
    public class ExemplaresController : Controller
    {
        //
        // GET: /Exemplares/
        public ActionResult Index()
        {

            List<Exemplares> lista = ExemplaresRepo.Get();
            return View(lista);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Exemplares Exemplares)
        {
            if (ModelState.IsValid)
            {
                ExemplaresRepo.Create(Exemplares);
                return RedirectToAction("index");
            }
            else
            {
                return View();
            }
        }



        [HttpPost]
        public ActionResult Edit(int id, Exemplares Exemplares)
        {
            if (ModelState.IsValid)
            {
                ExemplaresRepo.Edit(id, Exemplares);
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
            ExemplaresRepo.Delete(id);
            return RedirectToAction("index");
        }

	}
}