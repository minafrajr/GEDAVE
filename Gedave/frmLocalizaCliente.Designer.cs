namespace Gedave
{
    partial class frmLocalizaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocalizaCliente));
            this.dgv_dados = new System.Windows.Forms.DataGridView();
            this.grp_localizacliente = new System.Windows.Forms.GroupBox();
            this.rdb_cidade = new System.Windows.Forms.RadioButton();
            this.rdb_codigo = new System.Windows.Forms.RadioButton();
            this.rdb_nomempresa = new System.Windows.Forms.RadioButton();
            this.rdb_contato = new System.Windows.Forms.RadioButton();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_localiza = new System.Windows.Forms.Button();
            this.Selec = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txt_cidade = new Gedave.MeuTextBox();
            this.msk_codigo = new Gedave.MeuMskTextBox();
            this.txt_contato = new Gedave.MeuTextBox();
            this.txt_nomempresa = new Gedave.MeuTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dados)).BeginInit();
            this.grp_localizacliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_dados
            // 
            this.dgv_dados.AllowUserToAddRows = false;
            this.dgv_dados.AllowUserToDeleteRows = false;
            this.dgv_dados.AllowUserToOrderColumns = true;
            this.dgv_dados.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_dados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selec});
            this.dgv_dados.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_dados.Location = new System.Drawing.Point(0, 145);
            this.dgv_dados.Name = "dgv_dados";
            this.dgv_dados.Size = new System.Drawing.Size(716, 291);
            this.dgv_dados.TabIndex = 1;
            this.dgv_dados.Visible = false;
            this.dgv_dados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dados_CellContentClick);
            // 
            // grp_localizacliente
            // 
            this.grp_localizacliente.Controls.Add(this.rdb_cidade);
            this.grp_localizacliente.Controls.Add(this.rdb_codigo);
            this.grp_localizacliente.Controls.Add(this.rdb_nomempresa);
            this.grp_localizacliente.Controls.Add(this.rdb_contato);
            this.grp_localizacliente.Controls.Add(this.btn_ok);
            this.grp_localizacliente.Controls.Add(this.txt_cidade);
            this.grp_localizacliente.Controls.Add(this.btn_localiza);
            this.grp_localizacliente.Controls.Add(this.msk_codigo);
            this.grp_localizacliente.Controls.Add(this.txt_contato);
            this.grp_localizacliente.Controls.Add(this.txt_nomempresa);
            this.grp_localizacliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_localizacliente.Location = new System.Drawing.Point(6, 12);
            this.grp_localizacliente.Name = "grp_localizacliente";
            this.grp_localizacliente.Size = new System.Drawing.Size(698, 127);
            this.grp_localizacliente.TabIndex = 0;
            this.grp_localizacliente.TabStop = false;
            this.grp_localizacliente.Text = "Localizar Cliente";
            // 
            // rdb_cidade
            // 
            this.rdb_cidade.AutoSize = true;
            this.rdb_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_cidade.Location = new System.Drawing.Point(425, 40);
            this.rdb_cidade.Name = "rdb_cidade";
            this.rdb_cidade.Size = new System.Drawing.Size(81, 24);
            this.rdb_cidade.TabIndex = 14;
            this.rdb_cidade.TabStop = true;
            this.rdb_cidade.Text = "Cidade:";
            this.rdb_cidade.UseVisualStyleBackColor = true;
            this.rdb_cidade.CheckedChanged += new System.EventHandler(this.rdb_cidade_CheckedChanged);
            // 
            // rdb_codigo
            // 
            this.rdb_codigo.AutoSize = true;
            this.rdb_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_codigo.Location = new System.Drawing.Point(425, 70);
            this.rdb_codigo.Name = "rdb_codigo";
            this.rdb_codigo.Size = new System.Drawing.Size(81, 24);
            this.rdb_codigo.TabIndex = 13;
            this.rdb_codigo.TabStop = true;
            this.rdb_codigo.Text = "Código:";
            this.rdb_codigo.UseVisualStyleBackColor = true;
            this.rdb_codigo.CheckedChanged += new System.EventHandler(this.rdb_codigo_CheckedChanged);
            // 
            // rdb_nomempresa
            // 
            this.rdb_nomempresa.AutoSize = true;
            this.rdb_nomempresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_nomempresa.Location = new System.Drawing.Point(11, 37);
            this.rdb_nomempresa.Name = "rdb_nomempresa";
            this.rdb_nomempresa.Size = new System.Drawing.Size(163, 24);
            this.rdb_nomempresa.TabIndex = 12;
            this.rdb_nomempresa.TabStop = true;
            this.rdb_nomempresa.Text = "Nome da Empresa:";
            this.rdb_nomempresa.UseVisualStyleBackColor = true;
            this.rdb_nomempresa.CheckedChanged += new System.EventHandler(this.rdb_nomempresa_CheckedChanged);
            // 
            // rdb_contato
            // 
            this.rdb_contato.AutoSize = true;
            this.rdb_contato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_contato.Location = new System.Drawing.Point(12, 63);
            this.rdb_contato.Name = "rdb_contato";
            this.rdb_contato.Size = new System.Drawing.Size(156, 24);
            this.rdb_contato.TabIndex = 11;
            this.rdb_contato.TabStop = true;
            this.rdb_contato.Text = "Nome do Contato:";
            this.rdb_contato.UseVisualStyleBackColor = true;
            this.rdb_contato.CheckedChanged += new System.EventHandler(this.rdb_contato_CheckedChanged);
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_ok.Enabled = false;
            this.btn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.Location = new System.Drawing.Point(93, 98);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 9;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_localiza
            // 
            this.btn_localiza.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_localiza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_localiza.Location = new System.Drawing.Point(12, 98);
            this.btn_localiza.Name = "btn_localiza";
            this.btn_localiza.Size = new System.Drawing.Size(75, 23);
            this.btn_localiza.TabIndex = 8;
            this.btn_localiza.Text = "Localizar";
            this.btn_localiza.UseVisualStyleBackColor = false;
            this.btn_localiza.Click += new System.EventHandler(this.btn_localiza_Click);
            // 
            // Selec
            // 
            this.Selec.HeaderText = "Selecione";
            this.Selec.Name = "Selec";
            this.Selec.Width = 60;
            // 
            // txt_cidade
            // 
            this.txt_cidade.Enabled = false;
            this.txt_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cidade.Location = new System.Drawing.Point(506, 44);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(178, 20);
            this.txt_cidade.TabIndex = 7;
            // 
            // msk_codigo
            // 
            this.msk_codigo.Enabled = false;
            this.msk_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_codigo.Location = new System.Drawing.Point(501, 74);
            this.msk_codigo.Name = "msk_codigo";
            this.msk_codigo.Size = new System.Drawing.Size(47, 20);
            this.msk_codigo.TabIndex = 5;
            // 
            // txt_contato
            // 
            this.txt_contato.Enabled = false;
            this.txt_contato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contato.Location = new System.Drawing.Point(173, 67);
            this.txt_contato.Name = "txt_contato";
            this.txt_contato.Size = new System.Drawing.Size(232, 20);
            this.txt_contato.TabIndex = 3;
            // 
            // txt_nomempresa
            // 
            this.txt_nomempresa.Enabled = false;
            this.txt_nomempresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nomempresa.Location = new System.Drawing.Point(171, 41);
            this.txt_nomempresa.Name = "txt_nomempresa";
            this.txt_nomempresa.Size = new System.Drawing.Size(234, 20);
            this.txt_nomempresa.TabIndex = 1;
            // 
            // frmLocalizaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(716, 436);
            this.ControlBox = false;
            this.Controls.Add(this.grp_localizacliente);
            this.Controls.Add(this.dgv_dados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLocalizaCliente";
            this.Text = "GEDAVE -Sistema de Gestão de Venda";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dados)).EndInit();
            this.grp_localizacliente.ResumeLayout(false);
            this.grp_localizacliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_dados;
        private System.Windows.Forms.GroupBox grp_localizacliente;
        private MeuTextBox txt_nomempresa;
        private MeuMskTextBox msk_codigo;
        private MeuTextBox txt_contato;
        private System.Windows.Forms.Button btn_localiza;
        private System.Windows.Forms.Button btn_ok;
        private MeuTextBox txt_cidade;
        private System.Windows.Forms.RadioButton rdb_contato;
        private System.Windows.Forms.RadioButton rdb_cidade;
        private System.Windows.Forms.RadioButton rdb_codigo;
        private System.Windows.Forms.RadioButton rdb_nomempresa;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selec;
    }
}