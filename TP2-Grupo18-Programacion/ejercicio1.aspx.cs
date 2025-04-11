using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            if ((txtProducto1.Text.Trim() == ""
              || txtProducto2.Text.Trim() == ""
              || txtCantidad1.Text.Trim() == ""
              || txtCantidad2.Text.Trim() == ""))
            {
                lblError.Text = "Todos los campos son obligatorios.";
                lblTabla.Text = "";
                return;
            }
        }
    }
}