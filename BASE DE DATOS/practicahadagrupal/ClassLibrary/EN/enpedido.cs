using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EN{
    public class pedido{

        private int numPedido;
        private string fecha;
        private int cantidad;
        private List<Producto> productos;
        //private Usuario usuario;

        public int NumPedido { get; set; }
        public string Fecha { get; set; }
        public int Cantidad { get; set; }
        


        public pedido(int numPedido, int cantidad, string fecha = "") {
            this.numPedido = numPedido;
            this.fecha = fecha;
            this.cantidad = cantidad;
            productos = new List<Producto> { };
        }

        public pedido() { }

        public void savePedido(string dbname) {
            CAD.CADpedido pedido = new CAD.CADpedido();
            pedido.create(this);

        }

        public void removeProducto(Producto p) {
            productos.Remove(p);

        }

        public void addProducto(Producto p) {
            productos.Add(p);
        }

        public void consultarProducto() {
            CAD.CADpedido aux = new CAD.CADpedido();
            productos = aux.consultarProducto(this.numPedido, productos);
        }

    }
}
