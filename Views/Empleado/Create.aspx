﻿<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MVCLaboratorio.Models.Empleado>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Crear Empleado</title>
</head>
<body>
    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>DATOS</legend>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.idEmpleado) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.idEmpleado) %>
                <%: Html.ValidationMessageFor(model => model.idEmpleado) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.nombre) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.nombre) %>
                <%: Html.ValidationMessageFor(model => model.nombre) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.direccion) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.direccion) %>
                <%: Html.ValidationMessageFor(model => model.direccion) %>
            </div>
            
            <p>
                <input type="submit" value="Crear" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Regresar a la lista", "Index") %>
    </div>

</body>
</html>

