using Data_Layer.Entities;
using System.Collections.Generic;

namespace Data_Layer.Repositories
{
    public class OrdenPagoRepository
    {
        public OrdenPagoRepository()
        {
            OrdenesPago = new List<OrdenPago>();
        }

        public List<OrdenPago> OrdenesPago { get; set; }
    }
}