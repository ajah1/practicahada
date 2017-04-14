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
        

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }

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

        public bool comprobarStock() {
            bool existencias = true;
            //COMPROBAR QUE HAY UNIDADES EN EL STOCK

            return existencias;
        }

    }
}
