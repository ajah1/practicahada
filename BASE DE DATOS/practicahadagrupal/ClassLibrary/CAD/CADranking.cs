using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO;

namespace ClassLibrary.CAD
{
    

    public class CADranking
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

        //constructor por defecto
        public CADranking() { }

		// borrar todas las tuplas de la tabla ranking
		public void drop()
        {
            try
            {

                string sentencia = @"TRUNCATE TABLE ranking";

                conn = new SqlConnection();

                conn.ConnectionString = stringConexion;
                conn.Open();

                SqlCommand com = new SqlCommand(sentencia, conn);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("drop rankin failed.");
                Console.WriteLine(". \nError: {0}", ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        // inserta los usuarios con mayor record según la sentencia que hemos hecho
        public void add()
        {
            try
            {
                //sentencia que escoge de la tabla puntuacion los usuarios y su puntuacion
                //para añadirlo a la tabla ranking
                string sentencia = "INSERT INTO ranking(usuario, puntuacion) " +
                    " SELECT pusuario, record FROM puntuacion";


                conn = new SqlConnection();

                conn.ConnectionString = stringConexion;
                conn.Open();

                conn = new SqlConnection();

                conn.ConnectionString = stringConexion;
                conn.Open();

                SqlCommand com = new SqlCommand(sentencia, conn);
                com.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Create Ranking failed.");
                Console.WriteLine(". \nError: {0}", ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        // actualizar el ranking cada vez que se llama
        public void updateTable()
        {

            // 1.- borrar toda la tabla ranking
            this.drop();

            // 2.- actualizar la tabla con el nuevo ranking
            this.add();
        }
    }
}