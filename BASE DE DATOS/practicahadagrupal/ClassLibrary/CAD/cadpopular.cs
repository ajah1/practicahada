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

        const string s = "data source=.\\SQLEXPRESS;Integrated"
           + "Security = SSPI; AttachDBFilename =| DataDirectory |\\Database1.mdf;"
           + "User Instance = true";
        SqlConnection conn = new SqlConnection(s);

        public CADpopular() { }

        public void add( EN.Popular p )
        {
            try
            {
                conn.Open();
                SqlCommand com = new SqlCommand
                    (
                       "INSERT INTO" +
                       "productoPopular(id, numeroVentas) VALUES(" +
                       p.id.ToString() + ", " +
                       p.Numero_ventas.ToString() + ")"
                    );

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

        public void read( int id )
        {
            try
            {
                conn.Open();
                SqlCommand com = new SqlCommand();
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
