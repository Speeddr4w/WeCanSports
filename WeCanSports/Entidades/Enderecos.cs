using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeCanSports.Entidades
{
    class Enderecos
    {
        public int CEP { get; set; }
        public String Endereco { get; set; }
        public int Numero { get; set; }

        public Enderecos(int cep, string endereco, int numero)
        {
            CEP = cep;
            Endereco = endereco;
            Numero = numero;
        }
    }
}
