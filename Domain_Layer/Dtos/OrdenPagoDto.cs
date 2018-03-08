using System;
using System.Collections.Generic;

namespace Domain_Layer.Dtos
{
    public class OrdenPagoDto
    {
        public OrdenPagoDto()
        {
            Id = 0;
            Monto = 0;
            Moneda = string.Empty;
            Estado = string.Empty;
            FechaPago = DateTime.Now;
            Sucursal = new SucursalDto();
        }

        public int Id { get; set; }
        public decimal Monto { get; set; }
        public string Moneda { get; set; }
        public string Estado { get; set; }
        public DateTime FechaPago { get; set; }
        public SucursalDto Sucursal { get; set; }
        public List<SucursalDto> Sucursales { get; set; }
    }
}