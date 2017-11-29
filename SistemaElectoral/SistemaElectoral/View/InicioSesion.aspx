<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InicioSesion.aspx.cs" Inherits="SistemaElectoral.View.InicioSesion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form action="../Controller/InicioSesionHandler.ashx" method="post">
        <input type="text" name="txt_Nom" placeholder="Usuario: ">
        <br>
        <input type="password" name="txt_Pass" placeholder="Password: ">
        <br>
        <input type="submit" value="Iniciar Sesion">
    </form>
</body>
</html>
