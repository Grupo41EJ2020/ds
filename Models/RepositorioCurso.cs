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
    public class RepositorioCurso : Curso

    {
        public List<Curso> ObtenerCursos()
        {
            DataTable dtCurso = BaseHelper.ejecutarConsulta("sp_Curso_ConsultarTodo", CommandType.StoredProcedure);
            List<Curso> IstCurso= new List<Curso>();

            foreach (DataRow item in dtCurso.Rows)

            {
                Curso datosCurso = new Curso();
                datosCurso.IdCurso = int.Parse(item["IdCurso"].ToString());
                datosCurso.Descripcion = item["Descripcion"].ToString();
                datosCurso.IdEmpleado = int.Parse(item["IdEmpleado"].ToString());

                IstCurso.Add(datosCurso);
            }
            return (IstCurso);
        }
        public Curso ObtenerCurso(int IdCurso)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdCurso", IdCurso));
            DataTable dtCurso = BaseHelper.ejecutarConsulta("sp_Curso_ConsultarPorID", CommandType.StoredProcedure, parametros);

            Curso miCurso = new Curso();

            if (dtCurso.Rows.Count > 0)
            {
                miCurso.IdCurso = int.Parse(dtCurso.Rows[0]["IdCurso"].ToString());
                miCurso.Descripcion = dtCurso.Rows[0]["Descripcion"].ToString();
                miCurso.IdEmpleado = int.Parse(dtCurso.Rows[0]["IdEmpleado"].ToString());

                return miCurso;
            }
            else
            {
                return null;
            }
        }
        public void InsertarCurso(Curso datosCurso)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@Descripcion", datosCurso.Descripcion));
            parametros.Add(new SqlParameter("@IdEmpleado", datosCurso.IdEmpleado));
            BaseHelper.ejecutarSentencia("sp_Curso_Insertar", CommandType.StoredProcedure, parametros);
        }
        public void EliminarCurso(int IdCurso)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdCurso", IdCurso));
            BaseHelper.ejecutarConsulta("sp_Curso_Eliminar", CommandType.StoredProcedure, parametros);
        }
        public void ActualizarCurso(Curso datosCurso)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdCurso", datosCurso.IdCurso));
            parametros.Add(new SqlParameter("@Descripcion", datosCurso.Descripcion));
            parametros.Add(new SqlParameter("@IdEmpleado", datosCurso.IdEmpleado));

            BaseHelper.ejecutarConsulta("sp_Curso_Actualizar", CommandType.StoredProcedure, parametros);
        }
    }
}