using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeCanSports.Entidades;

namespace WeCanSports.DAO
{
    class EstoqueEArmazem
    {
        public static void IncluirArmazem(String nomeArmazem, int idProduto, int idSKU)
        {
            ProdutosESKUs.listaProdutos[idProduto]._listaSKU[idSKU].estoque.ListaArmazem.Add(new Armazem(nomeArmazem));
            JSON.ExportarProdutosESKUs();


            Produtos aux1;
            aux1 = ProdutosESKUs.listaProdutos[idProduto];
            Armazem aux2;
            aux2 = ProdutosESKUs.listaProdutos[idProduto]._listaSKU[idSKU].estoque.ListaArmazem.Find(x => x.Nome == nomeArmazem);

            MessageBox.Show($"{aux1.Nome} {aux1._listaSKU[idSKU].Nome}, {aux2.Nome}");
        }

        public static void AlterarArmazem(String nomeArmazem, int idProduto, int idSKU, int idArmazem)
        {
            ProdutosESKUs.listaProdutos[idProduto]._listaSKU[idSKU].estoque.ListaArmazem[idArmazem].Nome = nomeArmazem;
            JSON.ExportarProdutosESKUs();

            Produtos aux1;
            aux1 = ProdutosESKUs.listaProdutos[idProduto];
            Armazem aux2;
            aux2 = ProdutosESKUs.listaProdutos[idProduto]._listaSKU[idSKU].estoque.ListaArmazem.Find(x => x.Nome == nomeArmazem);

            MessageBox.Show($"{aux1.Nome} {aux1._listaSKU[idSKU].Nome}, {aux2.Nome}");
        }

        public static void AtualizarArmazem(int idProduto, int idSKU, int idArmazem, int inventario)
        {
            ProdutosESKUs.listaProdutos[idProduto]._listaSKU[idSKU].estoque.ListaArmazem[idArmazem].Inventario = inventario;
            ProdutosESKUs.listaProdutos[idProduto]._listaSKU[idSKU].estoque.atualizarInventario();
            JSON.ExportarProdutosESKUs();

            Produtos aux1;
            aux1 = ProdutosESKUs.listaProdutos[idProduto];
            Armazem aux2;
            aux2 = ProdutosESKUs.listaProdutos[idProduto]._listaSKU[idSKU].estoque.ListaArmazem[idArmazem];

            MessageBox.Show($"{aux1.Nome} {aux1._listaSKU[idSKU].Nome}, {aux2.Nome}, {aux2.Inventario} unidades");
        }

        public static void ExcluirArmazem(int idProduto, int idSKU, int idArmazem)
        {
            ProdutosESKUs.listaProdutos[idProduto]._listaSKU[idSKU].estoque.ListaArmazem.RemoveAt(idArmazem);
            ProdutosESKUs.listaProdutos[idProduto]._listaSKU[idSKU].estoque.atualizarInventario();
            JSON.ExportarProdutosESKUs();
        }

        public static String ListarEstoque(int idProduto, int idSKU)
        {
            Produtos aux = ProdutosESKUs.listaProdutos[idProduto];
            String lista = String.Empty;
            foreach (Armazem armazem in ProdutosESKUs.listaProdutos[idProduto]._listaSKU[idSKU].estoque.ListaArmazem)
            {

                lista += $"Nome Completo: {aux.Nome} {aux._listaSKU[idSKU].Nome}, ID Armazem: {ProdutosESKUs.listaProdutos[idProduto]._listaSKU[idSKU].estoque.ListaArmazem.IndexOf(armazem)}, Nome: {armazem.Nome}, Inventario: {armazem.Inventario}\n";
            }
            lista += $"Invetario Total: {aux._listaSKU[idSKU].estoque.InventarioTotal}";
            return lista;

        }

    }
}
