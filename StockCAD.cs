using System;
using Mono.Data.Sqlite;
using System.Collections.Generic;
namespace CAD
{
	using System;
	using System.Collections.Generic;

	namespace EN
	{
		public class StockCAD
		{
			private const string ConnectionString = "Data Source=EN.sqlite;Version=3;New=False;Compress=True;";
			// <summary>
			// Representa la relación entre la EN y la CAD
			// </summary>
			private StockEN productstock;

			public StockCAD(StockEN productstock)
			{
				this.productstock = productstock;
			}

			// <summary>
			// Obtiene todas las reservas de la DB
			// </summary>
			// <returns>Vector con las reservas de la DB</returns>
			public static StockEN[] obtenerTodasReservas()
			{
				List<StockEN> productos = new List<StockEN>();
				using (SQLiteConnection conexion = new SQLiteConnection())
				{
					conexion.ConnectionString = ConnectionString;
					conexion.Open();

					string consulta = "SELECT * FROM productstock";
					SQLiteCommand cmd = new SQLiteCommand(consulta, conexion);

					SQLiteDataReader datos = cmd.ExecuteReader();
					while (datos.Read())
					{
						StockEN productstock = new StockEN();

						if (!string.IsNullOrEmpty(Convert.ToInt32(datos[0])))
							productstock.id = Convert.ToInt32(datos[0]);
						if (!string.IsNullOrEmpty(Convert.ToInt32(datos[1])))
							productstock.cantidad = Convert.ToInt32(datos[1]);

						productos.Add(productstock);
					}

				}
				return productos.ToArray();
			}


			// <summary>
			// Obtiene una reserva por su identificador
			// </summary>
			// <param name="id">Es el identificador de una reserva</param>
			// <returns>Devuelve la reserva cuyo id se paso como parámetro</returns>
			public static StockEN getProducto (int id)
			{
				StockEN productstock = new StockEN();

				using (SQLiteConnection conexion = new SQLiteConnection())
				{
					conexion.ConnectionString = ConnectionString;
					conexion.Open();

					string consulta = "SELECT * FROM productstock WHERE id = " + id;
					SQLiteCommand cmd = new SQLiteCommand(consulta, conexion);

					SQLiteDataReader datos = cmd.ExecuteReader();
					while (datos.Read())
					{
						if (!string.IsNullOrEmpty(Convert.ToInt32(datos[0])))
							productstock.id = Convert.ToInt32(datos[0]);
						if (!string.IsNullOrEmpty(Convert.ToInt32(datos[1])))
							productstock.usuario = Convert.ToInt32(datos[1]);
					}

				}
				return productstock;
				throw new NotImplementedException();
			}


			// <summary>
			// Inserta la reserva en la DB si no existe o lo actualiza si ya existia
			// </summary>
			// <returns>True si se hicieron cambios y false en caso contrario</returns>
			public bool InsertarActualizar()
			{
				return false;
			}

			// <summary>
			// Borra la reserva actual de la DB
			// </summary>
			// <returns>True si se borró y false en caso contrario</returns>
			public bool Borrar()
			{
				return false;
			}
		}
	}