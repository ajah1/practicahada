using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    public class CADcarrito
    {
        const string s = "data source=.\\SQLEXPRESS;Integrated"
                   + "Security = SSPI; AttachDBFilename =| DataDirectory |\\Database1.mdf;"
                   + "User Instance = true";

        SqlConnection conn = new SqlConnection(s);

        public CADcarrito()
        {
        }

        public void add(EN.ENCarro c)
        {
            try
            {
                conn.Open();
                SqlCommand com = new SqlCommand
                    (
                       "INSERT INTO " +
                       "carrito(Id, usuario, producto)" +
                       "VALUES(" +
                        c.Id.ToString() + ", " +
                        c.Usuario.ToString() + ", " +
                        c.Producto.ToString() + ")", conn);

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
                conn.Open();
                SqlCommand com = new SqlCommand
                    (
                        "DELETE FROM carrito WHERE ID = " +
                        num_pedido.ToString(), conn);

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

        public void update(EN.ENCarro c)
        {
            try
            {
                conn.Open();
                SqlCommand com = new SqlCommand();
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

        public List<EN.ENCarro> read(int num_pedido)
        {
            try
            {
                conn.Open();
                List<EN.ENCarro> c = new List<EN.ENCarro>();
                SqlCommand com = new SqlCommand("select * from carrito where usuario = 'esejuan'", conn);

                SqlDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {
                    EN.ENCarro carro = new EN.ENCarro();
                    carro.Id = dr.GetInt32(0);
                    carro.Usuario = dr.GetString(1);
                    carro.Producto.Id = dr.GetInt32(2);
                    SqlCommand com2 = new SqlCommand("select precio from productos where id = " + carro.Producto, conn);
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