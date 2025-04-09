<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormPrincipal.aspx.cs" Inherits="TP2_Grupo18_Programacion.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Pagina Principal del TP2-Programacion 3<br />
            <br />
            <asp:Button ID="btnEjercicio1" runat="server" OnClick="btnEjercicio1_Click" Text="Ejercicio1" />
&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Ejercicio2" />
&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Ejercicio3" />
&nbsp;&nbsp;
            <asp:Button ID="btnEjercicio4" runat="server" OnClick="btnEjercicio4_Click" Text="Ejercicio 4" />
&nbsp;&nbsp;
            <asp:Button ID="btnEjercicio5" runat="server" OnClick="btnEjercicio5_Click" Text="Ejercicio 5" />
        </div>
    </form>
</body>
</html>
