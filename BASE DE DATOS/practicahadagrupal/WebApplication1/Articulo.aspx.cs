using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary.EN;
using ClassLibrary.CAD;

namespace WebApplication1
{
    public partial class Articulo : System.Web.UI.Page
    {
        //Nos lleva a la pagina de compra del producto seleccionado. 
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["productoId"]);

            Producto producto = new Producto(id);

            NomProd.Text=producto.Nombre;
            Image1.ImageUrl = producto.Imagen;
            CantPrecio.Text = producto.Precio.ToString()+ " PUNTOS ";

            if (Session["user"] != null)
            {
                Button1.Visible = true;
                Label4.Visible = false;
            }
            else
            {
                Button1.Visible = false;
                Label4.Visible = true;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //MARIO ESTE ES EL METODO QUE EJECUTA EL BOTON DE COMPRAR, DE MOMENTO NO HACE NADA
            //AHORA YA TU, LE PONES LO QUE QUIERAS Y LLAMAS A LOS METODOS QUE NECESITES
        }
    }
}