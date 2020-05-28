<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MVCLaboratorio.Models.Tema>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Tema</title>
</head>
<body>
    <table>
        <tr>
            <th></th>
            <th>
                idTema
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Editar", "Edit", new { idTema = item.idTema}) %> |
                <%: Html.ActionLink("Detalles", "Details", new { idTema = item.idTema })%> |
                <%: Html.ActionLink("Eliminar", "Delete", new { idTema = item.idTema})%>
            </td>
            <td>
                <%: item.idTema %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Crear uno nuevo", "Create") %>
    </p>

</body>
</html>

