using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EN{
    public class Producto{
        private int id;
        private string nombre;
        private string descripcion;
        private string imagen;
        
        public Producto (int id, string nombre, string descripcion, string imagen){
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.imagen = imagen;
        } 

        public Producto() {}

        public void saveProducto(string dbname) {


        }

        public void removeProducto(string dbname) {


        }

        public void addProducto(string dbname) {


        }

    }
}
