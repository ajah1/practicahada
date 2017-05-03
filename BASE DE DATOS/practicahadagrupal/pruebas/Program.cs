using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.EN;
using ClassLibrary.CAD;

namespace pruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=> CADPOPULAR PRUEBAS");
            
            Console.WriteLine("=> añadir popular");
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
            

            Console.WriteLine("=> update numero ventas de un Popular");
            

        }
    }
}
