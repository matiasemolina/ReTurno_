﻿using EjemploABM.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploABM.Controladores
{
    class Cliente_Controller
    {
        public static bool crearCliente(String rzn_social, Rubro rubro)
        {
            //Darlo de alta en la BBDD
            // id, razon_social, rubro_id, estado_baja
            string query = "insert into dbo.cliente values" +
               "(@id, " +
               "@razon_social, " +
               "@rubro_id, " +
               ");";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", obtenerMaxId() + 1);
            cmd.Parameters.AddWithValue("@razon_social", rzn_social);
            cmd.Parameters.AddWithValue("@rubro_id", rubro.id);

            try
            {
                DB_Controller.connection.Open();
                cmd.ExecuteNonQuery();
                DB_Controller.connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

        }


        // OBTENER EL MAX ID

        public static int obtenerMaxId()
        {
            int MaxId = 0;
            string query = "select max(id) from dbo.cliente;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    MaxId = reader.GetInt32(0);
                }

                reader.Close();
                DB_Controller.connection.Close();
                return MaxId;
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }
        }


        // GET ALL

        public static List<Cliente> obtenerTodos()
        {
            List<Cliente> list = new List<Cliente>();
            string query = "select * from dbo.cliente;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Cliente(reader.GetInt32(0), reader.GetString(1), Rubro_Controller.obtenerPorId(reader.GetInt32(2)), reader.GetInt32(3)));
                    Trace.WriteLine("Usr encontrado, nombre: " + reader.GetString(1));
                }

                reader.Close();
                DB_Controller.connection.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return list;
        }



        // GET ONE BY ID

        public static Cliente obtenerPorId(int id)
        {
            Cliente cli = new Cliente();
            string query = "select * from dbo.cliente where id = @id;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cli = new Cliente(reader.GetInt32(0), reader.GetString(1), Rubro_Controller.obtenerPorId(reader.GetInt32(2)), reader.GetInt32(3));
                    Trace.WriteLine("Usr encontrado, nombre: " + reader.GetString(1));
                }

                reader.Close();
                DB_Controller.connection.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return cli;
        }



        // EDIT / PUT

        public static bool editarCliente(Cliente cliente, Rubro rubro, String razon_social, int estado_baja)
        {
            //Update en la BBDD

            string query = "update dbo.cliente set rubro_id  = @rubro , " +
                "razon_social   = @razon_social , " +
                "estado_baja  = @estado_baja " +
                "where id = @id ;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", cliente.id);
            cmd.Parameters.AddWithValue("@rubro", rubro.id);
            cmd.Parameters.AddWithValue("@razon_social", razon_social);
            cmd.Parameters.AddWithValue("@estado_baja", estado_baja);

            if (estado_baja == 1) {
                bajaSucursalCliente(cliente, estado_baja);
            }

            try
            {
                DB_Controller.connection.Open();
                cmd.ExecuteNonQuery();
                DB_Controller.connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

        }

        public static bool bajaSucursalCliente(Cliente cliente, int estado_baja)
        {
            //Update en la BBDD

            string query = "update dbo.sucursal set " +
                "estado_baja  = @estado_baja " +
                "where cliente_id = @cliente_id;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@cliente_id", cliente.id);
            cmd.Parameters.AddWithValue("@estado_baja", estado_baja);

            try
            {
                DB_Controller.connection.Open();
                cmd.ExecuteNonQuery();
                DB_Controller.connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

        }

    }
}
