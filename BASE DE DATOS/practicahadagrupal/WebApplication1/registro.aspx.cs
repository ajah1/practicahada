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
    public partial class registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            string usuario = "";
            string password = "";
            string direccion = "";
            string email = "";
            string ciudad = "";
            string pais = "";
            int edad = -1;
            string descripcion = "";

            usuario = this.TextBox1.Text;
            password = this.TextBox2.Text;
            direccion = this.TextBox3.Text;
            email = this.TextBox4.Text;
            ciudad = this.TextBox5.Text;
            pais = this.TextBox6.Text;
            if (this.TextBox7.Text != "") {
                edad = int.Parse(this.TextBox7.Text);
            }
            descripcion = this.TextBox8.Text;

            string s = this.TextBox7.Text;
        
            
            
            /*
            if (usuario == "" || password == "" || direccion == "" || email == "" || ciudad == "" || pais == ""
                || edad == -1 || descripcion == "") {

                MessageBox.Show("Error. No puede haber ningun dato sin completar");

            }
            else {
            */
                usuario u = new usuario();

                u.Usuario = usuario;
                u.Contrasena = password;
                u.Direccion = direccion;
                u.Email = email;
                u.Ciudad = ciudad;
                u.Pais = pais;
                u.Edad = edad;
                u.Descripcion = descripcion;

                u.registrarUsuario();

                Response.Redirect("login.aspx");
            //}
        }
    }
}