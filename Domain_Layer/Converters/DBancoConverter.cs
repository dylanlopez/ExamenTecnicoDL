using Data_Layer.Entities;
using Domain_Layer.Dtos;
using System.Collections.Generic;

namespace Domain_Layer.Converters
{
    public static class DBancoConverter
    {
        public static BancoDto ToDto(Banco entity)
        {
            var dto = new BancoDto();
            dto.Id = entity.Id;
            dto.Nombre = entity.Nombre;
            dto.Direccion = entity.Direccion;
            dto.FechaRegistro = entity.FechaRegistro;
            return dto;
        }
        public static List<BancoDto> ToDtos(List<Banco> entities)
        {
            var dtos = new List<BancoDto>();
            foreach(var entity in entities)
            {
                var dto = ToDto(entity);
                dtos.Add(dto);
            }
            return dtos;
        }
        public static Banco ToEntity(BancoDto dto)
        {
            var entity = new Banco();
            entity.Id = dto.Id;
            entity.Nombre = dto.Nombre;
            entity.Direccion = dto.Direccion;
            entity.FechaRegistro = dto.FechaRegistro;
            return entity;
        }
    }
}