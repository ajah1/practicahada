using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.EN;
using ClassLibrary.CAD;

namespace pruebas
{
    class pAlex
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=> CADPOPULAR PRUEBAS");
            
            Console.WriteLine("=> añadir popular OK");
            Popular p1 = new Popular(500);
            // no se si producto funciona...
            p1.Id = 5;
            p1.Nombre = "z";
            p1.Imagen = "z";
            p1.Precio = 23;
            p1.Descripcion = "z";
            // insertar popular
            //p1.addPopular();
            //Console.ReadLine();
            

            Console.WriteLine("=> borrar popular OK");
            Popular p2 = new Popular();
            p2.Id = 5;
            // borrar popular
            // p2.deletePopular();
            // Console.ReadLine();


            Console.WriteLine("=> actualizar ventas popular OK");
            Popular p3 = new Popular();
            p3.Id = 7;
            p3.Numero_ventas = 90;
            //p3.updatePopular();
            //Console.WriteLine();


            Console.WriteLine("=> leer popular ");
            Popular p4 = new Popular();
            p4.Id = 7;
            Console.WriteLine(p4.readPopular());
            Console.ReadLine();
        }
    }
}
