using System;
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
           return View(repoTema.obtenerTema());
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

        public ActionResult Edit(int idTema)
        {
            //muestra el registro antes de editarlo
            return View(repoTema.obtenerTema(idTema));
        }

        //
        // POST: /Tema/Edit/5

        [HttpPost]
        public ActionResult Edit(int idTema, Tema datosTema)
        {
            datosTema.idTema = idTema;
            repoTema.actualizarTema(datosTema);
            return RedirectToAction("Index");
        }

        //
        // GET: /Tema/Delete/5

        public ActionResult Delete(int idTema)
        {
            //muestra el registro antes de eliminarlo
            return View(repoTema.obtenerTema(idTema));

        }
      
        //
        // POST: /Tema/Delete/5

        [HttpPost]
        public ActionResult Delete(int idTema, FormCollection collection)
        {
            repoTema.eliminarTema(idTema);
            return RedirectToAction("Index");
            
        }
    }
}
