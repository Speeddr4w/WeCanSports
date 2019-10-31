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
    public partial class EstoqueEArmazem : Form
    {
        public EstoqueEArmazem()
        {
            InitializeComponent();
        }

        private void BtnIncluirArmazem_Click(object sender, EventArgs e)
        {
            String nomeArmazem = txtboxIncluirArmazem.Text;
            int idProduto = Convert.ToInt32(txtboxIncluirArmazemIDProduto.Value);
            int idSKU = Convert.ToInt32(txtboxIncluirArmazemIDSKU.Value);

            DAO.EstoqueEArmazem.IncluirArmazem(nomeArmazem, idProduto, idSKU);
        }

        private void BtnAlterarArmazem_Click(object sender, EventArgs e)
        {
            String nomeArmazem = txtboxAlterarArmazem.Text;
            int idProduto = Convert.ToInt32(txtboxAlterarArmazemIDProduto.Value);
            int idSKU = Convert.ToInt32(txtboxAlterarArmazemIDSKU.Value);
            int idArmazem = Convert.ToInt32(txtboxAlterarArmazemIDArmazem.Value);

            DAO.EstoqueEArmazem.AlterarArmazem(nomeArmazem, idProduto, idSKU, idArmazem);
        }

        private void BtnAtualizarArmazem_Click(object sender, EventArgs e)
        {
            int idProduto = Convert.ToInt32(txtboxAtualizarArmazemIDProduto.Value);
            int idSKU = Convert.ToInt32(txtboxAtualizarArmazemIDSKU.Value);
            int idArmazem = Convert.ToInt32(txtboxAtualizarArmazemIDArmazem.Value);
            int inventario = Convert.ToInt32(txtboxAtualizarArmazemInventario.Value);

            DAO.EstoqueEArmazem.AtualizarArmazem(idProduto, idSKU, idArmazem, inventario);
        }

        private void BtnExcluirArmazem_Click(object sender, EventArgs e)
        {
            int idProduto = Convert.ToInt32(txtboxExcluirArmazemIDProduto.Value);
            int idSKU = Convert.ToInt32(txtboxExcluirArmazemIDSKU.Value);
            int idArmazem = Convert.ToInt32(txtboxExcluirArmazemIDArmazem.Value);

            DAO.EstoqueEArmazem.ExcluirArmazem(idProduto, idSKU, idArmazem);

        }

        private void BtnListarArmazem_Click(object sender, EventArgs e)
        {
            richtxtboxEstoque.Clear();

            int idProduto = Convert.ToInt32(txtboxListarArmazemIDProduto.Value);
            int idSKU = Convert.ToInt32(txtboxListarArmazemIDSKU.Value);

            richtxtboxEstoque.AppendText(DAO.EstoqueEArmazem.ListarEstoque(idProduto, idSKU));
        }
    }
}
