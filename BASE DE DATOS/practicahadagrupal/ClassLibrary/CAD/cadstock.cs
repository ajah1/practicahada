using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace ClassLibrary.CAD
{
	public class StockCAD
	{
		private const string ConnectionString = "data source=.\\SQLEXPRESS;Integrated"
	 	+ "Security = SSPI; AttachDBFilename =| DataDirectory |\\Database1.mdf;"
		+ "User Instance = true";
		SqlConnection conn = new SqlConnection();
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