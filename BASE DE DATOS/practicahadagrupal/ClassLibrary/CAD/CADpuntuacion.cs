using System;
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

    public class CADpuntuacion
    {

        public CADpuntuacion()
        { }

        private SqlConnection conn = null;
        private string stringConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFilename=/Users/Laila/Desktop/HADA/practicahada/BASE DE DATOS/practicahadagrupal/practicahadagrupal/App_Data/Database1.mdf;Integrated Security=true";


        public void remove(string usuario)
        {
            try
            {
                string sentencia = @"UPDATE puntuacion  SET " +
                        "record = 0" + "vidas = 0" + "puntosTotales= 0 " + " WHERE pusuario " + usuario;

                conn = new SqlConnection();

                conn.ConnectionString = stringConexion;
                conn.Open();

                SqlCommand com = new SqlCommand(sentencia, conn);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Remove Puntuacion failed.");
                Console.WriteLine(". \nError: {0}", ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        //se supone que saca los puntos Totales del usuario
        public int obtenerPuntuacion(string usuario)
        {

            int salida = 0;

            try
            {

                string sentencia = "Select * from puntuacion " +
                                   "where pusuario = '" + usuario + "'";

                conn = new SqlConnection();

                conn.ConnectionString = stringConexion;
                conn.Open();

                SqlCommand com = new SqlCommand(sentencia, conn);
                SqlDataReader dr = com.ExecuteReader();


                while (dr.Read())
                {
                    salida = (int)dr["puntosTotales"];
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Read Puntos failed.");
                Console.WriteLine(". \nError: {0}", ex.ToString());
            }
            finally
            {
                conn.Close();
            }

            return salida;
        }


    public void updatePuntuacion(EN.puntuacion p)
    {
        int puntos = 0;
        puntos = p.obtenerPuntuacion(p.user);
        puntos += p.p;
        try
        {

            string sentencia = @"UPDATE puntuacion  SET " +
                       "puntosTotales = '" + puntos.ToString() + "'" + "WHERE pusuario= '" + p.user + "'";


            conn = new SqlConnection();

            conn.ConnectionString = stringConexion;
            conn.Open();

            SqlCommand com = new SqlCommand(sentencia, conn);
            com.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Update Puntuacion failed.");
            Console.WriteLine(". \nError: {0}", ex.ToString());
        }
        finally
        {
            conn.Close();
        }
    }

    // PROVISIONAL: hasta que se una con la web
    public string read(string usuario)
    {
        string salida = "";

        try
        {

            string sentencia = "Select * from puntuacion " +
                               "where pusuario = '" + usuario + "'";

            conn = new SqlConnection();

            conn.ConnectionString = stringConexion;
            conn.Open();

            SqlCommand com = new SqlCommand(sentencia, conn);
            SqlDataReader dr = com.ExecuteReader();


            while (dr.Read())
            {
                salida = " " + dr["record"].ToString() +
                    dr["vidas"].ToString() + " " +
                    dr["puntosTotales"].ToString();
                }

        }
        catch (Exception ex)
        {
            Console.WriteLine("Read Puntuacion failed.");
            Console.WriteLine(". \nError: {0}", ex.ToString());
        }
        finally
        {
            conn.Close();
        }

        return salida;
    }
}
}
