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
    public partial class WebForm1 : System.Web.UI.Page
    {
        /*
        // actualiza la puntuación de un usuario
        void updatePuntuacion(int addScore)
        {
            puntuacion score = new puntuacion();
            
            // temporal
            string usuario = "hola3";

            // cuando tengamos la sesiones hechas
            //user.Usuario = (string)Session["usuario"];
            
            // actualizar puntuación del usuario
            score.p = addScore;
            score.user = usuario;
            score.updatePuntuacion();
        }*/

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
            }

        }

        public static void update(string puntuacion)
        {
            puntuacion score = new puntuacion();

            // temporal
            string usuario = "hola3";

            // cuando tengamos la sesiones hechas
            //user.Usuario = (string)Session["usuario"];

            // actualizar puntuación del usuario
            score.p = int.Parse(puntuacion);
            score.user = usuario;
            score.updatePuntuacion();

        }

    }
}