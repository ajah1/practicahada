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

        // borrar una promo
        protected void Button2_Click(object sender, EventArgs e)
        {
            int id_promocion = 0;
            Promocion promo = new Promocion();

            id_promocion = int.Parse(this.TextBox2.Text);

            if (id_promocion != 0)
            {
                promo.Id_promocion = id_promocion;

                if (promo.existe() == true)
                {
                    promo.removePromocion();
                }
                else
                {
                    MessageBox.Show("No existe la promo indicada");
                }

            }
            else
            {
                MessageBox.Show("No ha rellenado el campo indicado");
            }

        }


        // insertar promo
        protected void Button3_Click(object sender, EventArgs e)
        {
            int id_producto = 0;
            int id_promocion = 0;
            int descuento = 0;
            DateTime ini, fin;

            id_producto = int.Parse(this.TextBox3.Text);
            id_promocion = int.Parse(this.TextBox4.Text);
            descuento = int.Parse(this.TextBox5.Text);
            ini = DateTime.Parse(this.TextBox6.Text);
            fin = DateTime.Parse(this.TextBox6.Text);

            if (id_producto != 0 && id_promocion != 0 && descuento != 0 && ini != null && fin != null)
            {
                Promocion promo = new Promocion();

                promo.Id_producto = id_producto;
                promo.Id_promocion = id_promocion;
                promo.Descuento = descuento;
                promo.F_Inicio = ini;
                promo.F_limite = fin;

                promo.addPromocion();
            }
            else
            {
                MessageBox.Show("No ha rellenado el campo indicado");
            }
        }
    }
}