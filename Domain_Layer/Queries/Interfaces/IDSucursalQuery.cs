using Data_Layer;
using Domain_Layer.Dtos;
using System.Collections.Generic;

namespace Domain_Layer.Queries.Interfaces
{
    public interface IDSucursalQuery
    {
        void Actualizar(SucursalDto dto);
        void Eliminar(SucursalDto dto);
        UnitOfWork GetUnitOfWork();
        void Insertar(SucursalDto dto);
        List<SucursalDto> Listar(SucursalDto dto);
    }
}