using System;

namespace Domain_Layer.Dtos
{
    public class BancoDto
    {
        public BancoDto()
        {
            Id = 0;
            Nombre = string.Empty;
            Direccion = string.Empty;
            FechaRegistro = DateTime.Now;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}