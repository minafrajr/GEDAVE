namespace Gedave
{
    partial class frmParamPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParamPedido));
            this.btn_visualizar = new System.Windows.Forms.Button();
            this.dtp_final = new System.Windows.Forms.DateTimePicker();
            this.lbl_data1 = new System.Windows.Forms.Label();
            this.grp_parametros = new System.Windows.Forms.GroupBox();
            this.cbo_fornecedor = new Gedave.MeuComboBox();
            this.fornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsComboBox = new Gedave.dsComboBox();
            this.lbl_datainicial = new System.Windows.Forms.Label();
            this.lbl_datafinal = new System.Windows.Forms.Label();
            this.dtp_inicial = new System.Windows.Forms.DateTimePicker();
            this.fornecedoresTableAdapter = new Gedave.dsComboBoxTableAdapters.FornecedoresTableAdapter();
            this.tableAdapterManager = new Gedave.dsComboBoxTableAdapters.TableAdapterManager();
            this.grp_parametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsComboBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_visualizar
            // 
            this.btn_visualizar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_visualizar.Location = new System.Drawing.Point(218, 68);
            this.btn_visualizar.Name = "btn_visualizar";
            this.btn_visualizar.Size = new System.Drawing.Size(72, 29);
            this.btn_visualizar.TabIndex = 0;
            this.btn_visualizar.Text = "Visualizar";
            this.btn_visualizar.UseVisualStyleBackColor = false;
            this.btn_visualizar.Click += new System.EventHandler(this.btn_visualizar_Click);
            // 
            // dtp_final
            // 
            this.dtp_final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_final.Location = new System.Drawing.Point(103, 84);
            this.dtp_final.Name = "dtp_final";
            this.dtp_final.Size = new System.Drawing.Size(87, 20);
            this.dtp_final.TabIndex = 1;
            // 
            // lbl_data1
            // 
            this.lbl_data1.AutoSize = true;
            this.lbl_data1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data1.Location = new System.Drawing.Point(6, 26);
            this.lbl_data1.Name = "lbl_data1";
            this.lbl_data1.Size = new System.Drawing.Size(95, 20);
            this.lbl_data1.TabIndex = 3;
            this.lbl_data1.Text = "Fornecedor:";
            // 
            // grp_parametros
            // 
            this.grp_parametros.Controls.Add(this.cbo_fornecedor);
            this.grp_parametros.Controls.Add(this.lbl_datainicial);
            this.grp_parametros.Controls.Add(this.lbl_datafinal);
            this.grp_parametros.Controls.Add(this.lbl_data1);
            this.grp_parametros.Controls.Add(this.dtp_inicial);
            this.grp_parametros.Controls.Add(this.dtp_final);
            this.grp_parametros.Controls.Add(this.btn_visualizar);
            this.grp_parametros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_parametros.Location = new System.Drawing.Point(0, 0);
            this.grp_parametros.Name = "grp_parametros";
            this.grp_parametros.Size = new System.Drawing.Size(322, 121);
            this.grp_parametros.TabIndex = 4;
            this.grp_parametros.TabStop = false;
            this.grp_parametros.Text = "Escolha os parâmetros para o relatório";
            // 
            // cbo_fornecedor
            // 
            this.cbo_fornecedor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "NomeDaEmpresa", true));
            this.cbo_fornecedor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.fornecedoresBindingSource, "NomeDaEmpresa", true));
            this.cbo_fornecedor.DataSource = this.fornecedoresBindingSource;
            this.cbo_fornecedor.DisplayMember = "NomeDaEmpresa";
            this.cbo_fornecedor.FormattingEnabled = true;
            this.cbo_fornecedor.Location = new System.Drawing.Point(103, 24);
            this.cbo_fornecedor.Name = "cbo_fornecedor";
            this.cbo_fornecedor.Size = new System.Drawing.Size(187, 21);
            this.cbo_fornecedor.TabIndex = 7;
            this.cbo_fornecedor.ValueMember = "NomeDaEmpresa";
            // 
            // fornecedoresBindingSource
            // 
            this.fornecedoresBindingSource.DataMember = "Fornecedores";
            this.fornecedoresBindingSource.DataSource = this.dsComboBox;
            // 
            // dsComboBox
            // 
            this.dsComboBox.DataSetName = "dsComboBox";
            this.dsComboBox.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_datainicial
            // 
            this.lbl_datainicial.AutoSize = true;
            this.lbl_datainicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datainicial.Location = new System.Drawing.Point(6, 58);
            this.lbl_datainicial.Name = "lbl_datainicial";
            this.lbl_datainicial.Size = new System.Drawing.Size(92, 20);
            this.lbl_datainicial.TabIndex = 6;
            this.lbl_datainicial.Text = "Data Inicial:";
            // 
            // lbl_datafinal
            // 
            this.lbl_datafinal.AutoSize = true;
            this.lbl_datafinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datafinal.Location = new System.Drawing.Point(12, 86);
            this.lbl_datafinal.Name = "lbl_datafinal";
            this.lbl_datafinal.Size = new System.Drawing.Size(86, 20);
            this.lbl_datafinal.TabIndex = 5;
            this.lbl_datafinal.Text = "Data Final:";
            // 
            // dtp_inicial
            // 
            this.dtp_inicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_inicial.Location = new System.Drawing.Point(103, 58);
            this.dtp_inicial.Name = "dtp_inicial";
            this.dtp_inicial.Size = new System.Drawing.Size(87, 20);
            this.dtp_inicial.TabIndex = 2;
            // 
            // fornecedoresTableAdapter
            // 
            this.fornecedoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriasTableAdapter = null;
            this.tableAdapterManager.FornecedoresTableAdapter = this.fornecedoresTableAdapter;
            this.tableAdapterManager.FuncionáriosTableAdapter = null;
            this.tableAdapterManager.ProdutosTableAdapter = null;
            this.tableAdapterManager.TransportadorasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Gedave.dsComboBoxTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmParamPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(322, 121);
            this.Controls.Add(this.grp_parametros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmParamPedido";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GEDAVE- Sistema de Gestão de Venda";
            this.Load += new System.EventHandler(this.frmParamPedido_Load);
            this.grp_parametros.ResumeLayout(false);
            this.grp_parametros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsComboBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_visualizar;
        private System.Windows.Forms.DateTimePicker dtp_final;
        private System.Windows.Forms.Label lbl_data1;
        private System.Windows.Forms.GroupBox grp_parametros;
        private System.Windows.Forms.Label lbl_datainicial;
        private System.Windows.Forms.Label lbl_datafinal;
        private System.Windows.Forms.DateTimePicker dtp_inicial;
        private MeuComboBox cbo_fornecedor;
        private dsComboBox dsComboBox;
        private System.Windows.Forms.BindingSource fornecedoresBindingSource;
        private dsComboBoxTableAdapters.FornecedoresTableAdapter fornecedoresTableAdapter;
        private dsComboBoxTableAdapters.TableAdapterManager tableAdapterManager;
    }
}