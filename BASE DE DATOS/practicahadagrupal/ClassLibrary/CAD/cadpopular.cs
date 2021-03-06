﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;

using ClassLibrary.EN;

namespace ClassLibrary.CAD
{
    public class CADpopular
    {
        // obtiene la ruta del ejecutable del programa, y la cambia para que apunte a la base de datos
        private static string entorno(string aux)
        {
            int x = aux.Length;
            for (int j = 0; j < 3; j++) { while (x > 0) { x--; if (aux[x] == '\\') { aux = aux.Remove(x, 1); break; } else { aux = aux.Remove(x, 1); } } }
            return aux + @"\WebApplication1\App_Data\database.mdf";
        }

        // inicializa una conexion, y apunta en stringConexion los parámetros de conexión
        private SqlConnection conn = null;
        private string stringConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFilename=" + entorno(Directory.GetCurrentDirectory()) + @";Integrated Security=true";

        //constructor
        public CADpopular() { }

        // añadir un productopopular
        public void add( EN.Popular p )
        {
            try
            {
                string sentencia = "INSERT INTO productoPopular" +
                                    "(id, numeroVentas) VALUES('" +
                                    p.Id.ToString() + "', '" +
                                    p.Numero_ventas.ToString() + "')";

                conn = new SqlConnection();

                conn.ConnectionString = stringConexion;
                conn.Open();

                SqlCommand com = new SqlCommand(sentencia,conn);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Create Popular failed.");
                Console.WriteLine(". \nError: {0}", ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        // boorar producto popopular por su id
        public void delete( int id )
        {
            try
            {
                string sentencia = "DELETE FROM productoPopular  WHERE ID = '" +
                                    id.ToString() + "'";

                conn = new SqlConnection();

                conn.ConnectionString = stringConexion;
                conn.Open();

                SqlCommand com = new SqlCommand(sentencia, conn);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Delete Popular failed.");
                Console.WriteLine(". \nError: {0}", ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        // actualizar un producto popultar
        public void update(EN.Popular p)
        {
            try
            {

                string sentencia = @"UPDATE productoPopular SET numeroVentas = '" +
                                    p.Numero_ventas.ToString() + "' " +
                                    "WHERE ID = '" + p.Id.ToString() + "'";

                conn = new SqlConnection();

                conn.ConnectionString = stringConexion;
                conn.Open();

                SqlCommand com = new SqlCommand(sentencia, conn);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Update Popular failed.");
                Console.WriteLine(". \nError: {0}", ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        // devuelve el nuermo de ventas de un pppopular
        public string read( int id )
        {

            string salida = "";

            try
            {

                string sentencia = @"SELECT * FROM productoPopular" +
                                                " WHERE ID = '" + id.ToString() + "'";

                conn = new SqlConnection();

                conn.ConnectionString = stringConexion;
                conn.Open();

                SqlCommand com = new SqlCommand(sentencia, conn);
                SqlDataReader dr = com.ExecuteReader();
                

                while (dr.Read())
                {
                    salida += dr["id"].ToString() + " ";
                    salida += dr["numeroVentas"].ToString();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Read Popular failed.");
                Console.WriteLine(". \nError: {0}", ex.ToString());
            }
            finally
            {
                conn.Close();
            }

            return salida;
        }

        // borrar todos los datos de la tabla ProductoPopular
        public void dropPopular()
        {
            try
            {

                string sentencia = @"TRUNCATE TABLE productoPopular";

                conn = new SqlConnection();

                conn.ConnectionString = stringConexion;
                conn.Open();

                SqlCommand com = new SqlCommand(sentencia, conn);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Update Popular failed.");
                Console.WriteLine(". \nError: {0}", ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        // devuelve una lista con los 3 productos mas comprados
        public List<int> productosPopulares()
        {
            List<int> lista = new List<int>();

            try
            {

                string sentencia = @"SELECT producto from lineaPedido " +
                                    "group by producto having count(*) >= 2";

                conn = new SqlConnection();

                conn.ConnectionString = stringConexion;
                conn.Open();

                SqlCommand com = new SqlCommand(sentencia, conn);
                SqlDataReader dr = com.ExecuteReader();


                while (dr.Read())
                {
                    lista.Add((int)dr["producto"]);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("ObtenerPopulares failed.");
                Console.WriteLine(". \nError: {0}", ex.ToString());
            }
            finally
            {
                conn.Close();
            }

            return lista;

        }

        // actualiza la tabla productoPopular llamando las funciones anteriores
        public void updateTable()
        {
            // 1- Borrar tuplas de la tabla
            this.dropPopular();

            // 2- devolver los productos mas comprados
            List<int> l = new List<int>();

            l = this.productosPopulares();

            // 3- insertar los productos en la db
            foreach (int id in l)
            {
                Popular p = new Popular(id);
                p.addPopular();
            }

        }
    }
}
