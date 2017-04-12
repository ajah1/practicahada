using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EN
{
    public class Popular //:Producto
    {
        // private int id; lo hereda de Producto
        private int numero_ventas;
        //private productos = new List<Producto> {};

        public Popular() { }

        public 
            Popular(int numero_ventas)
        {
            this.numero_ventas = numero_ventas;
        }
        
        public int Numero_ventas { get; set; }
        //public List<Producto> Productos { get; }

        public
            void save (string dbname)
        {
            // esto depende de como funcione
            // el gestor de la bd
        }

        public
            void addPopular(string dbname)
        {
            
        }

        public
            void removePopular(string dbname)
        {

        }
    }
}
