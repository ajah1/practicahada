using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.EN;
using System.Configuration;
using System.IO;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace ClassLibrary.CAD{

    class CADpedido
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


        public CADpedido(){}

        public void create(pedido ped){

            try
            {
                string sentenciadb = @"INSERT INTO pedido" +
                    "(usuario, fecha) VALUES ('" +
                    ped.Usuhario.Usuario.ToString() + "', '" +
                    ped.Fecha.ToString() + "')";

                conn = new SqlConnection();

                conn.ConnectionString = stringConexion;
                conn.Open();

                SqlCommand com = new SqlCommand(sentenciadb, conn);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo a la hora de eliminar un pedido");
                Console.WriteLine(".\nError: {0}", ex.ToString());
            }
            finally
            {
                conn.Close();
            }

        }

        
        public void remove(pedido ped){
            try {
                string sentenciaDB = "DELETE FROM pedido WHERE num_pedido = " + ped.NumPedido;

                conn = new SqlConnection();
                conn.ConnectionString = stringConexion;
                conn.Open();

                SqlCommand com = new SqlCommand(sentenciaDB, conn);
                com.ExecuteNonQuery();
            }
            catch (Exception ex) {
                Console.WriteLine("Fallo a la hora de eliminar un pedido");
                Console.WriteLine(".\nError: {0}", ex.ToString());
            }
            finally {
                conn.Close();
            }

        }

    }
}
