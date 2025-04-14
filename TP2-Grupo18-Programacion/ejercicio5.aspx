<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ejercicio5.aspx.cs" Inherits="TP2_Grupo18_Programacion.ejercicio5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ELIJA SU CONFIGURACION:<br />
            <br />
            Seleccione la cantidad de memoria:<br />
            <asp:DropDownList ID="ddlMemoria" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            Seleccione los accesorios:<asp:CheckBoxList ID="cblAccesorios" runat="server">
            </asp:CheckBoxList>
            <br />
            <asp:Button ID="btnCalcularPrecio" runat="server" Text="Calcular Precio" OnClick="btnCalcularPrecio_Click" />
            <br />
            <br />
            <br />
            <asp:Label ID="lblPrecio" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Button ID="btnVolverPrincipal" runat="server" OnClick="btnVolverPrincipal_Click" Text="Volver" />
        </div>
    </form>
</body>
</html>
