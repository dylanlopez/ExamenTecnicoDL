using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data_Layer;
using Domain_Layer.Dtos;
using Domain_Layer.Queries;
using Domain_Layer.Queries.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppParte02.Api
{
    [Produces("application/json")]
    [Route("api/Banco")]
    public class BancoController : Controller
    {
        private static UnitOfWork _unitOfWork;
        private static IDBancoQuery _query;

        public BancoController()
        {
            _unitOfWork = UnitOfWork.GetInstance;
        }

        [HttpGet]
        public List<BancoDto> Listar(BancoDto dto)
        {
            try
            {
                _query = new DQuery(_unitOfWork);
                var list = _query.Listar(new BancoDto());
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
    }
}