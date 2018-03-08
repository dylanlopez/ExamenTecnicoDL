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
    public class OrdenPagoController : Controller
    {
        private static UnitOfWork _unitOfWork;
        private static IDOrdenPagoQuery _query;

        public OrdenPagoController()
        {
            _unitOfWork = UnitOfWork.GetInstance;
        }

        [HttpGet]
        public IActionResult Index()
        {
            try
            {
                _query = new DQuery(_unitOfWork);
                var list = _query.Listar(new OrdenPagoDto());
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
        public ActionResult Create(OrdenPagoDto dto)
        {
            try
            {
                var dtoSucursales = _unitOfWork.SucursalRepository.Sucursales;
                foreach (var dtoSucursal in dtoSucursales)
                {
                    if (dto.Sucursal.Id == dtoSucursal.Id)
                    {
                        dto.Sucursal = DSucursalConverter.ToDto(dtoSucursal);
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
        public IActionResult Edit(OrdenPagoDto dto)
        {
            return View(dto);
        }

        [HttpPut]
        public ActionResult Save(OrdenPagoDto dto)
        {
            try
            {
                var dtoSucursales = _unitOfWork.SucursalRepository.Sucursales;
                foreach (var dtoSucursal in dtoSucursales)
                {
                    if (dto.Sucursal.Id == dtoSucursal.Id)
                    {
                        dto.Sucursal = DSucursalConverter.ToDto(dtoSucursal);
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
        public IActionResult Delete(OrdenPagoDto dto)
        {
            return View(dto);
        }

        [HttpPost]
        public ActionResult DeleteSucursal(OrdenPagoDto dto)
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