﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Data;
using System.Data.SqlClient;
using MVCLaboratorio.Utilerias;
using MVCLaboratorio.Models;

namespace MVCLaboratorio.Controllers
{
    public class TemaController : Controller
    {
        RepositorioTema repoTema = new RepositorioTema();

        public ActionResult Index()
        {
           //muestra todo
           return View(repoTema.ObtenerTema());
        }

        //
        // GET: /Tema/Details/5

        public ActionResult Details(int idTema)
        {
            //muestra la info del registro seleccionado
            return View(repoTema.obtenerTema(idTema));
        }

        //
        // GET: /Tema/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Tema/Create

        [HttpPost]
        public ActionResult Create(Tema datosTema)
        {
            repoTema.insertarTema(datosTema);
            return RedirectToAction("Index");
        }
        
        //
        // GET: /Tema/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Tema/Edit/5

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

        //
        // GET: /Tema/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Tema/Delete/5

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
