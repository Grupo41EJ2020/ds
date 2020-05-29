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

        RepositorioVideo repoVideo = new RepositorioVideo();

        public ActionResult Index()
        {
            return View(repoVideo.ObtenerVideos());
        }

      

        //
        // GET: /Video/Details/5

        public ActionResult Details(int id)
        {
            return View(repoVideo.ObtenerVideo(id));
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
        public ActionResult Create(Video datosVideo)
        {
            
                // TODO: Add insert logic here
                repoVideo.AgregarVideo(datosVideo);
                return RedirectToAction("Index");
        
            
        }
        
        //
        // GET: /Video/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View(repoVideo.ObtenerVideo(id));
        }

        //
        // POST: /Video/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, Video datosVideo)
        {

            datosVideo.IdVideo = id;
            repoVideo.ModificarVideo(datosVideo);

                return RedirectToAction("Index");
            
        }

        //
        // GET: /Video/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View(repoVideo.ObtenerVideo(id));
        }

        //
        // POST: /Video/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, Video datosVideo)
        {
            repoVideo.EliminarVideo(id);
                return RedirectToAction("Index");
            
        }
    }
}
