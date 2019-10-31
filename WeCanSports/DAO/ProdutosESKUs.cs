using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using WeCanSports.Entidades;

namespace WeCanSports.DAO
{
    class ProdutosESKUs
    {

        public static List<Produtos> listaProdutos = new List<Produtos>();



        /*---------Metodos Produtos---------*/


        public static void IncluirProduto(String nomeProduto)
        {
            listaProdutos.Add(new Produtos(nomeProduto));
            JSON.ExportarProdutosESKUs();

            Produtos aux1 = new Produtos();
            aux1 = listaProdutos.Find(x => x.Nome == nomeProduto);


            MessageBox.Show($"{aux1.Nome},{aux1.Ativo},{aux1._listaSKU.Count()}");
        }

        public static void AlterarProduto(int id, String produto)
        {
            int idProduto = id;

            listaProdutos[id].Nome = produto;
            JSON.ExportarProdutosESKUs();

            MessageBox.Show($"{listaProdutos[id].Nome}, {listaProdutos[id].Ativo}, {listaProdutos[id]._listaSKU.Count()}");
        }

        public static void AtivarProduto (int id)
        {
            listaProdutos[id].Ativo = true;
            JSON.ExportarProdutosESKUs();

            MessageBox.Show($"{listaProdutos[id].Nome}, {listaProdutos[id].Ativo}, {listaProdutos[id]._listaSKU.Count()}");
        }

        public static void ExcluirProduto (int id)
        {
            listaProdutos.RemoveAt(id);
            JSON.ExportarProdutosESKUs();
        }

        public static String ListarProduto()
        {
            String lista = string.Empty;
            foreach (Produtos produto in listaProdutos)
            {

               lista += $"ID: {listaProdutos.IndexOf(produto)}, Nome: {produto.Nome}, Ativo: {produto.Ativo}, Números de SKUs: {produto._listaSKU.Count()}\n";
            }
            return lista;
        }


        /*---------FIM Metodos Produtos---------*/
        /*---------Metodos SKUS---------*/


        public static void IncluirSKU(int idProduto, String nomeSKU)
        {

            listaProdutos[idProduto]._listaSKU.Add(new SKUs(nomeSKU));
            JSON.ExportarProdutosESKUs();


            SKUs aux1;
            aux1 = listaProdutos[idProduto]._listaSKU.Find((x => x.Nome == nomeSKU));

            MessageBox.Show($"{listaProdutos[idProduto].Nome} {aux1.Nome}, {aux1.Ativo}, {listaProdutos[idProduto]._listaSKU.Count()}");
        }
        public static void AlterarSKU(int idPro, int idSKU, String sku)
        {
            listaProdutos[idPro]._listaSKU[idSKU].Nome = sku;
            JSON.ExportarProdutosESKUs();

            MessageBox.Show($"{listaProdutos[idPro].Nome} {listaProdutos[idPro]._listaSKU[idSKU].Nome}, {listaProdutos[idPro]._listaSKU[idSKU].Ativo}, {listaProdutos[idPro]._listaSKU.Count()}");
        }
        public static void AtivarSKU(int idPro, int idSKU)
        {
            listaProdutos[idPro]._listaSKU[idSKU].Ativo = true;
            JSON.ExportarProdutosESKUs();

            MessageBox.Show($"{listaProdutos[idPro].Nome} {listaProdutos[idPro]._listaSKU[idSKU].Nome}, {listaProdutos[idPro]._listaSKU[idSKU].Ativo}, {listaProdutos[idPro]._listaSKU.Count()}");
        }
        public static void ExcluirSKU(int idPro, int idSKU)
        {
            listaProdutos[idPro]._listaSKU.RemoveAt(idSKU);
            JSON.ExportarProdutosESKUs();
        }
        public static void PrecificarSKU(int idProduto, int idSKU, decimal preco)
        {
            listaProdutos[idProduto]._listaSKU[idSKU].Preco = preco;
            JSON.ExportarProdutosESKUs();

            SKUs aux1;
            aux1 = listaProdutos[idProduto]._listaSKU[idSKU];

            MessageBox.Show($"{listaProdutos[idProduto].Nome} {aux1.Nome}, {aux1.Ativo}, R${aux1.Preco.ToString("F")}");
        }
        public static String ListarSKU(int idProduto)
        {
            String lista = String.Empty;
            foreach (SKUs sku in listaProdutos[idProduto]._listaSKU)
            {

                lista += $"ID SKU: {listaProdutos[idProduto]._listaSKU.IndexOf(sku)}, Nome Completo: {listaProdutos[idProduto].Nome} {sku.Nome}, Ativo: {sku.Ativo}, Preço: R${sku.Preco.ToString("F")}\n";
            }
            return lista;
        }

        /*---------FIM Metodos SKUS---------*/
        
    }
}
