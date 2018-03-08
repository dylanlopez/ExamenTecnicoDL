using Data_Layer;
using Domain_Layer.Dtos;
using System.Collections.Generic;

namespace Domain_Layer.Queries.Interfaces
{
    public interface IDOrdenPagoQuery
    {
        void Actualizar(OrdenPagoDto dto);
        void Eliminar(OrdenPagoDto dto);
        UnitOfWork GetUnitOfWork();
        void Insertar(OrdenPagoDto dto);
        List<OrdenPagoDto> Listar(OrdenPagoDto dto);
    }
}