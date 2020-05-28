<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MVCLaboratorio.Models.Empleado>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Empleados (Index)</title>
</head>
<body>
<h1>TABLA DE EMPLEADOS</h1>
<br />
    <table>
        <tr>
            <th></th>
            <th>
                idEmpleado
            </th>
            
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Editar", "Edit", new { idEmpleado = item.idEmpleado }) %> |
                <%: Html.ActionLink("Detalles", "Details", new { idEmpleado = item.idEmpleado })%> |
                <%: Html.ActionLink("Borrar", "Delete", new { idEmpleado = item.idEmpleado })%>
            </td>
            <td>
                <%: item.idEmpleado %>
            </td>
            
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Crear uno Nuevo", "Create") %>
    </p>

</body>
</html>

