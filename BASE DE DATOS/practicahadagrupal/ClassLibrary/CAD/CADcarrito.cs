using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace ClassLibrary.CAD
{
	public class CADcarrito
	{
		const string s = "data source=.\\SQLEXPRESS;Integrated"
				   + "Security = SSPI; AttachDBFilename =| DataDirectory |\\Database1.mdf;"
				   + "User Instance = true";
		
		SqlConnection conn = new SqlConnection(s);

		public CADcarrito()
		{
		}

		public void add(EN.ENCarro c)
		{
			try
			{
				conn.Open();
				SqlCommand com = new SqlCommand
					(
					   "INSERT INTO " +
					   "carrito(Id, usuario, producto)" +
					   "VALUES(" +
						c.Numpedido.ToString() + ", " +
						c.Usuario.ToString() + ", " +
						c.Productos.ToString() + ")", conn);

				com.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				Console.WriteLine("Fallo al crear carro.");
				Console.WriteLine(". \nError: {0}", ex.ToString());
			}
			finally
			{
				conn.Close();
			}
		}

		public void remove(int num_pedido)
		{
			try
			{
				conn.Open();
				SqlCommand com = new SqlCommand
					(
						"DELETE FROM carrito WHERE ID = " +
						num_pedido.ToString(), conn);

				com.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				Console.WriteLine("Fallo al limpiar carrito.");
				Console.WriteLine(". \nError: {0}", ex.ToString());
			}
			finally
			{
				conn.Close();
			}
		}

		public void update(EN.ENCarro c)
		{
			try
			{
				conn.Open();
				SqlCommand com = new SqlCommand();
			}
			catch (Exception ex)
			{
				Console.WriteLine("Fallo al actualizar carrito.");
				Console.WriteLine(". \nError: {0}", ex.ToString());
			}
			finally
			{
				conn.Close();
			}
		}

		public void read(int num_pedido)
		{
			try
			{
				conn.Open();
				SqlCommand com = new SqlCommand("Select * from carrito" +
												"where num_pedido = numpedido", conn);
				SqlDataReader dr = com.ExecuteReader();

				while (dr.Read())
				{

				}

			}
			catch (Exception ex)
			{
				Console.WriteLine("Fallo al leer carrito.");
				Console.WriteLine(". \nError: {0}", ex.ToString());
			}
			finally
			{
				conn.Close();
			}
		}
	}
}
