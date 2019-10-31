using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeCanSports
{
    public partial class ClientesEEnderecos : Form
    {
        public ClientesEEnderecos()
        {
            InitializeComponent();
        }

        private void BtnIncluirCliente_Click(object sender, EventArgs e)
        {
            String nome = txtBoxIncluirClienteNome.Text;
            String email = txtBoxIncluirClienteEmail.Text;
            decimal cpf = Math.Round(txtBoxIncluirClienteCPF.Value, 0);

            DAO.ClientesEEnderecos.IncluirCliente(nome, email, cpf);
        }

        private void BtnAlterarCliente_Click(object sender, EventArgs e)
        {
            int idCliente = Convert.ToInt32(txtBoxAlterarClienteIDCliente.Value);
            String nome = txtBoxAlterarClienteNome.Text;
            String email = txtBoxAlterarClienteEmail.Text;
            decimal cpf = Math.Round(txtBoxAlterarClienteCPF.Value, 0);

            DAO.ClientesEEnderecos.AlterarCliente(idCliente, nome, email, cpf);

        }

        private void BtnExcluirCliente_Click(object sender, EventArgs e)
        {
            int idCliente = Convert.ToInt32(txtBoxExcluirClienteIDCliente.Value);

            DAO.ClientesEEnderecos.ExcluirCliente(idCliente);

        }

        private void BtnListarCliente_Click(object sender, EventArgs e)
        {
            richtxtboxClientes.Clear();
            richtxtboxClientes.AppendText(DAO.ClientesEEnderecos.ListarCliente());
        }

        private void BtnIncluirEndereco_Click(object sender, EventArgs e)
        {
            int idCliente = Convert.ToInt32(txtBoxIncluirEnderecoIDCliente.Value);
            int cep = Convert.ToInt32(txtBoxIncluirEnderecoCEP.Value);
            String endereco = txtBoxIncluirEnderecoEndereco.Text;
            int numero = Convert.ToInt32(txtBoxIncluirEnderecoNumero.Value);

            DAO.ClientesEEnderecos.IncluirEndereco(idCliente, cep ,endereco ,numero);
        }

        private void BtnAlterarEndereco_Click(object sender, EventArgs e)
        {
            int idCliente = Convert.ToInt32(txtBoxAlterarEnderecoIDCliente.Value);
            int idEndereco = Convert.ToInt32(txtBoxAlterarEnderecoIDEndereco.Value);
            int cep = Convert.ToInt32(txtBoxAlterarEnderecoCEP.Value);
            String endereco = txtBoxAlterarEnderecoEndereco.Text;
            int numero = Convert.ToInt32(txtBoxAlterarEnderecoNumero.Value);

            DAO.ClientesEEnderecos.AlterarEndereco(idCliente, idEndereco, cep, endereco, numero);

        }

        private void BtnExcluirEndereco_Click(object sender, EventArgs e)
        {
            int idCliente = Convert.ToInt32(txtBoxExcluirEnderecoIDCliente.Value);
            int idEndereco = Convert.ToInt32(txtBoxExcluirEnderecoIDEndereco.Value);

            DAO.ClientesEEnderecos.ExcluirEndereco(idCliente, idEndereco);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            richtxtboxEnderecos.Clear();
            int idClientes = Convert.ToInt32(txtBoxListaEnderecoIDCliente.Value);
            richtxtboxEnderecos.AppendText(DAO.ClientesEEnderecos.ListarEnderecos(idClientes));

        }
    }
}
