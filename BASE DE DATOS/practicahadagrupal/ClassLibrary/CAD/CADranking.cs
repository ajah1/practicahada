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

        public CADranking() { }
            
            private SqlConnection conn = null;
		    private string stringConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFilename=/Users/Laila/Desktop/HADA/practicahada/BASE DE DATOS/practicahadagrupal/practicahadagrupal/App_Data/Database1.mdf;Integrated Security=true";


			public void add( EN.ranking r) {
				try
				{
                string sentencia = "INSERT INTO ranking" +
                    "SELECT name FROM puntuacion ORDER BY puntuacion DESC LIMIT 3";

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

}