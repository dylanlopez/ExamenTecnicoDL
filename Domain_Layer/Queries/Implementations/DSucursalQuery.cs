using Data_Layer.Entities;
using Domain_Layer.Converters;
using Domain_Layer.Dtos;
using Domain_Layer.Queries.Interfaces;
using System;
using System.Collections.Generic;

namespace Domain_Layer.Queries
{
    public partial class DQuery : IDSucursalQuery
    {
        public void Actualizar(SucursalDto dto)
        {
            try
            {
                foreach (var entity in UnitOfWork.SucursalRepository.Sucursales)
                {
                    if (dto.Id == entity.Id)
                    {
                        entity.Nombre = dto.Nombre;
                        entity.Direccion = dto.Direccion;
                        entity.FechaRegistro = dto.FechaRegistro;
                        entity.Banco = DBancoConverter.ToEntity(dto.Banco);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Eliminar(SucursalDto dto)
        {
            try
            {
                foreach (var entity in UnitOfWork.SucursalRepository.Sucursales)
                {
                    if (dto.Id == entity.Id)
                    {
                        UnitOfWork.SucursalRepository.Sucursales.Remove(entity);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Insertar(SucursalDto dto)
        {
            try
            {
                var entity = new Sucursal();
                entity = DSucursalConverter.ToEntity(dto);
                UnitOfWork.SucursalRepository.Sucursales.Add(entity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<SucursalDto> Listar(SucursalDto dto)
        {
            try
            {
                var dtos = DSucursalConverter.ToDtos(UnitOfWork.SucursalRepository.Sucursales);
                foreach (var myDto in dtos)
                {
                    myDto.Bancos = DBancoConverter.ToDtos(UnitOfWork.BancoRepository.Bancos);
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