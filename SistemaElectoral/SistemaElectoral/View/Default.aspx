<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SistemaElectoral.View.Default" %>

<%@ Import Namespace="SistemaElectoral.Model" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Elecciones 2018</title>
    <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
    <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
</head>
<body>

    <% Data d = new Data();%>
    <%
        try
        {
            Usuario u = (Usuario)Session["usuario"];
            if (u == null)
            {
                Response.Redirect("InicioSesion.aspx");
            }
        }
        catch (Exception)
        {
            Response.Redirect("InicioSesion.aspx");
        }

    %>
    <h1>Bienvenidos al Sistema Elecciones 2018</h1>

    <h2>Elija su Provincia</h2>
    <form action="Votar_Candidato.aspx">
        Provincia:
            
             <select id="cboPro" name="cboPro" onchange="cboComuna()">
                 <option>--Seleccionar--</option>
                 <%
                     foreach (Provincia p in d.getListaProvincia())
                     {
                         Response.Write("<option value='" + p.Id + "'>" + p.Nombre + "</option>");
                     }
                 %>
             </select>

        <h2>Elija su Comuna</h2>

        Comuna:
            <select id="resultado" name="result" onchange="comu()">
                <option>--Seleccionar--</option>

                <%
                    //foreach (Comuna p in d.getListaComuna()) {
                    //     Response.Write("<option value='" + p.Id + "'>" + p.Nombre + "</option>");
                    //  }
                %>
            </select>
        <script>
            function comu() {
                var idCom = $("#resultado").val();

            }
            function cboComuna() {
                var id = $("#cboPro").val();

                $.ajax({
                    url: "../Controller/CargarComboComuna.ashx",
                    data: {
                        id: id
                    },
                    success: function (result) {
                        $("#resultado").html(result);
                    }
                });
            }
        </script>
        <br />
        <br />
        <input type="submit" value="Ir a votacion" />

        <br />
        <br />

    </form>
    <a href="EstadisticasVotacion.aspx">Ir a estadisticas</a>

    <br />
    <a href="../Controller/cerrarSesionHandler.ashx"> Cerrar Sesion</a>
    

</body>
</html>
