using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gedave
{
    public partial class frmFornecedor : Gedave.frmBase
    {
        public frmFornecedor()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Busca o cep para completar o endereço
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_busca_Click(object sender, EventArgs e)
        {
            try
            {
                BuscaCep CEP = new BuscaCep();

                CEP.buscador(msk_cep.Text, txt_cidade, txt_bairro, txt_logradouro, cbo_tipolograd);
                if (txt_cidade.Text == "\n    ")
                {
                    System.Media.SystemSounds.Beep.Play();
                    MessageBox.Show("Nao foi encontrado o CEP! Porfavor digite o endereço.", "GEDAVE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    System.Media.SystemSounds.Beep.Play();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message,"GEDAVE");
            }

        }


        #region Transação com o Banco de dados

        /// <summary>
        /// Salva o fornecedor no banco de dados
        /// </summary>
        /// <returns></returns>
        protected override bool Adicionar()
        {
            bool salvar = false;

            AcessoDadosFornecedor Fornecedor = new AcessoDadosFornecedor();

            Fornecedor.CargoContatoForn = txt_cargo.Text;
            Fornecedor.Cep = msk_cep.Text;
            Fornecedor.Cidade = txt_cidade.Text;
            Fornecedor.Endereco = txt_logradouro.Text;
            Fornecedor.Fax = msk_fax.Text;
            Fornecedor.NomeContactForn = txt_contato.Text;
            Fornecedor.NomeFornecedor = txt_nome.Text;
            Fornecedor.Pais = cbo_pais.SelectedItem.ToString();
            Fornecedor.Regiao = cbo_regiao.SelectedItem.ToString();
            Fornecedor.Telefone = msk_telefone.Text;
            Fornecedor.Homepage = txt_homepage.Text;

            salvar = Fornecedor.salvar(true);

            return salvar;
        }
        
        /// <summary>
        /// Atualiza o fornecedor no banco de dados
        /// </summary>
        /// <returns></returns>
        protected override bool Atualizar()
        {
            bool salvar = false;

            AcessoDadosFornecedor Fornecedor = new AcessoDadosFornecedor();

            Fornecedor.CodigoFornecedor = Convert.ToInt32(lbl_codigo2.Text);
            Fornecedor.CargoContatoForn = txt_cargo.Text;
            Fornecedor.Cep = msk_cep.Text;
            Fornecedor.Cidade = txt_cidade.Text;
            Fornecedor.Endereco = txt_logradouro.Text;
            Fornecedor.Fax = msk_fax.Text;
            Fornecedor.NomeContactForn = txt_contato.Text;
            Fornecedor.NomeFornecedor = txt_nome.Text;
            Fornecedor.Pais = cbo_pais.Text;
            Fornecedor.Regiao = cbo_regiao.Text;
            Fornecedor.Telefone = msk_telefone.Text;
            Fornecedor.Homepage = txt_homepage.Text;

            salvar = Fornecedor.salvar(false);

            return salvar;
        }

        /// <summary>
        /// Carrega os dados a partir do banco de dados
        /// </summary>
        protected override void CarregarDados()
        {
            AcessoDadosFornecedor Fornecedor = new AcessoDadosFornecedor();

            dgv_dados.DataSource = Fornecedor.CarregaDados();
        }

        /// <summary>
        /// Deleta o fornecedor do banco de dados
        /// </summary>
        /// <returns></returns>
        protected override bool Deletar()
        {
            bool deletar = false;

            AcessoDadosFornecedor Fornecedor = new AcessoDadosFornecedor();

            Fornecedor.CodigoFornecedor = Convert.ToInt32(lbl_codigo2.Text);

            deletar = Fornecedor.delete();

            return deletar;
        }

        /// <summary>
        /// Localiza o fornecedor no banco;
        /// </summary>
        /// <returns></returns>
        protected override bool Localizar()
        {
            bool localizar = false;

            if (txt_nome.Enabled && txt_nome.Text != null)
            {
                AcessoDadosFornecedor Fornecedor = new AcessoDadosFornecedor();

                dgv_dados.DataSource = Fornecedor.pesquisaNome(txt_nome.Text);

                if (dgv_dados!=null)
                    localizar = true; 
            }
            else
            {
                txt_nome.Enabled = true;
                return true;
            }

            return localizar;

        }

        #endregion

        #region Controle do Formulário

        public void VerCodigo(bool value)
        {
            lbl_codigo1.Visible = value;
            lbl_codigo2.Visible = value;
        }
        /// <summary>
        /// Repassa os dados do DataGridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_dados_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lbl_codigo1.Visible = true;
            lbl_codigo2.Visible = true;

            cbo_pais.ResetText();
            cbo_regiao.ResetText();
            cbo_tipolograd.ResetText();

            lbl_codigo2.Text = dgv_dados[0, dgv_dados.CurrentCellAddress.Y].Value.ToString();
            txt_nome.Text = dgv_dados[1, dgv_dados.CurrentCellAddress.Y].Value.ToString();
            txt_contato.Text = dgv_dados[2, dgv_dados.CurrentCellAddress.Y].Value.ToString();
            txt_cargo.Text = dgv_dados[3, dgv_dados.CurrentCellAddress.Y].Value.ToString();
            txt_logradouro.Text = dgv_dados[4, dgv_dados.CurrentCellAddress.Y].Value.ToString();
            txt_cidade.Text = dgv_dados[5, dgv_dados.CurrentCellAddress.Y].Value.ToString();
            cbo_regiao.SelectedText = dgv_dados[6, dgv_dados.CurrentCellAddress.Y].Value.ToString();
            msk_cep.Text = dgv_dados[7, dgv_dados.CurrentCellAddress.Y].Value.ToString();
            cbo_pais.SelectedText = dgv_dados[8, dgv_dados.CurrentCellAddress.Y].Value.ToString();
            msk_telefone.Text = dgv_dados[9, dgv_dados.CurrentCellAddress.Y].Value.ToString();
            msk_fax.Text = dgv_dados[10, dgv_dados.CurrentCellAddress.Y].Value.ToString();
            txt_homepage.Text = dgv_dados[11, dgv_dados.CurrentCellAddress.Y].Value.ToString();
        }

        #endregion

        private void frmFornecedor_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

    }
}
