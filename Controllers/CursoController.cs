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
    public class CursoController : Controller
    {
        //
        // GET: /Curso/
        RepositorioCurso repoCurso = new RepositorioCurso();

        public ActionResult Index()
        {
            return View(repoCurso.ObtenerCurso());
        }
         //
        // GET: /Curso/Details/5

        public ActionResult Details(int id)
        {
          return View(repoCurso.ObtenerCurso(id));
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
        public ActionResult Create(FormCollection collection)
        {
           //repoCurso.InsertarCurso(dts);
           //return RedirectToAction("Index", "Curso");
            {
                return View();
            }
        }
        
        //
        // GET: /Curso/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View(repoCurso.ObtenerCurso(id));
        }

        //
        // POST: /Curso/Edit/5

        [HttpPost]
        public ActionResult Edit(int IdCurso, FormCollection collection)
        {
           //datos.IdCurso = id;
           //repoCurso.ActualizarCurso(dts);
           //return RedirectToAction("Index", "Curso");
            {
                return View();
            }
        }

        //
        // GET: /Curso/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View(repoCurso.ObtenerCurso(id));
        }

        //
        // POST: /Curso/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            repoCurso.EliminarCurso(id);
            return RedirectToAction("Index","Curso");
        }
    }
}


