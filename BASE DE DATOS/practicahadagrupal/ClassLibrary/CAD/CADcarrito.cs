using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using ClassLibrary.EN;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO;

namespace ClassLibrary.CAD
{
    public class CADcarrito
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

        public CADcarrito()
        {
        }

        public void add(ENCarro c)
        {
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = stringConexion;
                conn.Open();

                string sentenciaDB = "INSERT INTO " +
                       "carrito(Id, usuario, producto)" +
                       "VALUES(" +
                        c.Id.ToString() + ", " +
                        c.Usuario.ToString() + ", " +
                        c.Producto.ToString() + ")";

                SqlCommand com = new SqlCommand(sentenciaDB, conn);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo al crear carro.");
                Console.WriteLine(". \nError: {0}", ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        public void remove(int num_pedido)
        {
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = stringConexion;
                conn.Open();

                string sentenciaDB = "DELETE FROM carrito WHERE ID = " +
                        num_pedido.ToString();

                SqlCommand com = new SqlCommand(sentenciaDB, conn);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo al limpiar carrito.");
                Console.WriteLine(". \nError: {0}", ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        public void update(ENCarro c, ENCarro nuevo)
        {
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = stringConexion;
                conn.Open();

                string sentenciaDB = @"UPDATE carrito SET " +
                    "Id = " + nuevo.Id.ToString() +
                    ", usuario = '" + nuevo.Usuario.ToString() +
                    "', ciudad = " + nuevo.Producto.ToString() +
                    " WHERE Id = " + c.Usuario.ToString();

                SqlCommand com = new SqlCommand(sentenciaDB, conn);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo al actualizar carrito.");
                Console.WriteLine(". \nError: {0}", ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        public List<ENCarro> read(int num_pedido)
        {
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = stringConexion;
                conn.Open();

                List<ENCarro> c = new List<ENCarro>();
                string sentenciaDB = "select * from carrito where Id = " + num_pedido.ToString();

                SqlCommand com = new SqlCommand(sentenciaDB, conn);
                SqlDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {
                    ENCarro carro = new ENCarro();
                    carro.Id = dr.GetInt32(0);
                    carro.Usuario = int.Parse(dr.GetString(1));
                    carro.Producto.Id = dr.GetInt32(2);
                    string sentenciaDB2 = "select precio from productos where id = " + carro.Producto.ToString();
                    SqlCommand com2 = new SqlCommand(sentenciaDB2, conn);
                    SqlDataReader dr2 = com.ExecuteReader();
                    if (dr2.Read())
                    {
                        carro.Precio = dr2.GetFloat(4);
                    }
                    c.Add(carro);
                }
                return c;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo al leer carrito.");
                Console.WriteLine(". \nError: {0}", ex.ToString());
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}