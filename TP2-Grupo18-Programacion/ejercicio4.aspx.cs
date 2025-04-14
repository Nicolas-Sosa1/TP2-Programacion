using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_Grupo18_Programacion
{
    public partial class ejercicio4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnValidar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.ToLower() == "claudio" && txtClave.Text.ToLower() == "casas")
            {
                Server.Transfer("ejercicio4-LogInSucceeded.aspx");
            }
            else
            {
                Server.Transfer("ejercicio4-LoginFail.aspx");
            }
        }

        protected void btnVolverPrincipal_Click(object sender, EventArgs e)
        {
            Response.Redirect("FormPrincipal.aspx");
        }
    }
}