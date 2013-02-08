namespace Gedave
{
    partial class frmPedidos2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedidos2));
            this.tab_vendas = new System.Windows.Forms.TabControl();
            this.tab_itenspedidos = new System.Windows.Forms.TabPage();
            this.dgv_itens = new System.Windows.Forms.DataGridView();
            this.Selecao = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lbl_titulotab = new System.Windows.Forms.Label();
            this.lbl_selecionarcategoria = new System.Windows.Forms.Label();
            this.cbo_categoria = new Gedave.MeuComboBox();
            this.fornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsComboBox = new Gedave.dsComboBox();
            this.categoriasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tab_confere = new System.Windows.Forms.TabPage();
            this.lbl_totalparcial = new System.Windows.Forms.Label();
            this.lbl_totalparcialvenda = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.dgv_confere = new System.Windows.Forms.DataGridView();
            this.Selec = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tab_identificacao = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.grp_endereço = new System.Windows.Forms.GroupBox();
            this.lbl_numerologradour = new System.Windows.Forms.Label();
            this.txt_numero = new Gedave.MeuTextBox();
            this.cbo_regiao = new Gedave.MeuComboBox();
            this.txt_bairro = new Gedave.MeuTextBox();
            this.lbl_logradouro = new System.Windows.Forms.Label();
            this.lbl_bairro = new System.Windows.Forms.Label();
            this.cbo_pais = new Gedave.MeuComboBox();
            this.cbo_tipolograd = new Gedave.MeuComboBox();
            this.msk_fax = new Gedave.MeuMskTextBox();
            this.msk_telefone = new Gedave.MeuMskTextBox();
            this.lbl_fax = new System.Windows.Forms.Label();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.lbl_pais = new System.Windows.Forms.Label();
            this.lbl_regiao = new System.Windows.Forms.Label();
            this.txt_cidade = new Gedave.MeuTextBox();
            this.lbl_cidade = new System.Windows.Forms.Label();
            this.txt_logradouro = new Gedave.MeuTextBox();
            this.lbl_tipolograd = new System.Windows.Forms.Label();
            this.msk_cep = new Gedave.MeuMskTextBox();
            this.btn_busca = new System.Windows.Forms.Button();
            this.lbl_cep = new System.Windows.Forms.Label();
            this.lbl_valorvenda = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.grp_identificacao = new System.Windows.Forms.GroupBox();
            this.cbo_funcionario = new Gedave.MeuComboBox();
            this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_novocliente = new System.Windows.Forms.Button();
            this.txt_cliente = new Gedave.MeuTextBox();
            this.txt_destinatario = new Gedave.MeuTextBox();
            this.btn_localizacliente = new System.Windows.Forms.Button();
            this.btn_copiacliente = new System.Windows.Forms.Button();
            this.grp_datas = new System.Windows.Forms.GroupBox();
            this.dtp_envio = new System.Windows.Forms.DateTimePicker();
            this.dtp_entrega = new System.Windows.Forms.DateTimePicker();
            this.dtp_pedido = new System.Windows.Forms.DateTimePicker();
            this.lbl_pedido = new System.Windows.Forms.Label();
            this.lbl_entrega = new System.Windows.Forms.Label();
            this.lbl_envio = new System.Windows.Forms.Label();
            this.lbl_destinatario = new System.Windows.Forms.Label();
            this.msk_frete = new Gedave.MeuMskTextBox();
            this.lbl_frete = new System.Windows.Forms.Label();
            this.cbo_transportadora = new Gedave.MeuComboBox();
            this.transportadorasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_funcionario = new System.Windows.Forms.Label();
            this.lbl_transportadora = new System.Windows.Forms.Label();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.lbl_numeropedido = new System.Windows.Forms.Label();
            this.lbl_pedidonumero = new System.Windows.Forms.Label();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transportadorasTableAdapter = new Gedave.dsComboBoxTableAdapters.TransportadorasTableAdapter();
            this.funcionariosTableAdapter = new Gedave.dsComboBoxTableAdapters.FuncionáriosTableAdapter();
            this.tlt_formulariopedido = new System.Windows.Forms.ToolTip(this.components);
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosTableAdapter = new Gedave.dsComboBoxTableAdapters.ProdutosTableAdapter();
            this.categoriasTableAdapter = new Gedave.dsComboBoxTableAdapters.CategoriasTableAdapter();
            this.tsm_menu = new System.Windows.Forms.ToolStrip();
            this.btn_Novopedido = new System.Windows.Forms.ToolStripButton();
            this.btn_conferirpedidos = new System.Windows.Forms.ToolStripButton();
            this.btn_excluirpedido = new System.Windows.Forms.ToolStripButton();
            this.btn_comprador = new System.Windows.Forms.ToolStripButton();
            this.btn_concluirpedido = new System.Windows.Forms.ToolStripButton();
            this.btn_cancelar = new System.Windows.Forms.ToolStripButton();
            this.btn_void1 = new System.Windows.Forms.ToolStripButton();
            this.btn_void2 = new System.Windows.Forms.ToolStripButton();
            this.tss_separador = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Sair = new System.Windows.Forms.ToolStripButton();
            this.fornecedoresTableAdapter = new Gedave.dsComboBoxTableAdapters.FornecedoresTableAdapter();
            this.tableAdapterManager = new Gedave.dsComboBoxTableAdapters.TableAdapterManager();
            this.fKProdutosCategoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKProdutosCategoriasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tab_vendas.SuspendLayout();
            this.tab_itenspedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource1)).BeginInit();
            this.tab_confere.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_confere)).BeginInit();
            this.tab_identificacao.SuspendLayout();
            this.grp_endereço.SuspendLayout();
            this.grp_identificacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
            this.grp_datas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transportadorasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            this.tsm_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKProdutosCategoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProdutosCategoriasBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_vendas
            // 
            this.tab_vendas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_vendas.Controls.Add(this.tab_itenspedidos);
            this.tab_vendas.Controls.Add(this.tab_confere);
            this.tab_vendas.Controls.Add(this.tab_identificacao);
            this.tab_vendas.HotTrack = true;
            this.tab_vendas.Location = new System.Drawing.Point(0, -2);
            this.tab_vendas.Name = "tab_vendas";
            this.tab_vendas.SelectedIndex = 0;
            this.tab_vendas.Size = new System.Drawing.Size(1022, 516);
            this.tab_vendas.TabIndex = 0;
            this.tab_vendas.TabStop = false;
            this.tab_vendas.Selected += new System.Windows.Forms.TabControlEventHandler(this.tab_vendas_Selected);
            // 
            // tab_itenspedidos
            // 
            this.tab_itenspedidos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tab_itenspedidos.Controls.Add(this.dgv_itens);
            this.tab_itenspedidos.Controls.Add(this.lbl_titulotab);
            this.tab_itenspedidos.Controls.Add(this.lbl_selecionarcategoria);
            this.tab_itenspedidos.Controls.Add(this.cbo_categoria);
            this.tab_itenspedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_itenspedidos.Location = new System.Drawing.Point(4, 22);
            this.tab_itenspedidos.Name = "tab_itenspedidos";
            this.tab_itenspedidos.Padding = new System.Windows.Forms.Padding(3);
            this.tab_itenspedidos.Size = new System.Drawing.Size(1014, 490);
            this.tab_itenspedidos.TabIndex = 1;
            this.tab_itenspedidos.Text = "Itens do Pedido";
            this.tab_itenspedidos.ToolTipText = "Selecionar os itens do pedido";
            // 
            // dgv_itens
            // 
            this.dgv_itens.AllowUserToAddRows = false;
            this.dgv_itens.AllowUserToDeleteRows = false;
            this.dgv_itens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_itens.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_itens.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_itens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_itens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_itens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selecao});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_itens.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_itens.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_itens.Location = new System.Drawing.Point(3, 136);
            this.dgv_itens.Name = "dgv_itens";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_itens.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_itens.Size = new System.Drawing.Size(1008, 351);
            this.dgv_itens.TabIndex = 3;
            this.dgv_itens.Visible = false;
            this.dgv_itens.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_itens_CellContentClick);
            // 
            // Selecao
            // 
            this.Selecao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Selecao.HeaderText = "Selecionado";
            this.Selecao.Name = "Selecao";
            this.Selecao.ToolTipText = "Clique para escolher o produto";
            this.Selecao.Width = 72;
            // 
            // lbl_titulotab
            // 
            this.lbl_titulotab.AutoSize = true;
            this.lbl_titulotab.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulotab.Location = new System.Drawing.Point(3, 3);
            this.lbl_titulotab.Name = "lbl_titulotab";
            this.lbl_titulotab.Size = new System.Drawing.Size(279, 31);
            this.lbl_titulotab.TabIndex = 2;
            this.lbl_titulotab.Text = "Seleção dos Produtos";
            // 
            // lbl_selecionarcategoria
            // 
            this.lbl_selecionarcategoria.AutoSize = true;
            this.lbl_selecionarcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selecionarcategoria.Location = new System.Drawing.Point(42, 50);
            this.lbl_selecionarcategoria.Name = "lbl_selecionarcategoria";
            this.lbl_selecionarcategoria.Size = new System.Drawing.Size(169, 20);
            this.lbl_selecionarcategoria.TabIndex = 1;
            this.lbl_selecionarcategoria.Text = "Selecione a Categoria:";
            this.lbl_selecionarcategoria.Visible = false;
            // 
            // cbo_categoria
            // 
            this.cbo_categoria.BackColor = System.Drawing.Color.White;
            this.cbo_categoria.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.fornecedoresBindingSource, "NomeDaEmpresa", true));
            this.cbo_categoria.DataSource = this.categoriasBindingSource1;
            this.cbo_categoria.DisplayMember = "NomeDaCategoria";
            this.cbo_categoria.FormattingEnabled = true;
            this.cbo_categoria.Location = new System.Drawing.Point(217, 52);
            this.cbo_categoria.Name = "cbo_categoria";
            this.cbo_categoria.Size = new System.Drawing.Size(144, 21);
            this.cbo_categoria.TabIndex = 0;
            this.cbo_categoria.ValueMember = "CódigoDaCategoria";
            this.cbo_categoria.Visible = false;
            this.cbo_categoria.SelectedIndexChanged += new System.EventHandler(this.meuComboBox3_SelectedIndexChanged);
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
            // categoriasBindingSource1
            // 
            this.categoriasBindingSource1.DataMember = "Categorias";
            this.categoriasBindingSource1.DataSource = this.dsComboBox;
            // 
            // tab_confere
            // 
            this.tab_confere.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tab_confere.Controls.Add(this.lbl_totalparcial);
            this.tab_confere.Controls.Add(this.lbl_totalparcialvenda);
            this.tab_confere.Controls.Add(this.lbl_titulo);
            this.tab_confere.Controls.Add(this.dgv_confere);
            this.tab_confere.Location = new System.Drawing.Point(4, 22);
            this.tab_confere.Name = "tab_confere";
            this.tab_confere.Padding = new System.Windows.Forms.Padding(3);
            this.tab_confere.Size = new System.Drawing.Size(1014, 490);
            this.tab_confere.TabIndex = 2;
            this.tab_confere.Text = "Conferência";
            // 
            // lbl_totalparcial
            // 
            this.lbl_totalparcial.AutoSize = true;
            this.lbl_totalparcial.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalparcial.Location = new System.Drawing.Point(95, 34);
            this.lbl_totalparcial.Name = "lbl_totalparcial";
            this.lbl_totalparcial.Size = new System.Drawing.Size(49, 31);
            this.lbl_totalparcial.TabIndex = 39;
            this.lbl_totalparcial.Text = "R$";
            // 
            // lbl_totalparcialvenda
            // 
            this.lbl_totalparcialvenda.AutoSize = true;
            this.lbl_totalparcialvenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalparcialvenda.Location = new System.Drawing.Point(6, 34);
            this.lbl_totalparcialvenda.Name = "lbl_totalparcialvenda";
            this.lbl_totalparcialvenda.Size = new System.Drawing.Size(83, 31);
            this.lbl_totalparcialvenda.TabIndex = 38;
            this.lbl_totalparcialvenda.Text = "Total:";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(3, 3);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(317, 31);
            this.lbl_titulo.TabIndex = 1;
            this.lbl_titulo.Text = "Conferência dos Pedidos";
            // 
            // dgv_confere
            // 
            this.dgv_confere.AllowUserToAddRows = false;
            this.dgv_confere.AllowUserToDeleteRows = false;
            this.dgv_confere.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_confere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_confere.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selec});
            this.dgv_confere.Location = new System.Drawing.Point(3, 85);
            this.dgv_confere.Name = "dgv_confere";
            this.dgv_confere.Size = new System.Drawing.Size(1008, 402);
            this.dgv_confere.TabIndex = 0;
            // 
            // Selec
            // 
            this.Selec.HeaderText = "Selecionar";
            this.Selec.Name = "Selec";
            this.Selec.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Selec.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tab_identificacao
            // 
            this.tab_identificacao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tab_identificacao.Controls.Add(this.label1);
            this.tab_identificacao.Controls.Add(this.grp_endereço);
            this.tab_identificacao.Controls.Add(this.lbl_valorvenda);
            this.tab_identificacao.Controls.Add(this.lbl_total);
            this.tab_identificacao.Controls.Add(this.grp_identificacao);
            this.tab_identificacao.Controls.Add(this.lbl_numeropedido);
            this.tab_identificacao.Controls.Add(this.lbl_pedidonumero);
            this.tab_identificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_identificacao.Location = new System.Drawing.Point(4, 22);
            this.tab_identificacao.Name = "tab_identificacao";
            this.tab_identificacao.Padding = new System.Windows.Forms.Padding(3);
            this.tab_identificacao.Size = new System.Drawing.Size(1014, 490);
            this.tab_identificacao.TabIndex = 0;
            this.tab_identificacao.Text = "Comprador";
            this.tab_identificacao.ToolTipText = "Identificação do Comprador";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 31);
            this.label1.TabIndex = 39;
            this.label1.Text = "Identificação do Comprador";
            // 
            // grp_endereço
            // 
            this.grp_endereço.Controls.Add(this.lbl_numerologradour);
            this.grp_endereço.Controls.Add(this.txt_numero);
            this.grp_endereço.Controls.Add(this.cbo_regiao);
            this.grp_endereço.Controls.Add(this.txt_bairro);
            this.grp_endereço.Controls.Add(this.lbl_logradouro);
            this.grp_endereço.Controls.Add(this.lbl_bairro);
            this.grp_endereço.Controls.Add(this.cbo_pais);
            this.grp_endereço.Controls.Add(this.cbo_tipolograd);
            this.grp_endereço.Controls.Add(this.msk_fax);
            this.grp_endereço.Controls.Add(this.msk_telefone);
            this.grp_endereço.Controls.Add(this.lbl_fax);
            this.grp_endereço.Controls.Add(this.lbl_telefone);
            this.grp_endereço.Controls.Add(this.lbl_pais);
            this.grp_endereço.Controls.Add(this.lbl_regiao);
            this.grp_endereço.Controls.Add(this.txt_cidade);
            this.grp_endereço.Controls.Add(this.lbl_cidade);
            this.grp_endereço.Controls.Add(this.txt_logradouro);
            this.grp_endereço.Controls.Add(this.lbl_tipolograd);
            this.grp_endereço.Controls.Add(this.msk_cep);
            this.grp_endereço.Controls.Add(this.btn_busca);
            this.grp_endereço.Controls.Add(this.lbl_cep);
            this.grp_endereço.Location = new System.Drawing.Point(12, 273);
            this.grp_endereço.Name = "grp_endereço";
            this.grp_endereço.Size = new System.Drawing.Size(779, 120);
            this.grp_endereço.TabIndex = 38;
            this.grp_endereço.TabStop = false;
            this.grp_endereço.Text = "Endereço de Entrega";
            // 
            // lbl_numerologradour
            // 
            this.lbl_numerologradour.AutoSize = true;
            this.lbl_numerologradour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numerologradour.Location = new System.Drawing.Point(462, 52);
            this.lbl_numerologradour.Name = "lbl_numerologradour";
            this.lbl_numerologradour.Size = new System.Drawing.Size(30, 20);
            this.lbl_numerologradour.TabIndex = 85;
            this.lbl_numerologradour.Text = "Nº:";
            this.lbl_numerologradour.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_numero
            // 
            this.txt_numero.Enabled = false;
            this.txt_numero.Location = new System.Drawing.Point(494, 51);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(48, 20);
            this.txt_numero.TabIndex = 69;
            // 
            // cbo_regiao
            // 
            this.cbo_regiao.AutoCompleteCustomSource.AddRange(new string[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.cbo_regiao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbo_regiao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_regiao.Enabled = false;
            this.cbo_regiao.FormattingEnabled = true;
            this.cbo_regiao.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.cbo_regiao.Location = new System.Drawing.Point(268, 80);
            this.cbo_regiao.Name = "cbo_regiao";
            this.cbo_regiao.Size = new System.Drawing.Size(65, 21);
            this.cbo_regiao.TabIndex = 72;
            // 
            // txt_bairro
            // 
            this.txt_bairro.Enabled = false;
            this.txt_bairro.Location = new System.Drawing.Point(603, 51);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(155, 20);
            this.txt_bairro.TabIndex = 70;
            // 
            // lbl_logradouro
            // 
            this.lbl_logradouro.AutoSize = true;
            this.lbl_logradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logradouro.Location = new System.Drawing.Point(158, 52);
            this.lbl_logradouro.Name = "lbl_logradouro";
            this.lbl_logradouro.Size = new System.Drawing.Size(49, 20);
            this.lbl_logradouro.TabIndex = 83;
            this.lbl_logradouro.Text = "Logr.:";
            this.lbl_logradouro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_bairro
            // 
            this.lbl_bairro.AutoSize = true;
            this.lbl_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bairro.Location = new System.Drawing.Point(547, 52);
            this.lbl_bairro.Name = "lbl_bairro";
            this.lbl_bairro.Size = new System.Drawing.Size(55, 20);
            this.lbl_bairro.TabIndex = 84;
            this.lbl_bairro.Text = "Bairro:";
            this.lbl_bairro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbo_pais
            // 
            this.cbo_pais.AutoCompleteCustomSource.AddRange(new string[] {
            "Afghanistan",
            "Albania",
            "Algeria",
            "American Samoa",
            "Andorra",
            "Angola",
            "Anguilla",
            "Antarctica",
            "Antigua and Barbuda",
            "Argentina",
            "Armenia",
            "Aruba",
            "Australia",
            "Austria",
            "Azerbaidjan",
            "Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bermuda",
            "Bhutan",
            "Bolivia",
            "Bosnia-Herzegovina",
            "Botswana",
            "Bouvet Island",
            "Brasil",
            "British Indian Ocean Territory",
            "Brunei Darussalam",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Cape Verde",
            "Cayman Islands",
            "Central African Republic",
            "Chad",
            "Chile",
            "China",
            "Christmas Island",
            "Cocos (Keeling) Islands",
            "Colombia",
            "Comoros",
            "Congo",
            "Cook Islands",
            "Costa Rica",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czech Republic",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "East Timor",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Ethiopia",
            "Falkland Islands",
            "Faroe Islands",
            "Fiji",
            "Finland",
            "Former Czechoslovakia",
            "Former USSR",
            "France",
            "France (European Territory)",
            "French Guyana",
            "French Southern Territories",
            "Gabon",
            "Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Gibraltar",
            "Great Britain",
            "Greece",
            "Greenland",
            "Grenada",
            "Guadeloupe (French)",
            "Guam (USA)",
            "Guatemala",
            "Guinea",
            "Guinea Bissau",
            "Guyana",
            "Haiti",
            "Heard and McDonald Islands",
            "Honduras",
            "Hong Kong",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "International",
            "Iran",
            "Iraq",
            "Ireland",
            "Israel",
            "Italy",
            "Ivory Coast (Cote D\'Ivoire)",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Macau",
            "Macedonia",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Martinique (French)",
            "Mauritania",
            "Mauritius",
            "Mayotte",
            "Mexico",
            "Micronesia",
            "Moldavia",
            "Monaco",
            "Mongolia",
            "Montserrat",
            "Morocco",
            "Mozambique",
            "Myanmar",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "Netherlands Antilles",
            "Neutral Zone",
            "New Caledonia (French)",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "Niue",
            "Norfolk Island",
            "Northern Mariana Islands",
            "North Korea",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Pitcairn Island",
            "Poland",
            "Polynesia (French)",
            "Portugal",
            "Puerto Rico",
            "Qatar",
            "Reunion (French)",
            "Romania",
            "Russian Federation",
            "Rwanda",
            "Saint Helena",
            "Saint Kitts & Nevis Anguilla",
            "Saint Lucia",
            "Saint Pierre and Miquelon",
            "Saint Tome (Sao Tome) and Principe",
            "Saint Vincent & Grenadines",
            "Samoa",
            "San Marino",
            "Saudi Arabia",
            "Senegal",
            "Seychelles",
            "S. Georgia & S. Sandwich Isls.",
            "Sierra Leone",
            "Singapore",
            "Slovak Republic",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "South Korea",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Suriname",
            "Svalbard and Jan Mayen Islands",
            "Swaziland",
            "Sweden",
            "Switzerland",
            "Syria",
            "Tadjikistan",
            "Taiwan",
            "Tanzania",
            "Thailand",
            "Togo",
            "Tokelau",
            "Tonga",
            "Trinidad and Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Turks and Caicos Islands",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom",
            "United States",
            "Uruguay",
            "USA Military",
            "USA Minor Outlying Islands",
            "Uzbekistan",
            "Vanuatu",
            "Vatican City State",
            "Venezuela",
            "Vietnam",
            "Virgin Islands (British)",
            "Virgin Islands (USA)",
            "Wallis and Futuna Islands",
            "Western Sahara",
            "Yemen",
            "Yugoslavia",
            "Zaire",
            "Zambia",
            "Zimbabwe"});
            this.cbo_pais.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbo_pais.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_pais.Enabled = false;
            this.cbo_pais.FormattingEnabled = true;
            this.cbo_pais.Items.AddRange(new object[] {
            "Afghanistan",
            "Albania",
            "Algeria",
            "American Samoa",
            "Andorra",
            "Angola",
            "Anguilla",
            "Antarctica",
            "Antigua and Barbuda",
            "Argentina",
            "Armenia",
            "Aruba",
            "Australia",
            "Austria",
            "Azerbaidjan",
            "Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bermuda",
            "Bhutan",
            "Bolivia",
            "Bosnia-Herzegovina",
            "Botswana",
            "Bouvet Island",
            "Brasil",
            "British Indian Ocean Territory",
            "Brunei Darussalam",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Cape Verde",
            "Cayman Islands",
            "Central African Republic",
            "Chad",
            "Chile",
            "China",
            "Christmas Island",
            "Cocos (Keeling) Islands",
            "Colombia",
            "Comoros",
            "Congo",
            "Cook Islands",
            "Costa Rica",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czech Republic",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "East Timor",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Ethiopia",
            "Falkland Islands",
            "Faroe Islands",
            "Fiji",
            "Finland",
            "Former Czechoslovakia",
            "Former USSR",
            "France",
            "France (European Territory)",
            "French Guyana",
            "French Southern Territories",
            "Gabon",
            "Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Gibraltar",
            "Great Britain",
            "Greece",
            "Greenland",
            "Grenada",
            "Guadeloupe (French)",
            "Guam (USA)",
            "Guatemala",
            "Guinea",
            "Guinea Bissau",
            "Guyana",
            "Haiti",
            "Heard and McDonald Islands",
            "Honduras",
            "Hong Kong",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "International",
            "Iran",
            "Iraq",
            "Ireland",
            "Israel",
            "Italy",
            "Ivory Coast (Cote D\'Ivoire)",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Macau",
            "Macedonia",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Martinique (French)",
            "Mauritania",
            "Mauritius",
            "Mayotte",
            "Mexico",
            "Micronesia",
            "Moldavia",
            "Monaco",
            "Mongolia",
            "Montserrat",
            "Morocco",
            "Mozambique",
            "Myanmar",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "Netherlands Antilles",
            "Neutral Zone",
            "New Caledonia (French)",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "Niue",
            "Norfolk Island",
            "Northern Mariana Islands",
            "North Korea",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Pitcairn Island",
            "Poland",
            "Polynesia (French)",
            "Portugal",
            "Puerto Rico",
            "Qatar",
            "Reunion (French)",
            "Romania",
            "Russian Federation",
            "Rwanda",
            "Saint Helena",
            "Saint Kitts & Nevis Anguilla",
            "Saint Lucia",
            "Saint Pierre and Miquelon",
            "Saint Tome (Sao Tome) and Principe",
            "Saint Vincent & Grenadines",
            "Samoa",
            "San Marino",
            "Saudi Arabia",
            "Senegal",
            "Seychelles",
            "S. Georgia & S. Sandwich Isls.",
            "Sierra Leone",
            "Singapore",
            "Slovak Republic",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "South Korea",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Suriname",
            "Svalbard and Jan Mayen Islands",
            "Swaziland",
            "Sweden",
            "Switzerland",
            "Syria",
            "Tadjikistan",
            "Taiwan",
            "Tanzania",
            "Thailand",
            "Togo",
            "Tokelau",
            "Tonga",
            "Trinidad and Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Turks and Caicos Islands",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom",
            "United States",
            "Uruguay",
            "USA Military",
            "USA Minor Outlying Islands",
            "Uzbekistan",
            "Vanuatu",
            "Vatican City State",
            "Venezuela",
            "Vietnam",
            "Virgin Islands (British)",
            "Virgin Islands (USA)",
            "Wallis and Futuna Islands",
            "Western Sahara",
            "Yemen",
            "Yugoslavia",
            "Zaire",
            "Zambia",
            "Zimbabwe"});
            this.cbo_pais.Location = new System.Drawing.Point(382, 79);
            this.cbo_pais.Name = "cbo_pais";
            this.cbo_pais.Size = new System.Drawing.Size(112, 21);
            this.cbo_pais.TabIndex = 73;
            this.cbo_pais.Text = "Brasil";
            // 
            // cbo_tipolograd
            // 
            this.cbo_tipolograd.AutoCompleteCustomSource.AddRange(new string[] {
            "Alameda",
            "Avenida",
            "Beco",
            "Boulevard",
            "Caminho",
            "Cais",
            "Campo",
            "Escada",
            "Estrada",
            "Favela",
            "Fazenda",
            "Floresta",
            "Ilha",
            "Jardim",
            "Ladeira",
            "Largo",
            "Loteamento",
            "Lugar",
            "Morro",
            "Parque",
            "Passeio",
            "Praia",
            "Praça",
            "Recanto",
            "Rodovia",
            "Rua",
            "Servidao",
            "Travessa",
            "Via",
            "Vila"});
            this.cbo_tipolograd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbo_tipolograd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_tipolograd.Enabled = false;
            this.cbo_tipolograd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbo_tipolograd.FormattingEnabled = true;
            this.cbo_tipolograd.Items.AddRange(new object[] {
            "Alameda",
            "Avenida",
            "Beco",
            "Boulevard",
            "Caminho",
            "Cais",
            "Campo",
            "Escada",
            "Estrada",
            "Favela",
            "Fazenda",
            "Floresta",
            "Ilha",
            "Jardim",
            "Ladeira",
            "Largo",
            "Loteamento",
            "Lugar",
            "Morro",
            "Parque",
            "Passeio",
            "Praia",
            "Praça",
            "Recanto",
            "Rodovia",
            "Rua",
            "Servidao",
            "Travessa",
            "Via",
            "Vila"});
            this.cbo_tipolograd.Location = new System.Drawing.Point(70, 51);
            this.cbo_tipolograd.Name = "cbo_tipolograd";
            this.cbo_tipolograd.Size = new System.Drawing.Size(79, 21);
            this.cbo_tipolograd.TabIndex = 67;
            // 
            // msk_fax
            // 
            this.msk_fax.Enabled = false;
            this.msk_fax.Location = new System.Drawing.Point(696, 82);
            this.msk_fax.Mask = "(99) 000-0000";
            this.msk_fax.Name = "msk_fax";
            this.msk_fax.Size = new System.Drawing.Size(75, 20);
            this.msk_fax.TabIndex = 75;
            // 
            // msk_telefone
            // 
            this.msk_telefone.Enabled = false;
            this.msk_telefone.Location = new System.Drawing.Point(575, 81);
            this.msk_telefone.Mask = "(99) 000-0000";
            this.msk_telefone.Name = "msk_telefone";
            this.msk_telefone.Size = new System.Drawing.Size(75, 20);
            this.msk_telefone.TabIndex = 74;
            // 
            // lbl_fax
            // 
            this.lbl_fax.AutoSize = true;
            this.lbl_fax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fax.Location = new System.Drawing.Point(659, 81);
            this.lbl_fax.Name = "lbl_fax";
            this.lbl_fax.Size = new System.Drawing.Size(39, 20);
            this.lbl_fax.TabIndex = 82;
            this.lbl_fax.Text = "Fax:";
            this.lbl_fax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefone.Location = new System.Drawing.Point(500, 81);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(75, 20);
            this.lbl_telefone.TabIndex = 81;
            this.lbl_telefone.Text = "Telefone:";
            this.lbl_telefone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_pais
            // 
            this.lbl_pais.AutoSize = true;
            this.lbl_pais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pais.Location = new System.Drawing.Point(338, 80);
            this.lbl_pais.Name = "lbl_pais";
            this.lbl_pais.Size = new System.Drawing.Size(43, 20);
            this.lbl_pais.TabIndex = 80;
            this.lbl_pais.Text = "País:";
            this.lbl_pais.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_regiao
            // 
            this.lbl_regiao.AutoSize = true;
            this.lbl_regiao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_regiao.Location = new System.Drawing.Point(205, 81);
            this.lbl_regiao.Name = "lbl_regiao";
            this.lbl_regiao.Size = new System.Drawing.Size(64, 20);
            this.lbl_regiao.TabIndex = 79;
            this.lbl_regiao.Text = "Região:";
            this.lbl_regiao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_cidade
            // 
            this.txt_cidade.Enabled = false;
            this.txt_cidade.Location = new System.Drawing.Point(70, 80);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(133, 20);
            this.txt_cidade.TabIndex = 71;
            // 
            // lbl_cidade
            // 
            this.lbl_cidade.AutoSize = true;
            this.lbl_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cidade.Location = new System.Drawing.Point(3, 81);
            this.lbl_cidade.Name = "lbl_cidade";
            this.lbl_cidade.Size = new System.Drawing.Size(63, 20);
            this.lbl_cidade.TabIndex = 78;
            this.lbl_cidade.Text = "Cidade:";
            this.lbl_cidade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_logradouro
            // 
            this.txt_logradouro.Enabled = false;
            this.txt_logradouro.Location = new System.Drawing.Point(208, 52);
            this.txt_logradouro.Name = "txt_logradouro";
            this.txt_logradouro.Size = new System.Drawing.Size(243, 20);
            this.txt_logradouro.TabIndex = 68;
            // 
            // lbl_tipolograd
            // 
            this.lbl_tipolograd.AutoSize = true;
            this.lbl_tipolograd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipolograd.Location = new System.Drawing.Point(22, 52);
            this.lbl_tipolograd.Name = "lbl_tipolograd";
            this.lbl_tipolograd.Size = new System.Drawing.Size(43, 20);
            this.lbl_tipolograd.TabIndex = 77;
            this.lbl_tipolograd.Text = "Tipo:";
            this.lbl_tipolograd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // msk_cep
            // 
            this.msk_cep.Enabled = false;
            this.msk_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_cep.HidePromptOnLeave = true;
            this.msk_cep.Location = new System.Drawing.Point(70, 23);
            this.msk_cep.Margin = new System.Windows.Forms.Padding(0);
            this.msk_cep.Mask = "99999-999";
            this.msk_cep.Name = "msk_cep";
            this.msk_cep.Size = new System.Drawing.Size(63, 20);
            this.msk_cep.TabIndex = 65;
            this.msk_cep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btn_busca
            // 
            this.btn_busca.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_busca.Location = new System.Drawing.Point(135, 21);
            this.btn_busca.Name = "btn_busca";
            this.btn_busca.Size = new System.Drawing.Size(68, 25);
            this.btn_busca.TabIndex = 66;
            this.btn_busca.Text = "Buscar";
            this.btn_busca.UseVisualStyleBackColor = false;
            this.btn_busca.Click += new System.EventHandler(this.btn_busca_Click);
            // 
            // lbl_cep
            // 
            this.lbl_cep.AutoSize = true;
            this.lbl_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cep.Location = new System.Drawing.Point(22, 23);
            this.lbl_cep.Name = "lbl_cep";
            this.lbl_cep.Size = new System.Drawing.Size(45, 20);
            this.lbl_cep.TabIndex = 76;
            this.lbl_cep.Text = "CEP:";
            this.lbl_cep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_valorvenda
            // 
            this.lbl_valorvenda.AutoSize = true;
            this.lbl_valorvenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valorvenda.Location = new System.Drawing.Point(832, 435);
            this.lbl_valorvenda.Name = "lbl_valorvenda";
            this.lbl_valorvenda.Size = new System.Drawing.Size(49, 31);
            this.lbl_valorvenda.TabIndex = 37;
            this.lbl_valorvenda.Text = "R$";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(743, 435);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(83, 31);
            this.lbl_total.TabIndex = 36;
            this.lbl_total.Text = "Total:";
            // 
            // grp_identificacao
            // 
            this.grp_identificacao.Controls.Add(this.cbo_funcionario);
            this.grp_identificacao.Controls.Add(this.btn_novocliente);
            this.grp_identificacao.Controls.Add(this.txt_cliente);
            this.grp_identificacao.Controls.Add(this.txt_destinatario);
            this.grp_identificacao.Controls.Add(this.btn_localizacliente);
            this.grp_identificacao.Controls.Add(this.btn_copiacliente);
            this.grp_identificacao.Controls.Add(this.grp_datas);
            this.grp_identificacao.Controls.Add(this.lbl_destinatario);
            this.grp_identificacao.Controls.Add(this.msk_frete);
            this.grp_identificacao.Controls.Add(this.lbl_frete);
            this.grp_identificacao.Controls.Add(this.cbo_transportadora);
            this.grp_identificacao.Controls.Add(this.lbl_funcionario);
            this.grp_identificacao.Controls.Add(this.lbl_transportadora);
            this.grp_identificacao.Controls.Add(this.lbl_cliente);
            this.grp_identificacao.Location = new System.Drawing.Point(12, 82);
            this.grp_identificacao.Name = "grp_identificacao";
            this.grp_identificacao.Size = new System.Drawing.Size(677, 185);
            this.grp_identificacao.TabIndex = 35;
            this.grp_identificacao.TabStop = false;
            this.grp_identificacao.Text = "Identificação";
            // 
            // cbo_funcionario
            // 
            this.cbo_funcionario.DataSource = this.funcionariosBindingSource;
            this.cbo_funcionario.DisplayMember = "Nome";
            this.cbo_funcionario.Enabled = false;
            this.cbo_funcionario.FormattingEnabled = true;
            this.cbo_funcionario.Location = new System.Drawing.Point(104, 57);
            this.cbo_funcionario.Name = "cbo_funcionario";
            this.cbo_funcionario.Size = new System.Drawing.Size(138, 21);
            this.cbo_funcionario.TabIndex = 39;
            this.cbo_funcionario.ValueMember = "CódigoDoFuncionário";
            // 
            // funcionariosBindingSource
            // 
            this.funcionariosBindingSource.DataMember = "Funcionários";
            this.funcionariosBindingSource.DataSource = this.dsComboBox;
            // 
            // btn_novocliente
            // 
            this.btn_novocliente.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_novocliente.Location = new System.Drawing.Point(285, 21);
            this.btn_novocliente.Name = "btn_novocliente";
            this.btn_novocliente.Size = new System.Drawing.Size(48, 26);
            this.btn_novocliente.TabIndex = 38;
            this.btn_novocliente.Text = "Novo";
            this.btn_novocliente.UseVisualStyleBackColor = false;
            this.btn_novocliente.Click += new System.EventHandler(this.btn_novocliente_Click);
            // 
            // txt_cliente
            // 
            this.txt_cliente.Enabled = false;
            this.txt_cliente.Location = new System.Drawing.Point(70, 23);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(172, 20);
            this.txt_cliente.TabIndex = 37;
            // 
            // txt_destinatario
            // 
            this.txt_destinatario.Enabled = false;
            this.txt_destinatario.Location = new System.Drawing.Point(104, 132);
            this.txt_destinatario.Name = "txt_destinatario";
            this.txt_destinatario.Size = new System.Drawing.Size(138, 20);
            this.txt_destinatario.TabIndex = 36;
            // 
            // btn_localizacliente
            // 
            this.btn_localizacliente.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_localizacliente.BackgroundImage = global::Gedave.Properties.Resources.Search;
            this.btn_localizacliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_localizacliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_localizacliente.Location = new System.Drawing.Point(248, 21);
            this.btn_localizacliente.Name = "btn_localizacliente";
            this.btn_localizacliente.Size = new System.Drawing.Size(31, 26);
            this.btn_localizacliente.TabIndex = 35;
            this.btn_localizacliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_localizacliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tlt_formulariopedido.SetToolTip(this.btn_localizacliente, "Clique para localizar clientes");
            this.btn_localizacliente.UseVisualStyleBackColor = false;
            this.btn_localizacliente.Click += new System.EventHandler(this.btn_localizacliente_Click);
            // 
            // btn_copiacliente
            // 
            this.btn_copiacliente.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_copiacliente.Location = new System.Drawing.Point(248, 132);
            this.btn_copiacliente.Name = "btn_copiacliente";
            this.btn_copiacliente.Size = new System.Drawing.Size(57, 23);
            this.btn_copiacliente.TabIndex = 34;
            this.btn_copiacliente.Text = "= Cliente";
            this.btn_copiacliente.UseVisualStyleBackColor = false;
            this.btn_copiacliente.Click += new System.EventHandler(this.btn_copiacliente_Click);
            // 
            // grp_datas
            // 
            this.grp_datas.Controls.Add(this.dtp_envio);
            this.grp_datas.Controls.Add(this.dtp_entrega);
            this.grp_datas.Controls.Add(this.dtp_pedido);
            this.grp_datas.Controls.Add(this.lbl_pedido);
            this.grp_datas.Controls.Add(this.lbl_entrega);
            this.grp_datas.Controls.Add(this.lbl_envio);
            this.grp_datas.Location = new System.Drawing.Point(499, 19);
            this.grp_datas.Name = "grp_datas";
            this.grp_datas.Size = new System.Drawing.Size(172, 116);
            this.grp_datas.TabIndex = 27;
            this.grp_datas.TabStop = false;
            this.grp_datas.Text = "Datas";
            // 
            // dtp_envio
            // 
            this.dtp_envio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_envio.Location = new System.Drawing.Point(74, 50);
            this.dtp_envio.Name = "dtp_envio";
            this.dtp_envio.Size = new System.Drawing.Size(83, 20);
            this.dtp_envio.TabIndex = 16;
            // 
            // dtp_entrega
            // 
            this.dtp_entrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_entrega.Location = new System.Drawing.Point(76, 81);
            this.dtp_entrega.Name = "dtp_entrega";
            this.dtp_entrega.Size = new System.Drawing.Size(83, 20);
            this.dtp_entrega.TabIndex = 15;
            // 
            // dtp_pedido
            // 
            this.dtp_pedido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_pedido.Location = new System.Drawing.Point(74, 18);
            this.dtp_pedido.Name = "dtp_pedido";
            this.dtp_pedido.Size = new System.Drawing.Size(83, 20);
            this.dtp_pedido.TabIndex = 14;
            // 
            // lbl_pedido
            // 
            this.lbl_pedido.AutoSize = true;
            this.lbl_pedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pedido.Location = new System.Drawing.Point(6, 18);
            this.lbl_pedido.Name = "lbl_pedido";
            this.lbl_pedido.Size = new System.Drawing.Size(62, 20);
            this.lbl_pedido.TabIndex = 13;
            this.lbl_pedido.Text = "Pedido:";
            // 
            // lbl_entrega
            // 
            this.lbl_entrega.AutoSize = true;
            this.lbl_entrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_entrega.Location = new System.Drawing.Point(7, 81);
            this.lbl_entrega.Name = "lbl_entrega";
            this.lbl_entrega.Size = new System.Drawing.Size(70, 20);
            this.lbl_entrega.TabIndex = 12;
            this.lbl_entrega.Text = "Entrega:";
            // 
            // lbl_envio
            // 
            this.lbl_envio.AutoSize = true;
            this.lbl_envio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_envio.Location = new System.Drawing.Point(16, 50);
            this.lbl_envio.Name = "lbl_envio";
            this.lbl_envio.Size = new System.Drawing.Size(52, 20);
            this.lbl_envio.TabIndex = 11;
            this.lbl_envio.Text = "Envio:";
            // 
            // lbl_destinatario
            // 
            this.lbl_destinatario.AutoSize = true;
            this.lbl_destinatario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_destinatario.Location = new System.Drawing.Point(8, 133);
            this.lbl_destinatario.Name = "lbl_destinatario";
            this.lbl_destinatario.Size = new System.Drawing.Size(99, 20);
            this.lbl_destinatario.TabIndex = 30;
            this.lbl_destinatario.Text = "Destinatário:";
            // 
            // msk_frete
            // 
            this.msk_frete.Enabled = false;
            this.msk_frete.Location = new System.Drawing.Point(299, 100);
            this.msk_frete.Mask = "$ 00000.00";
            this.msk_frete.Name = "msk_frete";
            this.msk_frete.Size = new System.Drawing.Size(74, 20);
            this.msk_frete.TabIndex = 29;
            this.msk_frete.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lbl_frete
            // 
            this.lbl_frete.AutoSize = true;
            this.lbl_frete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_frete.Location = new System.Drawing.Point(248, 99);
            this.lbl_frete.Name = "lbl_frete";
            this.lbl_frete.Size = new System.Drawing.Size(51, 20);
            this.lbl_frete.TabIndex = 28;
            this.lbl_frete.Text = "Frete:";
            // 
            // cbo_transportadora
            // 
            this.cbo_transportadora.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.transportadorasBindingSource, "CódigoDaTransportadora", true));
            this.cbo_transportadora.DataSource = this.transportadorasBindingSource;
            this.cbo_transportadora.DisplayMember = "NomeDaEmpresa";
            this.cbo_transportadora.Enabled = false;
            this.cbo_transportadora.FormattingEnabled = true;
            this.cbo_transportadora.Location = new System.Drawing.Point(127, 98);
            this.cbo_transportadora.Name = "cbo_transportadora";
            this.cbo_transportadora.Size = new System.Drawing.Size(115, 21);
            this.cbo_transportadora.TabIndex = 26;
            this.cbo_transportadora.ValueMember = "CódigoDaTransportadora";
            // 
            // transportadorasBindingSource
            // 
            this.transportadorasBindingSource.DataMember = "Transportadoras";
            this.transportadorasBindingSource.DataSource = this.dsComboBox;
            // 
            // lbl_funcionario
            // 
            this.lbl_funcionario.AutoSize = true;
            this.lbl_funcionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_funcionario.Location = new System.Drawing.Point(8, 58);
            this.lbl_funcionario.Name = "lbl_funcionario";
            this.lbl_funcionario.Size = new System.Drawing.Size(96, 20);
            this.lbl_funcionario.TabIndex = 23;
            this.lbl_funcionario.Text = "Funcionário:";
            // 
            // lbl_transportadora
            // 
            this.lbl_transportadora.AutoSize = true;
            this.lbl_transportadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_transportadora.Location = new System.Drawing.Point(8, 98);
            this.lbl_transportadora.Name = "lbl_transportadora";
            this.lbl_transportadora.Size = new System.Drawing.Size(122, 20);
            this.lbl_transportadora.TabIndex = 22;
            this.lbl_transportadora.Text = "Transportadora:";
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cliente.Location = new System.Drawing.Point(8, 21);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(62, 20);
            this.lbl_cliente.TabIndex = 21;
            this.lbl_cliente.Text = "Cliente:";
            // 
            // lbl_numeropedido
            // 
            this.lbl_numeropedido.AutoSize = true;
            this.lbl_numeropedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numeropedido.Location = new System.Drawing.Point(84, 50);
            this.lbl_numeropedido.Name = "lbl_numeropedido";
            this.lbl_numeropedido.Size = new System.Drawing.Size(27, 20);
            this.lbl_numeropedido.TabIndex = 25;
            this.lbl_numeropedido.Text = "00";
            // 
            // lbl_pedidonumero
            // 
            this.lbl_pedidonumero.AutoSize = true;
            this.lbl_pedidonumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pedidonumero.Location = new System.Drawing.Point(8, 49);
            this.lbl_pedidonumero.Name = "lbl_pedidonumero";
            this.lbl_pedidonumero.Size = new System.Drawing.Size(81, 20);
            this.lbl_pedidonumero.TabIndex = 24;
            this.lbl_pedidonumero.Text = "Pedido nº:";
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataMember = "Categorias";
            this.categoriasBindingSource.DataSource = this.dsComboBox;
            // 
            // transportadorasTableAdapter
            // 
            this.transportadorasTableAdapter.ClearBeforeFill = true;
            // 
            // funcionariosTableAdapter
            // 
            this.funcionariosTableAdapter.ClearBeforeFill = true;
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "Produtos";
            this.produtosBindingSource.DataSource = this.dsComboBox;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // categoriasTableAdapter
            // 
            this.categoriasTableAdapter.ClearBeforeFill = true;
            // 
            // tsm_menu
            // 
            this.tsm_menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tsm_menu.BackgroundImage = global::Gedave.Properties.Resources.Sem_título1;
            this.tsm_menu.Dock = System.Windows.Forms.DockStyle.None;
            this.tsm_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Novopedido,
            this.btn_conferirpedidos,
            this.btn_excluirpedido,
            this.btn_comprador,
            this.btn_concluirpedido,
            this.btn_cancelar,
            this.btn_void1,
            this.btn_void2,
            this.tss_separador,
            this.btn_Sair});
            this.tsm_menu.Location = new System.Drawing.Point(494, -2);
            this.tsm_menu.Name = "tsm_menu";
            this.tsm_menu.Size = new System.Drawing.Size(528, 78);
            this.tsm_menu.TabIndex = 3;
            this.tsm_menu.Text = "toolStrip1";
            // 
            // btn_Novopedido
            // 
            this.btn_Novopedido.Image = global::Gedave.Properties.Resources._41;
            this.btn_Novopedido.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Novopedido.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Novopedido.Name = "btn_Novopedido";
            this.btn_Novopedido.Size = new System.Drawing.Size(80, 75);
            this.btn_Novopedido.Text = "Novo Pedido";
            this.btn_Novopedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Novopedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Novopedido.ToolTipText = "Clique para criar um novo pedido ou acrescentar itens.";
            this.btn_Novopedido.Click += new System.EventHandler(this.btn_Novopedido_Click);
            // 
            // btn_conferirpedidos
            // 
            this.btn_conferirpedidos.Image = global::Gedave.Properties.Resources.Search;
            this.btn_conferirpedidos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_conferirpedidos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_conferirpedidos.Name = "btn_conferirpedidos";
            this.btn_conferirpedidos.Size = new System.Drawing.Size(99, 75);
            this.btn_conferirpedidos.Text = "Conferir Pedidos";
            this.btn_conferirpedidos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_conferirpedidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_conferirpedidos.Click += new System.EventHandler(this.btn_conferirpedidos_Click);
            // 
            // btn_excluirpedido
            // 
            this.btn_excluirpedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_excluirpedido.Image = global::Gedave.Properties.Resources.Trash;
            this.btn_excluirpedido.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_excluirpedido.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_excluirpedido.Name = "btn_excluirpedido";
            this.btn_excluirpedido.Size = new System.Drawing.Size(75, 75);
            this.btn_excluirpedido.Text = "Deletar Item";
            this.btn_excluirpedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_excluirpedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_excluirpedido.ToolTipText = "Deletar";
            this.btn_excluirpedido.Visible = false;
            this.btn_excluirpedido.Click += new System.EventHandler(this.btn_excluirpedido_Click);
            // 
            // btn_comprador
            // 
            this.btn_comprador.Image = global::Gedave.Properties.Resources.ID;
            this.btn_comprador.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_comprador.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_comprador.Name = "btn_comprador";
            this.btn_comprador.Size = new System.Drawing.Size(72, 75);
            this.btn_comprador.Text = "Comprador";
            this.btn_comprador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_comprador.ToolTipText = "Clique para preencher os dados do comprador";
            this.btn_comprador.Click += new System.EventHandler(this.btn_comprador_Click);
            // 
            // btn_concluirpedido
            // 
            this.btn_concluirpedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_concluirpedido.Enabled = false;
            this.btn_concluirpedido.Image = global::Gedave.Properties.Resources._11;
            this.btn_concluirpedido.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_concluirpedido.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_concluirpedido.Name = "btn_concluirpedido";
            this.btn_concluirpedido.Size = new System.Drawing.Size(96, 75);
            this.btn_concluirpedido.Text = "Concluir Pedido";
            this.btn_concluirpedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_concluirpedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_concluirpedido.ToolTipText = "Adicionar";
            this.btn_concluirpedido.Click += new System.EventHandler(this.btn_concluirpedido_Click);
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
            // 
            // btn_void2
            // 
            this.btn_void2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_void2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_void2.Name = "btn_void2";
            this.btn_void2.Size = new System.Drawing.Size(23, 75);
            this.btn_void2.Text = "toolStripButton10";
            // 
            // tss_separador
            // 
            this.tss_separador.Name = "tss_separador";
            this.tss_separador.Size = new System.Drawing.Size(6, 78);
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
            // fornecedoresTableAdapter
            // 
            this.fornecedoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriasTableAdapter = this.categoriasTableAdapter;
            this.tableAdapterManager.FornecedoresTableAdapter = this.fornecedoresTableAdapter;
            this.tableAdapterManager.FuncionáriosTableAdapter = this.funcionariosTableAdapter;
            this.tableAdapterManager.ProdutosTableAdapter = this.produtosTableAdapter;
            this.tableAdapterManager.TransportadorasTableAdapter = this.transportadorasTableAdapter;
            this.tableAdapterManager.UpdateOrder = Gedave.dsComboBoxTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fKProdutosCategoriasBindingSource
            // 
            this.fKProdutosCategoriasBindingSource.DataMember = "FK_Produtos_Categorias";
            this.fKProdutosCategoriasBindingSource.DataSource = this.categoriasBindingSource;
            // 
            // fKProdutosCategoriasBindingSource1
            // 
            this.fKProdutosCategoriasBindingSource1.DataMember = "FK_Produtos_Categorias";
            this.fKProdutosCategoriasBindingSource1.DataSource = this.categoriasBindingSource;
            // 
            // frmPedidos2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1020, 514);
            this.ControlBox = false;
            this.Controls.Add(this.tsm_menu);
            this.Controls.Add(this.tab_vendas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPedidos2";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GEDAVE - Sistema de Gestão de Vendas";
            this.Load += new System.EventHandler(this.frmPedidos2_Load);
            this.tab_vendas.ResumeLayout(false);
            this.tab_itenspedidos.ResumeLayout(false);
            this.tab_itenspedidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource1)).EndInit();
            this.tab_confere.ResumeLayout(false);
            this.tab_confere.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_confere)).EndInit();
            this.tab_identificacao.ResumeLayout(false);
            this.tab_identificacao.PerformLayout();
            this.grp_endereço.ResumeLayout(false);
            this.grp_endereço.PerformLayout();
            this.grp_identificacao.ResumeLayout(false);
            this.grp_identificacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
            this.grp_datas.ResumeLayout(false);
            this.grp_datas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transportadorasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            this.tsm_menu.ResumeLayout(false);
            this.tsm_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKProdutosCategoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProdutosCategoriasBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab_vendas;
        private System.Windows.Forms.TabPage tab_identificacao;
        private System.Windows.Forms.TabPage tab_itenspedidos;
        private System.Windows.Forms.Label lbl_destinatario;
        private MeuMskTextBox msk_frete;
        private System.Windows.Forms.Label lbl_frete;
        private System.Windows.Forms.GroupBox grp_datas;
        private System.Windows.Forms.DateTimePicker dtp_envio;
        private System.Windows.Forms.DateTimePicker dtp_entrega;
        private System.Windows.Forms.DateTimePicker dtp_pedido;
        private System.Windows.Forms.Label lbl_pedido;
        private System.Windows.Forms.Label lbl_entrega;
        private System.Windows.Forms.Label lbl_envio;
        private MeuComboBox cbo_transportadora;
        private System.Windows.Forms.Label lbl_numeropedido;
        private System.Windows.Forms.Label lbl_pedidonumero;
        private System.Windows.Forms.Label lbl_funcionario;
        private System.Windows.Forms.Label lbl_transportadora;
        private System.Windows.Forms.Label lbl_cliente;
        private dsComboBox dsComboBox;
        private System.Windows.Forms.BindingSource transportadorasBindingSource;
        private dsComboBoxTableAdapters.TransportadorasTableAdapter transportadorasTableAdapter;
        private System.Windows.Forms.BindingSource funcionariosBindingSource;
        private dsComboBoxTableAdapters.FuncionáriosTableAdapter funcionariosTableAdapter;
        private System.Windows.Forms.Button btn_copiacliente;
        private System.Windows.Forms.GroupBox grp_identificacao;
        private System.Windows.Forms.Button btn_localizacliente;
        private System.Windows.Forms.ToolTip tlt_formulariopedido;
        private System.Windows.Forms.GroupBox grp_endereço;
        private System.Windows.Forms.Label lbl_valorvenda;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_numerologradour;
        private MeuTextBox txt_numero;
        private MeuComboBox cbo_regiao;
        private MeuTextBox txt_bairro;
        private System.Windows.Forms.Label lbl_logradouro;
        private System.Windows.Forms.Label lbl_bairro;
        private MeuComboBox cbo_pais;
        private MeuComboBox cbo_tipolograd;
        private MeuMskTextBox msk_fax;
        private MeuMskTextBox msk_telefone;
        private System.Windows.Forms.Label lbl_fax;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.Label lbl_pais;
        private System.Windows.Forms.Label lbl_regiao;
        private MeuTextBox txt_cidade;
        private System.Windows.Forms.Label lbl_cidade;
        private MeuTextBox txt_logradouro;
        private System.Windows.Forms.Label lbl_tipolograd;
        private MeuMskTextBox msk_cep;
        private System.Windows.Forms.Button btn_busca;
        private System.Windows.Forms.Label lbl_cep;
        private MeuComboBox cbo_categoria;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private dsComboBoxTableAdapters.ProdutosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private dsComboBoxTableAdapters.CategoriasTableAdapter categoriasTableAdapter;
        private System.Windows.Forms.DataGridView dgv_itens;
        private System.Windows.Forms.Label lbl_titulotab;
        private System.Windows.Forms.Label lbl_selecionarcategoria;
        private System.Windows.Forms.ToolStrip tsm_menu;
        private System.Windows.Forms.ToolStripButton btn_Novopedido;
        private System.Windows.Forms.ToolStripButton btn_concluirpedido;
        private System.Windows.Forms.ToolStripButton btn_excluirpedido;
        private System.Windows.Forms.ToolStripButton btn_cancelar;
        private System.Windows.Forms.ToolStripButton btn_void1;
        private System.Windows.Forms.ToolStripButton btn_void2;
        private System.Windows.Forms.ToolStripSeparator tss_separador;
        private System.Windows.Forms.ToolStripButton btn_Sair;
        private MeuTextBox txt_cliente;
        private MeuTextBox txt_destinatario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tab_confere;
        private System.Windows.Forms.DataGridView dgv_confere;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.ToolStripButton btn_conferirpedidos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selecao;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selec;
        private System.Windows.Forms.ToolStripButton btn_comprador;
        private System.Windows.Forms.Button btn_novocliente;
        private System.Windows.Forms.Label lbl_totalparcial;
        private System.Windows.Forms.Label lbl_totalparcialvenda;
        private System.Windows.Forms.BindingSource fornecedoresBindingSource;
        private dsComboBoxTableAdapters.FornecedoresTableAdapter fornecedoresTableAdapter;
        private dsComboBoxTableAdapters.TableAdapterManager tableAdapterManager;
        private MeuComboBox cbo_funcionario;
        private System.Windows.Forms.BindingSource categoriasBindingSource1;
        private System.Windows.Forms.BindingSource fKProdutosCategoriasBindingSource;
        private System.Windows.Forms.BindingSource fKProdutosCategoriasBindingSource1;
    }
}