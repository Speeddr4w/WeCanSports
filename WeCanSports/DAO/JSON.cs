using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeCanSports.Entidades;

namespace WeCanSports.DAO
{
    public class JSON
    {
        /*---------Metodos JSON---------*/
        public static void ImportarProdutosESKUs()
        {
            using (StreamReader r = new StreamReader(@"lista.json")) //TENTAR FAZER CAMINHO N FIXADO MAIS TARDE
            {
                string json = r.ReadToEnd();
                ProdutosESKUs.listaProdutos = JsonConvert.DeserializeObject<List<Produtos>>(json);
            }

        }

        public static void ExportarProdutosESKUs()
        {
            var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(ProdutosESKUs.listaProdutos);
            System.IO.File.WriteAllText(@"lista.json", jsonString); //TENTAR FAZER CAMINHO N FIXADO MAIS TARDE
        }




        public static void ImportarClientesEEnderecos()
        {
            using (StreamReader r = new StreamReader(@"listaclientes.json")) //TENTAR FAZER CAMINHO N FIXADO MAIS TARDE
            {
                string json = r.ReadToEnd();
                ClientesEEnderecos.listaClientes = JsonConvert.DeserializeObject<List<Clientes>>(json);
            }

        }

        public static void ExportarClientesEEnderecos()
        {
            var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(ClientesEEnderecos.listaClientes);
            System.IO.File.WriteAllText(@"listaclientes.json", jsonString); //TENTAR FAZER CAMINHO N FIXADO MAIS TARDE
        }



        public static void ImportarTransportadora()
        {
            using (StreamReader r = new StreamReader(@"listatransportadora.json")) //TENTAR FAZER CAMINHO N FIXADO MAIS TARDE
            {
                string json = r.ReadToEnd();
                PedidosETransportadora.listaTransportadora = JsonConvert.DeserializeObject<List<Transportadora>>(json);
            }

        }

        public static void ExportarTransportadora()
        {
            var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(PedidosETransportadora.listaTransportadora);
            System.IO.File.WriteAllText(@"listatransportadora.json", jsonString); //TENTAR FAZER CAMINHO N FIXADO MAIS TARDE
        }



        public static void ImportarPedidos()
        {
            using (StreamReader r = new StreamReader(@"listapedidos.json")) //TENTAR FAZER CAMINHO N FIXADO MAIS TARDE
            {
                string json = r.ReadToEnd();
                PedidosETransportadora.listaPedidos = JsonConvert.DeserializeObject<List<Pedidos>>(json);
            }

        }

        public static void ExportarPedidos()
        {
            var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(PedidosETransportadora.listaPedidos);
            System.IO.File.WriteAllText(@"listapedidos.json", jsonString); //TENTAR FAZER CAMINHO N FIXADO MAIS TARDE

            /*---------FIM Metodos JSON---------*/
        }
    }
}
