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
        }

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


        protected void actualizarProductos(List<Producto> p) {
            ocultar();

            for (int i = 0; i < p.Count; i++) {
                switch (i)
                {
                    case 0:
                        hueco0.Visible = true;
                        Label0.Text = p[0].Nombre;
                        Labelr0.Text = p[0].Descripcion;
                        Image0.ImageUrl = p[0].Imagen;
                        Button0.Text = p[0].Precio.ToString() + " €";
                        break;
                    case 1:
                        hueco1.Visible = true;
                        Label1.Text = p[1].Nombre;
                        Labelr1.Text = p[1].Descripcion;
                        Image1.ImageUrl = p[1].Imagen;
                        Button1.Text = p[1].Precio.ToString() + " €";
                        break;
                    case 2:
                        hueco2.Visible = true;
                        Label2.Text = p[2].Nombre;
                        Labelr2.Text = p[2].Descripcion;
                        Image2.ImageUrl = p[2].Imagen;
                        Button2.Text = p[2].Precio.ToString() + " €";
                        break;
                    case 3:
                        hueco3.Visible = true;
                        Label3.Text = p[3].Nombre;
                        Labelr3.Text = p[3].Descripcion;
                        Image3.ImageUrl = p[3].Imagen;
                        Button3.Text = p[3].Precio.ToString() + " €";
                        break;
                    case 4:
                        hueco4.Visible = true;
                        Label4.Text = p[4].Nombre;
                        Labelr4.Text = p[4].Descripcion;
                        Image4.ImageUrl = p[4].Imagen;
                        Button4.Text = p[4].Precio.ToString() + " €";
                        break;
                    case 5:
                        hueco5.Visible = true;
                        Label5.Text = p[5].Nombre;
                        Labelr5.Text = p[5].Descripcion;
                        Image5_1.ImageUrl = p[5].Imagen;
                        Button5.Text = p[5].Precio.ToString() + " €";
                        break;
                    case 6:
                        hueco6.Visible = true;
                        Label6.Text = p[6].Nombre;
                        Labelr6.Text = p[6].Descripcion;
                        Image6_1.ImageUrl = p[6].Imagen;
                        Button6.Text = p[6].Precio.ToString() + " €";
                        break;
                    case 7:
                        hueco7.Visible = true;
                        Label7.Text = p[7].Nombre;
                        Labelr7.Text = p[7].Descripcion;
                        Image7_1.ImageUrl = p[7].Imagen;
                        Button7.Text = p[7].Precio.ToString() + " €";
                        break;
                }
            }
        }

        protected void Buttonprod0_Click(object sender, EventArgs e)
        {
            string name = Labelr0.Text;
            Response.Redirect("producto.spx?idProd=" + name);
            
        }

        protected void Buttonprod1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Producto.aspx?idProd=" + Labelr1.Text);
        }

        protected void Buttonprod2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Producto.aspx?idProd=" + Labelr2.Text);
        }

        protected void Buttonprod3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Producto.aspx?idProd=" + Labelr3.Text);
        }

        protected void Buttonprod4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Producto.aspx?idProd=" + Labelr4.Text);
        }

        protected void Buttonprod5_Click(object sender, EventArgs e)
        {
            Response.Redirect("Producto.aspx?idProd=" + Labelr5.Text);
        }

        protected void Buttonprod6_Click(object sender, EventArgs e)
        {
            Response.Redirect("Producto.aspx?idProd=" + Labelr6.Text);
        }

        protected void Buttonprod7_Click(object sender, EventArgs e)
        {
            Response.Redirect("Producto.aspx?idProd=" + Labelr7.Text);
        }
    }
}