using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EN{
    public class pedido{

        private int numPedido;
        private string fecha;
        private usuario usuhario;

        public int NumPedido { get { return numPedido; } set { numPedido = value; } }
        public string Fecha { get { return fecha; } set { fecha = value; } }       
        public usuario Usuhario { get { return usuhario; } set { usuhario = value; } }

        public pedido(int numPedido, string fecha = "" /*usuario usuhario*/) {
            this.numPedido = numPedido;
            this.fecha = fecha;
            //this.usuhario = usuhario;
        }

        public pedido() {}

        public void savePedido() {
            CAD.CADpedido pedido = new CAD.CADpedido();
            pedido.create(this);

        }

        public void removePedido() {
            CAD.CADpedido pedido = new CAD.CADpedido();
            pedido.remove(this);

        }

    }
}
