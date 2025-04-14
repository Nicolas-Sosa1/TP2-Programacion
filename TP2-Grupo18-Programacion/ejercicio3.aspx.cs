using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_Grupo18_Programacion
{
    public partial class ejercicio3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnVolverPrincipal_Click(object sender, EventArgs e)
        {
            Response.Redirect("FormPrincipal.aspx");
        }

        protected void lnRojo_Click(object sender, EventArgs e)
        {
            lblTexto.ForeColor = System.Drawing.Color.Red;
        }

        protected void lnAzul_Click(object sender, EventArgs e)
        {
            lblTexto.ForeColor = System.Drawing.Color.Blue;
        }

        protected void lnVerde_Click1(object sender, EventArgs e)
        {
            lblTexto.ForeColor = System.Drawing.Color.Green;
        }
    }
}