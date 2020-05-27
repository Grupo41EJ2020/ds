<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Editar Un Curso</title>
</head>
<body>
       <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>
        
        <fieldset>
            <legend>Datos</legend>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.IdCurso) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.IdCurso) %>
                <%: Html.ValidationMessageFor(model => model.IdCurso) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.IdEmpleado) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.IdEmpleado) %>
                <%: Html.ValidationMessageFor(model => model.IdEmpleado) %>
            </div>
            
            <p>
                <input type="submit" value="Guardar" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Regresar a la lista", "Index")%>
    </div>
</body>
</html>
