using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace ClassLibrary.CAD
{
    public class CADpromocion
    {
        // obtiene la ruta del ejecutable del programa, y la cambia para que apunte a la base de datos
        private static string entorno(string aux)
        {
            int x = aux.Length;
            for (int j = 0; j < 3; j++) { while (x > 0) { x--; if (aux[x] == '\\') { aux = aux.Remove(x, 1); break; } else { aux = aux.Remove(x, 1); } } }
            return aux + @"\WebApplication1\App_Data\database.mdf";
        }

        // inicializa una conexion, y apunta en stringConexion los parámetros de conexión
        private SqlConnection conn = null;
        private string stringConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFilename=" + entorno(Directory.GetCurrentDirectory()) + @";Integrated Security=true";

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

        // devuelve la fecha inicio y fin
        public List<DateTime> obtenerFecha(int idProducto)
        {
            List<DateTime> fechas = new List<DateTime>();

            try
            {

                string sentencia = "Select * from promociones " +
                                   "where idproducto = '" + idProducto + "'";

                conn = new SqlConnection();

                conn.ConnectionString = stringConexion;
                conn.Open();

                SqlCommand com = new SqlCommand(sentencia, conn);
                SqlDataReader dr = com.ExecuteReader();


                while (dr.Read())
                {
                    fechas.Add((DateTime)dr["f_ini"]);
                    fechas.Add((DateTime)dr["f_fin"]);
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

            return fechas;
        }

        // devuelve el descuento de un producto
        public int obtenerDescuento(int id)
        {
            int salida = 0;

            try
            {

                string sentencia = "Select descuento from promociones " +
                                   "where idproducto = '" + id.ToString() + "'";

                conn = new SqlConnection();

                conn.ConnectionString = stringConexion;
                conn.Open();

                SqlCommand com = new SqlCommand(sentencia, conn);
                SqlDataReader dr = com.ExecuteReader();


                while (dr.Read())
                {
                    salida = (int)dr["descuento"];
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

        // si la promoción esta disponible devuelve el descuento
        public int aplicarDescuento(int idProducto)
        {
            int descuento = 0;

            List<DateTime> fechas = new List<DateTime>();

            DateTime finicio;
            DateTime ffin;
            DateTime today;

            fechas = obtenerFecha(idProducto);

            finicio = fechas[0];
            ffin = fechas[1];
            today = DateTime.Today;

            // si la fecha de la promocion es valida obtener descuento
           if (today >= finicio && today <= ffin)
            {
                descuento = obtenerDescuento(idProducto);
            }
           
            return descuento;
        }
    }
}
