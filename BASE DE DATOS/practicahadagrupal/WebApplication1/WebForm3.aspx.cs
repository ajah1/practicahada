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
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [System.Web.Services.WebMethod]
        public static double Sumar(double Valor1, double Valor2)
        {

            puntuacion p = new puntuacion();

            p.user = "hola3";
            p.p = 10;
            p.updatePuntuacion();

            return Valor1 + Valor2;
        }
    }
}