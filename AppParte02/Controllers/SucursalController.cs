using Data_Layer;
using Domain_Layer.Converters;
using Domain_Layer.Dtos;
using Domain_Layer.Queries;
using Domain_Layer.Queries.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AppParte02.Controllers
{
    public class SucursalController : Controller
    {
        private static UnitOfWork _unitOfWork;
        private static IDSucursalQuery _query;

        public SucursalController()
        {
            _unitOfWork = UnitOfWork.GetInstance;
        }

        [HttpGet]
        public IActionResult Index()
        {
            try
            {
                _query = new DQuery(_unitOfWork);
                var list = _query.Listar(new SucursalDto());
                return View(list);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(SucursalDto dto)
        {
            try
            {
                var dtoBancos = _unitOfWork.BancoRepository.Bancos;
                foreach (var dtoBanco in dtoBancos)
                {
                    if(dto.Banco.Id == dtoBanco.Id)
                    {
                        dto.Banco = DBancoConverter.ToDto(dtoBanco);
                    }
                }
                _query = new DQuery(_unitOfWork);
                _query.Insertar(dto);
                _unitOfWork = _query.GetUnitOfWork();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(SucursalDto dto)
        {
            return View(dto);
        }

        [HttpPut]
        public ActionResult Save(SucursalDto dto)
        {
            try
            {
                var dtoBancos = _unitOfWork.BancoRepository.Bancos;
                foreach (var dtoBanco in dtoBancos)
                {
                    if (dto.Banco.Id == dtoBanco.Id)
                    {
                        dto.Banco = DBancoConverter.ToDto(dtoBanco);
                    }
                }
                _query = new DQuery(_unitOfWork);
                _query.Actualizar(dto);
                _unitOfWork = _query.GetUnitOfWork();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(SucursalDto dto)
        {
            return View(dto);
        }

        [HttpPost]
        public ActionResult DeleteSucursal(SucursalDto dto)
        {
            try
            {
                _query = new DQuery(_unitOfWork);
                _query.Eliminar(dto);
                _unitOfWork = _query.GetUnitOfWork();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction("Index");
        }
    }
}