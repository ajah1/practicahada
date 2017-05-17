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


namespace ClassLibrary.CAD{

    public class CADranking
    {

        public CADranking() {
            string cadenaconexion = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            conn = new SqlConnection();
            conn.ConnectionString = cadenaconexion;
            conn.Open();
        }

        private SqlConnection conn = null;

        public void add(EN.ranking r)
        {
            try
            {
                string sentencia = "INSERT INTO ranking" +
                    "SELECT name FROM puntuacion ORDER BY puntuacion DESC LIMIT 3";

                SqlCommand com = new SqlCommand(sentencia, conn);
                com.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Create Ranking failed.");
                Console.WriteLine(". \nError: {0}", ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }
    }
}