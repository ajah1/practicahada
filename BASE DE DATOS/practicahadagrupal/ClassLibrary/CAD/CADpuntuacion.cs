using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO;
using System.Configuration;

namespace ClassLibrary.CAD
{

	public class CADpuntuacion
	{

		public CADpuntuacion()
		{ }

        private static string entorno(string aux)
        {
            int x = aux.Length;
            for (int j = 0; j < 3; j++) { while (x > 0) { x--; if (aux[x] == '\\') { aux = aux.Remove(x, 1); break; } else { aux = aux.Remove(x, 1); } } }
            return aux + @"\WebApplication1\App_Data\database.mdf";
        }

        private SqlConnection conn = null;
        private string stringConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFilename=" + entorno(Directory.GetCurrentDirectory()) + @";Integrated Security=true";

        private string ConnectionString = "data source=.\\SQLEXPRESS;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\\Database.mdf;User Instance=true";

        // poner todo a cero
        public void remove(string usuario)
		{
			try
			{
				string sentencia = @"UPDATE puntuacion  SET " +
						"record = 0" + "vidas = 0" + "puntosTotales= 0 " + " WHERE pusuario " + usuario;

                //conn = new SqlConnection();

                //conn.ConnectionString = stringConexion;

                SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

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

		// obtener la puntuación de un usuario
		public int obtenerPuntuacion(string usuario)
		{
			int salida = 0;

			try
			{

				string sentencia = "SELECT puntosTotales FROM puntuacion " +
								   "WHERE pusuario = '" + usuario + "'";

				conn = new SqlConnection();

				conn.ConnectionString = stringConexion;
				conn.Open();

				SqlCommand com = new SqlCommand(sentencia, conn);
				SqlDataReader dr = com.ExecuteReader();


				while (dr.Read())
				{
					salida = (int)dr["puntosTotales"];
				}

			}
			catch (Exception ex)
			{
				Console.WriteLine("Read Puntos failed.");
				Console.WriteLine(". \nError: {0}", ex.ToString());
			}
			finally
			{
				conn.Close();
			}

			return salida;
		}

		public void updatePuntuacion(int suma, EN.puntuacion p)
		{
			int puntos = 0;

			puntos += suma + p.obtenerPuntuacion();

			try
			{

				string sentencia = @"UPDATE puntuacion  SET " +
						   "puntosTotales = '" + puntos.ToString() + "'" +
						   " WHERE pusuario= '" + p.user + "'";


                conn = new SqlConnection();
                //SqlConnection coon = new SqlConnection(ConfigurationManager.ConnectionStrings[ConnectionString].ConnectionString);
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

		public string read(string usuario)
		{
			string salida = "";

			try
			{

				string sentencia = "Select * from puntuacion " +
								   "where pusuario = '" + usuario + "'";

				conn = new SqlConnection();

                conn.ConnectionString = stringConexion;
                conn.Open();

                SqlCommand com = new SqlCommand(sentencia, conn);
				SqlDataReader dr = com.ExecuteReader();



                while (dr.Read())
				{
					salida = dr["record"].ToString()+ " "+
						dr["vidas"].ToString() + " " +
						dr["puntosTotales"].ToString();
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
