using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// par poder usar la libreria
using ClassLibrary.EN;
using ClassLibrary.CAD;

namespace pruebasENCAD
{
    class Program
    {

        static void Main(string[] args)
        {

            usuario u = new usuario();

            u.Usuario = "aaaaadmin";
            u.Ciudad = "pruebaDatabase";
            u.Contrasena = "aaaahada";
            u.Edad = 4;
            u.Descripcion = "pruebaDatabase";
            u.Email = "pruebaDatabase";
            u.Direccion = "pruebaDatabase";
            u.Pais = "pruebaDatabase";

            u.registrarUsuario();

            Console.WriteLine(u.existe());
            Console.WriteLine(u.comprobarPass());


            puntuacion p = new puntuacion();
            p.user = "pruebaDatabase";

            List<string> l = new List<string>();
            l = p.readPuntuacion();

            int vidasActuales = int.Parse(l[1]);

            //si no tiene vidas, regidirigir a productos, para que compre
            if (vidasActuales == 0)
            {
                Console.WriteLine("vidas 0");
            }

            Console.ReadLine();

        }

    }
}
