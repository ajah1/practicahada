﻿using System;
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

        }

        [System.Web.Services.WebMethod]
        public double Sumar(double Valor1)
        {

            puntuacion p = new puntuacion();

            p.user = Session["user"].ToString();
            p.p = (int)Valor1;
            p.updatePuntuacion();

            return 0;
        }

    }
}