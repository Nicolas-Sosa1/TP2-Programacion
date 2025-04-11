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

        private bool NoEsNumero(char c)
        {
            //valida que solo sean digitos del 0 al 9
            return !char.IsDigit(c);
        }
        private bool NoEsLetra(char c)
        {
            //valida que solo sean letras mayusculas o minusculas
            return !char.IsLetter(c);
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

            // Validacion cantidades solo numeros
            if (txtCantidad1.Text.Any(NoEsNumero) || txtCantidad2.Text.Any(NoEsNumero))
            {
                lblError.Text = "Las cantidades deben contener solo números.";
                lblTabla.Text = "";
                return;
            }
            
            //Validacion nombre solo letras
            if (txtProducto1.Text.Any(NoEsLetra) || txtProducto2.Text.Any(NoEsLetra))
            {
                lblError.Text = "Los nombres deben contener solo letras.";
                lblTabla.Text = "";
                return;
            }

            // Generar tabla
            String tabla = "<table border = '1'>";
            tabla += "<tr><th>Producto</th><th>Cantidad</th></tr>";
            for (int i = 1; i <= 3; i++)
            {
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