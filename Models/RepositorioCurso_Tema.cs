﻿using System;
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
            DataTable dtCurso_Tema = BaseHelper.ejecutarConsulta("sp_Curso_Video_ConsultarTodo", CommandType.StoredProcedure);

            List<Curso_Tema> lstCurso_Tema = new List<Curso_Tema>();

            //convertir el DataTable en List<Video> 

            foreach (DataRow item in dtCurso_Tema.Rows)
            {
                Curso_Tema datosCurso_Tema = new Curso_Tema();

                datosCurso_Tema.idCT = int.Parse(item["idCT"].ToString());
                datosCurso_Tema.idCurso = int.Parse(item["idCurso"].ToString());

                lstCurso_Tema.Add(datosCurso_Tema);

            }
            return lstCurso_Tema;
        }

        //public Video obtenerVideo(int idVideo)
        //{
        //    //consultar los datos del video
        //    List<SqlParameter> parametros = new List<SqlParameter>();
        //    parametros.Add(new SqlParameter("@IdVideo", idVideo));

        //    DataTable dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsultarPorID", CommandType.StoredProcedure, parametros);

        //    Video miVideo = new Video();

        //    if (dtVideo.Rows.Count > 0)
        //    {
        //        miVideo.IdVideo = int.Parse(dtVideo.Rows[0]["IdVideo"].ToString());
        //        miVideo.Nombre = dtVideo.Rows[0]["Nombre"].ToString();
        //        miVideo.Url = dtVideo.Rows[0]["Url"].ToString();
        //        miVideo.FechaPublicacion = DateTime.Parse(dtVideo.Rows[0]["FechaPublicacion"].ToString());
        //        return miVideo;
        //    }
        //    else
        //    {  //no encontrado 
        //        return null;
        //    }
        //}

        //public void insertarVideo(Video datosVideo)
        //{
        //    throw new NotImplementedException();
        //}

        //public void eliminarVideo(int idVideo)
        //{
        //    //obtener info del video
        //    List<SqlParameter> parametros = new List<SqlParameter>();
        //    parametros.Add(new SqlParameter("@IdVideo", idVideo));

        //    BaseHelper.ejecutarConsulta("sp_Video_Eliminar", CommandType.StoredProcedure, parametros);
        //}

        //public void actualizarVideo(Video datosVideo)
        //{
        //    //realizar el update
        //    List<SqlParameter> parametros = new List<SqlParameter>();
        //    parametros.Add(new SqlParameter("@IdVideo", datosVideo.IdVideo));
        //    parametros.Add(new SqlParameter("@Nombre", datosVideo.Nombre));
        //    parametros.Add(new SqlParameter("@Url", datosVideo.Url));
        //    parametros.Add(new SqlParameter("@FechaPublicacion", datosVideo.FechaPublicacion));

        //    BaseHelper.ejecutarConsulta("sp_Video_Actualizar", CommandType.StoredProcedure, parametros);
        //}
    }
}