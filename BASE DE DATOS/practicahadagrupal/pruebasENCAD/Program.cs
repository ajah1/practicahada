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
                Las fechas deben tener mismo formato que en la base de datos (ok)
                no se si this.usuhario = usuhario funciona
            */

            // pruebas pedido
            Console.WriteLine("=> INICIO PRUEBAS pedido [no terminado] <=");

            // ---------------------------------------prueba 1 
            Console.WriteLine("=> prueba1: add  pedido[ok]<=");

            usuario u = new usuario();
            u.Usuario = "hola3";

            pedido p = new pedido();
            p.Fecha = DateTime.Today;
            p.NumPedido = 232;
            p.Usuhario = u;

            p.savePedido();

            Console.ReadLine();

            // ---------------------------------------prueba 2
            Console.WriteLine("=> prueba2: delete pedido [ok]<=");
           
            // ---------------------------------------prueba 3
            Console.WriteLine("=> prueba3: update pedido [ok]<=");
            
            // ---------------------------------------prueba 4
            Console.WriteLine("=> prueba4: read pedido ok<=");

            Console.ReadLine();
        }
    }
}
