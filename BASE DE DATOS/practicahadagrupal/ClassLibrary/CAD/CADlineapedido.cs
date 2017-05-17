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
	public class CADlineapedido
	{

		const string s = "data source=.\\SQLEXPRESS;Integrated"
				   + "Security = SSPI; AttachDBFilename =| DataDirectory |\\Database1.mdf;"
				   + "User Instance = true";

		SqlConnection conn = new SqlConnection(s);

		public CADlineapedido()
		{
		}

		public void add(EN.ENLineapedido l)
		{
			try
			{
				conn.Open();
				SqlCommand com = new SqlCommand
					(
					   "INSERT INTO " +
					   "lineapedido(id_linea, precio, cantidad, numpedido codigo_articulo)" +
					   "VALUES(" +
						l.Linea.ToString() + ", " +
						l.Preu.ToString() + ", " +
						l.Cantitat.ToString() + ", " +
						l.Numpedido.ToString() + ", " +
						l.Codart.ToString() + ")", conn);

				com.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				Console.WriteLine("Fallo al crear línea de pedido.");
				Console.WriteLine(". \nError: {0}", ex.ToString());
			}
			finally
			{
				conn.Close();
			}
		}

		public void remove(int lineap)
		{
			try
			{
				conn.Open();
				SqlCommand com = new SqlCommand
					(
						"DELETE FROM promociones  WHERE ID = " +
						lineap.ToString(), conn);

				com.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				Console.WriteLine("Fallo al remover líneaa de pedido.");
				Console.WriteLine(". \nError: {0}", ex.ToString());
			}
			finally
			{
				conn.Close();
			}
		}

		public void update(EN.ENLineapedido l)
		{
			try
			{
				conn.Open();
				SqlCommand com = new SqlCommand();
			}
			catch (Exception ex)
			{
				Console.WriteLine("Fallo al actualizar linea de pedido.");
				Console.WriteLine(". \nError: {0}", ex.ToString());
			}
			finally
			{
				conn.Close();
			}
		}

		public void read(int lineap)
		{
			try
			{
				conn.Open();
				SqlCommand com = new SqlCommand("Select * from lineapedido" +
												"where lineap = id_linea", conn);
				SqlDataReader dr = com.ExecuteReader();

				while (dr.Read())
				{

				}

			}
			catch (Exception ex)
			{
				Console.WriteLine("Fallo al leer linea de pedido.");
				Console.WriteLine(". \nError: {0}", ex.ToString());
			}
			finally
			{
				conn.Close();
			}
		}
	}
}
