using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gedave.dsRelatoriosTableAdapters;
using Microsoft.Reporting.WinForms;

namespace Gedave
{
    public partial class frmRelatorio : Form
    {
        private int CodigoRelatorio;

        private string Fornecedor;
        private DateTime datainicial;
        private DateTime datafinal;

        public frmRelatorio()
        {
            InitializeComponent();
        }

        private void frmRelatorio_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dsRelatorios.VW_ProdutosCategoria'. Você pode movê-la ou removê-la conforme necessário.
            this.VW_ProdutosCategoriaTableAdapter.Fill(this.dsRelatorios.VW_ProdutosCategoria);
            // TODO: esta linha de código carrega dados na tabela 'dsRelatorios.VW_ListaCrescenteIdadeFunc'. Você pode movê-la ou removê-la conforme necessário.
            this.VW_ListaCrescenteIdadeFuncTableAdapter.Fill(this.dsRelatorios.VW_ListaCrescenteIdadeFunc);
            // TODO: esta linha de código carrega dados na tabela 'dsRelatorios.VW_ClientePrecoAcimaMedia'. Você pode movê-la ou removê-la conforme necessário.
            this.VW_ClientePrecoAcimaMediaTableAdapter.Fill(this.dsRelatorios.VW_ClientePrecoAcimaMedia);
            this.ConfiguraRelatorio();
            this.RptCliente.RefreshReport();
        }

        public frmRelatorio(int codRelat)
        {
            InitializeComponent();

            this.CodigoRelatorio = codRelat;
            this.ConfiguraRelatorio();

        }

        public frmRelatorio(int codRelat, string fornecedor, DateTime dataini, DateTime datafin)
        {
            InitializeComponent();

            this.CodigoRelatorio = codRelat;
            this.Fornecedor = fornecedor;
            this.datainicial = dataini;
            this.datafinal = datafin;
            this.ConfiguraRelatorio();

        }


        private void ConfiguraRelatorio()
        {
            string sPath = Gedave.Properties.Settings.Default.SetRelatorio;

            RptCliente.Reset();
            RptCliente.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            RptCliente.LocalReport.EnableExternalImages = true;
            RptCliente.LocalReport.EnableHyperlinks = true;
            RptCliente.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            RptCliente.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            RptCliente.LocalReport.DataSources.Clear();

            DataTable dt = new DataTable();

            ReportDataSource datasource = new ReportDataSource();


            switch (CodigoRelatorio)
            {
                case 1:
                    datasource.Name = "dsCliente";//tem q ser o mesmo dataset informado no rdlc
                    RptCliente.LocalReport.ReportPath = sPath + "RptCliente.rdlc";
                    dt = this.VW_QuantVendasPaisTableAdapter.GetData();
                    datasource.Value = dt;
                    break;

                case 2:
                    datasource.Name = "dsCliente";
                    RptCliente.LocalReport.ReportPath = sPath + "rptCliente2.rdlc";
                    dt = this.VW_ClientePrecoAcimaMediaTableAdapter.GetData();
                    datasource.Value = dt;
                    break;
                case 3:
                    datasource.Name = "dsIdadeFuncionario";
                    RptCliente.LocalReport.ReportPath = sPath + "IdadeFuncionario.rdlc";
                    dt = this.VW_ListaCrescenteIdadeFuncTableAdapter.GetData();
                    datasource.Value = dt;
                    break;
                case 4:
                    datasource.Name = "dsPedidoFornAno";
                    RptCliente.LocalReport.ReportPath = sPath + "rptPedidoFornecedorAno.rdlc";
                    dt = this.PedFornecAnoTableAdapter.GetData("%"+Fornecedor+"%", datainicial.Date, datafinal.Date);
                    datasource.Value = dt;
                    break;
                case 5:
                    datasource.Name = "dsProdutosCategoria";
                    RptCliente.LocalReport.ReportPath = sPath + "ProdutosPorCategoria.rdlc";
                    dt = this.VW_ProdutosCategoriaTableAdapter.GetData();
                    datasource.Value = dt;
                    break;

                default:
                    break;
            }

            RptCliente.LocalReport.DataSources.Add(datasource);
            RptCliente.RefreshReport();
        }
    }
}
