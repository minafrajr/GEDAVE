namespace Gedave
{
    partial class frmRelatorio
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorio));
            this.PedFornecAnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRelatorios = new Gedave.dsRelatorios();
            this.VW_ListaCrescenteIdadeFuncBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VW_ClientePrecoAcimaMediaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VW_QuantVendasPaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RptCliente = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VW_QuantVendasPaisTableAdapter = new Gedave.dsRelatoriosTableAdapters.VW_QuantVendasPaisTableAdapter();
            this.VW_ClientePrecoAcimaMediaTableAdapter = new Gedave.dsRelatoriosTableAdapters.VW_ClientePrecoAcimaMediaTableAdapter();
            this.VW_ListaCrescenteIdadeFuncTableAdapter = new Gedave.dsRelatoriosTableAdapters.VW_ListaCrescenteIdadeFuncTableAdapter();
            this.PedFornecAnoTableAdapter = new Gedave.dsRelatoriosTableAdapters.PedFornecAnoTableAdapter();
            this.VW_ProdutosCategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VW_ProdutosCategoriaTableAdapter = new Gedave.dsRelatoriosTableAdapters.VW_ProdutosCategoriaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PedFornecAnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRelatorios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VW_ListaCrescenteIdadeFuncBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VW_ClientePrecoAcimaMediaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VW_QuantVendasPaisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VW_ProdutosCategoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PedFornecAnoBindingSource
            // 
            this.PedFornecAnoBindingSource.DataMember = "PedFornecAno";
            this.PedFornecAnoBindingSource.DataSource = this.dsRelatorios;
            // 
            // dsRelatorios
            // 
            this.dsRelatorios.DataSetName = "dsRelatorios";
            this.dsRelatorios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VW_ListaCrescenteIdadeFuncBindingSource
            // 
            this.VW_ListaCrescenteIdadeFuncBindingSource.DataMember = "VW_ListaCrescenteIdadeFunc";
            this.VW_ListaCrescenteIdadeFuncBindingSource.DataSource = this.dsRelatorios;
            // 
            // VW_ClientePrecoAcimaMediaBindingSource
            // 
            this.VW_ClientePrecoAcimaMediaBindingSource.DataMember = "VW_ClientePrecoAcimaMedia";
            this.VW_ClientePrecoAcimaMediaBindingSource.DataSource = this.dsRelatorios;
            // 
            // VW_QuantVendasPaisBindingSource
            // 
            this.VW_QuantVendasPaisBindingSource.DataMember = "VW_QuantVendasPais";
            this.VW_QuantVendasPaisBindingSource.DataSource = this.dsRelatorios;
            // 
            // RptCliente
            // 
            this.RptCliente.AutoSize = true;
            this.RptCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsProdutosCategoria";
            reportDataSource1.Value = this.VW_ProdutosCategoriaBindingSource;
            this.RptCliente.LocalReport.DataSources.Add(reportDataSource1);
            this.RptCliente.LocalReport.ReportEmbeddedResource = "Gedave.Relatorios.ProdutosPorCategoria.rdlc";
            this.RptCliente.Location = new System.Drawing.Point(0, 0);
            this.RptCliente.Name = "RptCliente";
            this.RptCliente.ShowBackButton = false;
            this.RptCliente.Size = new System.Drawing.Size(646, 576);
            this.RptCliente.TabIndex = 0;
            this.RptCliente.ZoomPercent = 60;
            // 
            // VW_QuantVendasPaisTableAdapter
            // 
            this.VW_QuantVendasPaisTableAdapter.ClearBeforeFill = true;
            // 
            // VW_ClientePrecoAcimaMediaTableAdapter
            // 
            this.VW_ClientePrecoAcimaMediaTableAdapter.ClearBeforeFill = true;
            // 
            // VW_ListaCrescenteIdadeFuncTableAdapter
            // 
            this.VW_ListaCrescenteIdadeFuncTableAdapter.ClearBeforeFill = true;
            // 
            // PedFornecAnoTableAdapter
            // 
            this.PedFornecAnoTableAdapter.ClearBeforeFill = true;
            // 
            // VW_ProdutosCategoriaBindingSource
            // 
            this.VW_ProdutosCategoriaBindingSource.DataMember = "VW_ProdutosCategoria";
            this.VW_ProdutosCategoriaBindingSource.DataSource = this.dsRelatorios;
            // 
            // VW_ProdutosCategoriaTableAdapter
            // 
            this.VW_ProdutosCategoriaTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 576);
            this.Controls.Add(this.RptCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GEDAVE- Sistema de Gestão de Vendas";
            this.Load += new System.EventHandler(this.frmRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PedFornecAnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRelatorios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VW_ListaCrescenteIdadeFuncBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VW_ClientePrecoAcimaMediaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VW_QuantVendasPaisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VW_ProdutosCategoriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RptCliente;
        private System.Windows.Forms.BindingSource VW_QuantVendasPaisBindingSource;
        private dsRelatorios dsRelatorios;
        private dsRelatoriosTableAdapters.VW_QuantVendasPaisTableAdapter VW_QuantVendasPaisTableAdapter;
        private System.Windows.Forms.BindingSource VW_ClientePrecoAcimaMediaBindingSource;
        private dsRelatoriosTableAdapters.VW_ClientePrecoAcimaMediaTableAdapter VW_ClientePrecoAcimaMediaTableAdapter;
        private System.Windows.Forms.BindingSource VW_ListaCrescenteIdadeFuncBindingSource;
        private dsRelatoriosTableAdapters.VW_ListaCrescenteIdadeFuncTableAdapter VW_ListaCrescenteIdadeFuncTableAdapter;
        private System.Windows.Forms.BindingSource PedFornecAnoBindingSource;
        private dsRelatoriosTableAdapters.PedFornecAnoTableAdapter PedFornecAnoTableAdapter;
        private System.Windows.Forms.BindingSource VW_ProdutosCategoriaBindingSource;
        private dsRelatoriosTableAdapters.VW_ProdutosCategoriaTableAdapter VW_ProdutosCategoriaTableAdapter;
    }
}