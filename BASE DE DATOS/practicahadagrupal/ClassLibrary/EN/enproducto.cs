using ClassLibrary.CAD;
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
            this.precio = precio;
            
        } 

        public Producto(int id)
        {

            EN.Producto p = mostrarProducto(id);

            this.id = p.id;
            this.nombre = p.nombre;
            this.descripcion = p.descripcion;
            this.imagen = p.imagen;
            this.precio = p.precio;
            


        }

        public Producto() {
            this.id = 0;
            this.nombre = "";
            this.descripcion = "";
            this.imagen = "";
            this.precio = 0;
        }

        public Producto(Producto producto) {
            this.id = producto.id;
            this.nombre = producto.nombre;
            this.descripcion = producto.descripcion;
            this.imagen = producto.imagen;
            this.precio = producto.precio;
            

        }


        public void saveProducto() {
            CAD.CADproducto p = new CAD.CADproducto();
            p.create(this);

        }

        public void removeProducto() {
            CAD.CADproducto aux = new CAD.CADproducto();
            aux.remove(this.id);

        }

        public void addProducto() {
            CAD.CADproducto aux = new CAD.CADproducto();
            aux.create(this);

        }

        public void updateProducto() {
            CAD.CADproducto aux = new CAD.CADproducto();
            aux.update(this);

        }

        public Producto mostrarProducto(int id) {
            EN.Producto p = new EN.Producto();
            CAD.CADproducto prod = new CADproducto();
            p = prod.consultarProducto(id);

            return p;

        }

        public static List<Producto> mostrarTodos() {

            CAD.CADproducto a = new CAD.CADproducto();

            List<EN.Producto> p = a.PeticionConsultar();

            return p;
        }

    }
}
