using System;
using System.Collections.Generic;

namespace Domain_Layer.Dtos
{
    public class SucursalDto
    {
        public SucursalDto()
        {
            Id = 0;
            Nombre = string.Empty;
            Direccion = string.Empty;
            FechaRegistro = DateTime.Now;
            Banco = new BancoDto();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public BancoDto Banco { get; set; }
        public List<BancoDto> Bancos { get; set; }
    }
}