﻿using EjemploABM.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EjemploABM.Controladores
{
    class Calendario_Controller
    {
        public static bool crearTurno(Usuario usr, Sucursal suc, DateTime fecha_ini, DateTime fecha_fin)
        {
            //Darlo de alta en la BBDD

            string query = "insert into dbo.turno values" +
               "(@id, " +
               "@id_suc, " +
               "@id_usr, " +
               "@fecha_ini, " +
               "@fecha_fin, " +
               ");";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", obtenerMaxId() + 1);
            cmd.Parameters.AddWithValue("@id_suc", suc.id);
            cmd.Parameters.AddWithValue("@id_usr", usr.Id);
            cmd.Parameters.AddWithValue("@fecha_ini", fecha_ini);
            cmd.Parameters.AddWithValue("@fecha_fin", fecha_fin);

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
            string query = "select max(id) from dbo.turno;";

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

        public static List<Turno> obtenerTodos()
        {
            List<Turno> list = new List<Turno>();
            string query = "select * from dbo.turno;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Turno(reader.GetInt32(0), Sucursal_Controller.obtenerPorId(reader.GetInt32(1)), Usuario_Controller.obtenerPorId(reader.GetInt32(2)), reader.GetDateTime(3), reader.GetDateTime(4), reader.GetInt32(5), reader.GetInt32(6)));
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

        public static Turno obtenerPorId(int id)
        {
            Turno trn = new Turno();
            string query = "select * from dbo.turno where id = @id;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    trn = new Turno(reader.GetInt32(0), Sucursal_Controller.obtenerPorId(reader.GetInt32(1)), Usuario_Controller.obtenerPorId(reader.GetInt32(2)), reader.GetDateTime(3), reader.GetDateTime(4), reader.GetInt32(5), reader.GetInt32(6));
                    Trace.WriteLine("Usr encontrado, nombre: " + reader.GetString(1));
                }

                reader.Close();
                DB_Controller.connection.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return trn;
        }



        // EDIT / PUT

        public static bool editarTurno(Turno trn, Usuario usr, Sucursal suc, DateTime dt_ini, DateTime dt_fin, int estado, int estado_baja)
        {
            //Darlo de alta en la BBDD

            string query = "update dbo.turno set sucursal_id  = @sucursal , " +
                "usuario_id  = @usuario , " +
                "fecha_ini  = @fecha_ini  , " +
                "fecha_fin  = @fecha_fin , " +
                "estado  = @estado , " +
                "estado_baja  = @estado_baja " +
                "where id = @id ;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", trn.id);
            cmd.Parameters.AddWithValue("@sucursal", suc.id);
            cmd.Parameters.AddWithValue("@usuario", usr.Id);
            cmd.Parameters.AddWithValue("@fecha_ini", dt_ini);
            cmd.Parameters.AddWithValue("@fecha_fin", dt_fin);
            cmd.Parameters.AddWithValue("@estado", estado);
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
