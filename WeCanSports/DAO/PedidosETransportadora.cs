using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeCanSports.Entidades;

namespace WeCanSports.DAO
{
    class PedidosETransportadora
    {
        public static List<Transportadora> listaTransportadora = new List<Transportadora>();
        public static List<Pedidos> listaPedidos = new List<Pedidos>();

        /*---------Metodos Transportadora---------*/
        public static void IncluirTransportadora(int cepInicial, int cepFinal, decimal preco, int prazo)
        {

            listaTransportadora.Add(new Transportadora(cepInicial, cepFinal, preco, prazo));
            JSON.ExportarTransportadora();

            Transportadora aux1 = listaTransportadora.Find(x => x.CepInicial == cepInicial);


            MessageBox.Show($"{aux1.CepInicial} - {aux1.CepFinal}, R${aux1.Preco.ToString("F")}, {aux1.Prazo} dias");
        }
        public static void AlterarTransportadora(int idTransportadora, int cepInicial, int cepFinal, decimal preco, int prazo)
        {
            if (cepInicial > 0)
                listaTransportadora[idTransportadora].CepInicial = cepInicial;

            if (cepFinal > 0)
                listaTransportadora[idTransportadora].CepFinal = cepFinal;

            if (preco > 0)
                listaTransportadora[idTransportadora].Preco = preco;

            if (preco > 0)
                listaTransportadora[idTransportadora].Prazo = prazo;


            JSON.ExportarTransportadora();


            Transportadora aux1 = listaTransportadora[idTransportadora];


            MessageBox.Show($"{aux1.CepInicial} - {aux1.CepFinal}, R${aux1.Preco.ToString("F")}, {aux1.Prazo} dias");

        }
        public static void ExcluirTransportadora(int idTransportadora)
        {
            listaTransportadora.RemoveAt(idTransportadora);
            JSON.ExportarClientesEEnderecos();
        }
        public static String ListarTransportadora()
        {
            String lista = string.Empty;
            foreach (Transportadora transportadora in listaTransportadora)
            {

                lista += $"ID: {listaTransportadora.IndexOf(transportadora)}, {transportadora.CepInicial} - {transportadora.CepFinal}, R${transportadora.Preco.ToString("F")}, {transportadora.Prazo} dias\n";
            }
            return lista;
        }


        /*---------FIM Metodos Transportadora---------*/
        /*---------Metodos Pedidos---------*/


        public static void IncluirPedido(int idProduto, int idSku, int idTransportadora, int idCliente, int idEndereco)
        {

            Produtos produto = ProdutosESKUs.listaProdutos[idProduto];
            SKUs Sku = ProdutosESKUs.listaProdutos[idProduto]._listaSKU[idSku];
            Clientes cliente = ClientesEEnderecos.listaClientes[idCliente];
            Enderecos enderecos = ClientesEEnderecos.listaClientes[idCliente].Enderecos[idEndereco];
            Transportadora Transportadora = listaTransportadora[idTransportadora];



            listaPedidos.Add(new Pedidos(produto, Sku, cliente, enderecos, Transportadora));
            JSON.ExportarPedidos();
        }
        public static void AlterarPedido(int idPedidos, int idProduto, int idSku, int idTransportadora, int idCliente, int idEndereco)
        {


            listaPedidos[idPedidos].Produto = ProdutosESKUs.listaProdutos[idProduto];
            listaPedidos[idPedidos].SKU = ProdutosESKUs.listaProdutos[idProduto]._listaSKU[idSku];
            listaPedidos[idPedidos].Cliente = ClientesEEnderecos.listaClientes[idCliente];
            listaPedidos[idPedidos].Endereco = ClientesEEnderecos.listaClientes[idCliente].Enderecos[idEndereco];
            listaPedidos[idPedidos].Frete = listaTransportadora[idTransportadora];


            JSON.ExportarPedidos();

        }
        public static void ExcluirPedido(int idPedido)
        {
            listaPedidos.RemoveAt(idPedido);
            JSON.ExportarClientesEEnderecos();
        }
        public static String ListarPedido(int idPedido)
        {
            Pedidos aux = listaPedidos[idPedido];
            String lista;

           lista = $"ID: {listaPedidos.IndexOf(aux)}, Produto {aux.Produto.Nome} {aux.SKU.Nome} \n R${(aux.SKU.Preco + aux.Frete.Preco).ToString("F")}\n Comprado pelo cliente: {aux.Cliente.Nome} para o endereço: {aux.Endereco.Endereco}, {aux.Endereco.Numero}, com o prazo de {aux.Frete.Prazo} dias";
          
            return lista;
        }
        /*---------FIM Metodos Pedidos---------*/
    }
}
