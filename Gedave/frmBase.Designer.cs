namespace Gedave
{
    partial class frmBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBase));
            this.tlt_botao = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_TituloForm = new System.Windows.Forms.Label();
            this.tsm_menu = new System.Windows.Forms.ToolStrip();
            this.btn_Novo = new System.Windows.Forms.ToolStripButton();
            this.btn_Editar = new System.Windows.Forms.ToolStripButton();
            this.btn_Adicionar = new System.Windows.Forms.ToolStripButton();
            this.btn_Atualizar = new System.Windows.Forms.ToolStripButton();
            this.btn_Excluir = new System.Windows.Forms.ToolStripButton();
            this.btn_Localizar = new System.Windows.Forms.ToolStripButton();
            this.btn_cancelar = new System.Windows.Forms.ToolStripButton();
            this.btn_void1 = new System.Windows.Forms.ToolStripButton();
            this.btn_void2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Sair = new System.Windows.Forms.ToolStripButton();
            this.tsm_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlt_botao
            // 
            this.tlt_botao.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tlt_botao.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // lbl_TituloForm
            // 
            this.lbl_TituloForm.AutoSize = true;
            this.lbl_TituloForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TituloForm.Location = new System.Drawing.Point(12, 9);
            this.lbl_TituloForm.Name = "lbl_TituloForm";
            this.lbl_TituloForm.Size = new System.Drawing.Size(163, 44);
            this.lbl_TituloForm.TabIndex = 1;
            this.lbl_TituloForm.Text = "frmBase";
            // 
            // tsm_menu
            // 
            this.tsm_menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tsm_menu.BackgroundImage = global::Gedave.Properties.Resources.Sem_título1;
            this.tsm_menu.Dock = System.Windows.Forms.DockStyle.None;
            this.tsm_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Novo,
            this.btn_Editar,
            this.btn_Adicionar,
            this.btn_Atualizar,
            this.btn_Excluir,
            this.btn_Localizar,
            this.btn_cancelar,
            this.btn_void1,
            this.btn_void2,
            this.toolStripSeparator1,
            this.btn_Sair});
            this.tsm_menu.Location = new System.Drawing.Point(331, 9);
            this.tsm_menu.Name = "tsm_menu";
            this.tsm_menu.Size = new System.Drawing.Size(544, 78);
            this.tsm_menu.TabIndex = 2;
            this.tsm_menu.Text = "toolStrip1";
            // 
            // btn_Novo
            // 
            this.btn_Novo.Image = global::Gedave.Properties.Resources._278_128x128;
            this.btn_Novo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Novo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(52, 75);
            this.btn_Novo.Text = "Novo";
            this.btn_Novo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Novo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Novo.ToolTipText = "Novo";
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Editar.Image = global::Gedave.Properties.Resources.editor_0308_replace;
            this.btn_Editar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Editar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(52, 75);
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Editar.ToolTipText = "Editar";
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Adicionar.Image = global::Gedave.Properties.Resources.Add;
            this.btn_Adicionar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Adicionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(62, 75);
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Adicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Adicionar.ToolTipText = "Adicionar";
            this.btn_Adicionar.Visible = false;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Atualizar.Image = global::Gedave.Properties.Resources._8437_128x128;
            this.btn_Atualizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Atualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(57, 75);
            this.btn_Atualizar.Text = "Atualizar";
            this.btn_Atualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Atualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Atualizar.ToolTipText = "Atualizar";
            this.btn_Atualizar.Visible = false;
            this.btn_Atualizar.Click += new System.EventHandler(this.btn_Atualizar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Excluir.Image = global::Gedave.Properties.Resources.Trash;
            this.btn_Excluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Excluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(52, 75);
            this.btn_Excluir.Text = "Deletar";
            this.btn_Excluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Excluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Excluir.ToolTipText = "Deletar";
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Localizar
            // 
            this.btn_Localizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Localizar.Image = global::Gedave.Properties.Resources.Search;
            this.btn_Localizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Localizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Localizar.Name = "btn_Localizar";
            this.btn_Localizar.Size = new System.Drawing.Size(57, 75);
            this.btn_Localizar.Text = "Localizar";
            this.btn_Localizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Localizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Localizar.ToolTipText = "Localizar";
            this.btn_Localizar.Click += new System.EventHandler(this.btn_Localizar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Image = global::Gedave.Properties.Resources.prohibit_icon;
            this.btn_cancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_cancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(57, 75);
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_cancelar.ToolTipText = "Clique para Cancelar toda a operação";
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_void1
            // 
            this.btn_void1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_void1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_void1.Name = "btn_void1";
            this.btn_void1.Size = new System.Drawing.Size(23, 75);
            this.btn_void1.Text = "toolStripButton9";
            this.btn_void1.Visible = false;
            // 
            // btn_void2
            // 
            this.btn_void2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_void2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_void2.Name = "btn_void2";
            this.btn_void2.Size = new System.Drawing.Size(23, 75);
            this.btn_void2.Text = "toolStripButton10";
            this.btn_void2.Visible = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 78);
            // 
            // btn_Sair
            // 
            this.btn_Sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Sair.Image = global::Gedave.Properties.Resources.logout_icon;
            this.btn_Sair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Sair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(60, 75);
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // frmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 512);
            this.Controls.Add(this.tsm_menu);
            this.Controls.Add(this.lbl_TituloForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(1300, 690);
            this.MinimumSize = new System.Drawing.Size(250, 100);
            this.Name = "frmBase";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GEDAVE - Sistema de Gestão de Venda";
            this.Load += new System.EventHandler(this.frmBase_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBase_KeyDown);
            this.tsm_menu.ResumeLayout(false);
            this.tsm_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip tlt_botao;
        public System.Windows.Forms.Label lbl_TituloForm;
        private System.Windows.Forms.ToolStrip tsm_menu;
        private System.Windows.Forms.ToolStripButton btn_Novo;
        private System.Windows.Forms.ToolStripButton btn_Editar;
        private System.Windows.Forms.ToolStripButton btn_Localizar;
        private System.Windows.Forms.ToolStripButton btn_Adicionar;
        private System.Windows.Forms.ToolStripButton btn_Atualizar;
        private System.Windows.Forms.ToolStripButton btn_Excluir;
        private System.Windows.Forms.ToolStripButton btn_void1;
        private System.Windows.Forms.ToolStripButton btn_void2;
        private System.Windows.Forms.ToolStripButton btn_Sair;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_cancelar;
    }
}