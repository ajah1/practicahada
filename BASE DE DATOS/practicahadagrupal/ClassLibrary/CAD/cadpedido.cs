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
        private string stringConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFilename=C:\Users\JOSEIGNACIO\Desktop\HADA\PRACTICA GRUPAL\practicahada\BASE DE DATOS\practicahadagrupal\practicahadagrupal\App_Data\Database1.mdf ;Integrated Security=true";


        public CADpedido(){}

        public void create(pedido ped){
            try
            {
                string sentenciaDB = "INSERT INTO pedido" +
                    "(num_pedido, usuario, fecha)"
                    + "VALUES('" +
                    ped.NumPedido.ToString() + "', '" +
                    ped.Usuhario.Usuario + "', '" +
                    ped.Fecha.ToString() + "', '" + "')'";

                conn = new SqlConnection();
                conn.ConnectionString = stringConexion;
                conn.Open();

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
