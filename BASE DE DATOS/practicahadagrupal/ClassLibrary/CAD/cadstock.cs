using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace ClassLibrary.CAD
{
	public class StockCAD
	{

        // obtiene la ruta del ejecutable del programa, y la cambia para que apunte a la base de datos
        private static string entorno(string aux)
        {
            int x = aux.Length;
            for (int j = 0; j < 3; j++) { while (x > 0) { x--; if (aux[x] == '\\') { aux = aux.Remove(x, 1); break; } else { aux = aux.Remove(x, 1); } } }
            return aux + @"\WebApplication1\App_Data\database.mdf";
        }

        // inicializa una conexion, y apunta en stringConexion los parámetros de conexión
        private SqlConnection conn = null;
        private string stringConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFilename=" + entorno(Directory.GetCurrentDirectory()) + @";Integrated Security=true";

		private EN.Stock productstock;

		// <summary>
		// Representa la relación entre la EN y la CAD
		// </summary>
		public StockCAD()
		{

		}

		public StockCAD(EN.Stock productstock)
		{
			this.productstock = productstock;
		}

		public void add(EN.Stock s)
		{
			try
			{
                conn = new SqlConnection();
                conn.ConnectionString = stringConexion;
                conn.Open();
				SqlCommand com = new SqlCommand
					(
					   "INSERT INTO" +
					   "productoStock(id, cantidad) VALUES(" +
					   s.Id.ToString() + ", "// +
					   //s.cantidad.ToString() + ")"
					);

				com.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				Console.WriteLine("Adding Stock failed.");
				Console.WriteLine(". \nError: {0}", ex.ToString());
			}
			finally
			{
				conn.Close();
			}
		}

		public void delete(int id)
		{
			try
			{
                conn = new SqlConnection();
                conn.ConnectionString = stringConexion;
                conn.Open();

				SqlCommand com = new SqlCommand
					(
						"DELETE FROM productoStock  WHERE ID = " +
						id.ToString()
					);
				com.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				Console.WriteLine("Delete Stock Product failed.");
				Console.WriteLine(". \nError: {0}", ex.ToString());
			}
			finally
			{
				conn.Close();
			}
		}

		public void update(EN.Stock s)
		{
			try
			{
                conn = new SqlConnection();
                conn.ConnectionString = stringConexion;
                conn.Open();
				SqlCommand com = new SqlCommand();
			}
			catch (Exception ex)
			{
				Console.WriteLine("Update Stock Product failed.");
				Console.WriteLine(". \nError: {0}", ex.ToString());
			}
			finally
			{
				conn.Close();
			}
		}
		public void read(int id)
		{
			try
			{
				EN.Stock salida = new EN.Stock();

                conn = new SqlConnection();
                conn.ConnectionString = stringConexion;
                conn.Open();
				SqlCommand com = new SqlCommand("Select * from productoStock" +
												"where idstock = id", conn);
				SqlDataReader dr = com.ExecuteReader();

				while (dr.Read())
				{

				}

			}
			catch (Exception ex)
			{
				Console.WriteLine("Read Stock Product failed.");
				Console.WriteLine(". \nError: {0}", ex.ToString());
			}
			finally
			{
				conn.Close();
			}


		}
	}
}