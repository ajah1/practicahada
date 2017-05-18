﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;


namespace ClassLibrary.CAD
{
    

    public class CADranking
    {

        
        public CADranking() { }

        private SqlConnection conn = null;
        private string stringConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFilename=C:\Users\alihyder\Documents\practicahada\BASE DE DATOS\practicahadagrupal\practicahadagrupal\App_Data\Database1.mdf;Integrated Security=true";


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

        // inserta los usuarios con mayor record
        public void add()
        {
            try
            {
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

        // actualizar el ranking
        public void updateTable()
        {

            // 1- borrar toda la tabla ranking
            this.drop();

            // 2- actualizar la tabla con el nuevo ranking
            this.add();
        }
    }
}