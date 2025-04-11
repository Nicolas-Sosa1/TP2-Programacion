using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_Grupo18_Programacion
{
    public partial class ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnVolverPrincipal_Click(object sender, EventArgs e)
        {
            Response.Redirect("FormPrincipal.aspx");
        }

        protected void btnGenerarTabla_Click(object sender, EventArgs e)
        {
            String tabla = "<table border = '1'>";
            tabla += "<tr><th>Producto</th><th>Cantidad</th></th>";
            for (int i = 1; i <= 3; i++) {
                
                tabla += "<tr>";
                tabla += "<td> n/a </td>"; 
                tabla += "<td> n/a </td>";
                tabla += "</tr>";
            }
            tabla += "</table>";
            lblTabla.Text = tabla;
        }
    }
}