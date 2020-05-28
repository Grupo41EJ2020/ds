using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using MVCLaboratorio.Utilerias;
using MVCLaboratorio.Controllers;

namespace MVCLaboratorio.Models
{
    public class RepositorioTema
    {
        public List<Tema> ObtenerTema()
        {
            DataTable dtTema = BaseHelper.ejecutarConsulta("sp_Tema_ConsultarTodo", CommandType.StoredProcedure);

            List<Tema> lstTema = new List<Tema>();
            foreach (DataRow item in dtTema.Rows)
            {
                Tema datosTema = new Tema();
                datosTema.idTema = int.Parse(item["idTema"].ToString());
                datosTema.Nombre = item["Nombre"].ToString();

                lstTema.Add(datosTema);
            }
            return (lstTema);
        }
    }
}