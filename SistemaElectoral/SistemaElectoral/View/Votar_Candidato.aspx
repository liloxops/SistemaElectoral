<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Votar_Candidato.aspx.cs" Inherits="SistemaElectoral.View.Votar_Candidato" %>

<%@ Import Namespace="SistemaElectoral.Model" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Elecciones 2018</title>
</head>
<body>
    <% Data d = new Data();%>
    <h1>Elija Un Candidato</h1>
    <form action="../Controller/votacionHandler.ashx" method="post">
        <table border="1">
            <tr>
                <th>Nombre Candidatos</th>
                <th>Elegir</th>

            </tr>
            <%
                foreach (Candidato c in d.getListaCandidatos())
                {
                    Response.Write("<tr>");
                    Response.Write("<td>" + c.Nombre + "</td>");
                    Response.Write("<td><input type='radio' value='" + c.Id + "' name='voto'/></td>");
                    Response.Write("</tr>");
                }
            %>
        </table>
        <%String idComuna = Context.Request.Params["result"]; %>
        <% Response.Write("<h2>" + idComuna + "</h2>"); %>
        <% Response.Write("<input type = 'hidden' name = 'comuna' value = " + idComuna + " >"); %>


        <p><% = idComuna %></p>
        <input type="submit" value="Votar" />
    </form>
</body>
</html>
