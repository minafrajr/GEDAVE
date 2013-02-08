namespace Gedave
{
    partial class frmCategoria
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_descricao = new System.Windows.Forms.Label();
            this.lbl_foto = new System.Windows.Forms.Label();
            this.dgv_dados = new System.Windows.Forms.DataGridView();
            this.txt_nomecategoria = new Gedave.MeuTextBox();
            this.txt_descricao = new Gedave.MeuTextBox();
            this.ptb_fotocategoria = new System.Windows.Forms.PictureBox();
            this.btn_addfoto = new System.Windows.Forms.Button();
            this.lbl_codigo2 = new System.Windows.Forms.Label();
            this.lbl_codigo1 = new System.Windows.Forms.Label();
            this.ofd_abrirfoto = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_fotocategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_TituloForm
            // 
            this.lbl_TituloForm.Size = new System.Drawing.Size(382, 44);
            this.lbl_TituloForm.Text = "Gerenciar Categorias";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome da Categoria:";
            // 
            // lbl_descricao
            // 
            this.lbl_descricao.AutoSize = true;
            this.lbl_descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descricao.Location = new System.Drawing.Point(81, 139);
            this.lbl_descricao.Name = "lbl_descricao";
            this.lbl_descricao.Size = new System.Drawing.Size(88, 20);
            this.lbl_descricao.TabIndex = 4;
            this.lbl_descricao.Text = "Descrição: ";
            // 
            // lbl_foto
            // 
            this.lbl_foto.AutoSize = true;
            this.lbl_foto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_foto.Location = new System.Drawing.Point(517, 116);
            this.lbl_foto.Name = "lbl_foto";
            this.lbl_foto.Size = new System.Drawing.Size(159, 20);
            this.lbl_foto.TabIndex = 5;
            this.lbl_foto.Text = "Imagem da categoria";
            // 
            // dgv_dados
            // 
            this.dgv_dados.AllowUserToAddRows = false;
            this.dgv_dados.AllowUserToDeleteRows = false;
            this.dgv_dados.AllowUserToOrderColumns = true;
            this.dgv_dados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_dados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_dados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dgv_dados.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dados.Location = new System.Drawing.Point(0, 307);
            this.dgv_dados.MultiSelect = false;
            this.dgv_dados.Name = "dgv_dados";
            this.dgv_dados.ReadOnly = true;
            this.dgv_dados.Size = new System.Drawing.Size(884, 205);
            this.dgv_dados.TabIndex = 6;
            this.dgv_dados.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_dados_CellMouseClick);
            // 
            // txt_nomecategoria
            // 
            this.txt_nomecategoria.Location = new System.Drawing.Point(172, 116);
            this.txt_nomecategoria.Name = "txt_nomecategoria";
            this.txt_nomecategoria.Size = new System.Drawing.Size(100, 20);
            this.txt_nomecategoria.TabIndex = 0;
            // 
            // txt_descricao
            // 
            this.txt_descricao.Location = new System.Drawing.Point(172, 142);
            this.txt_descricao.Multiline = true;
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(256, 139);
            this.txt_descricao.TabIndex = 1;
            // 
            // ptb_fotocategoria
            // 
            this.ptb_fotocategoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptb_fotocategoria.Enabled = false;
            this.ptb_fotocategoria.Location = new System.Drawing.Point(521, 139);
            this.ptb_fotocategoria.Name = "ptb_fotocategoria";
            this.ptb_fotocategoria.Size = new System.Drawing.Size(184, 128);
            this.ptb_fotocategoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_fotocategoria.TabIndex = 9;
            this.ptb_fotocategoria.TabStop = false;
            // 
            // btn_addfoto
            // 
            this.btn_addfoto.Location = new System.Drawing.Point(521, 278);
            this.btn_addfoto.Name = "btn_addfoto";
            this.btn_addfoto.Size = new System.Drawing.Size(75, 23);
            this.btn_addfoto.TabIndex = 2;
            this.btn_addfoto.Text = "Adicionar";
            this.btn_addfoto.UseVisualStyleBackColor = true;
            this.btn_addfoto.Click += new System.EventHandler(this.btn_addfoto_Click);
            // 
            // lbl_codigo2
            // 
            this.lbl_codigo2.AutoSize = true;
            this.lbl_codigo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo2.Location = new System.Drawing.Point(168, 93);
            this.lbl_codigo2.Name = "lbl_codigo2";
            this.lbl_codigo2.Size = new System.Drawing.Size(0, 20);
            this.lbl_codigo2.TabIndex = 11;
            this.lbl_codigo2.Visible = false;
            // 
            // lbl_codigo1
            // 
            this.lbl_codigo1.AutoSize = true;
            this.lbl_codigo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo1.Location = new System.Drawing.Point(103, 93);
            this.lbl_codigo1.Name = "lbl_codigo1";
            this.lbl_codigo1.Size = new System.Drawing.Size(63, 20);
            this.lbl_codigo1.TabIndex = 12;
            this.lbl_codigo1.Text = "Código:";
            this.lbl_codigo1.Visible = false;
            // 
            // ofd_abrirfoto
            // 
            this.ofd_abrirfoto.FileName = "openFileDialog1";
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(884, 512);
            this.Controls.Add(this.lbl_codigo1);
            this.Controls.Add(this.lbl_codigo2);
            this.Controls.Add(this.txt_descricao);
            this.Controls.Add(this.dgv_dados);
            this.Controls.Add(this.ptb_fotocategoria);
            this.Controls.Add(this.lbl_descricao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nomecategoria);
            this.Controls.Add(this.btn_addfoto);
            this.Controls.Add(this.lbl_foto);
            this.Name = "frmCategoria";
            this.Controls.SetChildIndex(this.lbl_foto, 0);
            this.Controls.SetChildIndex(this.btn_addfoto, 0);
            this.Controls.SetChildIndex(this.txt_nomecategoria, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lbl_descricao, 0);
            this.Controls.SetChildIndex(this.ptb_fotocategoria, 0);
            this.Controls.SetChildIndex(this.dgv_dados, 0);
            this.Controls.SetChildIndex(this.txt_descricao, 0);
            this.Controls.SetChildIndex(this.lbl_TituloForm, 0);
            this.Controls.SetChildIndex(this.lbl_codigo2, 0);
            this.Controls.SetChildIndex(this.lbl_codigo1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_fotocategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_descricao;
        private System.Windows.Forms.Label lbl_foto;
        private System.Windows.Forms.DataGridView dgv_dados;
        private MeuTextBox txt_nomecategoria;
        private MeuTextBox txt_descricao;
        private System.Windows.Forms.PictureBox ptb_fotocategoria;
        private System.Windows.Forms.Button btn_addfoto;
        private System.Windows.Forms.Label lbl_codigo2;
        private System.Windows.Forms.Label lbl_codigo1;
        private System.Windows.Forms.OpenFileDialog ofd_abrirfoto;
    }
}
