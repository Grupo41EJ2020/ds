<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Detalles del curso</title>
</head>
<body>
    <fieldset>
        <legend>Datos del Curso</legend>
        
        <div class="display-label">IdCurso</div>
        <div class="display-field"><%: Model.IdCurso %></div>
        
        <div class="display-label">IdCurso</div>
        <div class="display-field"><%: Model.Descripcion %></div>
        
        <div class="display-label">IdTema</div>
        <div class="display-field"><%: Model.IdEmpleado %></div>
        
    </fieldset>
    <p>
        <%: Html.ActionLink("Editar", "CursoEdit", new { IdCurso = Model.IdCurso })%> |
        <%: Html.ActionLink("Regresar a la lista", "Index")%>
    </p>
</body>
</html>
