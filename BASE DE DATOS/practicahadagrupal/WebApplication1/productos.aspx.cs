using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using ClassLibrary.EN;
using ClassLibrary.CAD;

namespace WebApplication1
{
    public partial class productos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ocultar();
            Buttonacer_Click(sender, e);
        }

        //Oculta los visibilidad de los labels
        protected void ocultar() {
            for (int i = 0; i <= 7; i++) {
                switch (i) {
                    case 0:
                        hueco0.Visible = false;
                        break;
                    case 1:
                        hueco1.Visible = false;
                        break;
                    case 2:
                        hueco2.Visible = false;
                        break;
                    case 3:
                        hueco3.Visible = false;
                        break;
                    case 4:
                        hueco4.Visible = false;
                        break;
                    case 5:
                        hueco5.Visible = false;
                        break;
                    case 6:
                        hueco6.Visible = false;
                        break;
                    case 7:
                        hueco7.Visible = false;
                        break;
                }

            }

        }

        //Actualiza la vista de la pagina a partir de la lista de articulos que hay ne la Base de DAtos.
        protected void actualizarProductos(List<Producto> p) {
            ocultar();

            for (int i = 0; i < p.Count; i++) {
                switch (i)
                {
                    case 0:
                        hueco0.Visible = true;
                        Label0.Text = p[0].Nombre;
                        Labeli0.Text = p[0].Id.ToString();
                        Labelr0.Text = p[0].Descripcion;
                        Imagen0.Src = p[0].Imagen;
                        Button0.Text = p[0].Precio.ToString() + " puntos";
                        break;
                    case 1:
                        hueco1.Visible = true;
                        Label1.Text = p[1].Nombre;
                        Labeli1.Text = p[1].Id.ToString();
                        Labelr1.Text = p[1].Descripcion;
                        Imagen1.Src = p[1].Imagen;
                        Button1.Text = p[1].Precio.ToString() + " puntos";
                        break;
                    case 2:
                        hueco2.Visible = true;
                        Label2.Text = p[2].Nombre;
                        Labeli2.Text = p[2].Id.ToString();
                        Labelr2.Text = p[2].Descripcion;
                        Imagen2.Src = p[2].Imagen;
                        Button2.Text = p[2].Precio.ToString() + " puntos";
                        break;
                    case 3:
                        hueco3.Visible = true;
                        Label3.Text = p[3].Nombre;
                        Labeli3.Text = p[3].Id.ToString();
                        Labelr3.Text = p[3].Descripcion;
                        Imagen3.Src = p[3].Imagen;
                        Button3.Text = p[3].Precio.ToString() + " puntos";
                        break;
                    case 4:
                        hueco4.Visible = true;
                        Label4.Text = p[4].Nombre;
                        Labeli4.Text = p[4].Id.ToString();
                        Labelr4.Text = p[4].Descripcion;
                        Imagen4.Src = p[4].Imagen;
                        Button4.Text = p[4].Precio.ToString() + " puntos";
                        break;
                    case 5:
                        hueco5.Visible = true;
                        Label5.Text = p[5].Nombre;
                        Labeli5.Text = p[5].Id.ToString();
                        Labelr5.Text = p[5].Descripcion;
                        Imagen5.Src = p[5].Imagen;
                        Button5.Text = p[5].Precio.ToString() + " puntos";
                        break;
                    case 6:
                        hueco6.Visible = true;
                        Label6.Text = p[6].Nombre;
                        Labeli6.Text = p[6].Id.ToString();
                        Labelr6.Text = p[6].Descripcion;
                        Imagen6.Src = p[6].Imagen;
                        Button6.Text = p[6].Precio.ToString() + " puntos";
                        break;
                    case 7:
                        hueco7.Visible = true;

                        Label7.Text = p[7].Nombre;
                        Labeli7.Text = p[7].Id.ToString();
                        Labelr7.Text = p[7].Descripcion;
                        Imagen7.Src = p[7].Imagen;
                        Button7.Text = p[7].Precio.ToString() + " puntos";
                        break;
                }
            }
        }
        //Muestra el producto y su opcion de compra.
        protected void Buttonprod0_Click(object sender, EventArgs e)
        {
            Response.Redirect("Articulo.aspx?productoId=" + Labeli0.Text);
        }
        //Muestra el producto y su opcion de compra.
        protected void Buttonprod1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Articulo.aspx?productoId=" + Labeli1.Text);
        }
        //Muestra el producto y su opcion de compra.
        protected void Buttonprod2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Articulo.aspx?productoId=" + Labeli2.Text);
        }
        //Muestra el producto y su opcion de compra.
        protected void Buttonprod3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Articulo.aspx?productoId=" + Labeli3.Text);
        }
        //Muestra el producto y su opcion de compra.
        protected void Buttonprod4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Articulo.aspx?productoId=" + Labeli4.Text);
        }
        //Muestra el producto y su opcion de compra.
        protected void Buttonprod5_Click(object sender, EventArgs e)
        {
            Response.Redirect("Articulo.aspx?productoId=" + Labeli5.Text);
        }
        //Muestra el producto y su opcion de compra.
        protected void Buttonprod6_Click(object sender, EventArgs e)
        {
            Response.Redirect("Articulo.aspx?productoId=" + Labeli6.Text);
        }
        //Muestra el producto y su opcion de compra.
        protected void Buttonprod7_Click(object sender, EventArgs e)
        {
            Response.Redirect("Articulo.aspx?productoId=" + Labeli7.Text);
        }

        //Muestra todos los Productos de la Base de Datos.
        protected void Buttonacer_Click(object sender, EventArgs e)
        {
            List<Producto> p = Producto.mostrarTodos();

            actualizarProductos(p);
        }
    }
}