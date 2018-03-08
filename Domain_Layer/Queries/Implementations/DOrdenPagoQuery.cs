using Data_Layer.Entities;
using Domain_Layer.Converters;
using Domain_Layer.Dtos;
using Domain_Layer.Queries.Interfaces;
using System;
using System.Collections.Generic;

namespace Domain_Layer.Queries
{
    public partial class DQuery : IDOrdenPagoQuery
    {
        public void Actualizar(OrdenPagoDto dto)
        {
            try
            {
                foreach (var entity in UnitOfWork.OrdenPagoRepository.OrdenesPago)
                {
                    if (dto.Id == entity.Id)
                    {
                        entity.Monto = dto.Monto;
                        entity.Moneda = dto.Moneda;
                        entity.Estado = dto.Estado;
                        entity.FechaPago = dto.FechaPago;
                        entity.Sucursal = DSucursalConverter.ToEntity(dto.Sucursal);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Eliminar(OrdenPagoDto dto)
        {
            try
            {
                foreach (var entity in UnitOfWork.OrdenPagoRepository.OrdenesPago)
                {
                    if (dto.Id == entity.Id)
                    {
                        UnitOfWork.OrdenPagoRepository.OrdenesPago.Remove(entity);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Insertar(OrdenPagoDto dto)
        {
            try
            {
                var entity = new OrdenPago();
                entity = DOrdenPagoConverter.ToEntity(dto);
                UnitOfWork.OrdenPagoRepository.OrdenesPago.Add(entity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<OrdenPagoDto> Listar(OrdenPagoDto dto)
        {
            try
            {
                var dtos = DOrdenPagoConverter.ToDtos(UnitOfWork.OrdenPagoRepository.OrdenesPago);
                foreach (var myDto in dtos)
                {
                    myDto.Sucursales = DSucursalConverter.ToDtos(UnitOfWork.SucursalRepository.Sucursales);
                }
                return dtos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}