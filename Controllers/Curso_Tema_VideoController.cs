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
    public class Curso_Tema_VideoController : Controller
    {
        //
        // GET: /Curso_Tema_Video/

        RepositorioCurso_Tema_Video repoCurso_Tema_Video = new RepositorioCurso_Tema_Video();

        public ActionResult Index()
        {
            return View(repoCurso_Tema_Video.ObtenerCurso_Tema_Videos());
        }

        

        //
        // GET: /Curso_Tema_Video/Details/5

        public ActionResult Details(int id)
        {
            return View(repoCurso_Tema_Video.ObtenerCurso_Tema_Video(id));
        }

        //
        // GET: /Curso_Tema_Video/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Curso_Tema_Video/Create

        [HttpPost]
        public ActionResult Create(Curso_Tema_Video datos_Curso_Tema_Video)
        {

            repoCurso_Tema_Video.AgregarCursoTemaVideo(datos_Curso_Tema_Video);

                return RedirectToAction("Index");
            
        }
        
        //
        // GET: /Curso_Tema_Video/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View(repoCurso_Tema_Video.ObtenerCurso_Tema_Video(id));
        }

        //
        // POST: /Curso_Tema_Video/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, Curso_Tema_Video datosCurso_Tema_Video)
        {
                datosCurso_Tema_Video.IdCTV=id;
                repoCurso_Tema_Video.ActualizarCursoTemaVideo(datosCurso_Tema_Video);
                return RedirectToAction("Index");
            
                
            
        }

        //
        // GET: /Curso_Tema_Video/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View(repoCurso_Tema_Video.ObtenerCurso_Tema_Video(id));
        }

        //
        // POST: /Curso_Tema_Video/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, Curso_Tema_Video datosCurso_Tema_Video)
        {

                repoCurso_Tema_Video.EliminarCursoTemaVideo(id);
                return RedirectToAction("Index");
            
        }
    }
}
