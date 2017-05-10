using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;


namespace ClassLibrary.CAD{

	public class CADranking{

		public CADranking() {
            
            private SqlConnection conn = null;
		    private string stringConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFilename=/Users/Laila/Desktop/HADA/practicahada/BASE DE DATOS/practicahadagrupal/practicahadagrupal/App_Data/Database1.mdf;Integrated Security=true";


			public void add( EN.ranking r) {
				try
				{
					string sentencia = "INSERT INTO promociones" +
								"(idproducto, descuento, f_ini, f_fin)" +
								"VALUES('" +
								r.Id_producto.ToString() + "', '" +
								r.Descuento.ToString() + "', '" +
								r.F_Inicio.ToString() + "', '" +
								r.F_limite.ToString() + "')";

					conn = new SqlConnection();

					conn.ConnectionString = stringConexion;
					conn.Open();

					SqlCommand com = new SqlCommand(sentencia, conn);
					com.ExecuteNonQuery();

				}
				catch (Exception ex){
					Console.WriteLine("Create Ranking failed.");
					Console.WriteLine(". \nError: {0}", ex.ToString());
				}
				finally{
					conn.Close();
				}
			}


		public void remove(int id){
			try{
				string sentencia = "DELETE FROM rankings WHERE idproducto = " +
									id.ToString();

				conn = new SqlConnection();

				conn.ConnectionString = stringConexion;
				conn.Open();

				SqlCommand com = new SqlCommand(sentencia, conn);
				com.ExecuteNonQuery();
			}
			catch (Exception ex){
				Console.WriteLine("Remove Ranking failed.");
				Console.WriteLine(". \nError: {0}", ex.ToString());
			}
			finally{
				conn.Close();
			}
		}

		public void update(EN.Promocion p){
			try{

				string sentencia = @"UPDATE ranking SET " +
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
			catch (Exception ex){
				Console.WriteLine("Update Ranking failed.");
				Console.WriteLine(". \nError: {0}", ex.ToString());
			}
			finally{
				conn.Close();
			}
		}

		// PROVISIONAL: hasta que se una con la web
		public string read(int id){
			string salida = "";

			try{

				string sentencia = "Select * from ranking " +
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
			catch (Exception ex){
				Console.WriteLine("Read Ranking failed.");
				Console.WriteLine(". \nError: {0}", ex.ToString());
			}
			finally{
				conn.Close();
			}

			return salida;
		}
	}
}