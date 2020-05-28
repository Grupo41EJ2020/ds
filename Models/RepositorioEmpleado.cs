using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using MVCLaboratorio.Utilerias;
using MVCLaboratorio.Models;

namespace MVCLaboratorio.Models
{
    public class RepositorioEmpleado:IEmpleado
    {
        public List<Empleado> obtenerEmpleado()
        {
            //obtener todos los videos
            DataTable dtEmpleado = BaseHelper.ejecutarConsulta("sp_Empleadoo_ConsultarTodo",CommandType.StoredProcedure);

            List<Empleado> lstEmpleado = new List<Empleado>();

            //convertir el DataTable en List<Video> 
            
            foreach (DataRow item in dtEmpleado.Rows)
            {
                //se quito direccion para ponerlo en detalles :) 
                Empleado datosEmpleado = new Empleado();
                datosEmpleado.idEmpleado = int.Parse(item["IdEmpleado"].ToString());
                datosEmpleado.nombre = item["Nombre"].ToString();
                //datosEmpleado.direccion = item["Direccion"].ToString();

                lstEmpleado.Add(datosEmpleado);

            }
            return lstEmpleado;
        }

        public Empleado obtenerEmpleado(int idEmpleado)
        {
            throw new NotImplementedException();
        }

        public void insertarEmpleado(Empleado datosEmpleado)
        {
            throw new NotImplementedException();
        }

        public void eliminarEmpleado(int idEmpleado)
        {
            throw new NotImplementedException();
        }

        public void actualizarEmpleado(Empleado datosEmpleado)
        {
            throw new NotImplementedException();
        }
    }
}