using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Data.SqlClient;
using System.Data;
using MVCLaboratorio.Utilerias;
using MVCLaboratorio.Models;

namespace MVCLaboratorio.Controllers
{
    public class Curso_TemaController : Controller
    {
        //
        // GET: /Curso_Tema/

        RepositorioCurso_Tema repoCurso_Tema = new RepositorioCurso_Tema();

        public ActionResult Index()
        {
            return View(repoCurso_Tema.ObtenerCurso_Temas());
        }

        //
        // GET: /Curso_Tema/Details/5

        public ActionResult Details(int IdCT)
        {
            return View(repoCurso_Tema.obtenerCurso_Tema(IdCT));
        }

        //
        // GET: /Curso_Tema/Create

        ////////////////////////////////////public ActionResult Create()
        ////////////////////////////////////{
        ////////////////////////////////////    return View();
        ////////////////////////////////////} 

        //////////////////////////////////////
        ////////////////////////////////////// POST: /Curso_Tema/Create

        ////////////////////////////////////[HttpPost]
        ////////////////////////////////////public ActionResult Create(FormCollection collection)
        ////////////////////////////////////{
        ////////////////////////////////////    try
        ////////////////////////////////////    {
        ////////////////////////////////////        // TODO: Add insert logic here

        ////////////////////////////////////        return RedirectToAction("Index");
        ////////////////////////////////////    }
        ////////////////////////////////////    catch
        ////////////////////////////////////    {
        ////////////////////////////////////        return View();
        ////////////////////////////////////    }
        ////////////////////////////////////}
        
        //
        // GET: /Curso_Tema/Edit/5
 
        public ActionResult Edit(int IdCT)
        {
            return View(repoCurso_Tema.obtenerCurso_Tema(IdCT));
        }

        //
        // POST: /Curso_Tema/Edit/5

        [HttpPost]
        public ActionResult Edit(int IdCT, Curso_Tema datos)
        {
            datos.IdCT = IdCT;
            repoCurso_Tema.actualizarCurso_Tema(datos);
            return View();
        }

        //
        // GET: /Curso_Tema/Delete/5
 
        public ActionResult Delete(int IdCT)
        {
            return View(repoCurso_Tema.obtenerCurso_Tema(IdCT));
        }

        //
        // POST: /Curso_Tema/Delete/5

        [HttpPost]
        public ActionResult Delete(int IdCT, FormCollection collection)
        {
            repoCurso_Tema.eliminarCurso_Tema(IdCT);
            return RedirectToAction("Index");
        }
    }
}
