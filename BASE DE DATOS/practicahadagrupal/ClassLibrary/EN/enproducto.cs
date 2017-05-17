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
        private int precio;
        

        public int Id { get { return id; } set { id = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public string Imagen { get { return imagen; } set { imagen = value; } }
        public int Precio { get { return precio; } set { precio = value; } }

        public Producto (int id, int precio, string nombre = "", string descripcion = "", string imagen = ""){
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.imagen = imagen;
            
        } 

        public Producto(int id)
        {
            this.id = id;
        }

        public Producto() {}


        public void saveProducto(string dbname) {
            CAD.CADproducto p = new CAD.CADproducto();
            p.create(this);

        }

        public void removeProducto(string dbname) {
            CAD.CADproducto aux = new CAD.CADproducto();
            aux.remove(this.id);

        }

        public void addProducto(string dbname) {
            CAD.CADproducto aux = new CAD.CADproducto();
            aux.create(this);

        }

        public void updateProducto(string dbname) {
            CAD.CADproducto aux = new CAD.CADproducto();
            aux.update(this);

        }

        public void mostrarProducto() {
            CAD.CADproducto aux = new CAD.CADproducto();
            aux.consultar(this);

        }
    }
}
