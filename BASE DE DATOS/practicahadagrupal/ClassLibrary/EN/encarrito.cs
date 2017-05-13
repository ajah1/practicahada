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
		private string data;
		private bool confirmado;
		private bool pagado;
		private bool enviado;
		private string email;
		private float precio;
		private ArrayList productos = new ArrayList();

		public ArrayList Productos
		{
			get { return productos; }
			set { productos = value; }
		}
		public int Numpedido
		{
			get { return numpedido; }
			set { numpedido = value; }
		}
		public string Data
		{
			get { return data; }
			set { data = value; }
		}
		public string Email
		{
			get { return email; }
			set { email = value; }
		}
		public float Precio
		{
			get { return precio; }
			set { precio = value; }
		}
		public ENCarro(string email)
		{
			precio = 0;
			this.email = email;
		}
		public ENCarro(EN.Producto producto, int cantidad)
		{
			precio = 0;
			int numLinea = productos.Count;
			productos.Add(new ENLineapedido(producto, cantidad, numLinea + 1));
		}
		public ENCarro(int idPedido, DateTime data, string emailUsuari)
		{
			precio = 0;
			this.email = emailUsuari;
			this.data = data.ToString();
			//this.idPedido = idPedido;
		}
		public ENCarro(ENCarro en)
		{
			this.email = en.Email;
			this.numpedido = en.numpedido;
			this.data = en.data;
			this.productos = en.productos;
			this.confirmado = en.confirmado;
			this.enviado = en.enviado;
			this.pagado = en.pagado;
			this.precio = en.precio;
		}
		public void Add(EN.Producto prod, int cantitat)
		{
			bool insertado = false;
			foreach (ENLineapedido linea in productos)
			{
				if (linea.Producto.Id == prod.Id)
				{
					linea.Cantitat += cantitat;
					insertado = true;
					break;
				}
			}
			if (!insertado)
			{
				ENLineapedido linea = new ENLineapedido();
				linea.Cantitat = cantitat;
				linea.Producto = prod;
				this.productos.Add(linea);
			}
			precio += cantitat * prod.Precio;
		}

		public float PreuPerCantitat(EN.Producto prod, int cantidad)
		{
			return (precio);
		}

		public void Delete(ENLineapedido linea)
		{
			precio -= linea.Cantitat * linea.Producto.Preu;

			this.productos.Remove(linea);
		}

		public void DeleteLineas()
		{
			precio = 0;
			this.productos.Clear();
		}

		public void preparaCompra()
		{
			data = DateTime.Now.ToString();
			//dataEnvio = DateTime.Now.AddDays(15);
		}
		public void guardarPedido()
		{
			preparaCompra();
			CAD.CADpedido p = new CAD.CADpedido();
			p.InsertarPedido(this);
		}
		public float getPreuTotal()
		{
			float precioTotal = 0;
			foreach (ENLineapedido linea in productos)
			{
				precioTotal += linea.Producto.Precio * linea.Cantitat;
			}
			return precioTotal;
		}
}
