<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Lista de Cursos</title>
</head>
<body>
    <table>
       <tr>
            <th></th>
            <th>
                IdCurso
            </th>
        </tr>
         <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Editar", "CursoEdit", new { IdCurso = item.IdCurso })%> |
                <%: Html.ActionLink("Detalles", "Details", new { IdCurso = item.IdCurso })%> |
                <%: Html.ActionLink("Eliminar", "Delete", new { IdCurso = item.IdCurso })%>
            </td>
            <td>
                <%: item.IdCurso %>
            </td>
        </tr>
    
    <% } %>

    </table>
    <p>
        <%: Html.ActionLink("Crear nuevo Curso", "Create")%>
    </p>
</body>
</html>
