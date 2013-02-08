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
    public partial class frmLocalizaCliente : Form
    {
        public int CodigoCliente { get; set; }
        public string nomecliente { get; set; }

        public frmLocalizaCliente()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Busca o cliente de acordo com a seleção no formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_localiza_Click(object sender, EventArgs e)
        {
            AcessoDadosClientes Cliente = new AcessoDadosClientes();

            dgv_dados.Visible = true;

            if (rdb_nomempresa.Checked)
            {
                dgv_dados.DataSource = Cliente.PesquisaNomeCliente(txt_nomempresa.Text);
                dgv_dados.Refresh();
            }
            
            if (rdb_codigo.Checked)
            {
                dgv_dados.DataSource = Cliente.PesquisaIDCliente(Convert.ToInt32(msk_codigo.Text));
                dgv_dados.Refresh();

            }
            
            if (rdb_contato.Checked)
            {
                dgv_dados.DataSource = Cliente.PesquisaporContato(txt_contato.Text);
                dgv_dados.Refresh();

            }
            
            if (rdb_cidade.Checked)
            {
                dgv_dados.DataSource = Cliente.PesquisaporCidade(txt_cidade.Text);
                dgv_dados.Refresh();

            }

        }

        /// <summary>
        /// Coleta o dados do cliente envia para o formulário de vendas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Controle dos RadioButtons
        
        /*O métodos controlam a entrada de dados nos formularios
         * para evitar entradas duplicadas*/

        private void rdb_nomempresa_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_nomempresa.Checked)
                txt_nomempresa.Enabled = true;
            else
                txt_nomempresa.Enabled = false;
        }

        private void rdb_contato_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_contato.Checked)
                txt_contato.Enabled = true;
            else
                txt_contato.Enabled = false;
        }

        private void rdb_cidade_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_cidade.Checked)
                txt_cidade.Enabled = true;
            else
                txt_cidade.Enabled = false;
        }

        private void rdb_codigo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_codigo.Checked)
                msk_codigo.Enabled = true;
            else
                msk_codigo.Enabled = false;
        } 
        #endregion

        private void dgv_dados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_dados.EndEdit();
            
            btn_ok.Enabled = true;

            foreach (DataGridViewRow row in dgv_dados.Rows)
            {
                if (row.Cells[0].Value != null && (bool)row.Cells[0].Value)
                {
                    CodigoCliente = Convert.ToInt32(row.Cells[1].Value);
                    nomecliente = row.Cells[2].Value.ToString();
                }
            }



        }






    }
}
