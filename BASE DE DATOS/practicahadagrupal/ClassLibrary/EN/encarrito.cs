using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EN
{
    public class ENCarro
    {
        private int numpedido;
        private int usuario;
        private float precio;
        private EN.Producto producto = new EN.Producto();

        public EN.Producto Producto
        {
            get;
            set;
        }
        public int Usuario
        {
            get;
            set;
        }
        public int Id
        {
            get { return numpedido; }
            set { numpedido = value; }
        }
        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public ENCarro()
        {

        }
        public ENCarro(ENCarro en)
        {
            this.numpedido = en.numpedido;
            this.usuario = en.usuario;
            this.producto = en.producto;
            this.precio = en.precio;
        }


    }
}
