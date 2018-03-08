using System;

namespace Data_Layer.Entities
{
    public class OrdenPago
    {
        public Int32 Id { get; set; }
        public Decimal Monto { get; set; }
        public String Moneda { get; set; }
        public String Estado { get; set; }
        public DateTime FechaPago { get; set; }
        public Sucursal Sucursal { get; set; }
    }
}