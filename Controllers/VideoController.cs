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
    public class VideoController : Controller
    {
        //
        // GET: /Video/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Video/All
        public ActionResult All()
        {
            DataTable dtVideos = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);
            //convert DATATABLE
            List<Video> lstvideos = new List<Video>();
            foreach (DataRow item in dtVideos.Rows)
            {
                Video datosVideo = new Video();
                datosVideo.IdVideo = int.Parse(item["IdVideo"].ToString());
                datosVideo.Nombre = item["Nombre"].ToString();
                datosVideo.Url = item["Url"].ToString();
                datosVideo.FechaPublicacion = DateTime.Parse(item["FechaPublicacion"].ToString());

                lstvideos.Add(datosVideo);

            }
            return View(lstvideos);
        }

        //
        // GET: /Video/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Video/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Video/Create

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
        // GET: /Video/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Video/Edit/5

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
        // GET: /Video/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Video/Delete/5

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
