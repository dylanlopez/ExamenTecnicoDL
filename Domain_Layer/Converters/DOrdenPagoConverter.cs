using Data_Layer.Entities;
using Domain_Layer.Dtos;
using System.Collections.Generic;

namespace Domain_Layer.Converters
{
    public static class DOrdenPagoConverter
    {
        public static OrdenPagoDto ToDto(OrdenPago entity)
        {
            var dto = new OrdenPagoDto();
            dto.Id = entity.Id;
            dto.Monto = entity.Monto;
            dto.Moneda = entity.Moneda;
            dto.Estado = entity.Estado;
            dto.FechaPago = entity.FechaPago;
            dto.Sucursal = DSucursalConverter.ToDto(entity.Sucursal);
            return dto;
        }
        public static List<OrdenPagoDto> ToDtos(List<OrdenPago> entities)
        {
            var dtos = new List<OrdenPagoDto>();
            foreach (var entity in entities)
            {
                var dto = ToDto(entity);
                dtos.Add(dto);
            }
            return dtos;
        }
        public static OrdenPago ToEntity(OrdenPagoDto dto)
        {
            var entity = new OrdenPago();
            entity.Id = dto.Id;
            entity.Monto = dto.Monto;
            entity.Moneda = dto.Moneda;
            entity.Estado = dto.Estado;
            entity.FechaPago = dto.FechaPago;
            entity.Sucursal = DSucursalConverter.ToEntity(dto.Sucursal);
            return entity;
        }
    }
}