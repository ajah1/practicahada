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
        }
    }
}
