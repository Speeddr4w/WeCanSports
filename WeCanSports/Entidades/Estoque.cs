using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeCanSports.Entidades
{
    class Estoque
    {
        public int InventarioTotal { get; private set; }
        public List<Armazem> ListaArmazem = new List<Armazem>();

        public void atualizarInventario()
        {
            InventarioTotal = 0;
            foreach (Armazem armazem in ListaArmazem)
            {
                InventarioTotal += armazem.Inventario;
            }
        }

    }
}
