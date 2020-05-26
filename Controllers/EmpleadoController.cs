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
        //
        // GET: /Empleado/

        public ActionResult Index()
        {
            //obtener todos los videos
            DataTable dtEmpleado = BaseHelper.ejecutarConsulta("sp_empleado_consultar", CommandType.StoredProcedure);

            List<Empleado> lstEmpleado = new List<Empleado>();

            //convertir el DataTable en List<Video> 

            foreach (DataRow item in dtEmpleado.Rows)
            {
                Empleado datosEmpleado = new Empleado();
                datosEmpleado.idEmpleado = int.Parse(item["idVideo"].ToString());
                datosEmpleado.nombre = item["nombre"].ToString();
                datosEmpleado.direccion = item["direccion"].ToString();
               
                lstEmpleado.Add(datosEmpleado);

            }

            return View(lstEmpleado);

        }

        //
        // GET: /Empleado/Details/5

        public ActionResult Details(int id)
        {
            
            return View();
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
            return View();
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
            return View();
        }

        //
        // POST: /Empleado/Delete/5

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
