using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EN
{
	public class ENLineapedido
	{
		private int linea;
		private float precio;
		private int cantidad;
		private int numpedido;
		private EN.Producto producto;
		private EN.ENCarro pedido;
		private int codart;
		public int Codart
		{
			get { return codart; }
			set { codart = value; }
		}
		public EN.Producto Producto
		{
			get { return producto; }
			set { producto = value; }
		}
		public EN.ENCarro Pedido
		{
			get { return pedido; }
			set { pedido = value; }
		}
		public int Linea
		{
			get { return linea; }
			set { linea = value; }
		}
		public float Preu
		{
			get { return precio; }
			set { precio = value; }
		}
		public int Cantitat
		{
			get { return cantidad; }
			set { cantidad = value; }
		}
		public int Numpedido
		{
			get { return numpedido; }
			set { numpedido = value; }
		}
		public ENLineapedido()
		{
			//Constructor por defecto   
		}
		public ENLineapedido(EN.Producto lpidArticle, int cantitat, int numLinea)
		{
			this.producto = lpidArticle;
			this.cantidad  = cantitat;
			this.linea = numLinea;
		}
		//Uso del CAD
		/*Extraemos el nombre del pedido para insertarlo en lineapedido*/
		public int ExtraureNomArticle()
		{
			return producto.Id;
		}
		/*Multiplicamos precio por unidades*/
		public float InsertarPedidoNombre()
		{
			float preut = Producto.Precio * cantidad;
			return preut;
		}
		public int IdArticle()
		{
			return producto.Id;
		}
	}
}
