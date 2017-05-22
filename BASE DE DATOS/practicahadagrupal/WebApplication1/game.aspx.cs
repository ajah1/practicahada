using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ClassLibrary.EN;
using ClassLibrary.CAD;
using System.Windows.Forms;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
            puntuacion p = new puntuacion();
            p.user = Session["user"].ToString();
            p.p = 10;
            p.v = 1;
            p.updatePuntuacion();
            p.updateVidas();
            }
            else
            {
                Response.Redirect("login.aspx");
            }
        }

        public void Sumar(int valor1)
        {
            puntuacion p = new puntuacion();

            p.user = Session["user"].ToString();
            p.p = valor1;
            p.v = 1;
            p.updatePuntuacion();
            p.updateVidas();
        }

    }
}
