<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Detalles</title>
</head>
<body>
     <fieldset>
     <legend>Datos del curso</legend>

    <div class="display-label">IdCurso</div>
    <div class="display-field"><%: Model.IdCurso %></div>

    <div class="display-label">Descripcion</div>
    <div class="display-field"><%: Model.Descripcion %></div>

    <div class="display-label">IdEmpleado</div>
    <div class="display-field"><%: Model.IdEmpleado %></div>

    </fieldset>
    <p>
    <%: Html.ActionLink("Editar ", "Edit", new {id=Model.Curso}) %> |

    <a href="/Curso/consultar">Regresar a la lista</a>
    </p>
</body>
</html>
