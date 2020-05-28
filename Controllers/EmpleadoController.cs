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
    public class EmpleadoController : Controller
    {
        RepositorioEmpleado repoEmpleado = new RepositorioEmpleado();

        public ActionResult Index()
        {
            return View(repoEmpleado.obtenerEmpleado());
        }

        //
        // GET: /Empleado/Details/5

        public ActionResult Details(int id)
        {
            
            return View(repoEmpleado.obtenerEmpleado(id));
        }

        //
        // GET: /Empleado/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Empleado/Create

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
        // GET: /Empleado/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View(repoEmpleado.obtenerEmpleado(id));
        }

        //
        // POST: /Empleado/Edit/5

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
        // GET: /Empleado/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View(repoEmpleado.obtenerEmpleado(id));
        }

        //
        // POST: /Empleado/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            repoEmpleado.eliminarEmpleado(id);
                return View();
            
        }
    }
}
