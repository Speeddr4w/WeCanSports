using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeCanSports.Entidades
{
    class Transportadora
    {
        public int CepInicial { get; set; }
        public int CepFinal { get; set; }
        public decimal Preco { get; set; }
        public int Prazo { get; set; }

        public Transportadora(int cepIncial, int cepFinal, decimal preco, int prazo)
        {
            CepInicial = cepIncial;
            CepFinal = cepFinal;
            Preco = preco;
            Prazo = prazo;

        }
    }
}
