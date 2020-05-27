using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Data.SqlClient;
using System.Data;
using MVCLaboratorio.Utilerias;

namespace MVCLaboratorio.Models
{
    public class RepositorioVideo
    {
        //
        // Consultar todo

        public List<Video> ObtenerVideos()
        {
            DataTable dtVideos = BaseHelper.ejecutarConsulta("sp_Video_ConsultarTodo", CommandType.StoredProcedure);
            List<Video> lstVideo = new List<Video>();
            //convert
            foreach (DataRow item in dtVideos.Rows)
            {
                Video datosVideo = new Video();
                datosVideo.IdVideo = int.Parse(item["IdVideo"].ToString());
                datosVideo.Nombre = item["Nombre"].ToString();
                datosVideo.Url = item["Url"].ToString();
                datosVideo.FechaPublicacion = DateTime.Parse(item["FechaPublicacion"].ToString());

                lstVideo.Add(datosVideo);
                
            }
            return lstVideo;
        }
        //
        // Consultar por ID
        public Video ObtenerVideo(int IdVideo)
        {
            //consultar dato de video
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", IdVideo));
            DataTable dtVideo = BaseHelper.ejecutarConsulta("sp_Video_ConsutlarPorId", CommandType.StoredProcedure, parametros);

            Video datosVideo = new Video();

            if (dtVideo.Rows.Count > 0)
            {
                datosVideo.IdVideo = int.Parse(dtVideo.Rows[0]["IdVideo"].ToString());
                datosVideo.Nombre = dtVideo.Rows[0]["Nombre"].ToString();
                datosVideo.Url = dtVideo.Rows[0]["Url"].ToString();
                datosVideo.FechaPublicacion = DateTime.Parse(dtVideo.Rows[0]["FechaPublicacion"].ToString());

                return datosVideo;
            }
            else
            {
                return null;
            }

        }
        //
        // Agregar Video
        public void AgregarVideo(Video datosVideo)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@Nombre", datosVideo.Nombre));
            parametros.Add(new SqlParameter("@Url", datosVideo.Url));
            parametros.Add(new SqlParameter("@FechaPublicacion", datosVideo.FechaPublicacion));

            BaseHelper.ejecutarConsulta("sp_Video_Agregar", CommandType.StoredProcedure, parametros);
        }
        //
        // Eliminar Video
        public void EliminarVideo(int IdVideo)
        {
            //obtener el Id
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", IdVideo));

            BaseHelper.ejecutarConsulta("sp_Video_Borrar", CommandType.StoredProcedure, parametros);
        }
        //
        // Modificar Video
        public void ModificarVideo(Video datosVideo)
        {
            //realizar el update
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", datosVideo.IdVideo));
            parametros.Add(new SqlParameter("@Nombre", datosVideo.Nombre));
            parametros.Add(new SqlParameter("@Url", datosVideo.Url));
            parametros.Add(new SqlParameter("@FechaPublicacion", datosVideo.FechaPublicacion));

            BaseHelper.ejecutarConsulta("sp_Video_Modificar", CommandType.StoredProcedure, parametros);
        }
    }
}
