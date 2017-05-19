using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

using ClassLibrary.EN;
using ClassLibrary.CAD;

namespace WebApplication1
{
    public partial class perfil : System.Web.UI.Page
    {
        
        // al cargar la pagina, si hay sesion activada te muestra tus datos, sino te redirecciona a registro
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] != null)
            {
                this.Label11.Text = "Podrá ver sus datos si esta registrado";   // Usuario
                this.Label12.Text = "Podrá ver sus datos si esta registrado";   // Direccion
                this.Label13.Text = "Podrá ver sus datos si esta registrado";   // Email
                this.Label17.Text = "Podrá ver sus datos si esta registrado";   // Ciudad
                this.Label14.Text = "Podrá ver sus datos si esta registrado";   // Pais
                this.Label15.Text = "Podrá ver sus datos si esta registrado";   // Edad
                this.Label16.Text = "Podrá ver sus datos si esta registrado";   // Descripcion
            }
            else
            {
                //MessageBox.Show("Usted ha sido redireccioando ya que no tiene abierta una sesion");
                Response.Redirect("login.aspx");
            }
            
        }

        // modificar el usuario (pendiente)
        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        // darse de baja
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Session["Usuario"] != null)
            {
                usuario user = new usuario();
                user.borrarUsuario(Session["Usuario"].ToString());
            }
            else
            {
                MessageBox.Show("Error. No puede darse de baja si no ha iniciado sesion");
            }
        }
    }
}