using Data_Layer.Entities;
using Domain_Layer.Dtos;
using System.Collections.Generic;

namespace Domain_Layer.Converters
{
    public static class DSucursalConverter
    {
        public static SucursalDto ToDto(Sucursal entity)
        {
            var dto = new SucursalDto();
            dto.Id = entity.Id;
            dto.Nombre = entity.Nombre;
            dto.Direccion = entity.Direccion;
            dto.FechaRegistro = entity.FechaRegistro;
            dto.Banco = DBancoConverter.ToDto(entity.Banco);
            return dto;
        }
        public static List<SucursalDto> ToDtos(List<Sucursal> entities)
        {
            var dtos = new List<SucursalDto>();
            foreach (var entity in entities)
            {
                var dto = ToDto(entity);
                dtos.Add(dto);
            }
            return dtos;
        }
        public static Sucursal ToEntity(SucursalDto dto)
        {
            var entity = new Sucursal();
            entity.Id = dto.Id;
            entity.Nombre = dto.Nombre;
            entity.Direccion = dto.Direccion;
            entity.FechaRegistro = dto.FechaRegistro;
            entity.Banco = DBancoConverter.ToEntity(dto.Banco);
            return entity;
        }
    }
}