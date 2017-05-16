using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EN
{
	// falta lo que herede de la clase Producto
	// actualizar automaticamente desde la base de datos a todas las tuplas

	// <summary>
	// Esta clase representa la comprobación de stock
	// </summary>
	public class Stock : Producto
	{
		#region Miembros
		/// <summary>
		/// Identificador del producto
		/// </summary>
		private int id;
		/// <summary>
		/// Cantidad en stock
		/// </summary>
		private int cantidad;
		/// <summary>
		/// Producto de la comprobación
		/// </summary>
		public Producto producto;
		#endregion

		#region Constructor

		public Stock()
		{
			
		}

		public Stock(int id, int stock)
		{
			this.id = id;
			this.cantidad = stock;

		}

		#endregion

		#region Métodos
		// <summary>
		// Devuelve el identificador del producto actual
		// <summary>
		// <returns>Devuelve el id del producto actual</returns>
		public int getId()
		{
			return id;
		}

		// <summary>
		// Devuelve la fecha de la reserva
		// </summary>
		// <returns>Devuelve la fecha de la reserva actual</returns>
		public int getStock()
		{
			return cantidad;
		}

		public void addStock(string dbname)
		{
			CAD.StockCAD aux = new CAD.StockCAD();
			aux.add(this);
		}
		public void deleteStock(string dbname)
		{
			CAD.StockCAD aux = new CAD.StockCAD();
			aux.delete(Id);
		}
		public void updateStock(string dbname)
		{
			CAD.StockCAD aux = new CAD.StockCAD();
			aux.update(this);
		}
		public void readStock(string dbname)
		{
			CAD.StockCAD aux = new CAD.StockCAD();
			aux.read(Id);
		}
		#endregion
	}
}
