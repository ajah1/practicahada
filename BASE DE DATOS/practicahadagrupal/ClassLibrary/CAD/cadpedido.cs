﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.EN;
using System.Configuration;
<<<<<<< HEAD
using System.Collections;
=======
>>>>>>> master

using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
<<<<<<< HEAD

namespace ClassLibrary.CAD{

    class CADpedido{

        private SqlConnection conn = null;
        private string stringConexion = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\EPS\Desktop\practicahada\BASE DE DATOS\practicahadagrupal\practicahadagrupal\App_Data\Database1.mdf; Integrated Security = True";
=======

namespace ClassLibrary.CAD{

    class CADpedido{

        private SqlConnection conn = null;
        private string stringConexion = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\EPS\Desktop\practicahada\BASE DE DATOS\practicahadagrupal\practicahadagrupal\App_Data\Database1.mdf; Integrated Security = True";

>>>>>>> master

        public CADpedido(){}

<<<<<<< HEAD
        public CADpedido(){}

=======
>>>>>>> master
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
<<<<<<< HEAD

        }

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
				SqlDataReader dr = com.ExecuteReader();
				dr.Read();
                int numPedido = Convert.ToInt32(dr["numPedido"]);
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

        }
>>>>>>> master

    }
}
