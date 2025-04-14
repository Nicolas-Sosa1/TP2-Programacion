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

            
            string zona;
            DropDownList ddlzona = (DropDownList)PreviousPage.FindControl("ddlCiudad");
            zona = ddlzona.SelectedValue;
            lblZona.Text = zona;

            string temas = "";
            CheckBoxList cbltemas = (CheckBoxList)PreviousPage.FindControl("cblTemas");

            foreach (ListItem item in cbltemas.Items)
            {
                if (item.Selected)
                {
                    temas += "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + item.Text + "<br>";
                }
            }

            if (temas.Length > 0)
            {
                lblTemas.Text = temas;
            }
            else
            {
                lblTemas.Text = "No se seleccionaron temas";
            }

        }
       
    }
}  