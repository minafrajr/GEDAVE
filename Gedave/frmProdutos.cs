using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gedave
{
    public partial class frmProdutos : Gedave.frmBase
    {
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            // esta linha de código carrega dados na tabela 'dsComboBox.Categorias'. Você pode movê-la ou removê-la conforme necessário.
            this.categoriasTableAdapter.Fill(this.dsComboBox.Categorias);
            
            // esta linha de código carrega dados na tabela 'dsComboBox.Fornecedores'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedoresTableAdapter.Fill(this.dsComboBox.Fornecedores);
            CarregarDados();
            vercodigo(false);
        }

        #region Transação com o Banco de dados


        /// <summary>
        /// Carrega do banco de dados os produtos cadastrados
        /// </summary>
        protected override void CarregarDados()
        {
            AcessoDadosProdutos Produtos = new AcessoDadosProdutos();

            if (rbt_todas.Checked)
                dgv_dados.DataSource = Produtos.CarregaDados();
            else if (rbt_disponiveis.Checked)
                dgv_dados.DataSource = Produtos.CarregaDados(false);
            else
                dgv_dados.DataSource = Produtos.CarregaDados(true);

        }

        /// <summary>
        /// Adiciona um novo produto ao banco de dados
        /// </summary>
        /// <returns></returns>
        protected override bool Adicionar()
        {
            bool salvar = false;

            AcessoDadosProdutos Produtos = new AcessoDadosProdutos();
            Produtos.CodigoCategoria = Convert.ToInt32(cbo_categoria.SelectedValue);
            Produtos.CodigoFornecedor = Convert.ToInt32(cbo_fornecedor.SelectedValue);
            if (rbt_nao.Checked)
                Produtos.Descontinuado = false;
            else
                Produtos.Descontinuado = true;

            Produtos.NiveldeReposicao = Convert.ToSByte(msk_nivelrepos.Text);
            Produtos.PrecoUnitario = Convert.ToDecimal(msk_precounit.Text)/100;
            Produtos.QuantidadepUnidade = txt_qtdeunidade.Text;
            Produtos.UnidadeEstocada = Convert.ToSByte(msk_unidadesestoque.Text);
            Produtos.NomeProduto = txt_nomeproduto.Text;
            Produtos.UnidadesPedidas = Convert.ToSByte(msk_unidpedidas.Text);

            salvar = Produtos.salvar(true);

            return salvar;
        }

        /// <summary>
        /// Atualiza um produto no banco de dados
        /// </summary>
        /// <returns>verdadeiro se atualizou ou falso caso negativo</returns>
        protected override bool Atualizar()
        {
            bool atualizar = false;

            AcessoDadosProdutos Produtos = new AcessoDadosProdutos();
            AcessoDadosFornecedor Fornecedor = new AcessoDadosFornecedor();// para localizar o código do fornecedor
            AcessoDadosCategoria Categoria = new AcessoDadosCategoria();// para localizar o código do fornecedor

            Produtos.CodigoProduto = Convert.ToInt32(lbl_codigo2.Text);

            //localiza o código da categoria a partir do nome contido na combobox de categorias
            Produtos.CodigoCategoria = Convert.ToInt32(Categoria.pesquisaNome(cbo_categoria.Text).Rows[0][0].ToString());

            //localiza o código do fornecedor a partir do nome contido na combobox de fornecedores
            Produtos.CodigoFornecedor = Convert.ToInt32(Fornecedor.pesquisaNome(cbo_fornecedor.Text).Rows[0][0].ToString());

            if (rbt_nao.Checked)
                Produtos.Descontinuado = false;
            else
                Produtos.Descontinuado = true;

            Produtos.NiveldeReposicao = Convert.ToSByte(msk_nivelrepos.Text);
            Produtos.PrecoUnitario = Convert.ToDecimal(msk_precounit.Text)/100;
            Produtos.QuantidadepUnidade = txt_qtdeunidade.Text;
            Produtos.UnidadeEstocada = Convert.ToSByte(msk_unidadesestoque.Text);
            Produtos.NomeProduto = txt_nomeproduto.Text;
            Produtos.UnidadesPedidas = Convert.ToSByte(msk_unidpedidas.Text);

            atualizar = Produtos.salvar(false);

            return atualizar;
        }

        /// <summary>
        /// Exclui um produto do banco de dados.
        /// </summary>
        /// <returns>verdadeiro se deletou e falso se não tiver deletado</returns>
        protected override bool Deletar()
        {
            bool deletar = false;

            AcessoDadosProdutos Produtos = new AcessoDadosProdutos();

            if (MessageBox.Show("Deseja excluir o produto: " + txt_nomeproduto.Text.ToUpper() + "?", "Gedave", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
            {
                Produtos.CodigoProduto = Convert.ToInt32(lbl_codigo2.Text);
                deletar = Produtos.delete();
            }

            return deletar;
        }

        protected override bool Localizar()
        {
            bool Localizar = false;

            if (txt_nomeproduto.Enabled)
            {
                AcessoDadosProdutos Produtos = new AcessoDadosProdutos();

                dgv_dados.DataSource = null;

                dgv_dados.DataSource = Produtos.pesquisaNome(txt_nomeproduto.Text);

                dgv_dados.Refresh();


                Localizar = true;
            }
            else
            {
                txt_nomeproduto.Enabled = true;
                txt_nomeproduto.Focus();
                Localizar = true;
            }

            return Localizar;
        }



        #endregion


        #region Controle do formulário

        #region Controle dos radiosbuttons de produto continuado ou descontinuado

        /// <summary>
        /// se qualquer status cheked dos botões mudarem, executa recarrega o formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbt_todas_CheckedChanged(object sender, EventArgs e)
        {
            frmProdutos_Load(null, null);
        }

        /// <summary>
        /// se qualquer status cheked dos botões mudarem, executa recarrega o formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbt_disponiveis_CheckedChanged(object sender, EventArgs e)
        {
            frmProdutos_Load(null, null);
        }

        /// <summary>
        /// se qualquer status cheked dos botões mudarem, executa recarrega o formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbt_indisponiveis_CheckedChanged(object sender, EventArgs e)
        {
            frmProdutos_Load(null, null);
        }
        #endregion

        /// <summary>
        /// abre o formulário de fornecedores e força o recarregamento do formulário de produtos com a combobox atualizada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_novoforn_Click(object sender, EventArgs e)
        {
            frmFornecedor frm = new frmFornecedor();
            frm.ShowDialog();
            frmProdutos_Load(null, null);
        }

        /// <summary>
        /// abre o formulário de categorias e força o recarregamento do formulário de produtos com a combobox atualizada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_novacatg_Click(object sender, EventArgs e)
        {
            frmCategoria frm = new frmCategoria();
            frm.ShowDialog();
            frmProdutos_Load(null, null);
        }

        /// <summary>
        /// Respassa os dados do DataGridView para os campos do formulário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_dados_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            vercodigo(true);

            lbl_codigo2.Text = dgv_dados[0, dgv_dados.CurrentCellAddress.Y].Value.ToString();
            cbo_categoria.ResetText();
            cbo_categoria.SelectedText = dgv_dados[4, dgv_dados.CurrentCellAddress.Y].Value.ToString();
            cbo_fornecedor.ResetText();
            cbo_fornecedor.SelectedText = dgv_dados[8, dgv_dados.CurrentCellAddress.Y].Value.ToString();
            rbt_nao.Checked = true;

            if ((bool)dgv_dados[9, dgv_dados.CurrentCellAddress.Y].Value)//compara se o produto é descontinuado ou não.
            {
                rbt_nao.Checked = false;
                rbt_sim.Checked = true;
            }
            msk_nivelrepos.Text = dgv_dados[7, dgv_dados.CurrentCellAddress.Y].Value.ToString();
            msk_precounit.Text = string.Format("{0:0.00}",dgv_dados[3, dgv_dados.CurrentCellAddress.Y].Value);
            txt_qtdeunidade.Text = dgv_dados[2, dgv_dados.CurrentCellAddress.Y].Value.ToString();
            msk_unidadesestoque.Text = dgv_dados[5, dgv_dados.CurrentCellAddress.Y].Value.ToString();
            txt_nomeproduto.Text = dgv_dados[1, dgv_dados.CurrentCellAddress.Y].Value.ToString();
            msk_unidpedidas.Text = dgv_dados[6, dgv_dados.CurrentCellAddress.Y].Value.ToString();

        }

        /// <summary>
        /// Tornar visível a label ou não.
        /// </summary>
        /// <param name="value">verdadeiro ou falso</param>
        private void vercodigo(bool value)
        {
            lbl_codigo1.Visible = value;
            lbl_codigo2.Visible = value;
        }

        #endregion






    }
}
