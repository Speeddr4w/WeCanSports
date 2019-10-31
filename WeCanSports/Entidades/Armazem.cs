using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeCanSports.Entidades
{
    class Armazem
    {
        public String Nome { get; set; }
        public int Inventario { get; set; }

        public Armazem(String nome)
        {
            Nome = nome;
            Inventario = 0;
        }

    }
}
