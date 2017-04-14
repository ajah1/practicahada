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
    public class CADpromocion
    {

        const string s = "data source=.\\SQLEXPRESS;Integrated"
                   + "Security = SSPI; AttachDBFilename =| DataDirectory |\\Database1.mdf;"
                   + "User Instance = true";
        SqlConnection conn = new SqlConnection(s);


        public CADpromocion() { }

        public void add( EN.Promocion p )
        {
            try
            {
                conn.Open();
                SqlCommand com = new SqlCommand
                    (
                       "INSERT INTO " +
                       "promociones(idpromocion, idproducto, descuento, f_inim f_fin)" +
                       "VALUES(" +
                       p.Id_promocion.ToString() + ", "  +
                       p.Id_producto.ToString()  + ", "  + 
                       p.Descuento.ToString()    + ", "  +
                       p.F_Inicio.ToString()     + ", "  +
                       p.F_limite.ToString() + ")"
                    );

                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Create Promocion failed.");
                Console.WriteLine(". \nError: {0}", ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        public void remove( int id )
        {
            try
            {
                conn.Open();
                SqlCommand com = new SqlCommand
                    (
                        "DELETE FROM promociones  WHERE ID = " +
                        id.ToString()
                    );
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Remove Promocion failed.");
                Console.WriteLine(". \nError: {0}", ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        public void update( EN.Promocion p )
        {
            try
            {
                conn.Open();
                SqlCommand com = new SqlCommand();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Update Promocion failed.");
                Console.WriteLine(". \nError: {0}", ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        public void read( int id_promocion )
        {
            try
            {
                conn.Open();
                SqlCommand com = new SqlCommand();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Read Promocion failed.");
                Console.WriteLine(". \nError: {0}", ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
