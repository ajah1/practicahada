﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EN
{
    // falta lo que herede de la clase Producto
    // actualizar automaticamente desde la base de datos a todas las tuplas

    public class Popular : Producto
    {
        private int numero_ventas;

        public Popular() { }

        public 
            Popular(int numero_ventas)
        {
            this.numero_ventas = numero_ventas;
        }
        
        public int Numero_ventas { get; set; }


        public void savePopular (string dbname)
        {
            CAD.CADpopular aux = new CAD.CADpopular();
            aux.add(this);
        }
        public void removePopular(string dbname)
        {
            CAD.CADpopular aux = new CAD.CADpopular();
            aux.remove(id);
        }
    }
}
