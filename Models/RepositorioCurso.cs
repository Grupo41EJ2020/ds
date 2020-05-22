using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCLaboratorio.Models;
using System.Data;
using System.Data.SqlClient;
using MVCLaboratorio.Utilerias;

namespace MVCLaboratorio.Models
{
    public class RepositorioCurso
    {
        public List<Curso> ObtenerCurso()
        {
            DataTable dtCurso = BaseHelper.ejecutarConsulta("sp_Curso_ConsultarTodo", CommandType.StoredProcedure);

            List<Curso> lstCurso = new List<Curso>();
            foreach (DataRow item in dtCurso.Rows)
            {
                Curso datosCurso = new Curso();
                datosCurso.IdCurso = int.Parse(item["IdCurso"].ToString());
                datosCurso.Descripcion = int.Parse(item["Descripcion"].ToString());
                datosCurso.IdEmpleado = int.Parse(item["IdEmpleado"].ToString());

                lstCurso.Add(datosCurso);
 
            }
            return lstCurso;
        }
    }
}