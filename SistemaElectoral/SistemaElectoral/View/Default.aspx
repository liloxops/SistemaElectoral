<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SistemaElectoral.View.Default" %>

<%@ Import Namespace="SistemaElectoral.Model" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Elecciones 2018</title>
    <script type="text/javascript"> 
       
        function comuna() {
            alert("Hola");
        }
       </script> 
</head>
<body>
    <script type="text/JavaScript"
        src="http://ajax.googleapis.com/ajax/libs/jquery/1.7.2/jquery.min.js"></script>
    <% Data d = new Data();%>
    <h1>Bienvenidos al Sistema Elecciones 2018</h1>

    <h2>Elija su Provincia</h2>
    <form action="Votar_Candidato.aspx">
        Provincia:
            
             <select id="cboPro" name="cboPro" onchange="cargarComuna()">
                 <option>--Seleccionar--</option>
                 <%
                     foreach (Provincia p in d.getListaProvincia()) {
                         Response.Write("<option value='" + p.Id + "'>" + p.Nombre + "</option>");
                     }
                 %>
             </select>

        <h2>Elija su Comuna</h2>

        Comuna:
            <select name="cboComuna" id="resultado">
               <option>--Seleccionar--</option>

                 <%
                     // foreach (Comuna p in d.getListaComuna()) {
                     //      Response.Write("<option value='" + p.Id + "'>" + p.Nombre + "</option>");
                     //   }
                 %>

            </select>



        <script type="text/javascript">   

            function cargarComuna() {
                alert("entro");
                
                var txtfitro = $('#cboPro').val()

                alert(txtfitro)
                $.ajax({
                    type: "POST",
                    url: "CargarComboComuna.ashx",

                    data: { filtro: $('#cboPro').val()},
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    async: "true",
                    cache: "false",
                    success: function (result) {
                        $("#resultado").html(result);
                    },
                    Error: function (x, e) {
                        // On Error
                    }
                });
            }
        </script>
        <br />
        <br />
        <input type="submit" value="Ir a votacion" />
    </form>

</body>
</html>
