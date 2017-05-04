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

        private SqlConnection conn = null;
        private string stringConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFilename=C:\Users\alihyder\Documents\practicahada\BASE DE DATOS\practicahadagrupal\practicahadagrupal\App_Data\Database1.mdf;Integrated Security=true";

        public CADpromocion() { }

        public void add( EN.Promocion p )
        {
            try
            {
                string sentencia = "INSERT INTO promociones" + 
                            "(idproducto, descuento, f_ini, f_fin)" +
                            "VALUES('" +
                            p.Id_producto.ToString()  + "', '"  + 
                            p.Descuento.ToString()    + "', '"  +
                            p.F_Inicio.ToString()     + "', '"  +
                            p.F_limite.ToString() + "')";

                conn = new SqlConnection();

                conn.ConnectionString = stringConexion;
                conn.Open();

                SqlCommand com = new SqlCommand(sentencia, conn);
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
                string sentencia = "DELETE FROM promociones  WHERE idproducto = " +
                                    id.ToString();

                conn = new SqlConnection();

                conn.ConnectionString = stringConexion;
                conn.Open();

                SqlCommand com = new SqlCommand(sentencia, conn);
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
                string sentencia = @"UPDATE promociones SET " +
                                "descuento = " + p.Descuento.ToString() +
                                ", f_ini = " + p.F_Inicio.ToString() +
                                ", f_fin = " + p.F_limite.ToString() +
                                " WHERE idproducto = " + p.Id_producto;

                conn = new SqlConnection();

                conn.ConnectionString = stringConexion;
                conn.Open();

                SqlCommand com = new SqlCommand(sentencia, conn);
                com.ExecuteNonQuery();
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

        public void read( int id )
        {
            try
            {
                conn.Open();
                SqlCommand com = new SqlCommand("Select * from promociones"+
                                                "where idpromocion = id", conn);
                SqlDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {
                    
                }

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
