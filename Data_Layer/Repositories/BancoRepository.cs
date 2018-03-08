using Data_Layer.Entities;
using System.Collections.Generic;

namespace Data_Layer.Repositories
{
    public class BancoRepository
    {
        public BancoRepository()
        {
            Bancos = new List<Banco>();
        }

        public List<Banco> Bancos { get; set; }
    }
}