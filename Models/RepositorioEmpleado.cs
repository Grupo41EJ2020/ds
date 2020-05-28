﻿using System;
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
            //consultar los datos del empleado
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdEmpleado", idEmpleado));

            DataTable dtEmpleado = BaseHelper.ejecutarConsulta("sp_Empleado_ConsultarPorID", CommandType.StoredProcedure, parametros);

            Empleado miEmpleado = new Empleado();

            if (dtEmpleado.Rows.Count > 0)
            {
                miEmpleado.idEmpleado = int.Parse(dtEmpleado.Rows[0]["IdEmpleado"].ToString());
                miEmpleado.nombre = dtEmpleado.Rows[0]["Nombre"].ToString();
                miEmpleado.direccion= dtEmpleado.Rows[0]["Direccion"].ToString();
                return miEmpleado;
            }
            else
            {  //no encontrado 
                return null;
            }
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