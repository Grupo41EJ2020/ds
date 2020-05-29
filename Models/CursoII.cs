using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCLaboratorio.Models
{
    public interface CursoII
    {
        List<Curso> ObtenerCursos();
        Curso ObtenerCurso(int IdCurso);
        void InsertarCurso(Curso datosCurso);
        void ActualizarCurso(Curso datosCurso);
        void EliminarCurso(int IdCurso);
    }
}