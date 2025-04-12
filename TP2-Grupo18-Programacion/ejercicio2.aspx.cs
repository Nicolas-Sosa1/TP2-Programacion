using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_Grupo18_Programacion
{
    public partial class ejercicio2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                ListItem gralPacheco = new ListItem();
                gralPacheco.Text = "Gral. Pacheco";
                gralPacheco.Value = "Norte";

                ListItem sanMartin = new ListItem();
                sanMartin.Text = "San Miguel";
                sanMartin.Value = "Oeste";

                ListItem boedo = new ListItem();
                boedo.Text = "Boedo";
                boedo.Value = "Sur";

                ddlCiudad.Items.Add(gralPacheco);
                ddlCiudad.Items.Add(sanMartin);
                ddlCiudad.Items.Add(boedo);

                ListItem Ciencias = new ListItem();
                Ciencias.Text = "Ciencias";
                Ciencias.Value = "Ciencias";

                ListItem Literatura = new ListItem();
                Literatura.Text = "Literatura";
                Literatura.Value = "Literatura";

                ListItem Historia = new ListItem();
                Historia.Text = "Historia";
                Historia.Value = "Historia";

                cblTemas.Items.Add(Ciencias);
                cblTemas.Items.Add(Literatura);
                cblTemas.Items.Add(Historia);

            }
        }
        private bool NoEsLetra(char c)
        {
            //se valida que solo sean letras mayusculas o minusculas
            return !char.IsLetter(c);
        }


        protected void btnVolverPrincipal_Click(object sender, EventArgs e)
        {
            Response.Redirect("FormPrincipal.aspx");
        }
    }
}