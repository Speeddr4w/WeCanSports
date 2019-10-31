using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeCanSports
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DAO.JSON.ImportarProdutosESKUs();
            DAO.JSON.ImportarClientesEEnderecos();
            DAO.JSON.ImportarTransportadora();
            DAO.JSON.ImportarPedidos();
            Application.Run(new MenuAdmin());
        }
    }
}
