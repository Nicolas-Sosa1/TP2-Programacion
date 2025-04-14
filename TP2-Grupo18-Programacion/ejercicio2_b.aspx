<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ejercicio2_b.aspx.cs" Inherits="TP2_Grupo18_Programacion.ejercicio2_b" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblResumen" runat="server" Text="Resumen" Font-Size="X-Large" Font-Bold="true"></asp:Label>
            <br />
            <br />
            Nombre:&nbsp; <asp:Label ID="lblNombre" runat="server"></asp:Label>
            <br />
            <br />
            Apellido:&nbsp; <asp:Label ID="lblApellido" runat="server"></asp:Label>
            <br />
            <br />
            Zona:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblZona" runat="server"></asp:Label>
            <br />
            <asp:Button ID="btnVolverEj2" runat="server" OnClick="btnVolverEj2_Click" Text="Volver" />
        </div>
    </form>
</body>
</html>