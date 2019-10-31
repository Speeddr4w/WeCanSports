using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeCanSports.Entidades;

namespace WeCanSports.DAO
{
    class ClientesEEnderecos
    {
        public static List<Clientes> listaClientes = new List<Clientes>();

        /*---------Metodos Clientes---------*/
        public static void IncluirCliente(string nome, string email, decimal cpf)
        {
            listaClientes.Add(new Clientes(nome, email, cpf));
            JSON.ExportarClientesEEnderecos();

            Clientes aux1 = listaClientes.Find(x => x.Email == email);


            MessageBox.Show($"{aux1.Nome}, {aux1.Email}, {aux1.CPF}");
        }
        public static void AlterarCliente(int idCliente, string nome, string email, decimal cpf)
        {
            if (!String.IsNullOrEmpty(nome) || !String.IsNullOrWhiteSpace(nome))
                listaClientes[idCliente].Nome = nome;

            if (!String.IsNullOrEmpty(email) || !String.IsNullOrWhiteSpace(email))
                listaClientes[idCliente].Email = email;

            if (cpf > 0)
                listaClientes[idCliente].CPF = cpf;


            JSON.ExportarClientesEEnderecos();


            Clientes aux1 = listaClientes[idCliente];


            MessageBox.Show($"{aux1.Nome}, {aux1.Email}, {aux1.CPF}");
        }
        public static void ExcluirCliente(int idCliente)
        {
            listaClientes.RemoveAt(idCliente);
            JSON.ExportarClientesEEnderecos();
        }
        public static String ListarCliente()
        {
            String lista = string.Empty;
            foreach (Clientes clientes in listaClientes)
            {

                lista += $"ID: {listaClientes.IndexOf(clientes)}, Nome: {clientes.Nome}, Email: {clientes.Email}, CPF: {clientes.CPF}\n";
            }
            return lista;
        }

        /*---------FIM Metodos Clientes---------*/
        /*---------Metodos Enderecos---------*/
        public static void IncluirEndereco(int idCliente, int cep, string endereco, int numero)
        {
            listaClientes[idCliente].Enderecos.Add(new Enderecos(cep, endereco, numero));
            JSON.ExportarClientesEEnderecos();

            Enderecos aux1 = listaClientes[idCliente].Enderecos.Find(x => x.CEP == cep);


            MessageBox.Show($"{aux1.CEP}, {aux1.Endereco}, {aux1.Numero}");
        }
        public static void AlterarEndereco(int idCliente, int idEndereco, int cep, string endereco, int numero)
        {

            if (cep > 0)
                listaClientes[idCliente].Enderecos[idEndereco].CEP = cep;

            if (!String.IsNullOrEmpty(endereco) || !String.IsNullOrWhiteSpace(endereco))
                listaClientes[idCliente].Enderecos[idEndereco].Endereco = endereco;

            if (numero > 0)
                listaClientes[idCliente].Enderecos[idEndereco].Numero = numero;


            JSON.ExportarClientesEEnderecos();


            Enderecos aux1 = listaClientes[idCliente].Enderecos[idEndereco];


            MessageBox.Show($"{aux1.CEP}, {aux1.Endereco}, {aux1.Numero}");
        }
        public static void ExcluirEndereco(int idCliente, int idEndereco)
        {
            listaClientes[idCliente].Enderecos.RemoveAt(idEndereco);
            JSON.ExportarClientesEEnderecos();
        }
        public static String ListarEnderecos(int idCliente)
        {
            String lista = String.Empty;
            foreach (Enderecos enderecos in listaClientes[idCliente].Enderecos)
            {

                lista += $"ID: {listaClientes[idCliente].Enderecos.IndexOf(enderecos)}, CEP: {enderecos.CEP}, Endereço: {enderecos.Endereco} {enderecos.Numero}\n";
            }
            return lista;
        }
        /*---------FIM Metodos Enderecos---------*/
    }
}
