using System;
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

namespace ClassLibrary.CAD{
    class CADpedido{

        private SqlConnection conn = null;


        public CADpedido(){
            string cadenaconexion = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            conn = new SqlConnection();
            conn.ConnectionString = cadenaconexion;
            conn.Open();
        }

        public void create(pedido ped){
            try
            {
                string sentenciaDB = "INSERT INTO pedido" +
                    "(usuario, fecha) "
                    + "VALUES('" +
                    ped.Usuhario.Usuario.ToString() + "', '" +
                    ped.Fecha.ToString() + "')";


                SqlCommand com = new SqlCommand(sentenciaDB, conn);
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

        // en principio no vamos a dejar borrar un pedido
        public void remove(pedido ped){
            try {
                string sentenciaDB = "DELETE FROM pedido WHERE num_pedido = " + ped.NumPedido;

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
