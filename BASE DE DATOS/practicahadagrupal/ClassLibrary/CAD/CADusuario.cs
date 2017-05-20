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
using System.IO;

namespace ClassLibrary.CAD{


    public class CADusuario
    {

        //constructor por defecto
        // private SqlConnection conexion = null;
        // private string stringConexion = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alihyder\Documents\practicahada\BASE DE DATOS\practicahadagrupal\WebApplication1\App_Data\database.mdf; Integrated Security = True";
        private SqlConnection conexion = null;

        public CADusuario()
        {
            conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
        }

        // hace una sentencia para poder meter el nuevo usuario en la base de datos
        public void create(EN.usuario user)
        {
            
            SqlConnection conn = conexion;
            conn.Open();
            


            // cuando se añada un usuario también se hará en puntuacion con 3 vidas
            EN.puntuacion p = new EN.puntuacion();
            p.user = user.Usuario;
            p.r = 0;
            p.v = 3;
            p.p = 0;


            try
            {
                string sentencia = "INSERT INTO usuario " +
                    "(usuario, direccion, contraseña, ciudad, pais, descripcion, email, edad)" +
                    "VALUES('" +
                    user.Usuario.ToString() + "', '" +
                    user.Direccion.ToString() + "', '" +
                    user.Contrasena.ToString() + "', '" +
                    user.Ciudad.ToString() + "', '" +
                    user.Pais.ToString() + "', '" +
                    user.Descripcion.ToString() + "', '" +
                    user.Email.ToString() + "', '" +
                    user.Edad.ToString() + "')";
                /*
                conn = new SqlConnection();

                conn.ConnectionString = stringConexion;
                conn.Open();
                */
                SqlCommand com = new SqlCommand(sentencia, conn);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Create Usuario failed.");
                Console.WriteLine(". \nError: {0}", ex.ToString());
            }
            finally
            {
                conn.Close();
            }

            p.addUser();

        }

        // sentencia que te lee un usuario en concreto
        public List<string> read(string user)
        {
            List<string> salida = new List<string>();
            
            SqlConnection conn = conexion;
            conn.Open();
            
            try
            {
                string sentencia = "Select * from usuario " + 
                                    "where usuario = '" + user + "'";
                /*
                conn = new SqlConnection();

                conn.ConnectionString = stringConexion;
                conn.Open();
                */
                SqlCommand com = new SqlCommand(sentencia, conn);
                SqlDataReader ur = com.ExecuteReader();


                while (ur.Read())
                {
                    /*
                    salida = " " + ur["usuario"].ToString() + ur["direccion"].ToString() + " " +
                        ur["ciudad"].ToString() + " " + ur["pais"].ToString() + " " + ur["descripcion"].ToString() +
                        " " + ur["email"].ToString() + " " + ur["edad"].ToString();
                    */
                    
                    salida.Add(ur["direccion"].ToString());
                    salida.Add(ur["ciudad"].ToString());
                    salida.Add(ur["pais"].ToString());
                    salida.Add(ur["descripcion"].ToString());
                    salida.Add(ur["email"].ToString());
                    salida.Add(ur["edad"].ToString());
                    salida.Add(ur["contraseña"].ToString());
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Read Usuario failed.");
                Console.WriteLine(". \nError: {0}", ex.ToString());
            }
            finally
            {
                conn.Close();
            }

            return salida;
        }

        // lee usuario
        public string readstring(string user)

        {
            string salida = "";
            
            SqlConnection conn = conexion;
            conn.Open();
            
            try
            {
                string sentencia = "Select * from usuario " +
                                    "where usuario = '" + user + "'";
                
                /*
                conn = new SqlConnection();

                conn.ConnectionString = stringConexion;
                conn.Open();
                */
                SqlCommand com = new SqlCommand(sentencia, conn);
                SqlDataReader ur = com.ExecuteReader();


                while (ur.Read())
                {
                    
                    salida = ur["usuario"].ToString() + ur["direccion"].ToString() + " " +
                        ur["ciudad"].ToString() + " " + ur["pais"].ToString() + " " + ur["descripcion"].ToString() +
                        " " + ur["email"].ToString() + " " + ur["edad"].ToString();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Read Usuario failed.");
                Console.WriteLine(". \nError: {0}", ex.ToString());
            }
            finally
            {
                conn.Close();
            }

            return salida;
        }
        
        // comprueba si el usuario existe en la base de datos, return bool 
        public bool existe(string user)
        {
            bool encontrado = false;

            string datosUsuario = "";

            datosUsuario = readstring(user);

            if (datosUsuario != "")
                encontrado = true;

            return encontrado;
        }
        
        // modifica un usuario que exista en la base de datos
        public void update(EN.usuario user){
            
            SqlConnection conn = conexion;
            conn.Open();
            
            try
            {

                string sentencia = @"UPDATE usuario SET " +

                 "direccion = '"        + user.Direccion.ToString() + 
                 "', contraseña = '"    + user.Contrasena.ToString() +
                 "', ciudad = '"        + user.Ciudad.ToString() +
                 "', pais = '"          + user.Pais.ToString() + 
                 "', descripcion = '"   + user.Descripcion.ToString() +
                 "', email = '"         + user.Email.ToString() +
                 "', edad = '"          + user.Edad.ToString() + "'" +
                 " WHERE usuario = '" + user.Usuario.ToString() + "'";
                
                /*
                conn = new SqlConnection();

                conn.ConnectionString = stringConexion;
                conn.Open();
                */
                SqlCommand com = new SqlCommand(sentencia, conn);
                com.ExecuteNonQuery();

            }
            catch(Exception ex){
                Console.WriteLine("Update Usuario failed.");
                Console.WriteLine(". \nError: {0}", ex.ToString());
            }
            finally{
                conn.Close();
            }
        }

        // hace una sentencia que te borra el usuario de la base de datos
        public void delete(string user)
        {
            
            SqlConnection conn = conexion;
            conn.Open();
            
            try
            {
                string sentencia = "DELETE FROM usuario  WHERE usuario = '" +
                                    user + "'";
                /*
                conn = new SqlConnection();

                conn.ConnectionString = stringConexion;
                conn.Open();
                */
                SqlCommand com = new SqlCommand(sentencia, conn);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Remove usuario failed.");
                Console.WriteLine(". \nError: {0}", ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        // devuelve un booleano
        public bool comprobarPass(string user, string pass)
        {
            bool correcta = false;

            List<string> l = new List<string>();
            l = read(user);

            if (existe(user) == true)
                if (pass == l[6])
                    correcta = true;
        
            return correcta;
        }

    }
}