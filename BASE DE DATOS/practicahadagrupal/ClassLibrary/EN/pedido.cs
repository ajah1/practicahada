using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EN{
    class pedido{

        private int numPedido;
        private string fecha;
        private int cantidad;
        private List<Producto> productos;
        //private Usuario usuario;

        public int Id { get; set; }
        public string Fecha { get; set; }
        public int Cantidad { get; set; }
        


        public pedido(int numPedido, string fecha, int cantidad) {
            this.numPedido = numPedido;
            this.fecha = fecha;
            this.cantidad = cantidad;
            productos = new List<Producto> { };
        }

        public pedido() { }

        public void savePedido(string dbname) {


        }

        public void removePedido(string dbname) {


        }

        public void addPedido(string dbname) {


        }
        public void consultarProducto()
        {
            CAD.CADpedido aux = new CAD.CADpedido();
            productos = aux.consultarProducto(this.numPedido, productos);
        }

    }
}
}
