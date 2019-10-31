using System;
using System.Collections.Generic;
using WeCanSports.Entidades;

namespace WeCanSports.Entidades
{
    class Produtos
    {
        public String Nome{ get; set; }
        public bool Ativo { get; set; }
        public List<SKUs> _listaSKU = new List<SKUs>();

        
       public Produtos(string nome)
        {
            Nome = nome;
            Ativo = false;
        }

        public Produtos()
        {

        }

    }
}
