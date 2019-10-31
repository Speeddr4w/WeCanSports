using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeCanSports.Entidades;

namespace WeCanSports
{
    public partial class ProdutosESKUs : Form
    {
        public ProdutosESKUs()
        {
            InitializeComponent();
        }

        List<Produtos> listaProdutos = new List<Produtos>();

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            String nomeProduto = txtBoxInlcuirProduto.Text;
            DAO.ProdutosESKUs.IncluirProduto(nomeProduto);
        }

        private void btnIncluirSKU_Click(object sender, EventArgs e)
        {
            int idProduto = Convert.ToInt32(txtboxIncluirSKUID.Value);
            String nomeSKU = txtBoxInlcuirSKU.Text;

            DAO.ProdutosESKUs.IncluirSKU(idProduto, nomeSKU);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int idProduto = Convert.ToInt32(txtBoxAlterarProdutoID.Value);
            String nomeSKU = txtBoxAlterarProduto.Text;

            DAO.ProdutosESKUs.AlterarProduto(idProduto, nomeSKU);

        }

        private void btnAlterarSKU_Click(object sender, EventArgs e)
        {
            int idProduto = Convert.ToInt32(txtboxAlterarSKUIDProduto.Value);
            int idSKU = Convert.ToInt32(txtBoxAlterarSKUID.Value);
            String nomeSKU = txtBoxAlterarSKU.Text;


            DAO.ProdutosESKUs.AlterarSKU(idProduto, idSKU, nomeSKU);
        }

        private void btnAtivar_Click(object sender, EventArgs e)
        {
            int idProduto = Convert.ToInt32(txtBoxAtivarProdutoID.Value);

            DAO.ProdutosESKUs.AtivarProduto(idProduto);
        }

        private void btnAtivarSKU_Click(object sender, EventArgs e)
        {
            int idProduto = Convert.ToInt32(txtboxAtivarSKUIDProduto.Value);
            int idSKU = Convert.ToInt32(txtBoxAtivarSKUID.Value);

            DAO.ProdutosESKUs.AtivarSKU(idProduto, idSKU);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int idProduto = Convert.ToInt32(txtboxExcluirProdutoID.Value);

            DAO.ProdutosESKUs.ExcluirProduto(idProduto);
        }

        private void btnExcluirSKU_Click(object sender, EventArgs e)
        {
            int idProduto = Convert.ToInt32(txtboxExcluirSKUIDProduto.Value);
            int idSKU = Convert.ToInt32(txtboxExcluirSKUID.Value);

            DAO.ProdutosESKUs.ExcluirSKU(idProduto, idSKU);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            richtxtboxProdutos.Clear();
            richtxtboxProdutos.AppendText(DAO.ProdutosESKUs.ListarProduto());
        }

        private void btnListarSKU_Click(object sender, EventArgs e)
        {
            richtxtboxSKU.Clear();
            int idProdutos = Convert.ToInt32(txtboxListarSKUsIDProduto.Value);
            richtxtboxSKU.AppendText(DAO.ProdutosESKUs.ListarSKU(idProdutos));
        }

        private void BtnPrecoSKU_Click(object sender, EventArgs e)
        {
            int idProduto = Convert.ToInt32(txtboxPrecificarSKUIDProduto.Value);
            int idSKU = Convert.ToInt32(txtboxPrecificarSKUID.Value);
            decimal preco = txtboxPrecificarSKUValor.Value;

            DAO.ProdutosESKUs.PrecificarSKU(idProduto, idSKU, preco);
        }
    }
}
