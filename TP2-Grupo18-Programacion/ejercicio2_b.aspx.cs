using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_Grupo18_Programacion
{
    public partial class ejercicio2_b : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string nombre;
            nombre = Request["txtNombre"].ToString();
            lblNombre.Text = nombre;

            string apellido;
            apellido = Request["txtApellido"].ToString();
            lblApellido.Text = apellido;

        }
        protected void btnVolverEj2_Click(object sender, EventArgs e)
        {
            Response.Redirect("ejercicio2.aspx");
        }
    }
}  