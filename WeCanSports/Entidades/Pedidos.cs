using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeCanSports.Entidades
{
    class Pedidos
    {
        public Produtos Produto { get; set; }
        public SKUs SKU { get; set; }
        public Clientes Cliente { get; set; }
        public Enderecos Endereco { get; set; }
        //Pagamentos Pagamentos { get; set; }
        //Promocoes Promocoes { get; set; }
        public Transportadora Frete { get; set; }

        public Pedidos(Produtos produto, SKUs sku ,Clientes cliente, Enderecos enderecos, Transportadora frete)
        {
            Produto = produto;
            SKU = sku;
            Cliente = cliente;
            Endereco = enderecos;
            Frete = frete;

        }
    }
}
