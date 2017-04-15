using System;
using System.Collections.Generic;

namespace EN
{
	// <summary>
	// Esta clase representa la comprobación de stock
	// </summary>
	public class StockEN : ENBase
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
		private Product producto;
		#endregion

		#region Constructor
		/// <summary>
		/// Constructor con el id del producto y el stock
		/// </summary>
		/// <param name="producto.id">Id del producto/param>
		/// <param name="stock">Stock</param>
		public StockEN(Product producto, int stock)
		{
			this.id = producto.id;
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

		// <summary>
		// Obtiene todas las reservas de la base de datos
		// </summary>
		// <returns>Devuelve todas los productos en stock que se encuentran en la DB</returns>
		static public StockEN[] getStock()
		{
			return StockCAD.obtenerTodoStock();
		}


		// <summary>
		// Obtiene un producto y su stock a través del identificador
		// <summary>
		// <param name="id">El identificador del producto</param>
		// <returns>Devuelve el producto y el stock</returns>
		static public StockEN getProducto(int id)
		{
			return StockCAD.obtenerProducto(id);
		}

		/// <summary>
		/// Añade stock al producto actual
		/// </summary>
		/// <param name="cantidad">cantidad a añador</param>
		/// <returns>Devuelve true si se añadio el stock y en caso contrario false</returns>
		public bool addStock(int stockp)
		{
			cantidad = cantidad + stockp;
			if (cantidad >= 0)
				return true;
			if (cantidad < 0)
				return false;
		}
		/// <summary>
		/// Quita stock al pedido actual
		/// </summary>
		/// <param name="id">Stock a quitar</param>
		/// <returns>Devuelve true si se redujo correctamente y false en el caso contrario</returns>
		public bool quitStock(int stockp)
		{
			cantidad = cantidad - stockp;
			if (cantidad >= 0)
				return true;
			if (cantidad < 0)
				return false;
			}

		/// <summary>
		/// Confirma los cambios de la reserva en la DB. Inserta o modifica.
		/// </summary>
		/// <returns>Devuelve true si se llevó a cabo la insercion/actualización o false en caso contrario</returns>
		public bool commitDB()
		{
			StockCAD cad = new StockCAD(this);
			return cad.InsertarActualizar();
		}

		/// <summary>
		/// Borra la reserva actual de la DB
		/// </summary>
		/// <returns>Devuelve true si se borró con éxito o false en caso contrario</returns>
		public bool borrarDB()
		{
			StockCAD cad = new StockCAD(this);
			return cad.Borrar();
		}
		#endregion
	}
}
