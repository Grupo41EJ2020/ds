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
    public class Curso1Controller : Controller
    {
        //
        // GET: /Curso1/
        RepositorioCurso repoCurso = new RepositorioCurso();

        public ActionResult Index()
        {
            return View(repoCurso.ObtenerCursos());
        }
        //
        // GET: /Curso/Details/5

        public ActionResult Details(int IdCurso)
        {
            return View(repoCurso.ObtenerCurso(IdCurso));
        }

        //
        // GET: /Curso/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Curso/Create

        [HttpPost]
        public ActionResult Create(Curso datos)
        {
            repoCurso.InsertarCurso(datos);
            return RedirectToAction("Index");
           
        }

        //
        // GET: /Curso/Edit/5

        public ActionResult Edit(int IdCurso)
        {
            return View(repoCurso.ObtenerCurso(IdCurso));
        }

        //
        // POST: /Curso/Edit/5

        [HttpPost]
        public ActionResult Edit(int IdCurso, Curso datos)
        {
            datos.IdCurso = IdCurso;
            repoCurso.ActualizarCurso(datos);
            return RedirectToAction("Index");
          
        }

        //
        // GET: /Curso/Delete/5

        public ActionResult Delete(int IdCurso)
        {
            return View(repoCurso.ObtenerCurso(IdCurso));
        }

        //
        // POST: /Curso/Delete/5

        [HttpPost]
        public ActionResult Delete(int IdCurso, FormCollection collection)
        {
            repoCurso.EliminarCurso(IdCurso);
            return RedirectToAction("Index");
        }
    }
}
