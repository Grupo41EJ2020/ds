<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MVCLaboratorio.Models.Curso_Tema>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Lista de Curso_Temas</title>
</head>
<body>
    <table>
        <tr>
            <th></th>
            <th>
                IdCT
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Editar", "Edit", new {  IdCT=item.IdCT }) %> |
                <%: Html.ActionLink("Detalles", "Details", new {  IdCT=item.IdCT })%> |
                <%: Html.ActionLink("Eliminar", "Delete", new {  IdCT=item.IdCT  })%>
            </td>
            <td>
                <%: item.IdCT %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Crear nuevo Curso_Tema", "Create") %>
    </p>

</body>
</html>

