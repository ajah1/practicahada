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

namespace ClassLibrary.CAD{

    public class CADusuario{
        
        private SqlConnection conn = null;


        public CADusuario(){
            string cadenaconexion = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            conn = new SqlConnection();
            conn.ConnectionString = cadenaconexion;
            conn.Open();
        }


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


        public List<string> read(string user)
        {
            List<string> salida = new List<string>();

            try
            {
                string sentencia = "Select * from usuario " + 
                                    "where usuario = '" + user + "'";

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

        public void update(EN.usuario user){
            try{
                string sentencia = @"UPDATE usuario SET " +
                 "direccion = '"        + user.Direccion.ToString() + 
                 "', contraseña = '"    + user.Contrasena.ToString() +
                 "', ciudad = '"        + user.Ciudad.ToString() +
                 "', pais = '"          + user.Pais.ToString() + 
                 "', descripcion = '"   + user.Descripcion.ToString() +
                 "', email = '"         + user.Email.ToString() +
                 "', edad = '"          + user.Edad.ToString() + "')" +
                 "WHERE usuario = '" + user.Usuario.ToString() + "'";


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

        public void delete(string user)
        {
            try
            {
                string sentencia = "DELETE FROM usuario  WHERE usuario = '" +
                                    user + "'";
                


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