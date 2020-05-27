<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>ELIMINAR</title>
</head>
<body>
   <h3>¿Seguro de que quieres eliminar este registro?</h3>
    <fieldset>
        <legend>Datos</legend>

        <div class="display-label">IdCurso</div>
        <div class="display-field"><%: Model.IdCurso %></div>

        <div class="display-label">Descripcion</div>
        <div class="display-field"><%: Model.Descripcion %></div>
       
        <div class="display-label">IdEmpleado</div>
        <div class="display-field"><%: Model.IdEmpleado %></div>
        
    </fieldset>
    <% using (Html.BeginForm()) { %>
        <p>
		    <input type="submit" value="Eliminar" /> |
		    <%: Html.ActionLink("Regresar a la lista", "Index")%>
        </p>
    <% } %>

</body>
</html>
