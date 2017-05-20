using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

using System.Web;

using System.IO;

using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using ClassLibrary.EN;

namespace ClassLibrary.CAD{
    class CADproducto
    {


        private SqlConnection conexion = null;

        //constructor por defecto.
        public CADproducto() {
            conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
        }

        //Metodo que crea un producto a partir del que le pasan por parametro
        public void create(ClassLibrary.EN.Producto p) {
            SqlConnection conn = conexion;
            conn.Open();
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
            conn.Close();
        }

        //Metodo que elimina el producto que tenga la id pasada porparametro.
        public void remove(int id) {
            SqlConnection conn = conexion;
            conn.Open();
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

        //Metodo que modifica un producto pasado por parametro.
        public void update(ClassLibrary.EN.Producto p) {
            SqlConnection conn = conexion;
            conn.Open();
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

        //Metodo que te devuleve el objeto que contenga la id pasada por parametro.
        public EN.Producto consultarProducto(int id) {
            SqlConnection conn = conexion;
            conn.Open();

            string sentenciaDB = "SELECT * FROM producto WHERE id = '" +
                id + "'";
            EN.Producto prod = new EN.Producto();

            SqlCommand com = new SqlCommand(sentenciaDB, conn);
            SqlDataReader rd = com.ExecuteReader();

            while (rd.Read()) {
                prod.Id = int.Parse(rd["id"].ToString());
                prod.Nombre = rd["nombre"].ToString();
                prod.Descripcion = rd["descripcion"].ToString();
                prod.Imagen = rd["imagen"].ToString();
                prod.Precio = int.Parse(rd["precio"].ToString());
            }

            conn.Close();
            return prod;
        }

        //Metodo que recibe la peticion de consultar todos los producos
        public List<EN.Producto> PeticionConsultar() {

            SqlConnection conn = conexion;

            return ConsultarTodos(conn);
        }

        //Metodo que consulta todos los productos de la pagina web
        public List<EN.Producto> ConsultarTodos(SqlConnection conn) {

            conn.Open();

            string sentenciaDB = "SELECT * FROM Producto";

            SqlCommand com = new SqlCommand(sentenciaDB, conn);
            SqlDataReader rd = com.ExecuteReader();

            List<EN.Producto> p = new List<EN.Producto>();
            while (rd.Read()) {
                EN.Producto prod = new EN.Producto();
                prod.Id = rd.GetInt32(0);
                prod.Nombre = rd.GetString(1);
                prod.Descripcion = rd.GetString(2);
                prod.Imagen = rd.GetString(3);
                prod.Precio = int.Parse(rd["precio"].ToString());

                p.Add(prod);
            }

            rd.Close();
            conn.Close();
            return p;
        }


    }
}
