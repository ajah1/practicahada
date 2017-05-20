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
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // borrar cualquier usuario 
        protected void Button1_Click(object sender, EventArgs e)
        {
            string nombre = "";
            usuario userAux = new usuario();

            nombre = this.TextBox1.Text;

            // si el nombre no esta vacio
            if (nombre != "")
            {
                userAux.Usuario = nombre;

                // si existe en la base de datos
                if (userAux.existe() == true)
                {
                    userAux.borrarUsuario(nombre);
                }
                else
                {
                    MessageBox.Show("El usuario que ha metido no existe en la Base de Datos");
                }
            }
            else
            {
                MessageBox.Show("No ha rellenado el campo indicado");
            }
        }
    }
}