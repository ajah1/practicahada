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
        
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string usuario = "";
            string pass = "";

            usuario = this.TextBox3.Text;
            pass = this.TextBox2.Text;


            if (usuario == "")
                MessageBox.Show("El campo usuario sin rellenar");
            else if (pass == "")
                MessageBox.Show("El campo password sin rellenar");
            else if (usuario == "" && pass == "")
                MessageBox.Show("Ambos campos están vacios");
            else
            {
                Session["usuario"] = usuario;
                Response.Redirect("game.aspx");
            }
            // FALTA CONTROLAR QUE EL USUARIO SEA ADMINISTRADOR CUANDO HAGAMOS LAS PESTAÑA
            // el usuario este en la base de datos

        }
    }
}