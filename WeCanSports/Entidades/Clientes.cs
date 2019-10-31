using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeCanSports.Entidades
{
    class Clientes
    {
        public String Nome { get; set; }
        public String Email { get; set; }
        public decimal CPF { get; set; }

        public List<Enderecos> Enderecos = new List<Enderecos>();

        public Clientes(string nome, string email, decimal cpf)
        {
            Nome = nome;
            Email = email;
            CPF = cpf;
        }

    }
}
