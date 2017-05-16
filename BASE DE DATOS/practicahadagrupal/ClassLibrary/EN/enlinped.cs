using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EN{

    public class enlinped{

        // parte privada
        private int numPedido;
        private int linea;
        private int producto;
        private float precio;
        private int cantidad;

        //********************************************
        // constructores

        public enlinped() { }

        public enlinped(Producto pro, pedido ped) {
            numPedido = ped.NumPedido;
            producto = pro.Id;
            precio = pro.Precio;
            //cantidad = ped.Cantidad;
            //linea = 
        }

        //********************************************
        // get set

        public int NumPedido
        {
            get { return numPedido; }
            set { numPedido = value; }
        }

        public int Linea
        {
            get { return linea; }
            set { linea = value; }
        }

        public int Producto
        {
            get { return producto; }
            set { producto = value; }
        }

        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        //********************************************
        // metodos

        public void nuevoLinped(Producto pro, pedido ped)
        {
            CAD.CADlinped lin = new CAD.CADlinped();
            lin.create(this);
        }

        public void borrarLinped(Producto pro, pedido ped)
        {
            CAD.CADlinped lin = new CAD.CADlinped();
            lin.delete(this);

        }

        public void modificarLinped(Producto pro, pedido ped)
        {
            CAD.CADlinped lin = new CAD.CADlinped();
            lin.update();
        }

        public string leerLinped(Producto pro, pedido ped)
        {
            string salida = "";

            CAD.CADlinped lin = new CAD.CADlinped();
            salida = salida + lin.read(this);
            return salida;
        }

    }
}
