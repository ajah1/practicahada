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
            if (Session["user"] != null)
            {
                Response.Redirect("login.aspx");
            }
        }


        //Este es el boton que registra al usuario y realiza todas las comprobaciones o llama a los metodos correspondientes que las prueban.
        protected void Button1_Click(object sender, EventArgs e)
        {
            usuario aux = new usuario();
            aux.Usuario = this.TextBox1.Text;
            if (aux.existe() == true){

                MessageBox.Show("Error. Ya hay un usuario registrado con este nombre");
            } else{

                string usuario = "";
                string password = "";
                string direccion = "";
                string email = "";
                string ciudad = "";
                string pais = "";
                int edad = -1;
                string descripcion = "";


                int number;
                bool numero = false;
                bool fallo = false;


                usuario = this.TextBox1.Text;
                password = this.TextBox2.Text;
                direccion = this.TextBox3.Text;
                email = this.TextBox4.Text;
                ciudad = this.TextBox5.Text;
                pais = this.TextBox6.Text;
                descripcion = this.TextBox8.Text;
                if (this.TextBox7.Text != ""){
                    
                    
                    numero = int.TryParse(this.TextBox7.Text, out number);
                    if (numero == true)
                    {
                        edad = int.Parse(this.TextBox7.Text);
                    }else {
                        MessageBox.Show("Error. Edad esta mal escrito.");
                        fallo = true;
                    }
                }
                
                

                string s = this.TextBox7.Text;



                if (fallo == false){
                    if (usuario == "" || password == "" || direccion == "" || email == "" || ciudad == "" || pais == ""
                        || edad == -1 || descripcion == "")
                    {

                        MessageBox.Show("Error. No puede haber ningun dato sin completar");

                    }
                    else
                    {

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
                    }
                }
            }
        }
    }
}