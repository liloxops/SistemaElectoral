<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Votar_Candidato.aspx.cs" Inherits="SistemaElectoral.View.Votar_Candidato" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Elecciones 2018</title>
</head>
<body>

    <h1>Elija Un Presidente</h1>
    <form>
        <table border="1">
            <tr>
                <th>Nombre presidente</th>
                <th>Partido</th>
                <th>Elegir</th>
                <th>Votar</th>

            </tr>
            <tr>
                <td>Piñera</td>
                <td>a</td>
                <td>
                    <input type="radio" value="radioVoto" name="voto" checked="checked" />
                </td>
                <td>
                    <input type="button" value="votar" name="btnVotar" />
                </td>
            </tr>
            <tr>
                <td><</td>
                <td>a</td>
                <td>
                    <input type="radio" value="radioVoto" name="voto" />
                </td>
                <td>
                    <input type="button" value="votar" name="btnVotar" />
                </td>
            </tr>
            <tr>
                <td>Kast</td>
                <td>a</td>
                <td>
                    <input type="radio" value="radioVoto" name="voto" />
                </td>
                <td>
                    <input type="button" value="votar" name="btnVotar" />
                </td>
            </tr>
            <tr>
                <td>Guiller</td>
                <td>a</td>
                <td>
                    <input type="radio" value="radioVoto" name="voto" />
                </td>
                <td>
                    <input type="button" value="votar" name="btnVotar" />
                </td>
            </tr>
            <tr>
                <td>Goic</td>
                <td>a</td>
                <td>
                    <input type="radio" value="radioVoto" name="voto" />
                </td>
                <td>
                    <input type="button" value="votar" name="btnVotar" />
                </td>
            </tr>
            <tr>
                <td>Artes</td>
                <td>a</td>
                <td>
                    <input type="radio" value="radioVoto" name="voto" />
                </td>
                <td>
                    <input type="button" value="votar" name="btnVotar" />
                </td>
            </tr>
            <tr>
                <td>Navarro</td>
                <td>a</td>
                <td>
                    <input type="radio" value="radioVoto" name="voto" />
                </td>
                <td>
                    <input type="button" value="votar" name="btnVotar" />
                </td>
            </tr>
            <tr>
                <td>Ominami</td>
                <td>a</td>
                <td>
                    <input type="radio" value="radioVoto" name="voto" />
                </td>
                <td>
                    <input type="button" value="votar" name="btnVotar" />
                </td>
            </tr>


        </table>
    </form>
</body>
</html>
