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

            /*
            usuario u = new usuario();
            CADusuario cu = new CADusuario();
            u.Usuario = "esejuan";

            //string salida = "";
            //salida = cu.readstring(u.Usuario);
            //Console.WriteLine(salida);

            

            u.Ciudad = "hola999";
            u.Contrasena = "hola999";
            u.Edad = 9;
            u.Descripcion = "hola999";
            u.Email = "hola999";
            u.Direccion = "hola999";
            u.Pais = "hola999";

            Console.WriteLine(u.existe());

            Console.ReadLine();
            */

            /*
            // pruebas pedido
            Console.WriteLine("=> INICIO PRUEBAS ranking [terminado] <=");

            // ---------------------------------------prueba 1 
            Console.WriteLine("=> prueba1: add  ranking[terminado]<=");

            ranking r = new ranking();

            //p
            r.droptable();
            r.addRanking();
            
            */

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
            p.p = 10;
            p.v = 10;

            p.updatePuntuacion();
            p.updateVidas();
            Console.WriteLine(p.readPuntuacion()[1]);
            Console.WriteLine(p.obtenerPuntuacion());
            
            //p.updateVidas();

            Console.ReadLine();

        }

    }
}
