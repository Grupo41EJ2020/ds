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

        public ActionResult Index()
        {
            return View();
        }

        //
        //GET: /Curso_Tema_Video/All
        public ActionResult All()
        {
            DataTable dtCTVideos = BaseHelper.ejecutarConsulta("sp_Curso_Tema_Video_ConsultarTodo", CommandType.StoredProcedure);
            //convert DATATABLE
            List<Curso_Tema_Video> lstCTVideos = new List<Curso_Tema_Video>();
            foreach (DataRow item in dtCTVideos.Rows)
	        {
                Curso_Tema_Video datosCTVideos = new Curso_Tema_Video();
                datosCTVideos.IdCTV = int.Parse(item["IdCTV"].ToString());
                datosCTVideos.IdCT = int.Parse(item["IdCT"].ToString());
                datosCTVideos.IdVideo = int.Parse(item["IdVideo"].ToString());
                
                lstCTVideos.Add(datosCTVideos);
		 
	        }
            return View(lstCTVideos);
        }

        //
        // GET: /Curso_Tema_Video/Details/5

        public ActionResult Details(int id)
        {
            return View();
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
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Curso_Tema_Video/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Curso_Tema_Video/Edit/5

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
        // GET: /Curso_Tema_Video/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Curso_Tema_Video/Delete/5

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
