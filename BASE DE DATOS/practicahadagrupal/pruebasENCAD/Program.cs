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


            puntuacion p = new puntuacion();

            p.user = "alex";
            p.v = 500;
            p.p = 1000;

            CADpuntuacion pt = new CADpuntuacion();

            //pt.updateVidas(p);

            //p.updateVidas();

            Console.ReadLine();

            //p.updatePuntuacion();
        }

    }
}
