using System;
using System.IO;
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

namespace ClassLibrary.CAD
{
    public class CADdatosbancarios
    {
        private SqlConnection conn = null;
        private string stringConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFilename=" + Directory.GetCurrentDirectory() + "..\..\..\practicahadagrupal\App_Data\Database1.mdf ";Integrated Security=true";

        public CADdatosbancarios() {}

        public void create( EN.datosbancarios dban )
        {
            try
            {
                string sentenciaDB = "INSERT INTO datosBancarios" +
                    "(usuario, numeroTarjeta, nombre, apellido, fvencimiento, codigoSeguridad)"
                    + "VALUES('" +
                    dban.Usuario.ToString() + "', '" +
                    dban.NumeroTarjeta.ToString() + "', '" +
                    dban.Nombre.ToString() + "', '" +
                    dban.Apellido.ToString() + "', '" +
                    dban.FechaVencimiento.ToString() + "', " +
                    dban.CVC.ToString() + ")";

                conn = new SqlConnection();
                conn.ConnectionString = stringConexion;
                conn.Open();

                SqlCommand com = new SqlCommand(sentenciaDB, conn);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo a la hora de crear el dato bancario de {0}", dban.Usuario.ToString());
                Console.WriteLine(".\nError: {0}", ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }
        public void read(EN.datosbancarios dban)
        {
            string mostrado = "";

            try
            {
                string sentenciaDB = "SELECT * FROM datosBancarios WHERE usuario = '" +
                    dban.Usuario.ToString() + "'";

                conn = new SqlConnection();
                conn.ConnectionString = stringConexion;
                conn.Open();

                SqlCommand com = new SqlCommand(sentenciaDB, conn);
                SqlDataReader rd = com.ExecuteReader();

                while (rd.Read())
                {
                    mostrado =  rd["usuario"].ToString() +
                                rd["numeroTarjeta"].ToString() +
                                rd["nombre"].ToString() +
                                rd["apellido"].ToString() +
                                rd["fvencimiento"].ToString() +
                                rd["codigoSeguridad"].ToString() +;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo a la hora de leer el dato bancario de {0}", dban.Usuario.ToString());
                Console.WriteLine(".\nError: {0}", ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }
        public void update(EN.datosbancarios dban)
        {
            try
            {
                string sentencia = "UPDATE datosBancarios  SET " +
                           "numeroTarjeta = '" + dban.NumeroTarjeta.ToString() + "'" +
                           " WHERE usuario = '" + dban.Usuario.ToString() + "'";


                conn = new SqlConnection();


                SqlCommand com = new SqlCommand(sentencia, conn);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo a la hora de cambiar el dato bancario de {0}", dban.Usuario.ToString());
                Console.WriteLine(". \nError: {0}", ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }
        public void delete(EN.datosbancarios dban)
        {
            try
            {
                string sentenciaDB = "DELETE FROM datosBancarios WHERE usuario = " + dban.Usuario + " AND numeroTarjeta = " + dban.NumeroTarjeta;

                conn = new SqlConnection();
                conn.ConnectionString = stringConexion;
                conn.Open();

                SqlCommand com = new SqlCommand(sentenciaDB, conn);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo a la hora de eliminar el dato bancario de {0}", dban.Usuario.ToString());
                Console.WriteLine(".\nError: {0}", ex.ToString());
            }
            finally
            {
                conn.Close();
            }

        }

    }
}
