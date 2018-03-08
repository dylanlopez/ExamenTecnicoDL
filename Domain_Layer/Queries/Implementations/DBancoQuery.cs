using Data_Layer.Entities;
using Domain_Layer.Converters;
using Domain_Layer.Dtos;
using Domain_Layer.Queries.Interfaces;
using System;
using System.Collections.Generic;

namespace Domain_Layer.Queries
{
    public partial class DQuery : IDBancoQuery
    {
        public void Actualizar(BancoDto dto)
        {
            try
            {
                foreach(var entity in UnitOfWork.BancoRepository.Bancos)
                {
                    if(dto.Id == entity.Id)
                    {
                        entity.Nombre = dto.Nombre;
                        entity.Direccion = dto.Direccion;
                        entity.FechaRegistro = dto.FechaRegistro;
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void Eliminar(BancoDto dto)
        {
            try
            {
                foreach (var entity in UnitOfWork.BancoRepository.Bancos)
                {
                    if (dto.Id == entity.Id)
                    {
                        UnitOfWork.BancoRepository.Bancos.Remove(entity);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Insertar(BancoDto dto)
        {
            try
            {
                var entity = new Banco();
                entity = DBancoConverter.ToEntity(dto);
                UnitOfWork.BancoRepository.Bancos.Add(entity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<BancoDto> Listar(BancoDto dto)
        {
            try
            {
                var dtos = DBancoConverter.ToDtos(UnitOfWork.BancoRepository.Bancos);
                return dtos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}