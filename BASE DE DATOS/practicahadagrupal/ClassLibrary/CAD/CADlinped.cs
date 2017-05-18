using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace ClassLibrary.CAD{

    public class CADlinped{

        private SqlConnection conn = null;
        private string stringConexion = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\EPS\Desktop\practicahada\BASE DE DATOS\practicahadagrupal\practicahadagrupal\App_Data\Database1.mdf; Integrated Security = True";

        public CADlinped() { }

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
