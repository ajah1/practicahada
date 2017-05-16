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
            /*
            Console.WriteLine("=> CADPOPULAR PRUEBAS <=");
            
            Console.WriteLine("=> añadir popular OK");
            
            Popular p1 = new Popular(500);
            // producto añadido a mano en la base de datos
            p1.Id = 5;
            // insertar popular
            p1.addPopular();
            Console.ReadLine();
            
            
            Console.WriteLine("=> borrar popular OK");
            
            Popular p2 = new Popular();
            p2.Id = 5;
            // borrar popular
            p2.deletePopular();
            Console.ReadLine();
            
            
            Console.WriteLine("=> actualizar ventas popular OK");
            
            Popular p3 = new Popular();
            p3.Id = 7;
            p3.Numero_ventas = 900;
            p3.updatePopular();
            //Console.WriteLine();
         
            Console.WriteLine("=> leer popular OK");
            Popular p4 = new Popular();
            p4.Id = 7;
            Console.WriteLine(p4.readPopular());
            Console.ReadLine();
            
            
            Console.WriteLine("=> CADPROMOCION PRUEBAS <=");

            Console.WriteLine("=> add promocion ¿?");
            Promocion r1 = new Promocion();
            r1.Id_promocion = 0;
            r1.Id_producto = 5;
            r1.Descuento = 50;
            DateTime di = new DateTime(12/12/2012);
            DateTime df = new DateTime(12/12/2020);
            r1.F_Inicio = di;
            r1.F_limite = df;
            r1.addPromocion();
            Console.ReadLine();
            
            Console.WriteLine("=> remove promocion OK");
            Promocion r2 = new Promocion(5);
            //r2.removePromocion();
            Console.ReadLine();
            
            
            Console.WriteLine("=> update promocion ¿?");
            Promocion r3 = new Promocion();
            r3.Id_producto = 1;
            r3.Descuento = 500;
            r3.F_Inicio = "1/1/2001";
            r3.F_limite = "1/1/2001";
            //r3.updatePromocion();
            //Console.ReadLine();
            

            Console.WriteLine("=> read promocion ok");
            Promocion r4 = new Promocion(7);
            Console.WriteLine(r4.readPromocion());
            Console.ReadLine();
            */


            Console.WriteLine("=> PRODUCTOS POPULARES <=");
            /*
            Popular p = new Popular();

            // borrar todas las tuplas de la tabla popular
            Console.WriteLine("=> drop table ok");
            p.dropPopular();

            // de momento devuelve los que sean comprados un mayor de x veces
            Console.WriteLine("=> devolver populares ¿?");
            List<int> l = new List<int>();

            l = p.productosPopulares();

            foreach (int valor in l)
            {
                System.Console.Write(valor);
            }
            
            // insertar los productos mas comprados obtenidos anteriormente
            foreach (int valor in l)
            {
                Popular p1 = new Popular(valor);
                p1.addPopular();
            }
            
            Console.ReadLine();
            
            Popular p = new Popular();
            p.updateTable();
            */
            /*
            Console.WriteLine("=> lee una prmocion que no esta en la db");
            
            Promocion p = new Promocion(1);

            CADpromocion aux = new CADpromocion();


            Console.WriteLine(aux.obtenerDescuento(5));

            // Console.WriteLine(p.aplicarPromocion());

            Console.ReadLine();
            */

            Console.WriteLine("=> obtener fechas de una promocion OK");
            /*
            CADpromocion aux = new CADpromocion();

            List<DateTime> fechas = new List<DateTime>();

            fechas = aux.obtenerFecha(5);

            foreach (DateTime elemento in fechas)
            {
                Console.WriteLine(elemento);
            }

            Console.ReadLine();
            */

            /*
            int descuento = 0;
            CADpromocion aux = new CADpromocion();

            descuento = aux.aplicarDescuento(5);

            Console.WriteLine(descuento);

            Console.ReadLine();
            */

            CADpromocion aux = new CADpromocion();
            
            List<String> l = new List<string>();

            l = aux.read(3);

            foreach (string value in l)
            {
                Console.WriteLine(value);
            }

            Console.ReadLine();
        }
    }
}
