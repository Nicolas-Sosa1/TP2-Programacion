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

        protected void btnVolverPrincipal_Click(object sender, EventArgs e)
        {
            Response.Redirect("FormPrincipal.aspx");
        }

        protected void btnValidar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" && txtClave.Text == "")
            {
                lblError.Text = "Debe ingresar un Usuario y una Clave";
            }
            else if (txtUsuario.Text != "" && txtClave.Text == "")
            {
                lblError.Text = "Debe ingresar una Clave";
            }
            else if (txtUsuario.Text == "" && txtClave.Text != "")
            {
                lblError.Text = "Debe ingresar un Usuario";
            }
            else
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


        }
    }
}