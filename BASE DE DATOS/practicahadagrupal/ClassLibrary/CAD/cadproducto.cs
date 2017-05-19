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

namespace ClassLibrary.CAD{
    class CADproducto{

        private SqlConnection conn = null;
        private string stringConexion = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\EPS\Desktop\practicahada\BASE DE DATOS\practicahadagrupal\practicahadagrupal\App_Data\Database1.mdf; Integrated Security = True";


        public CADproducto() {}

        public void create(ClassLibrary.EN.Producto p) {
            try {
                string sentenciaDB = "INSERT INTO producto" +
                    "(id, nombre, descripcion, imagen, precio)"
                    + "VALUES('" +
                    p.Id.ToString() + "', '" +
                    p.Nombre + "', '" +
                    p.Descripcion + "', '" +
                    p.Nombre + "', '" +
                    p.Precio.ToString() + "')'";

                conn = new SqlConnection();
                conn.ConnectionString = stringConexion;
                conn.Open();

                SqlCommand com = new SqlCommand(sentenciaDB, conn);
                com.ExecuteNonQuery();
            }
            catch (Exception ex) {
                Console.WriteLine("Fallo a la hora de crear un producto");
                Console.WriteLine(".\nError: {0}", ex.ToString());
            }
            finally {
                conn.Close();
            }
        }

<<<<<<< HEAD
        public void InsertarPedido(EN.ENCarro ped)
		{
			try
			{
				string sentenciaDB = "Insert into carro (data,email) values ('" + ped.Data + "','" + ped.Email + "')";
				//Insertamos el pedido
				conn = new SqlConnection();
				conn.ConnectionString = stringConexion;
				conn.Open();
				//nesecitem el id de l'ultim pedido per fer insert de les llinies del pedido
				SqlCommand com = new SqlCommand(sentenciaDB, conn);
                com.ExecuteNonQuery();

                int numPedido = Convert.ToInt32(conn["numPedido"]);
				//Insertem les linies de pedido
                EN.ENLineapedido linea;
                ArrayList lineas = ped.Productos;
                for (int i = 1; i <= lineas.Count; i++)
				{
                    linea = (EN.ENLineapedido)lineas[i - 1];
                    string sentenciaDB2 = "Insert into lineapedido (linea, numpedido,codart,cantitat) values (" + i + ", " + numPedido + ",'" + linea.IdArticle() + "'," + linea.Cantitat + ")";
					SqlCommand com2 = new SqlCommand(sentenciaDB2, conn);
					com2.ExecuteNonQuery();
				}
			}
			catch (Exception ex)
			{
				throw new Exception("Exception en InsertarPedido " + ex.ToString());
			}
			finally
			{
                conn.Close();
			}
		}

=======
>>>>>>> master
        public void remove(int id) {
            try {
                string sentenciaDB = "DELETE FROM producto WHERE id = " + id.ToString();

                conn = new SqlConnection();
                conn.ConnectionString = stringConexion;
                conn.Open();

                SqlCommand com = new SqlCommand(sentenciaDB, conn);
                com.ExecuteNonQuery();
            }
            catch (Exception ex) {
                Console.WriteLine("Fallo a la hora de eliminar un producto");
                Console.WriteLine(".\nError: {0}", ex.ToString());
            }
            finally {
                conn.Close();
            }

        }

        public void update(ClassLibrary.EN.Producto p) {
            try {
                string sentenciaDB = @"UPDATE producto SET " +
                    "id =" + p.Id.ToString() + 
                    "', nombre = '" + p.Nombre + 
                    "', descripcion = '" + p.Descripcion + 
                    "', imagen = '" + p.Nombre + 
                    "', precio = '" + p.Precio.ToString() + "')'";

                conn = new SqlConnection();
                conn.ConnectionString = stringConexion;
                conn.Open();

                SqlCommand com = new SqlCommand(sentenciaDB, conn);
                com.ExecuteNonQuery();
            }
            catch (Exception ex) {
                Console.WriteLine("Fallo a la hora de modificar un producto");
                Console.WriteLine(".\nError: {0}", ex.ToString());
            }
            finally {
                conn.Close();
            }

        }

        public void consultar(ClassLibrary.EN.Producto p) {
            string mostrado = "";

            try {
                string sentenciaDB = "SELECT * FROM producto WHERE id = " +
                    p.Id.ToString() + "'";

                conn = new SqlConnection();
                conn.ConnectionString = stringConexion;
                conn.Open();

                SqlCommand com = new SqlCommand(sentenciaDB, conn);
                SqlDataReader rd = com.ExecuteReader();

                while (rd.Read()) {
                    mostrado = " " + rd["id"].ToString() +
                                     rd["nombre"] +
                                     rd["descripcion"] +
                                     rd["imagen"] +
                                     rd["precio"].ToString();
                }
            }
            catch (Exception ex) {
                Console.WriteLine("Fallo a la hora de mostrar un producto");
                Console.WriteLine(".\nError: {0}", ex.ToString());
            }
            finally {
                conn.Close();
            }

        }

    }
}
