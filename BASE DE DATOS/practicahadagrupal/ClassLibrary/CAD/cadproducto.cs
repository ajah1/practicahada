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

        public CADproducto() {
            string cadenaconexion = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            conn = new SqlConnection();
            conn.ConnectionString = cadenaconexion;
            conn.Open();
        }

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

        public void remove(int id) {
            try {
                string sentenciaDB = "DELETE FROM producto WHERE id = " + id.ToString();

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
