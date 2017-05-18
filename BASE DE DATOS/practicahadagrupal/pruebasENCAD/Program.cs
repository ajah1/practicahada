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

            u.Usuario = "hola3";

            List<string> l = new List<string>();


            l = u.leerUsuario();

            foreach (string valor in l)
            {
                Console.WriteLine(valor);
            }


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

            Console.ReadLine();
            */
        }
    }
}
