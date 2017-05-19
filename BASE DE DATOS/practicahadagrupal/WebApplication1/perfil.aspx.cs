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
        
        // al cargar la pagina, si hay sesion te deja modificar usuario o darte de baja, sino te redirecciona a registro
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null)
            {
                Response.Redirect("login.aspx");
            }
        }

        // modificar el usuario (pendiente)
        protected void Button1_Click(object sender, EventArgs e)
        {
            string usuarios, direccion, email, ciudad, pais, descripcion;
            int edad = 0;
            usuarios = direccion = email = ciudad = pais = descripcion = "";

            usuarios = this.users.Text;
            direccion = this.users.Text;
            email = this.users.Text;
            ciudad = this.users.Text;
            pais = this.users.Text;
            descripcion = this.users.Text;

            // añadir que la sesion coincide con el textbox usuarios
            if (usuarios != "" && direccion != "" && email != "" && ciudad != "" && pais != "" && descripcion != "")
            {
               //implementar
            }
            else
            {
                MessageBox.Show("Usted no ha rellenado todos los campos");
            }
        }

        // darse de baja
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Session["User"] != null)
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