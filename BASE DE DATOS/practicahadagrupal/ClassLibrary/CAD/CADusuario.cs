﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO;

namespace ClassLibrary.CAD{

    public class CADusuario{
        
        private SqlConnection conn = null;
<<<<<<< HEAD

        private string stringConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFilename=C:\Users\JOSEIGNACIO\Desktop\HADA\PRACTICA GRUPAL\practicahada\BASE DE DATOS\practicahadagrupal\practicahadagrupal\App_Data\Database1.mdf; Integrated Security=true";
<<<<<<< HEAD
=======
        public CADusuario(){}
=======

        private string stringConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFilename=C:\Users\alihyder\Documents\practicahada\BASE DE DATOS\practicahadagrupal\practicahadagrupal\App_Data\Database1.mdf; Integrated Security=true";

>>>>>>> 48765284V
>>>>>>> master

        // constructor por defecto
        public CADusuario(){}

        // hace una sentencia para poder meter el nuevo usuario en la base de datos
        public void create(EN.usuario user)
        {
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

                conn = new SqlConnection();

                conn.ConnectionString = stringConexion;
                conn.Open();

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
        }

        // sentencia que te lee un usuario en concreto
        public List<string> read(string user)
        {
            List<string> salida = new List<string>();

            try
            {
                string sentencia = "Select * from usuario " + 
                                    "where usuario = '" + user + "'";

                conn = new SqlConnection();

                conn.ConnectionString = stringConexion;
                conn.Open();

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

<<<<<<< HEAD
        /*
        // comprueba si el usuario existe en la base de datos, return bool 
        public bool existe(string user)
=======
        public string readstring(string user)
>>>>>>> master
        {
            string salida = "";

            try
            {
                string sentencia = "Select * from usuario " +
                                    "where usuario = '" + user + "'";

                conn = new SqlConnection();

                conn.ConnectionString = stringConexion;
                conn.Open();

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
        
        // compruena si el usuario existe en la base de datos, return bool 
        public bool existe(string user)
        {
            bool encontrado = false;

            string datosUsuario = "";

            datosUsuario = readstring(user);

            if (datosUsuario != "")
                encontrado = true;

            return encontrado;
        }
<<<<<<< HEAD
        */

        // modifica un usuario que exista en la base de datos
=======
        
>>>>>>> master
        public void update(EN.usuario user){

            try{

                string sentencia = @"UPDATE usuario SET " +

                 "direccion = '"        + user.Direccion.ToString() + 
                 "', contraseña = '"    + user.Contrasena.ToString() +
                 "', ciudad = '"        + user.Ciudad.ToString() +
                 "', pais = '"          + user.Pais.ToString() + 
                 "', descripcion = '"   + user.Descripcion.ToString() +
                 "', email = '"         + user.Email.ToString() +
                 "', edad = '"          + user.Edad.ToString() + "'" +
                 "WHERE usuario = '" + user.Usuario.ToString() + "'";

                conn = new SqlConnection();

                conn.ConnectionString = stringConexion;
                conn.Open();

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
            try
            {
                string sentencia = "DELETE FROM usuario  WHERE usuario = '" +
                                    user + "'";
                
                conn = new SqlConnection();

                conn.ConnectionString = stringConexion;
                conn.Open();

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
        
    }
}