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
    public class CADpopular
    {
        private SqlConnection conn = null;
        private string stringConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFilename=C:\Users\alihyder\Documents\practicahada\BASE DE DATOS\practicahadagrupal\practicahadagrupal\App_Data\Database1.mdf;Integrated Security=true";

        public CADpopular() { }

        public void add( EN.Popular p )
        {
            try
            {
                string sentencia = "INSERT INTO productoPopular" +
                                    "(id, numeroVentas) VALUES('" +
                                    p.Id.ToString() + "', '" +
                                    p.Numero_ventas.ToString() + "')";

                conn = new SqlConnection();

                conn.ConnectionString = stringConexion;
                conn.Open();

                SqlCommand com = new SqlCommand(sentencia,conn);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Create Popular failed.");
                Console.WriteLine(". \nError: {0}", ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        public void delete( int id )
        {
            try
            {
                string sentencia = "DELETE FROM productoPopular  WHERE ID = '" +
                                    id.ToString() + "'";

                conn = new SqlConnection();

                conn.ConnectionString = stringConexion;
                conn.Open();

                SqlCommand com = new SqlCommand(sentencia, conn);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Delete Popular failed.");
                Console.WriteLine(". \nError: {0}", ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        public void update(EN.Popular p)
        {
            try
            {

                string sentencia = @"UPDATE productoPopular SET numeroVentas = '" +
                                    p.Numero_ventas.ToString() + "' " +
                                    "WHERE ID = '" + p.Id.ToString() + "'";

                conn = new SqlConnection();

                conn.ConnectionString = stringConexion;
                conn.Open();

                SqlCommand com = new SqlCommand(sentencia, conn);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Update Popular failed.");
                Console.WriteLine(". \nError: {0}", ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        // PROVISIONAL: hasta que se conecte con la pagina web
        public string read( int id )
        {

            string salida = "";

            try
            {

                string sentencia = @"SELECT * FROM productoPopular" +
                                                " WHERE ID = '" + id.ToString() + "'";

                conn = new SqlConnection();

                conn.ConnectionString = stringConexion;
                conn.Open();

                SqlCommand com = new SqlCommand(sentencia, conn);
                SqlDataReader dr = com.ExecuteReader();
                

                while (dr.Read())
                {
                    salida += dr["id"].ToString() + " ";
                    salida += dr["numeroVentas"].ToString();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Read Popular failed.");
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
