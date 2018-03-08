using Data_Layer;
using Domain_Layer.Dtos;
using Domain_Layer.Queries;
using Domain_Layer.Queries.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AppParte02.Controllers
{
    public class BancoController : Controller
    {
        //private int Id;
        private static UnitOfWork _unitOfWork;
        private static IDBancoQuery _query;

        public BancoController()
        {
            _unitOfWork = UnitOfWork.GetInstance;
        }

        [HttpGet]
        public IActionResult Index()
        {
            try
            {
                _query = new DQuery(_unitOfWork);
                var list = _query.Listar(new BancoDto());
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
        public ActionResult Create(BancoDto dto)
        {
            try
            {
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
        public IActionResult Edit(BancoDto dto)
        {
            return View(dto);
        }

        [HttpPut]
        public ActionResult Save(BancoDto dto)
        {
            try
            {
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
        public IActionResult Delete(BancoDto dto)
        {
            return View(dto);
        }

        [HttpPost]
        public ActionResult DeleteBanco(BancoDto dto)
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