using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ClassLibrary.CAD;
using ClassLibrary.EN;

namespace WebApplication1
{
    public partial class pruebasAlex : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }




        /*
        // boton para obtener la siguente promocion
        public void Button1_Click(object sender, EventArgs e)
        {
            int idpromocion = 3;

            List<string> salida = new List<string>();
            salida = null;

            Promocion aux = new Promocion();
            aux.Id_promocion = 3;

            CADpromocion aux1 = new CADpromocion();

            salida = aux.readPromocion();
            //salida = aux1.read(idpromocion);
            // si lis<string> tiene elemento mostrar sus datos
            
            if (salida != null)
            {
                
                this.TextBox5.Text = salida[0];
                //this.TextBox6.Text += leer[0];
                //this.TextBox7.Text += leer[1];
                //this.TextBox8.Text += leer[2];
                //this.TextBox9.Text += leer[3];
            }

        }

        // boton para obtener la anterior promocion
        protected void Button2_Click(object sender, EventArgs e)
        {
            // si string devuelto es vaxio ("") busco otro
        }
        */
    }
}