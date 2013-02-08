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
    public partial class frmFuncionario : Gedave.frmBase
    {
        public frmFuncionario()
        {
            InitializeComponent();
            CarregarDados();

        }

        private void btn_busca_Click(object sender, EventArgs e)
        {
            BuscaCep CEP = new BuscaCep();

            CEP.buscador(msk_cep.Text, txt_cidade, txt_bairro, txt_logradouro, cbo_tipolograd);
            if (txt_cidade.Text == "\n    ")
            {
                System.Media.SystemSounds.Beep.Play();
                MessageBox.Show("Nao foi encontrado o CEP! Porfavor digite-o.", "GEDAVE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                System.Media.SystemSounds.Beep.Play();
        }


        #region Transação com o banco de dados

        /// <summary>
        /// Carrega os dados dos funcionários a partir do banco de dados.
        /// </summary>
        protected override void CarregarDados()
        {
            AcessoDadosFuncionarios Funcionario = new AcessoDadosFuncionarios();

            dgv_dados.DataSource = Funcionario.CarregaDados();
        }

        /// <summary>
        /// Adiciona o funcionário no banco de dados
        /// </summary>
        /// <returns></returns>
        protected override bool Adicionar()
        {
            bool salvar = false;

            if (ptb_fotofunc.Image != null) // verifica se existe uma foto para ser salva com os dados do funcionário
            {

                AcessoDadosFuncionarios Funcionarios = new AcessoDadosFuncionarios();

                Funcionarios.Cargo = txt_cargo.Text;
                Funcionarios.Cep = msk_cep.Text;
                Funcionarios.Cidade = txt_cidade.Text;
                Funcionarios.DataContratacao = dtp_admissao.Value;
                Funcionarios.DataNascimento = dtp_aniversario.Value;
                Funcionarios.Endereco = txt_logradouro.Text;
                Funcionarios.Foto = FiguraToChar();
                Funcionarios.Nome = txt_nome.Text;
                Funcionarios.Observacao = txt_observacao.Text;
                Funcionarios.Pais = cbo_pais.SelectedText;
                Funcionarios.Ramal = msk_ramal.Text;
                Funcionarios.Regiao = cbo_regiao.Text;
                Funcionarios.Sobrenome = txt_sobrenome.Text;
                Funcionarios.TelefoneResFuncionario = msk_telefone.Text;
                Funcionarios.Tratamento = cbo_tratamento.SelectedText;
                Funcionarios.Bairro = txt_bairro.Text;
                Funcionarios.Numero = txt_numero.Text;

                salvar = Funcionarios.salvar(true);

            }
            else
                throw new Exception("Escolha uma foto antes de salvar os dados do funcionário!");

            return salvar;
        }

        /// <summary>
        /// Atualiza os dados de um funcionario no banco de dados
        /// </summary>
        /// <returns></returns>
        protected override bool Atualizar()
        {
            bool atualizar = false;

            if (ptb_fotofunc.Image != null) //verifica se existe uma foto do funcionário
            {
                AcessoDadosFuncionarios Funcionarios = new AcessoDadosFuncionarios();

                Funcionarios.Foto = FiguraToChar();
                Funcionarios.Cargo = txt_cargo.Text;
                Funcionarios.Cep = msk_cep.Text;
                Funcionarios.Cidade = txt_cidade.Text;
                Funcionarios.DataContratacao = dtp_admissao.Value;
                Funcionarios.DataNascimento = dtp_aniversario.Value;
                Funcionarios.Endereco = txt_logradouro.Text;
                Funcionarios.Nome = txt_nome.Text;
                Funcionarios.Observacao = txt_observacao.Text;
                Funcionarios.Pais = cbo_pais.SelectedText;
                Funcionarios.Ramal = msk_ramal.Text;
                Funcionarios.Regiao = cbo_regiao.Text;
                Funcionarios.Sobrenome = txt_sobrenome.Text;
                Funcionarios.TelefoneResFuncionario = msk_telefone.Text;
                Funcionarios.Tratamento = cbo_tratamento.SelectedText;
                Funcionarios.CodigoFuncionario = Convert.ToInt32(lbl_codigo2.Text);
                Funcionarios.Bairro = txt_bairro.Text;
                Funcionarios.Numero = txt_numero.Text;
                
                atualizar = Funcionarios.salvar(false);
            }
            else
                throw new Exception("Selecione uma imagem para atualizar o contato");

            return atualizar;

        }

        /// <summary>
        /// Deleta um funcionario do banco de dados
        /// </summary>
        /// <returns></returns>
        protected override bool Deletar()
        {
            bool deletar = false;

            if (MessageBox.Show("Deseja realmente deletar o funcionário " + txt_nome.Text.ToUpper() + "?", "GEDAVE", MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes))
            {
                AcessoDadosFuncionarios Funcionarios = new AcessoDadosFuncionarios();

                Funcionarios.CodigoFuncionario = Convert.ToInt32(lbl_codigo2.Text);
                ptb_fotofunc.Image = null;

                deletar = Funcionarios.delete();
            }

            return deletar;
        }

        /// <summary>
        /// Pesquisa no banco o nome do funcionario.
        /// </summary>
        /// <returns>DataTable</returns>
        protected override bool Localizar()
        {
            bool localizar = false;

            if (txt_nome.Text != null && txt_nome.Enabled)
            {
                AcessoDadosFuncionarios Funcionarios = new AcessoDadosFuncionarios();

                dgv_dados.DataSource = Funcionarios.pesquisaNome(txt_nome.Text);

                if (dgv_dados != null)
                    localizar = true;
            }
            else
            {
                txt_nome.Enabled = true;
                txt_nome.Focus();
                localizar = true;
            }

            return localizar;
        }



        #endregion


        /// <summary>
        /// Transforma uma arguivo de imagem em um array de bytes.
        /// </summary>
        /// <returns></returns>
        public byte[] FiguraToChar()
        {
            MemoryStream ms = new MemoryStream();

            string temp = ptb_fotofunc.Image.GetType().ToString();

            //if (ptb_fotofunc.Image != ImageFormat.Bmp)
            //{
            //    ptb_fotofunc.Image.Save(ms, ImageFormat.Bmp);
            //}
            //else
            ptb_fotofunc.Image.Save(ms, ImageFormat.Bmp);//executar só quando for uma nova imagem

            byte[] photoarray = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(photoarray, 0, photoarray.Length);



            return photoarray;
        }

        /// <summary>
        /// Ação do botão carregar foto do funcionario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_addfoto_Click(object sender, EventArgs e)
        {
            try
            {
                ptb_fotofunc.Enabled = true;
                ofd_abrirfotofunc.Title = "Escolher foto";
                ofd_abrirfotofunc.FileName = null;
                ofd_abrirfotofunc.Filter = "Imagens(*.BMP; *.JPG; *.GIF)|*.BMP; *.JPG; *.GIF";

                try
                {
                    if (ofd_abrirfotofunc.ShowDialog() == DialogResult.OK)
                    {
                        ptb_fotofunc.Visible = true;
                        ptb_fotofunc.Image = new Bitmap(ofd_abrirfotofunc.OpenFile());
                        ptb_fotofunc.Refresh();
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
        /// Recolhe do datagridview os dados do funcionário e repassam aos campos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_dados_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            AcessoDadosFuncionarios Funcionario = new AcessoDadosFuncionarios();
            
            cbo_pais.ResetText();
            cbo_regiao.ResetText();
            cbo_tipolograd.ResetText();
            cbo_tratamento.ResetText();
            lbl_codigo1.Visible = true;
            lbl_codigo2.Visible = true;

            lbl_codigo2.Text = dgv_dados[0, dgv_dados.CurrentCellAddress.Y].Value.ToString();
            txt_sobrenome.Text = dgv_dados[1, dgv_dados.CurrentCellAddress.Y].Value.ToString();
            txt_nome.Text = dgv_dados[2, dgv_dados.CurrentCellAddress.Y].Value.ToString();
            txt_cargo.Text = dgv_dados[3, dgv_dados.CurrentCellAddress.Y].Value.ToString();
            cbo_tratamento.ResetText();
            cbo_tratamento.SelectedText = dgv_dados[4, dgv_dados.CurrentCellAddress.Y].Value.ToString();
            dtp_aniversario.Value = (DateTime)dgv_dados[5, dgv_dados.CurrentCellAddress.Y].Value;
            dtp_admissao.Value = (DateTime)dgv_dados[6, dgv_dados.CurrentCellAddress.Y].Value;
            txt_logradouro.Text = dgv_dados[7, dgv_dados.CurrentCellAddress.Y].Value.ToString();
            txt_cidade.Text = dgv_dados[8, dgv_dados.CurrentCellAddress.Y].Value.ToString();
            cbo_pais.ResetText();
            cbo_regiao.SelectedText = dgv_dados[9, dgv_dados.CurrentCellAddress.Y].Value.ToString();
            msk_cep.Text = dgv_dados[10, dgv_dados.CurrentCellAddress.Y].Value.ToString();
            cbo_pais.ResetText();
            cbo_pais.SelectedText = dgv_dados[11, dgv_dados.CurrentCellAddress.Y].Value.ToString();
            msk_telefone.Text = dgv_dados[12, dgv_dados.CurrentCellAddress.Y].Value.ToString();
            msk_ramal.Text = dgv_dados[13, dgv_dados.CurrentCellAddress.Y].Value.ToString();
            txt_observacao.Text = dgv_dados[15, dgv_dados.CurrentCellAddress.Y].Value.ToString();
            txt_bairro.Text = dgv_dados[17, dgv_dados.CurrentCellAddress.Y].Value.ToString();
            txt_numero.Text = dgv_dados[16, dgv_dados.CurrentCellAddress.Y].Value.ToString();


            if (dgv_dados[14, dgv_dados.CurrentCellAddress.Y].Value != null && (Convert.ToInt32(dgv_dados[0, dgv_dados.CurrentCellAddress.Y].Value) <= 9))
            {
                try
                {
                    byte[] fotoarray = Funcionario.GetFoto(Convert.ToInt32(dgv_dados[0, dgv_dados.CurrentCellAddress.Y].Value.ToString()));
                    MemoryStream ms = new MemoryStream(fotoarray);
                    int offset = 78;
                    ms.Write(fotoarray, offset, fotoarray.Length - offset);
                    Image img = Image.FromStream(ms);

                    ms.Close();
                    ptb_fotofunc.Image = ((Bitmap)img);
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro: " + erro.Message, "Gedave");
                }
            }

            if ((dgv_dados[14, dgv_dados.CurrentCellAddress.Y].Value != null && (Convert.ToInt32(dgv_dados[0, dgv_dados.CurrentCellAddress.Y].Value) > 9)))
            {
                byte[] fotoarray = Funcionario.GetFoto(Convert.ToInt32(dgv_dados[0, dgv_dados.CurrentCellAddress.Y].Value.ToString()));
                MemoryStream ms = new MemoryStream(fotoarray);

                Image img = Image.FromStream(ms);

                ms.Close();
                ptb_fotofunc.Image = ((Bitmap)img);
            }
        }

        



    }
}
