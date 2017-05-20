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
            if (Session["usuario"] == null)
            {
                Response.Redirect("login.aspx");
            }            
        }

        // modificar el usuario
        protected void Button1_Click(object sender, EventArgs e)
        {
            string contraseña, direccion, email, ciudad, pais, descripcion;
            string edad = "";
            contraseña = direccion = email = ciudad = pais = descripcion = "";

            contraseña = this.contra.Text;
            direccion = this.dir.Text;
            email = this.ema.Text;
            ciudad = this.ciu.Text;
            pais = this.pai.Text;
            descripcion = this.desc.Text;
            edad = this.ed.ToString();
            
            if (contraseña != "" && direccion != "" && email != "" && ciudad != "" && pais != "" && descripcion != "" && edad != "")
            {
                usuario userAux = new usuario();

                userAux.Usuario = Session["usuario"].ToString();
                userAux.Contrasena = contraseña;
                userAux.Direccion = direccion;
                userAux.Email = email;
                userAux.Ciudad = ciudad;
                userAux.Pais = pais;
                userAux.Descripcion = descripcion;
                userAux.Edad = int.Parse(edad);

                // modifica el usuario
                userAux.modificarUsuario();
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