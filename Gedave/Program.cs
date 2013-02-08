using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Gedave
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
            Application.Run(new frmPrincipal());
            
            /* para testes*/
            //Application.Run(new frmCliente());
            //Application.Run(new frmBase());
            //Application.Run(new frmCategoria());
            //Application.Run(new frmFornecedor());
            //Application.Run(new frmFuncionario());
            //Application.Run(new frmTransportadora());
            //Application.Run(new frmProdutos());
            //Application.Run(new frmPedido());
            //Application.Run(new frmPedidos2());
            //Application.Run(new frmLocalizaCliente());
            //Application.Run(new frmRelatorio(1));
            //Application.Run(new frmRelatorio(2));
            //Application.Run(new frmRelatorio(3));
            //Application.Run(new frmRelatorio(5));
            //Application.Run(new frmParamPedido());




        }
    }
}
