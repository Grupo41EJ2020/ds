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
    public class RepositorioTema:ITema
    {
        public List<Tema> ObtenerTema()
        {
            //obtener videos
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

        public List<Tema> obtenerTema()
        {
            throw new NotImplementedException();
        }

        public Tema obtenerTema(int idTema)
        {
            throw new NotImplementedException();
        }

        public void insertarTema(Tema datosTema)
        {
            throw new NotImplementedException();
        }

        public void eliminarTema(int idTema)
        {
            throw new NotImplementedException();
        }

        public void actualizarTema(Tema datosTema)
        {
            throw new NotImplementedException();
        }
    }
}