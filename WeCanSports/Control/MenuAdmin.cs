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
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProdutosESKUs form = new ProdutosESKUs();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EstoqueEArmazem form = new EstoqueEArmazem();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClientesEEnderecos form = new ClientesEEnderecos();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            PedidosETransportadora form = new PedidosETransportadora();
            form.ShowDialog();
        }
    }
}
