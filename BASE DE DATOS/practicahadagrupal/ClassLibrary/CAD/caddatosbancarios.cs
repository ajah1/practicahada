using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.EN;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace ClassLibrary.CAD
{
    public class CADdatosbancarios
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

        // constructor por defecto
        public CADdatosbancarios() {}

        // inserta una tupla en la tabla datosBancarios de la base de datos con una tarjeta asociada a un usuario
        public void create( EN.datosbancarios dban )
        {
            // creamos la query en sentenciaDB, conectamos con la base de datos y ejecutamos la query
            try
            {
                string sentenciaDB = "INSERT INTO datosBancarios" +
                    "(usuario, numeroTarjeta, nombre, apellido, fvencimiento, codigoSeguridad)"
                    + "VALUES('" +
                    dban.Usuario.ToString() + "', '" +
                    dban.NumeroTarjeta.ToString() + "', '" +
                    dban.Nombre.ToString() + "', '" +
                    dban.Apellido.ToString() + "', '" +
                    dban.FechaVencimiento.ToString() + "', " +
                    dban.CVC.ToString() + ")";

                conn = new SqlConnection();
                conn.ConnectionString = stringConexion;
                conn.Open();

                SqlCommand com = new SqlCommand(sentenciaDB, conn);
                com.ExecuteNonQuery();
            }
            // capturamos un posible fallo
            catch (Exception ex)
            {
                Console.WriteLine("Fallo a la hora de crear el dato bancario de {0}", dban.Usuario.ToString());
                Console.WriteLine(".\nError: {0}", ex.ToString());
            }
            // cerramos la conexión
            finally
            {
                conn.Close();
            }
        }

        // recupera una tupla de la tabla datosBancarios de la base de datos con una tarjeta asociada a un usuario
        public List<string> read(EN.datosbancarios dban)
        {
            List<string> mostrado = new List<string>();

            // creamos la query en sentenciaDB, conectamos con la base de datos y ejecutamos la query
            try
            {
                string sentenciaDB = "SELECT * FROM datosBancarios WHERE usuario = '" +
                    dban.Usuario.ToString() + "'";

                conn = new SqlConnection();
                conn.ConnectionString = stringConexion;
                conn.Open();

                SqlCommand com = new SqlCommand(sentenciaDB, conn);
                SqlDataReader rd = com.ExecuteReader();

                while (rd.Read())
                {
                    mostrado.Add(rd["usuario"].ToString());
                    mostrado.Add(rd["numeroTarjeta"].ToString());
                    mostrado.Add(rd["nombre"].ToString());
                    mostrado.Add(rd["apellido"].ToString());
                    mostrado.Add(rd["fvencimiento"].ToString());
                    mostrado.Add(rd["codigoSeguridad"].ToString());
                }
            }
            // capturamos un posible fallo
            catch (Exception ex)
            {
                Console.WriteLine("Fallo a la hora de leer el dato bancario de {0}", dban.Usuario.ToString());
                Console.WriteLine(".\nError: {0}", ex.ToString());
            }
            // cerramos la conexión
            finally
            {
                conn.Close();
            }
            return mostrado;
        }
        // cambia una tupla de la tabla datosBancarios de la base de datos con una tarjeta asociada a un usuario
        public void update(EN.datosbancarios dban, ulong numerotarjeta)
        {
            // creamos la query en sentenciaDB, conectamos con la base de datos y ejecutamos la query
            try
            {
                string sentenciaDB = "UPDATE datosBancarios SET " +
                           "numeroTarjeta = '" + numerotarjeta.ToString() + "'" +
                           " WHERE usuario = '" + dban.Usuario.ToString() + "'";

                conn = new SqlConnection();
                conn.ConnectionString = stringConexion;
                conn.Open();

                SqlCommand com = new SqlCommand(sentenciaDB, conn);
                com.ExecuteNonQuery();
            }
            // capturamos un posible fallo
            catch (Exception ex)
            {
                Console.WriteLine("Fallo a la hora de cambiar el dato bancario de {0}", dban.Usuario.ToString());
                Console.WriteLine(". \nError: {0}", ex.ToString());
            }
            // cerramos la conexión
            finally
            {
                conn.Close();
            }
        }
        public void delete(EN.datosbancarios dban)
        {
            // creamos la query en sentenciaDB, conectamos con la base de datos y ejecutamos la query
            try
            {
                string sentenciaDB = "DELETE FROM datosBancarios WHERE usuario = " + dban.Usuario + " AND numeroTarjeta = " + dban.NumeroTarjeta;

                conn = new SqlConnection();
                conn.ConnectionString = stringConexion;
                conn.Open();

                SqlCommand com = new SqlCommand(sentenciaDB, conn);
                com.ExecuteNonQuery();
            }
            // capturamos un posible fallo
            catch (Exception ex)
            {
                Console.WriteLine("Fallo a la hora de eliminar el dato bancario de {0}", dban.Usuario.ToString());
                Console.WriteLine(".\nError: {0}", ex.ToString());
            }
            // cerramos la conexión
            finally
            {
                conn.Close();
            }

        }

    }
}
