﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.CAD{

    class CADusuario{

        public CADusuario(){}
		
<<<<<<< HEAD
		public void create(EN.usuario user){

        }
=======
>>>>>>> origin/48781689T

        public void delete(string usuario){

        }

<<<<<<< HEAD
        public void update(EN.usuario user){

        }

        public void read(string usuario){
=======
        public void create(EN.usuario user)
        {
            try
            {
                string sentencia = "INSERT INTO usuario" +
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

        public string read(string user)
        {
            string salida = "";

            try
            {

                string sentencia = "Select * from usuario " + "where usuario = '" + user + "'";

                conn = new SqlConnection();

                conn.ConnectionString = stringConexion;
                conn.Open();

                SqlCommand com = new SqlCommand(sentencia, conn);
                SqlDataReader ur = com.ExecuteReader();


                while (ur.Read())
                {
                    salida = " " + ur["usuario"].ToString() + ur["direccion"].ToString() + " " +
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
>>>>>>> origin/48781689T

        }

        public void update(EN.usuario user){
            try{
                string sentencia = @"UPDATE usuario SET" +
                 "direccion = '"        + user.Direccion.ToString() + 
                 "', contraseña = '"    + user.Contrasena.ToString() +
                 "', ciudad = '"        + user.Ciudad.ToString() +
                 "', pais = '"          + user.Pais.ToString() + 
                 "', descripcion = '"   + user.Descripcion.ToString() +
                 "', email = '"         + user.Email.ToString() +
                 "', edad = '"          + user.Edad.ToString() + "')";

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
        
    }
}
