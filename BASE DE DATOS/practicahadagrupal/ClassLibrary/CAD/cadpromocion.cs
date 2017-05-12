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

        // string para la conexion
        private SqlConnection conn = null;
        private string stringConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFilename=C:\Users\alihyder\Documents\practicahada\BASE DE DATOS\practicahadagrupal\practicahadagrupal\App_Data\Database1.mdf;Integrated Security=true";

        // constructor
        public CADpromocion() { }

        // añadir una promocion
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

        // borrar promocion a partir del id
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
        
        // actualizar promocion
        public void update( EN.Promocion p )
        {
            try
            {
                
                string sentencia = @"UPDATE promociones SET " +
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
                Console.WriteLine("Update Promocion failed.");
                Console.WriteLine(". \nError: {0}", ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        // leer promocion
        public string read( int id )
        {
            string salida = "";

            try
            {
                
                string sentencia = "Select * from promociones " +
                                   "where idproducto = '" + id.ToString() + "'";
                
                conn = new SqlConnection();

                conn.ConnectionString = stringConexion;
                conn.Open();

                SqlCommand com = new SqlCommand(sentencia, conn);
                SqlDataReader dr = com.ExecuteReader();


                while (dr.Read())
                {
                    salida = " " + dr["descuento"].ToString() +
                        dr["idproducto"].ToString() +" "+
                        dr["f_ini"].ToString() + " "+
                        dr["f_fin"].ToString();            
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

            return salida;
        }

        /*
        // devuelve true si el producto tiene promocion
        public bool tienePromocion(int idProducto)
        {
            bool tiene = false;

            

            return tiene;
        }

        // devuelve la cantidad a descontar del producto pasado
        public int aplicarPromocion(int idProducto)
        {
            
            int descuento = 0;

            // si el producto tiene promocion se obtiene el valor
            if (tienePromocion(idProducto) == true)
            {
                descuento = 
            }

            return descuento;
        }
        */
    }
}
