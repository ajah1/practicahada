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
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // FALTA CORREGIR CUANDO SE MUESTRA EL LABEL DEL PANELADMINISTRADOR
                //Page.ClientScript.RegisterStartupScript(this.GetType(), "clientscript", "document.getElementById('algo').style.display = 'block';", true);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            usuario useraux = new usuario();
            useraux.Usuario = this.TextBox3.Text;
            useraux.Contrasena = this.TextBox2.Text;

            Session["user"] = this.TextBox3.ToString();

            // en caso de intentar loguearse de nuevo, salta mensaje error
            if (Session["user"] != null && useraux.Usuario == Session["user"].ToString())
                MessageBox.Show("Ya has iniciado sesion");

            // comprobaciones de campos vacios
            else if (useraux.Usuario == "" || useraux.Contrasena == "")
                MessageBox.Show("Faltan campos por rellenar");

            // si el usuario es administrador...
            else if (useraux.Usuario == "admin" && useraux.comprobarPass() == true)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "clientscript", "document.getElementById('algo').style.display = 'block';", true);
                Session["user"] = "admin";
                Response.Redirect("admin.aspx");
            }

            // si es usuario...
            else if (useraux.existe() == true && useraux.comprobarPass() == true)
            {
                
                puntuacion p = new puntuacion();
                p.user = useraux.Usuario;
                
                List<string> l = new List<string>();
                l = p.readPuntuacion();

                int vidasActuales = int.Parse(l[1]);

                //si no tiene vidas, regidirigir a productos, para que compre
                if (vidasActuales == 0)
                {
                    MessageBox.Show("Tiene 0 vidas, puedes compralas en la tienda :D");
                    Response.Redirect("productos.aspx");
                }
                
                // si tienes vidas te lleva a game
                Response.Redirect("game.aspx");
            }
            else
            {
                Session["user"] = null;
                MessageBox.Show("Hay campos incorrectos");
            }

        


        }
    }
}





