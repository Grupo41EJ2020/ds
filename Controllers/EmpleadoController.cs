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
            //muestra todo
            return View(repoEmpleado.obtenerEmpleado());
        }

        //
        // GET: /Empleado/Details/5

        public ActionResult Details(int idEmpleado)
        {
            //muestra la info del registro seleccionado
            return View(repoEmpleado.obtenerEmpleado(idEmpleado));
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
        public ActionResult Create(Empleado datosEmpleado)
        {
            repoEmpleado.insertarEmpleado(datosEmpleado);
            return RedirectToAction("Index");
        }
        
        //
        // GET: /Empleado/Edit/5
 
        public ActionResult Edit(int idEmpleado)
        {
            //muestra el registro antes de editarlo
            return View(repoEmpleado.obtenerEmpleado(idEmpleado));
        }

        //
        // POST: /Empleado/Edit/5

        [HttpPost]
        public ActionResult Edit(int idEmpleado, Empleado datosEmpleado)
        {
            datosEmpleado.idEmpleado = idEmpleado;
            repoEmpleado.actualizarEmpleado(datosEmpleado);
            return RedirectToAction("Index");
        }

        //
        // GET: /Empleado/Delete/5
 
        public ActionResult Delete(int idEmpleado)
        {
            //muestra el registro antes de eliminarlo
            return View(repoEmpleado.obtenerEmpleado(idEmpleado));
            
        }

        //
        // POST: /Empleado/Delete/5

        [HttpPost]
        public ActionResult Delete(int idEmpleado, FormCollection collection)
        {
            repoEmpleado.eliminarEmpleado(idEmpleado);
            return RedirectToAction("Index");
            
        }
    }
}
