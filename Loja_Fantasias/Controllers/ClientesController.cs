﻿using Fantasias.Data;
using Fantasias.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Loja_Fantasias.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Clientes
        public ActionResult Index()
        {
            List<Clientes> lista = ClientesRepo.Get();
            return View(lista);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Clientes Cliente)
        {
            if (ModelState.IsValid)
            {
                ClientesRepo.Create(Cliente);
                return RedirectToAction("index");
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        public ActionResult Edit(int id, Clientes Cliente)
        {
            if (ModelState.IsValid)
            {
                ClientesRepo.Edit(id, Cliente);
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
            ClientesRepo.Delete(id);
            return RedirectToAction("index");
        }
    }
}