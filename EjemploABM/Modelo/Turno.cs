﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploABM.Modelo
{
    public class Turno
    {
        public int id {  get; set; }
        public Sucursal sucursal { get; set; }

        public Usuario usuario { get; set; }

        public DateTime fecha_ini { get; set; }

        public DateTime fecha_fin { get; set; }

        public int estado { get; set; }

        public int estado_baja { get; set; }

        public Turno(int p_id, Sucursal p_sucursal, Usuario p_usuario, DateTime p_fecha_ini, DateTime p_fecha_fin, int p_estado, int p_estado_baja)
        {
            id = p_id;
            sucursal = p_sucursal;
            usuario = p_usuario;
            fecha_ini = p_fecha_ini;
            fecha_fin = p_fecha_fin;
            estado = p_estado;
            estado_baja = p_estado_baja;
        }

        public Turno() { }
    }
}
