<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ejercicio2.aspx.cs" Inherits="TP2_Grupo18_Programacion.ejercicio2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Nombre:&nbsp;
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <br />
            <br />
            Apellido:
            <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
            <br />
            <br />
            Ciudad:&nbsp;&nbsp;
            <asp:DropDownList ID="ddlCiudad" runat="server"></asp:DropDownList>
            <br />
            <br />
            Temas:<br />
            <asp:CheckBoxList ID="cblTemas" runat="server">
            </asp:CheckBoxList>
            <br />
            <br />
            <br />
            <asp:Button ID="btnEnviar" runat="server" Text="Ver resumen" OnClick="btnEnviar_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnVolverPrincipal" runat="server" OnClick="btnVolverPrincipal_Click1" Text="Volver" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            
        </div>
    </form>
</body>
</html>
