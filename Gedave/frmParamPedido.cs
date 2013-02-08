using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gedave
{
    public partial class frmParamPedido : Form
    {
        public frmParamPedido()
        {
            InitializeComponent();
        }

        private void frmParamPedido_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dsComboBox.Fornecedores'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedoresTableAdapter.Fill(this.dsComboBox.Fornecedores);

        }

        private void btn_visualizar_Click(object sender, EventArgs e)
        {
            frmRelatorio frm = new frmRelatorio(4, cbo_fornecedor.Text, dtp_inicial.Value, dtp_final.Value);

            frm.Show();

        }
    }
}
