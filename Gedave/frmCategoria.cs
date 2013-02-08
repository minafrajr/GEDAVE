using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;


namespace Gedave
{
    public partial class frmCategoria : Gedave.frmBase
    {
        public frmCategoria()
        {
            InitializeComponent();
            CarregarDados();
        }

        #region Transações com o Banco de Dados

        /// <summary>
        /// Adicionar a categoria no banco de dados
        /// </summary>
        /// <returns></returns>
        protected override bool Adicionar()
        {
            bool bsalvar = false;
            AcessoDadosCategoria Categoria = new AcessoDadosCategoria();

            if (ptb_fotocategoria.Image != null)
            {
                Categoria.NomeCategoria = txt_nomecategoria.Text;
                Categoria.DescricaoCategoria = txt_descricao.Text;
                Categoria.Figura = FiguraToChar();

                bsalvar = Categoria.salvar(true);
            }
            else
                throw new Exception("Selecione uma imagem antes de salvar a categoria");

            ptb_fotocategoria.Image = null;

            DesabilitaCampos(false);

            return bsalvar;
        }

        /// <summary>
        /// Atualiza a categoria no banco de dados.
        /// </summary>
        /// <returns></returns>
        protected override bool Atualizar()
        {
            bool atualizou = false;
            AcessoDadosCategoria Categoria = new AcessoDadosCategoria();

            if (ptb_fotocategoria.Image != null)
            {
                Categoria.CodigoCategoria = Convert.ToInt32(lbl_codigo2.Text);
                Categoria.NomeCategoria = txt_nomecategoria.Text;
                Categoria.DescricaoCategoria = txt_descricao.Text;
                Categoria.Figura = FiguraToChar();

                atualizou = Categoria.salvar(false);
            }
            else
                throw new Exception("Selecione uma imagem antes de atualizar a categoria");

            DesabilitaCampos(false);

            return atualizou;
        }

        /// <summary>
        /// Deleta a categoria do banco de dados
        /// </summary>
        /// <returns></returns>
        protected override bool Deletar()
        {
            bool deletar = false;

            AcessoDadosCategoria Categoria = new AcessoDadosCategoria();

            if ((MessageBox.Show("Deseja excluir o registro: " + txt_nomecategoria.Text.ToUpper() + " ?", "Gedave", MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes)))
            {
                Categoria.CodigoCategoria = Convert.ToInt32(lbl_codigo2.Text);

                deletar = Categoria.delete();
                ptb_fotocategoria.Image = null;
            }

            return deletar;

        }

        /// <summary>
        /// Localiza uma categoria no banco de dados
        /// </summary>
        /// <returns></returns>
        protected override bool Localizar()
        {
            bool localizar = false;

            if (txt_nomecategoria.Enabled && txt_nomecategoria.Text != null)
            {
                AcessoDadosCategoria Categoria = new AcessoDadosCategoria();

                dgv_dados.DataSource = Categoria.pesquisaNome(txt_nomecategoria.Text);

                if (dgv_dados != null)
                    localizar = true;
            }
            else
            {
                txt_nomecategoria.Enabled = true;
                localizar = true;
            }

            return localizar;
        }

        /// <summary>
        /// Carrega os dados do banco de dados para o DataGridView.
        /// </summary>
        protected override void CarregarDados()
        {
            AcessoDadosCategoria Categoria = new AcessoDadosCategoria();

            dgv_dados.DataSource = Categoria.CarregaDados();
        }

        #endregion

        #region Controle do Formulário

        /// <summary>
        /// Ação do botão carregar foto da categoria
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_addfoto_Click(object sender, EventArgs e)
        {
            try
            {
                ptb_fotocategoria.Enabled = true;
                ofd_abrirfoto.Title = "Escolher foto";
                ofd_abrirfoto.FileName = null;
                ofd_abrirfoto.Filter = "Imagens(*.BMP; *.JPG; *.GIF)|*.BMP; *.JPG; *.GIF";

                try
                {
                    if (ofd_abrirfoto.ShowDialog() == DialogResult.OK)
                    {
                        ptb_fotocategoria.Visible = true;
                        ptb_fotocategoria.Image = new Bitmap(ofd_abrirfoto.OpenFile());
                        ptb_fotocategoria.Refresh();
                    }
                }
                catch (Exception)
                {
                    throw new Exception("Não foi possível Carregar a foto!");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("GEDAVE", erro.Message);
            }
        }

        /// <summary>
        /// Transforma uma arguivo de imagem em um array de bytes.
        /// </summary>
        /// <returns></returns>
        private byte[] FiguraToChar()
        {
            MemoryStream ms = new MemoryStream();
            ptb_fotocategoria.Image.Save(ms, ImageFormat.Bmp);
            byte[] photoarray = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(photoarray, 0, photoarray.Length);

            return photoarray;
        }

        /// <summary>
        /// Repassa os dados do DataGridView para os campos do formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_dados_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lbl_codigo1.Visible = true;
            lbl_codigo2.Visible = true;

            DesabilitaCampos(false);
            lbl_codigo2.Visible = true;
            lbl_codigo1.Visible = true;
            lbl_codigo2.Text = dgv_dados[0, dgv_dados.CurrentCellAddress.Y].Value.ToString();
            txt_nomecategoria.Text = dgv_dados[1, dgv_dados.CurrentCellAddress.Y].Value.ToString();
            txt_descricao.Text = dgv_dados[2, dgv_dados.CurrentCellAddress.Y].Value.ToString();

            ptb_fotocategoria.Image = null;

            if (dgv_dados[3, dgv_dados.CurrentCellAddress.Y].Value != null)
            {
                byte[] fotoarray = ((byte[])dgv_dados[3, dgv_dados.CurrentCellAddress.Y].Value);
                
                MemoryStream ms = new MemoryStream(fotoarray);
                
                ptb_fotocategoria.Image = Image.FromStream(ms);
            }
        }

        /// <summary>
        /// habilitar campos
        /// </summary>
        /// <param name="value">verdadeiro ou falso</param>
        private void DesabilitaCampos(bool value)
        {
            ptb_fotocategoria.Image = null;
            txt_descricao.Enabled = value;
            txt_nomecategoria.Enabled = value;
            lbl_codigo1.Visible = value;
            lbl_codigo2.Visible = value;
        }
        #endregion



    }
}
