using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace ClassLibrary
{

    // clase para probar si funciones los EN / CAD
    public class pruebas
    {

        /**** probar conexion y editar la bd ****/
        int id;
        string nombre = "ponceDoce";
        string descripcion = "muchas cosas";
        string imagen = "url";

        string s = "data source=.\\SQLEXPRESS;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\\Database1.mdf;User Instance = true";
        SqlConnection c = new SqlConnection(s);
        c.Open();

    }
}
