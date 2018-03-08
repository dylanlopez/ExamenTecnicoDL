using Data_Layer;
using Domain_Layer.Dtos;
using Domain_Layer.Queries;
using Domain_Layer.Queries.Interfaces;
using NUnit.Framework;
using System;

namespace TestAppParte02
{
    [TestFixture]
    public class TestBancoQuery
    {
        private IDBancoQuery _query;
        private static UnitOfWork _unitOfWork;

        [SetUp()]
        public void Init()
        {
            _query = new DQuery();
            _unitOfWork = UnitOfWork.GetInstance;
        }

        [TestCase()]
        public void TestActualizarBancoAreEqual()
        {
            var compare = false;
            var dto = new BancoDto();
            dto.Id = 1;
            dto.Nombre = "BCP";
            dto.Direccion = "Torre Principal BCP";
            dto.FechaRegistro = DateTime.Now;
            _query.Actualizar(dto);
            var lista = _query.Listar(new BancoDto());
            if (lista[0].Id == dto.Id &&
                lista[0].Nombre == dto.Nombre &&
                lista[0].Direccion == dto.Direccion)
            {
                compare = true;
            }
            Assert.AreEqual(compare, true);
        }
        [TestCase()]
        public void TestEliminarBancoAreEqual()
        {
            var compare = true;
            var dto = new BancoDto();
            dto.Id = 1;
            _query.Eliminar(dto);
            var lista = _query.Listar(new BancoDto());
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
        public void TestInsertarBancoAreEqual()
        {
            var compare = false;
            var dto = new BancoDto();
            dto.Id = 10;
            dto.Nombre = "Continental";
            dto.Direccion = "Torre Principal";
            dto.FechaRegistro = DateTime.Now;
            _query.Insertar(dto);
            var lista = _query.Listar(new BancoDto());
            if (lista[2].Id == dto.Id &&
                lista[2].Nombre == dto.Nombre &&
                lista[2].Direccion == dto.Direccion)
            {
                compare = true;
            }
            Assert.AreEqual(compare, true);
        }


        [TestCase()]
        public void TestListarBancoAreEqual()
        {
            var compare = false;
            var lista = _query.Listar(new BancoDto());
            if (lista[0].Id == _unitOfWork.BancoRepository.Bancos[0].Id &&
                lista[1].Id == _unitOfWork.BancoRepository.Bancos[1].Id)
            {
                compare = true;
            }
            Assert.AreEqual(compare, true);
        }
    }
}