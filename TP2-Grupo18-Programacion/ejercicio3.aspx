<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ejercicio3.aspx.cs" Inherits="TP2_Grupo18_Programacion.ejercicio3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LinkButton ID="lnRojo" runat="server">Rojo</asp:LinkButton>
            <br />
            <asp:LinkButton ID="lnAzul" runat="server">Azul</asp:LinkButton>
            <br />
            <br />
            <asp:Button ID="btnVolverPrincipal" runat="server" OnClick="btnVolverPrincipal_Click" Text="Volver" />
        </div>
    </form>
</body>
</html>
