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

	public class CADpuntuacion
	{

		public CADpuntuacion()
		{


		private SqlConnection conn = null;
		private string stringConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFilename=/Users/Laila/Desktop/HADA/practicahada/BASE DE DATOS/practicahadagrupal/practicahadagrupal/App_Data/Database1.mdf;Integrated Security=true";


		public void add(EN.puntuacion p)
		{
			try
			{
				string sentencia = "INSERT INTO promociones" +
							"(idproducto, descuento, f_ini, f_fin)" +
							"VALUES('" +
							p.Id_producto.ToString() + "', '" +
							p.Descuento.ToString() + "', '" +
							p.F_Inicio.ToString() + "', '" +
							p.F_limite.ToString() + "')";

				conn = new SqlConnection();

				conn.ConnectionString = stringConexion;
				conn.Open();

				SqlCommand com = new SqlCommand(sentencia, conn);
				com.ExecuteNonQuery();

			}
			catch (Exception ex)
			{
				Console.WriteLine("Create Puntuacion failed.");
				Console.WriteLine(". \nError: {0}", ex.ToString());
			}
			finally
			{
				conn.Close();
			}
		}


		public void remove(int id)
		{
			try
			{
				string sentencia = "DELETE FROM puntuacion WHERE idproducto = " +
									id.ToString();

				conn = new SqlConnection();

				conn.ConnectionString = stringConexion;
				conn.Open();

				SqlCommand com = new SqlCommand(sentencia, conn);
				com.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				Console.WriteLine("Remove Puntuacion failed.");
				Console.WriteLine(". \nError: {0}", ex.ToString());
			}
			finally
			{
				conn.Close();
			}
		}

		public void update(EN.Promocion p)
		{
			try
			{

				string sentencia = @"UPDATE puntuacion  SET " +
								"descuento = '" + p.Descuento.ToString() +
								"', f_ini = '" + p.F_Inicio +
								"', f_fin = '" + p.F_limite +
								"' WHERE idproducto = '" + p.Id_producto.ToString() + "'";

				conn = new SqlConnection();

				conn.ConnectionString = stringConexion;
				conn.Open();

				SqlCommand com = new SqlCommand(sentencia, conn);
				com.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				Console.WriteLine("Update Puntuacion failed.");
				Console.WriteLine(". \nError: {0}", ex.ToString());
			}
			finally
			{
				conn.Close();
			}
		}

		// PROVISIONAL: hasta que se una con la web
		public string read(int id)
		{
			string salida = "";

			try
			{

				string sentencia = "Select * from puntuacion " +
								   "where idproducto = '" + id.ToString() + "'";

				conn = new SqlConnection();

				conn.ConnectionString = stringConexion;
				conn.Open();

				SqlCommand com = new SqlCommand(sentencia, conn);
				SqlDataReader dr = com.ExecuteReader();


				while (dr.Read())
				{
					salida = " " + dr["descuento"].ToString() +
						dr["idproducto"].ToString() + " " +
						dr["f_ini"].ToString() + " " +
						dr["f_fin"].ToString();
				}

			}
			catch (Exception ex)
			{
				Console.WriteLine("Read Puntuacion failed.");
				Console.WriteLine(". \nError: {0}", ex.ToString());
			}
			finally
			{
				conn.Close();
			}

			return salida;
		}
	}
}