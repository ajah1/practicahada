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
                conn = new SqlConnection();

                conn.ConnectionString = stringConexion;

                conn.Open();

                string sentencia = "INSERT INTO productoPopular" +
                       "(id, numeroVentas) VALUES('" +
                       p.Id.ToString() + "', '" +
                       p.Numero_ventas.ToString() + "')";

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
                conn.Open();

                SqlCommand com = new SqlCommand
                    (
                        "DELETE FROM productoPopular  WHERE ID = " +
                        id.ToString()
                    );
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

        public void update( EN.Popular p)
        {
            try
            {
                conn.Open();
                SqlCommand com = new SqlCommand();
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
        //EN.Popular
        public void read( int id )
        {
            try
            {
                EN.Popular salida = new EN.Popular();

                conn.Open();
                SqlCommand com = new SqlCommand("Select * from productoPopular" +
                                                "where idpromocion = id", conn);
                SqlDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {

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

            
        }
    }
}
