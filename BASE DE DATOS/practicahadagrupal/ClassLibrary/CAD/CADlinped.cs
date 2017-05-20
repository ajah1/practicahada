using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace ClassLibrary.CAD{

    public class CADlinped
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
        public CADlinped() { }

        // hace una sentencia para meter la linea de pedido en la base de datos
        public void create(EN.enlinped lin)
        {
            try
            {
                string sentencia = "INSERT INTO lineaPedido" +
                    "(numPedido, linea, producto, precio, cantidad)" +
                    "VALUES('" +
                    lin.NumPedido.ToString() + "', '" +
                    lin.Linea.ToString() + "', '" +
                    lin.Producto.ToString() + "', '" +
                    lin.Precio.ToString() + "', '" +
                    lin.Cantidad.ToString() + "')";

                conn = new SqlConnection();

                conn.ConnectionString = stringConexion;
                conn.Open();

                SqlCommand com = new SqlCommand(sentencia, conn);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Create LineaPedido failed.");
                Console.WriteLine(". \nError: {0}", ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        // borra la linea de pedido
        public void delete(EN.enlinped lin)
        {
            try
            {
                string sentencia = "DELETE FROM lineaPedido WHERE numPedido = " +
                    lin.NumPedido.ToString() + " and linea = " + lin.Linea.ToString();

                conn = new SqlConnection();

                conn.ConnectionString = stringConexion;
                conn.Open();

                SqlCommand com = new SqlCommand(sentencia, conn);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Delete lineaPedido failed.");
                Console.WriteLine(". \nError: {0}", ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        // lee una linea de pedido
        public string read(EN.enlinped lin)
        {
            string salida = "";

            try
            {

                string sentencia = "Select * from lineaPedido " + "where numPedido = '" + lin.NumPedido.ToString()
                    + "' and linea = '" + lin.Linea.ToString() + "'";

                conn = new SqlConnection();

                conn.ConnectionString = stringConexion;
                conn.Open();

                SqlCommand com = new SqlCommand(sentencia, conn);
                SqlDataReader ur = com.ExecuteReader();


                while (ur.Read())
                {
                    salida = " " + ur["numPedido"].ToString() + ur["linea"].ToString() + " " +
                        ur["producto"].ToString() + " " + ur["precio"].ToString() + " " + ur["cantidad"].ToString();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Read LineaPedido failed.");
                Console.WriteLine(". \nError: {0}", ex.ToString());
            }
            finally
            {
                conn.Close();
            }

            return salida;
        }
    }
    /*
    public void update()
        {
           
        }*/
}
