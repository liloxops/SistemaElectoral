<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="SistemaElectoral.View.Error" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <h1>Error De Inicio De Sesion</h1>
    <% 
        try {
            String error = Session["error"].ToString();

            if (error == null) {
                Response.Redirect("Default.aspx");
            }
        } catch (Exception) {
            Response.Redirect("../view/InicioSesion.aspx");
        }
        %>

   <a href="Index.aspx">Volver</a>
</body>
</html>
