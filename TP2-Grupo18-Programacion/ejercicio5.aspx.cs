using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_Grupo18_Programacion
{
    public partial class ejercicio5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //DDL
                ddlMemoria.Items.Add(new ListItem("2GB", "200"));
                ddlMemoria.Items.Add(new ListItem("4GB", "375"));
                ddlMemoria.Items.Add(new ListItem("6GB", "500"));

                //CBL
                cblAccesorios.Items.Add(new ListItem("Monitor LCD", "2000,50"));
                cblAccesorios.Items.Add(new ListItem("HD 500GB", "550,50"));
                cblAccesorios.Items.Add(new ListItem("Grabador DVD", "1200"));
            }
        }

        protected void btnVolverPrincipal_Click(object sender, EventArgs e)
        {
            Response.Redirect("FormPrincipal.aspx");
        }
    }
}