using Data_Layer;
using Domain_Layer.Dtos;
using Domain_Layer.Queries;
using Domain_Layer.Queries.Interfaces;
using NUnit.Framework;
using System;

namespace TestAppParte02
{
    [TestFixture]
    public class TestSucursalQuery
    {
        private IDSucursalQuery _query;
        private static UnitOfWork _unitOfWork;

        [SetUp()]
        public void Init()
        {
            _query = new DQuery();
            _unitOfWork = UnitOfWork.GetInstance;
        }

        [TestCase()]
        public void TestActualizarSucursalAreEqual()
        {
            var compare = false;
            var dto = new SucursalDto();
            dto.Id = 1;
            dto.Nombre = "Sucursal Bcp 01";
            dto.Direccion = "Javier Prado Modificado";
            dto.FechaRegistro = DateTime.Now;
            dto.Banco.Id = 1;
            _query.Actualizar(dto);
            var lista = _query.Listar(new SucursalDto());
            if (lista[0].Id == dto.Id &&
                lista[0].Nombre == dto.Nombre &&
                lista[0].Direccion == dto.Direccion)
            {
                compare = true;
            }
            Assert.AreEqual(compare, true);
        }
        [TestCase()]
        public void TestEliminarSucursalAreEqual()
        {
            var compare = true;
            var dto = new SucursalDto();
            dto.Id = 1;
            _query.Eliminar(dto);
            var lista = _query.Listar(new SucursalDto());
            foreach (var item in lista)
            {
                if (item.Id == dto.Id)
                {
                    compare = false;
                    break;
                }
            }
            Assert.AreEqual(compare, true);
        }
        [TestCase()]
        public void TestInsertarSucursalAreEqual()
        {
            var compare = false;
            var dto = new SucursalDto();
            dto.Id = 10;
            dto.Nombre = "Sucursal BCP 3";
            dto.Direccion = "Torre Sucursal BCP";
            dto.FechaRegistro = DateTime.Now;
            dto.Banco.Id = 1;
            _query.Insertar(dto);
            var lista = _query.Listar(new SucursalDto());
            if (lista[5].Id == dto.Id &&
                lista[5].Nombre == dto.Nombre &&
                lista[5].Direccion == dto.Direccion)
            {
                compare = true;
            }
            Assert.AreEqual(compare, true);
        }


        [TestCase()]
        public void TestListarSucursalAreEqual()
        {
            var compare = false;
            var lista = _query.Listar(new SucursalDto());
            if (lista[0].Id == _unitOfWork.BancoRepository.Bancos[0].Id &&
                lista[1].Id == _unitOfWork.BancoRepository.Bancos[1].Id)
            {
                compare = true;
            }
            Assert.AreEqual(compare, true);
        }
    }
}