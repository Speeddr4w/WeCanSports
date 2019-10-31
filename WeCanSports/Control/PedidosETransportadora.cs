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
    public partial class PedidosETransportadora : Form
    {
        public PedidosETransportadora()
        {
            InitializeComponent();
        }

        private void btnIncluirTransportadora_Click(object sender, EventArgs e)
        {
            int cepInicial = Convert.ToInt32(txtBoxIncluirTransportadoraCEPInicial.Value);
            int cepFinal = Convert.ToInt32(txtBoxIncluirTransportadoraCEPFinal.Value);
            decimal valor = txtBoxIncluirTransportadoraValor.Value;
            int prazo = Convert.ToInt32(txtBoxIncluirTransportadoraPrazo.Value);

            DAO.PedidosETransportadora.IncluirTransportadora(cepInicial, cepFinal, valor, prazo);
        }

        private void btnAlterarAlterar_Click(object sender, EventArgs e)
        {
            int idTransportadora = Convert.ToInt32(txtBoxAlterarTransportadoraIDTransportadora.Value);
            int cepInicial = Convert.ToInt32(txtBoxAlterarTransportadoraCEPInicial.Value);
            int cepFinal = Convert.ToInt32(txtBoxAlterarTransportadoraCEPFinal.Value);
            decimal valor = txtBoxAlterarTransportadoraValor.Value;
            int prazo = Convert.ToInt32(txtBoxAlterarTransportadoraPrazo.Value);

            DAO.PedidosETransportadora.AlterarTransportadora(idTransportadora, cepInicial, cepFinal, valor, prazo);

        }

        private void btnExcluirTransportadora_Click(object sender, EventArgs e)
        {
            int idTransportadora = Convert.ToInt32(txtBoxRemoverTransportadoraIDTransportadora.Value);

            DAO.PedidosETransportadora.ExcluirTransportadora(idTransportadora);

        }

        private void btnListarTransportadora_Click(object sender, EventArgs e)
        {
            richtxtboxTransportadora.Clear();
            richtxtboxTransportadora.AppendText(DAO.PedidosETransportadora.ListarTransportadora());
        }

        private void btnIncluirPedido_Click(object sender, EventArgs e)
        {
            int idProduto = Convert.ToInt32(txtBoxIncluirPedidoIDProduto.Value);
            int idSku = Convert.ToInt32(txtBoxIncluirPedidoIDSKU.Value);
            int idCliente = Convert.ToInt32(txtBoxIncluirPedidoIDCliente.Value);
            int idEnderecos = Convert.ToInt32(txtBoxIncluirPedidoIDEndereco.Value);
            int idTransportadora = Convert.ToInt32(txtBoxIncluirPedidoIDTransportadora.Value);

            DAO.PedidosETransportadora.IncluirPedido(idProduto, idSku, idTransportadora ,idCliente, idEnderecos);
        }

        private void btnAlterarPedido_Click(object sender, EventArgs e)
        {
            int idPedido = Convert.ToInt32(txtBoxExcluirPedidoIDPedido.Value);
            int idProduto = Convert.ToInt32(txtBoxIAlterarPedidoIDProduto.Value);
            int idSku = Convert.ToInt32(txtBoxAlterarPedidoIDSKU.Value);
            int idCliente = Convert.ToInt32(txtBoxAlterarPedidoIDCliente.Value);
            int idEnderecos = Convert.ToInt32(txtBoxAlterarPedidoIDEndereco.Value);
            int idTransportadora = Convert.ToInt32(txtBoxAlterarPedidoIDTransportadora.Value);

            DAO.PedidosETransportadora.IncluirPedido(idProduto, idSku, idTransportadora, idCliente, idEnderecos);

        }

        private void btnExcluirExcluir_Click(object sender, EventArgs e)
        {
            int idPedido = Convert.ToInt32(txtBoxExcluirPedidoIDPedido.Value);

            DAO.PedidosETransportadora.ExcluirPedido(idPedido);
        }

        private void btnMostrarPedido_Click(object sender, EventArgs e)
        {
            int idPedido = Convert.ToInt32(txtBoxMostrarPedidoIDPedido.Value);
            richtxtboxPedidos.Clear();
            richtxtboxPedidos.AppendText(DAO.PedidosETransportadora.ListarPedido(idPedido));

        }
        
    }
}
