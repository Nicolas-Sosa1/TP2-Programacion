<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ejercicio1.aspx.cs" Inherits="TP2_Grupo18_Programacion.ejercicio1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Ingrese el nombre del producto:&nbsp;&nbsp;
            <asp:TextBox ID="txtProducto1" runat="server"></asp:TextBox>
            &nbsp;<br />
            <br />
            Ingrese el nombre del producto:&nbsp;&nbsp;
            <asp:TextBox ID="txtProducto2" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="btnVolverPrincipal" runat="server" OnClick="btnVolverPrincipal_Click" Text="Volver" />
        </div>
    </form>
</body>
</html>
