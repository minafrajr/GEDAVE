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
    public partial class frmBase : Form
    {
        public int CodGeral; //atributo para repassar o códgio do objeto.

        public frmBase()
        {
            InitializeComponent();
            HabilitarBotões(true);
        }

        /// <summary>
        /// Realiza ao carregar o formulário base
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmBase_Load(object sender, EventArgs e)
        {
            Habilitarcampos(false);

            LimparCampos();
        }

        #region Controle do Formulário


        /// <summary>
        /// Limpa todos os campos de entrada de dados.
        /// </summary>
        private void LimparCampos()
        {
            foreach (Component comp in this.Controls)
            {
                if (comp is MeuTextBox)
                {
                    ((MeuTextBox)comp).Clear();
                }
                if (comp is MeuMskTextBox)
                {
                    ((MeuMskTextBox)comp).Clear();
                }
                if (comp is MeuComboBox)
                {
                    ((MeuComboBox)comp).ResetText();
                }
                if (comp is CheckBox)
                {
                    ((CheckBox)comp).Checked = false;
                }

            }
           
        }

        /// <summary>
        /// Habilita a entrada de dados nos campos quando necessário. Verdadeiro para habilitado e  falso para desabilitado.
        /// </summary>
        /// <param name="bvalue">verdadeiro ou falso</param>
        protected void Habilitarcampos(bool bvalue)
        {
            foreach (Component mycomp in Controls)//passa por todos os componentes do formulário
            {
                if (mycomp is MeuComboBox)    // se for um componente personalizado combobox
                    ((MeuComboBox)mycomp).Enabled = bvalue;
                if (mycomp is MeuMskTextBox)   // se for um componente personalizado msktextbox
                    ((MeuMskTextBox)mycomp).Enabled = bvalue;
                if (mycomp is MeuTextBox)      // se for um componente personalizado textbox
                    ((MeuTextBox)mycomp).Enabled = bvalue;
            }
            foreach (Control ctrl in Controls)
            {
                if (ctrl is PictureBox)
                    ((PictureBox)ctrl).Image = null;
                if (ctrl is DateTimePicker)
                {
                    ((DateTimePicker)ctrl).ResetText();
                    ((DateTimePicker)ctrl).Enabled = bvalue;

                }
            }

        }

        /// <summary>
        /// Habilitar os botões de acordo com a necessidade.
        /// </summary>
        /// <param name="bvalue">verdeiro ou falso</param>
        private void HabilitarBotões(bool bvalue)
        {
            btn_Novo.Enabled = bvalue; //se o botao novo estiver habilitado
            btn_Editar.Enabled = bvalue; // o botão editar estará desabilitado ...
            btn_Excluir.Enabled = bvalue;
            btn_Adicionar.Enabled = !bvalue;
            btn_Localizar.Enabled = bvalue;
            btn_Atualizar.Enabled = !bvalue;
        }

        /// <summary>
        /// Fecha o formulário após apertar a tecla escape.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Tecla escape</param>
        private void frmBase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Método para fechar o formulário quando acionado o botão sair.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Métodos a serem herdados

        /*Condicionais para executar os metodos da classe pai*/
        protected virtual bool Deletar() { return false; }
        protected virtual bool Adicionar() { return false; }
        protected virtual bool Localizar() { return false; }
        protected virtual bool Atualizar() { return false; }
        protected virtual void CarregarDados() { }
        protected virtual void dgv_Dados_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) { } //relativo ao evento de clicar sobre o datagridview

        #endregion

        #region Métodos base para os botões do formulário

        /// <summary>
        /// Funionalidade do botão novo.Realiza funções de tela.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Novo_Click(object sender, EventArgs e)
        {
            try
            {
                HabilitarBotões(false);
                btn_Adicionar.Visible = true;
                btn_Atualizar.Visible = false;
                btn_Editar.Visible = false;
                btn_Excluir.Visible = false;
                btn_Localizar.Visible = true;
                Habilitarcampos(true);
                LimparCampos();
                CarregarDados();
            }
            catch (Exception erro)
            {
                System.Media.SystemSounds.Exclamation.Play(); //emite um aviso sonoro de erro
                MessageBox.Show("Erro : \n " + erro.Message, "GEDAVE", MessageBoxButtons.OK, MessageBoxIcon.Warning); // avisa que houve um erro e o especifica.
            }

        }

        /// <summary>
        /// Funionalidade do botao editar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Editar_Click(object sender, EventArgs e)
        {
            HabilitarBotões(false);
            btn_Adicionar.Visible = false;
            btn_Atualizar.Visible = true;
            btn_Excluir.Visible = false;
            btn_Localizar.Visible = false;
            Habilitarcampos(true);

        }

        /// <summary>
        /// Funcionalidades do botão adicionar. Verifica se salvou o objeto no banco de dados e realiza funções de tela.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Adicionar())
                {
                    LimparCampos();
                    HabilitarBotões(true);
                    CarregarDados();
                    System.Media.SystemSounds.Beep.Play();
                    MessageBox.Show("Salvo com sucesso", "Gedave", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    throw new Exception("Erro ao salvar!");
                }
            }
            catch (Exception erro)
            {
                System.Media.SystemSounds.Exclamation.Play(); //emite um aviso sonoro de erro
                MessageBox.Show("Erro ao salvar: \n " + erro.Message, "GEDAVE", MessageBoxButtons.OK, MessageBoxIcon.Warning); // avisa que houve um erro e o especifica.
            }
            finally
            {
                HabilitarBotões(true);
                Habilitarcampos(false);
                btn_Adicionar.Visible = false;
                btn_Atualizar.Visible = false;
                btn_Excluir.Visible = true;
                btn_Localizar.Visible = true;
                btn_Editar.Visible = true;
            }
        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Atualizar())
                {
                    LimparCampos();
                    CarregarDados();
                    System.Media.SystemSounds.Beep.Play();
                    MessageBox.Show("Atualizado com sucesso", "Gedave", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    throw new Exception("Erro ao Atualizar");
            }
            catch (Exception erro)
            {
                System.Media.SystemSounds.Exclamation.Play(); //emite um aviso sonoro de erro
                MessageBox.Show("Erro: \n " + erro.Message, "GEDAVE", MessageBoxButtons.OK, MessageBoxIcon.Warning); // avisa que houve um erro e o especifica.
            }
            finally
            {
                HabilitarBotões(true);
                btn_Adicionar.Visible = false;
                btn_Atualizar.Visible = false;
                btn_Excluir.Visible = true;
                btn_Localizar.Visible = true;
                Habilitarcampos(false);
                LimparCampos();

            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Deletar())
                {
                    LimparCampos();
                    HabilitarBotões(true);
                    CarregarDados();
                    System.Media.SystemSounds.Beep.Play();
                    MessageBox.Show("Deletado com sucesso!", "Gedave", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    throw new Exception("Erro ao deletar");
            }
            catch (Exception erro)
            {
                System.Media.SystemSounds.Exclamation.Play();
                MessageBox.Show("Erro ao excluir!\n" + erro.Message, "Gedave", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Localizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Localizar())
                {

                }
                else
                    throw new Exception("Não localizado!");
            }
            catch (Exception erro)
            {
                System.Media.SystemSounds.Exclamation.Play(); //emite um aviso sonoro de erro
                MessageBox.Show("Erro ao localizar: \n " + erro.Message, "GEDAVE", MessageBoxButtons.OK, MessageBoxIcon.Warning); // avisa que houve um erro e o especifica.
            }
        }

        private void dgv_Dados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            HabilitarBotões(true);
        }

        /// <summary>
        /// Cancela a operação vigente e retorna ao estado inicial do formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            frmBase_Load(null, null);//força a releitura do formulário

            btn_Novo.Enabled = true; //se o botao novo estiver habilitado
            btn_Editar.Enabled = true; // o botão editar estará desabilitado ...
            btn_Excluir.Enabled = true;
            btn_Adicionar.Visible = false;
            btn_Localizar.Enabled = true;
            btn_Atualizar.Visible = false;
            btn_Editar.Visible = true;
            btn_Excluir.Visible = true;
            btn_Localizar.Visible = true;
            CarregarDados();

        }
        #endregion








    }
}
