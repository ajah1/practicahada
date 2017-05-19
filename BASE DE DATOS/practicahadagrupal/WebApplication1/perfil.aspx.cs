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
            // cambiar esto
            if (Session["user"] != null)
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
            direccion = this.dir.Text;
            email = this.ema.Text;
            ciudad = this.ciu.Text;
            pais = this.pai.Text;
            descripcion = this.desc.Text;
            
            // añadir que la sesion coincide con el textbox usuarios
            if (usuarios != "" && direccion != "" && email != "" && ciudad != "" && pais != "" && descripcion != "")
            {
                //implementar
                MessageBox.Show("Furula");
            }
            else
            {
                MessageBox.Show("Usted no ha rellenado todos los campos");
            }
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