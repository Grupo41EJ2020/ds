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
    public class RepositorioCurso_Tema
    {
        public List<Curso_Tema> ObtenerCurso_Temas()
        {
            //obtener todos los videos
            DataTable dtCurso_Tema = BaseHelper.ejecutarConsulta("sp_Curso_Tema_ConsultarTodo", CommandType.StoredProcedure);

            List<Curso_Tema> lstCurso_Tema = new List<Curso_Tema>();

            //convertir el DataTable en List<Video> 

            foreach (DataRow item in dtCurso_Tema.Rows)
            {
                Curso_Tema datosCurso_Tema = new Curso_Tema();

                datosCurso_Tema.IdCT = int.Parse(item["idCT"].ToString());
                datosCurso_Tema.IdCurso = int.Parse(item["idCurso"].ToString());

                lstCurso_Tema.Add(datosCurso_Tema);

            }
            return lstCurso_Tema;
        }

        public Curso_Tema obtenerCurso_Tema(int IdCT)
        {
            //consultar los datos del video
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdCT", IdCT));

            DataTable dtCurso_Tema = BaseHelper.ejecutarConsulta("sp_Curso_Tema_ConsultarPorID", CommandType.StoredProcedure, parametros);

            Curso_Tema miCurso_Tema = new Curso_Tema();

            if (dtCurso_Tema.Rows.Count > 0)
            {
                miCurso_Tema.IdCT = int.Parse(dtCurso_Tema.Rows[0]["IdCT"].ToString());
                miCurso_Tema.IdCurso = int.Parse(dtCurso_Tema.Rows[0]["IdCurso"].ToString());
                miCurso_Tema.IdTema = int.Parse(dtCurso_Tema.Rows[0]["IdTema"].ToString());                
                return miCurso_Tema;
            }
            else
            {  //no encontrado 
                return null;
            }
        }

        //public void insertarVideo(Video datosVideo)
        //{
        //    throw new NotImplementedException();
        //}

        public void eliminarCurso_Tema(int IdCT)
        {
            //obtener info del video
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdCT", IdCT));

            BaseHelper.ejecutarConsulta("sp_Curso_Tema_Eliminar", CommandType.StoredProcedure, parametros);
        }

        public void actualizarCurso_Tema(Curso_Tema datosCurso_Tema)
        {
            //realizar el update
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdCurso", datosCurso_Tema.IdCurso));
            parametros.Add(new SqlParameter("@IdTema", datosCurso_Tema.IdTema));

            BaseHelper.ejecutarConsulta("sp_Curso_Tema_Actualizar", CommandType.StoredProcedure, parametros);
        }
    }
}