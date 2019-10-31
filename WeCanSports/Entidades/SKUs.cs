using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeCanSports.Entidades
{
    class SKUs
    {
        public String Nome { get; set; }
        public bool Ativo { get; set; }
        public Estoque estoque = new Estoque();
        public decimal Preco { get; set; }

        public SKUs(string nome)
        {
            Nome = nome;
            Ativo = false;
        }

        public SKUs()
        {

        }
    }
}
