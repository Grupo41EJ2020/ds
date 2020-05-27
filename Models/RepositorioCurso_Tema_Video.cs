using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MVCLaboratorio.Models;
using System.Data.SqlClient;
using System.Data;
using MVCLaboratorio.Utilerias;

namespace MVCLaboratorio.Models
{
    public class RepositorioCurso_Tema_Video
    {
     
        public List<Curso_Tema_Video> ObtenerCurso_Tema_Videos()
        {
            DataTable dtCurso_Tema_Video = BaseHelper.ejecutarConsulta("sp_Curso_Tema_Video_ConsultarTodo", CommandType.StoredProcedure);
            List<Curso_Tema_Video> lstCurso_Tema_Video = new List<Curso_Tema_Video>();

            //convert datatable in list

            foreach (DataRow item in dtCurso_Tema_Video.Rows)
            {
                Curso_Tema_Video datosCurso_Tema_Video = new Curso_Tema_Video();
                datosCurso_Tema_Video.IdCTV = int.Parse(item["IdCTV"].ToString());
                datosCurso_Tema_Video.IdCT = int.Parse(item["IdCT"].ToString());
                datosCurso_Tema_Video.IdVideo = int.Parse(item["IdVideo"].ToString());

                lstCurso_Tema_Video.Add(datosCurso_Tema_Video);

            }
            return lstCurso_Tema_Video;
        }

        public Curso_Tema_Video ObtenerCurso_Tema_Video(int IdCTV)
        {
            //consultar el id
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdCTV", IdCTV));

            DataTable dtCurso_Tema_Video = BaseHelper.ejecutarConsulta("sp_Curso_Tema_Video_ConsultarPorId", CommandType.StoredProcedure, parametros);
            
            Curso_Tema_Video datos_Curso_Tema_Video = new Curso_Tema_Video();
            
            if (dtCurso_Tema_Video.Rows.Count > 0)
            {
                datos_Curso_Tema_Video.IdCTV = int.Parse(dtCurso_Tema_Video.Rows[0]["IdCTV"].ToString());
                datos_Curso_Tema_Video.IdCT = int.Parse(dtCurso_Tema_Video.Rows[0]["IdCT"].ToString());
                datos_Curso_Tema_Video.IdVideo = int.Parse(dtCurso_Tema_Video.Rows[0]["IdVideo"].ToString());

                return datos_Curso_Tema_Video;
            }
            else
            {
                return null;
            }


        }

        public void AgregarCursoTemaVideo(Curso_Tema_Video datosCurso_Tema_Video)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            
            parametros.Add(new SqlParameter("@IdCT", datosCurso_Tema_Video.IdCT));
            parametros.Add(new SqlParameter("@IdVideo", datosCurso_Tema_Video.IdVideo));

            BaseHelper.ejecutarConsulta("sp_Curso_Tema_Video_Agregar", CommandType.StoredProcedure, parametros);
        }

        public void EliminarCursoTemaVideo(int IdCTV)
        {
            //obtener id
            List<SqlParameter> parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("@IdCTV", IdCTV));

            BaseHelper.ejecutarConsulta("sp_Curso_Tema_Video_Borrar", CommandType.StoredProcedure, parametros);
        }

        public void ActualizarCursoTemaVideo(Curso_Tema_Video datosCurso_Tema_Video)
        {
            //UPDATE
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdCTV", datosCurso_Tema_Video.IdCTV));
            parametros.Add(new SqlParameter("@IdCT", datosCurso_Tema_Video.IdCT));
            parametros.Add(new SqlParameter("@IdVideo", datosCurso_Tema_Video.IdVideo));

            BaseHelper.ejecutarConsulta("sp_Curso_Tema_Video_Modificar", CommandType.StoredProcedure, parametros);
        }
    }
}
