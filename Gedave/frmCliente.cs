using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace Gedave
{

    public partial class frmCliente : Gedave.frmBase
    {
        public frmCliente()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// Acesso ao Webservice para busca do cep
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
                    MessageBox.Show("Nao foi encontrado o CEP!\nPor favor digite o endereço.", "GEDAVE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    System.Media.SystemSounds.Beep.Play();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message,"GEDAVE");
            }
        }


        #region Transação com o banco de dados

        /// <summary>
        /// Deletar o cliente da base de dados
        /// </summary>
        /// <returns></returns>
        protected override bool Deletar()
        { 
            bool bdeletar = false;

            if ((MessageBox.Show("Deseja excluir o registro: "+txt_nome.Text.ToUpper()+" ?","Gedave",MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes)))
            {

                AcessoDadosClientes Cliente = new AcessoDadosClientes();

                //Cliente.CargoContatoCliente = txt_cargo.Text;
                //Cliente.Cep = msk_cep.Text;
                //Cliente.Cidade = txt_cidade.Text;
                //Cliente.Endereco = txt_logradouro.Text;
                //Cliente.Fax = msk_cep.Text;
                //Cliente.NomeContatoCliente = txt_contato.Text;
                //Cliente.NomeEmpresaCliente = txt_nome.Text;
                //Cliente.Pais = cbo_pais.SelectedText;
                //Cliente.Regiao = cbo_regiao.SelectedText;
                //Cliente.Telefone = msk_telefone.Text;
                Cliente.CodigoCliente = Convert.ToInt32(lbl_codigo2.Text);
                bdeletar = Cliente.delete();

                return bdeletar; 
            }
            else
                return bdeletar;
        }


        /// <summary>
        /// Adicionar um novo cliente na base de dados
        /// </summary>
        /// <returns></returns>
        protected override bool Adicionar()
        {
            bool bsalvar = false;

            AcessoDadosClientes Cliente = new AcessoDadosClientes();

            Cliente.CargoContatoCliente = txt_cargo.Text;
            Cliente.Cep = msk_cep.Text;
            Cliente.Cidade = txt_cidade.Text;
            Cliente.Endereco = txt_logradouro.Text;
            Cliente.Fax = msk_cep.Text;
            Cliente.NomeContatoCliente = txt_contato.Text;
            Cliente.NomeEmpresaCliente = txt_nome.Text;
            Cliente.Pais = cbo_pais.SelectedItem.ToString();
            Cliente.Regiao = cbo_regiao.SelectedItem.ToString();
            Cliente.Telefone = msk_telefone.Text;

            bsalvar = Cliente.salvar(true);

            return bsalvar;
        }

        /// <summary>
        /// Atualizar os dados de um cliente na base de dados
        /// </summary>
        /// <returns></returns>
        protected override bool Atualizar()
        {
            bool batualizar = false;

            AcessoDadosClientes Cliente = new AcessoDadosClientes();

            Cliente.CargoContatoCliente = txt_cargo.Text;
            Cliente.Cep = msk_cep.Text;
            Cliente.Cidade = txt_cidade.Text;
            Cliente.Endereco = txt_logradouro.Text;
            Cliente.Fax = msk_fax.Text; ;
            Cliente.NomeContatoCliente = txt_contato.Text;
            Cliente.NomeEmpresaCliente = txt_nome.Text;
            Cliente.Pais = cbo_pais.Text;
            Cliente.Regiao = cbo_regiao.Text;
            Cliente.Telefone = msk_telefone.Text;
            Cliente.CodigoCliente = Convert.ToInt32(lbl_codigo2.Text);

            batualizar = Cliente.salvar(false);

            return batualizar;
        }

        /// <summary>
        /// Carregar os dados dos clientes a partir do banco de dados
        /// </summary>
        protected override void CarregarDados()
        {
            AcessoDadosClientes Cliente = new AcessoDadosClientes();

            dgv_dados.DataSource = Cliente.CarregaDados();

        }


        /// <summary>
        /// Localizar um cliente específico
        /// </summary>
        /// <returns></returns>
        protected override bool Localizar()
        {
            bool localizou = false;

            if (txt_nome.Enabled)
            {
                AcessoDadosClientes Cliente = new AcessoDadosClientes();

                dgv_dados.DataSource = Cliente.PesquisaNomeCliente(txt_nome.Text);

                if (dgv_dados != null)
                    localizou = true;
            }
            else
            {
                txt_nome.Enabled = true;
                txt_nome.Focus();
                localizou = true;
            }

            return localizou;
        }
        #endregion


        /// <summary>
        /// Habilita o campo de código.
        /// </summary>
        /// <param name="value">verdadeiro ou falso</param>
        public void VerCodigo(bool value)
        {
            lbl_codigo1.Visible = value;
            lbl_codigo2.Visible = value;
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void dgv_dados_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            VerCodigo(true);
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
        }

    }
}
