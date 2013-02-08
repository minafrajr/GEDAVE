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
    public partial class frmPrincipal : Form
    {
        private int childFormNumber = 0;

        public frmPrincipal()
        {
            InitializeComponent();

        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Janela " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }


        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        /// <summary>
        /// Procede com o encerramento do sistema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Exclamation.Play();         //aviso sonoro
            if (MessageBox.Show("GEDAVE", "Deseja sair do sistema?", MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes))                //confirma o encerramento do sistema
                this.Close();
        }

        /// <summary>
        /// Abre o form de informações sobre o sistema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_sobre_Click(object sender, EventArgs e)
        {
            frmSobre frm = new frmSobre();
            System.Media.SystemSounds.Beep.Play();//aviso sonoro
            frm.ShowDialog();
        }


        /// <summary>
        /// Abre o formulário de vendas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_vendas_Click(object sender, EventArgs e)
        {
            frmPedidos2 frm = new frmPedidos2();

            frm.MdiParent = this;

            frm.Show();
        }



        /// <summary>
        /// Permite abrir um submenu a partir do botão do menu principal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Pessoas_ButtonClick(object sender, EventArgs e)
        {
            btn_Pessoas.ShowDropDown();
        }

        /// <summary>
        /// Permite abrir um submenu a partir do botão do menu principal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Gerenciar_ButtonClick(object sender, EventArgs e)
        {
            btn_Gerenciar.ShowDropDown();
        }


        /// <summary>
        /// Permite abrir um submenu a partir do botão do menu principal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_relatorios_ButtonClick(object sender, EventArgs e)
        {
            btn_relatorios.ShowDropDown();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnu_clientes_Click(object sender, EventArgs e)
        {
            frmCliente frm = new frmCliente();

            frm.MdiParent = this;
            frm.Show();
        }

        private void mnu_categorias_Click(object sender, EventArgs e)
        {
            frmCategoria frm = new frmCategoria();

            frm.MdiParent = this;
            frm.Show();
        }

        private void mnu_fornecedores_Click(object sender, EventArgs e)
        {
            frmFornecedor frm = new frmFornecedor();

            frm.MdiParent = this;
            frm.Show();
        }

        private void mnu_funcionarios_Click(object sender, EventArgs e)
        {
            frmFuncionario frm = new frmFuncionario();

            frm.MdiParent = this;
            frm.Show();
        }

        private void mnu_transportadora_Click(object sender, EventArgs e)
        {
            frmTransportadora frm = new frmTransportadora();

            frm.MdiParent = this;
            frm.Show();
        }

        private void mnu_produtos_Click(object sender, EventArgs e)
        {
            frmProdutos frm = new frmProdutos();

            frm.MdiParent = this;
            frm.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            frmLoad frm = new frmLoad();
            frm.ShowDialog();
        }

        private void pedidosPorPaísesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorio frm = new frmRelatorio(1);

            frm.MdiParent = this;

            frm.Show();
        }

        private void listaDeAniversáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorio frm = new frmRelatorio(3);
            frm.MdiParent = this;

            frm.Show();
        }

        private void pedidosAcimaDaMédiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorio frm = new frmRelatorio(2);
            frm.MdiParent = this;

            frm.Show();
        }

        private void fornecedoresPorAnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmParamPedido frm = new frmParamPedido();

            frm.MdiParent = this;

            frm.Show();
        }

        private void produtosPorCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorio frm = new frmRelatorio(5);
            frm.MdiParent = this;

            frm.Show();
        }

        

        

        
        

        

        
    }
}
