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

        public pedido(int numPedido, string fecha, int cantidad) {
            this.numPedido = numPedido;
            this.fecha = fecha;
            this.cantidad = cantidad;

        }

        public pedido() { }

        public void savePedido(string dbname) {


        }

        public void removePedido(string dbname) {


        }

        public void addPedido(string dbname) {


        }

    }
}
}
