using Data_Layer;
using Domain_Layer.Dtos;
using System.Collections.Generic;

namespace Domain_Layer.Queries.Interfaces
{
    public interface IDBancoQuery
    {
        void Actualizar(BancoDto dto);
        void Eliminar(BancoDto dto);
        UnitOfWork GetUnitOfWork();
        void Insertar(BancoDto dto);
        List<BancoDto> Listar(BancoDto dto);
    }
}