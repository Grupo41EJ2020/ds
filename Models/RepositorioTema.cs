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
    public class RepositorioTema : ITema
    {
        public List<Tema> obtenerTema()
        {
            //obtener todos los videos
            DataTable dtTema = BaseHelper.ejecutarConsulta("sp_Tema_ConsultarTodo", CommandType.StoredProcedure);

            List<Tema> lstTema = new List<Tema>();

            //convertir el DataTable en List<Video> 

            foreach (DataRow item in dtTema.Rows)
            {
                Tema datosTema = new Tema();
                datosTema.idTema = int.Parse(item["idTema"].ToString());
                datosTema.Nombre = item["Nombre"].ToString();

                lstTema.Add(datosTema);

            }
            return lstTema;
        }

        public Tema obtenerTema(int idTema)
        {
            //consultar los datos del Tema
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idTema", idTema));

            DataTable dtTema = BaseHelper.ejecutarConsulta("sp_Tema_ConsultarPorID", CommandType.StoredProcedure, parametros);

            Tema miTema = new Tema();

            if (dtTema.Rows.Count > 0)
            {
                miTema.idTema = int.Parse(dtTema.Rows[0]["idTema"].ToString());
                miTema.Nombre = dtTema.Rows[0]["Nombre"].ToString();

                return miTema;
            }
            else
            {  //no encontrado 
                return null;
            }
        }

        public void insertarTema(Tema datosTema)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            //parametros.Add(new SqlParameter("@idTema", datosTema.idTema));
            parametros.Add(new SqlParameter("@Nombre", datosTema.Nombre));

            BaseHelper.ejecutarConsulta("sp_Tema_Insertar", CommandType.StoredProcedure, parametros);
        }

        public void eliminarTema(int idTema)
        {
            //obtener informacion del video
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idTema", idTema));

            BaseHelper.ejecutarConsulta("sp_Tema_Eliminar", CommandType.StoredProcedure, parametros);
        }

        public void actualizarTema(Tema datosTema)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idTema", datosTema.idTema));
            parametros.Add(new SqlParameter("@Nombre", datosTema.Nombre));

            BaseHelper.ejecutarConsulta("sp_Tema_Actualizar", CommandType.StoredProcedure, parametros);
        }
    }
}