﻿using System;

namespace Data_Layer.Entities
{
    public class Banco
    {
        public Int32 Id { get; set; }
        public String Nombre { get; set; }
        public String Direccion { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}