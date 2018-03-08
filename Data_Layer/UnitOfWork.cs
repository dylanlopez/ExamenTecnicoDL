using Data_Layer.Entities;
using Data_Layer.Repositories;
using System;

namespace Data_Layer
{
    public class UnitOfWork
    {
        private static UnitOfWork _unitOfWork;
        private Banco _banco;
        private Sucursal _sucursal;
        private OrdenPago _ordenPago;

        public UnitOfWork()
        {
            BancoRepository = new BancoRepository();
            SucursalRepository = new SucursalRepository();
            OrdenPagoRepository = new OrdenPagoRepository();
            LoadBancos();
            LoadSucursales();
            LoadOrdenesPago();
        }

        public static UnitOfWork GetInstance
        {
            get
            {
                if (_unitOfWork == null)
                {
                    _unitOfWork = new UnitOfWork();
                }
                return _unitOfWork;
            }
        }
        private void LoadBancos()
        {
            _banco = new Banco();
            _banco.Id = 1;
            _banco.Nombre = "BCP";
            _banco.Direccion = "Torre Principal";
            _banco.FechaRegistro = DateTime.Now;
            BancoRepository.Bancos.Add(_banco);
            _banco = new Banco();
            _banco.Id = 2;
            _banco.Nombre = "Interbank";
            _banco.Direccion = "Torre Interbank";
            _banco.FechaRegistro = DateTime.Now;
            BancoRepository.Bancos.Add(_banco);
        }
        private void LoadSucursales()
        {
            _sucursal = new Sucursal();
            _sucursal.Id = 1;
            _sucursal.Nombre = "Sucursal Bcp 01";
            _sucursal.Direccion = "Javier Prado";
            _sucursal.FechaRegistro = DateTime.Now;
            _sucursal.Banco = BancoRepository.Bancos[0];
            SucursalRepository.Sucursales.Add(_sucursal);
            _sucursal = new Sucursal();
            _sucursal.Id = 2;
            _sucursal.Nombre = "Sucursal Bcp 02";
            _sucursal.Direccion = "Primavera";
            _sucursal.FechaRegistro = DateTime.Now;
            _sucursal.Banco = BancoRepository.Bancos[0];
            SucursalRepository.Sucursales.Add(_sucursal);
            _sucursal = new Sucursal();
            _sucursal.Id = 3;
            _sucursal.Nombre = "Sucursal Interbank 01";
            _sucursal.Direccion = "Javier Prado";
            _sucursal.FechaRegistro = DateTime.Now;
            _sucursal.Banco = BancoRepository.Bancos[1];
            SucursalRepository.Sucursales.Add(_sucursal);
            _sucursal = new Sucursal();
            _sucursal.Id = 4;
            _sucursal.Nombre = "Sucursal Interbank 02";
            _sucursal.Direccion = "Canada";
            _sucursal.FechaRegistro = DateTime.Now;
            _sucursal.Banco = BancoRepository.Bancos[1];
            SucursalRepository.Sucursales.Add(_sucursal);
            _sucursal = new Sucursal();
            _sucursal.Id = 5;
            _sucursal.Nombre = "Sucursal Interbank 03";
            _sucursal.Direccion = "Jockey";
            _sucursal.FechaRegistro = DateTime.Now;
            _sucursal.Banco = BancoRepository.Bancos[1];
            SucursalRepository.Sucursales.Add(_sucursal);
        }
        private void LoadOrdenesPago()
        {
            _ordenPago = new OrdenPago();
            _ordenPago.Id = 1;
            _ordenPago.Monto = 100;
            _ordenPago.Moneda = "Soles";
            _ordenPago.Estado = "Pagada";
            _ordenPago.FechaPago = DateTime.Now;
            _ordenPago.Sucursal = SucursalRepository.Sucursales[0];
            OrdenPagoRepository.OrdenesPago.Add(_ordenPago);
            _ordenPago = new OrdenPago();
            _ordenPago.Id = 2;
            _ordenPago.Monto = 945;
            _ordenPago.Moneda = "Dolares";
            _ordenPago.Estado = "Declinada";
            _ordenPago.FechaPago = DateTime.Now;
            _ordenPago.Sucursal = SucursalRepository.Sucursales[1];
            OrdenPagoRepository.OrdenesPago.Add(_ordenPago);
            _ordenPago = new OrdenPago();
            _ordenPago.Id = 3;
            _ordenPago.Monto = 14580;
            _ordenPago.Moneda = "Soles";
            _ordenPago.Estado = "Fallida";
            _ordenPago.FechaPago = DateTime.Now;
            _ordenPago.Sucursal = SucursalRepository.Sucursales[2];
            OrdenPagoRepository.OrdenesPago.Add(_ordenPago);
            _ordenPago = new OrdenPago();
            _ordenPago.Id = 4;
            _ordenPago.Monto = 25000;
            _ordenPago.Moneda = "Dolares";
            _ordenPago.Estado = "Anulada";
            _ordenPago.FechaPago = DateTime.Now;
            _ordenPago.Sucursal = SucursalRepository.Sucursales[2];
            OrdenPagoRepository.OrdenesPago.Add(_ordenPago);
        }

        public BancoRepository BancoRepository { get; set; }
        public SucursalRepository SucursalRepository { get; set; }
        public OrdenPagoRepository OrdenPagoRepository { get; set; }
    }
}