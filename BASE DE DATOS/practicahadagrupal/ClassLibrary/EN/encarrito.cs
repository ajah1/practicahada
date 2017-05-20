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

        // manda los atributos de instancia al cad para ser insertados en la BBDD
        public void createCarro()
        {
            CAD.CADcarrito carro = new CAD.CADcarrito();
            carro.add(this);
        }

        // manda los atributos de instancia al cad para ser buscados en la BBDD
        public void readCarro()
        {
            CAD.CADcarrito carro = new CAD.CADcarrito();
            carro.read(numpedido);
        }

        // manda los atributos de instancia al cad para ser encontrados en la BBDD y actualizados
        public void updateCarro(ENCarro nuevo)
        {
            CAD.CADcarrito carro = new CAD.CADcarrito();
            carro.update(this, nuevo);
        }

        // manda los atributos de instancia al cad para ser borrados de la BBDD
        public void deleteCarro()
        {
            CAD.CADcarrito carro = new CAD.CADcarrito();
            carro.remove(numpedido);
        }
    }
}
