using Data_Layer.Entities;
using System.Collections.Generic;

namespace Data_Layer.Repositories
{
    public class SucursalRepository
    {
        public SucursalRepository()
        {
            Sucursales = new List<Sucursal>();
        }

        public List<Sucursal> Sucursales { get; set; }
    }
}