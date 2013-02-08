namespace Gedave
{
    partial class frmProdutos
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
            this.components = new System.ComponentModel.Container();
            this.dgv_dados = new System.Windows.Forms.DataGridView();
            this.lbl_codigo1 = new System.Windows.Forms.Label();
            this.lbl_descont = new System.Windows.Forms.Label();
            this.lbl_nivelrepos = new System.Windows.Forms.Label();
            this.lbl_unidpedida = new System.Windows.Forms.Label();
            this.lbl_unidestocada = new System.Windows.Forms.Label();
            this.lbl_precounit = new System.Windows.Forms.Label();
            this.lbl_qtdeunidade = new System.Windows.Forms.Label();
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.lbl_fornecedor = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txt_nomeproduto = new Gedave.MeuTextBox();
            this.cbo_fornecedor = new Gedave.MeuComboBox();
            this.fornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsComboBox = new Gedave.dsComboBox();
            this.cbo_categoria = new Gedave.MeuComboBox();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.msk_precounit = new Gedave.MeuMskTextBox();
            this.msk_nivelrepos = new Gedave.MeuMskTextBox();
            this.pl_descont = new System.Windows.Forms.Panel();
            this.rbt_nao = new System.Windows.Forms.RadioButton();
            this.rbt_sim = new System.Windows.Forms.RadioButton();
            this.msk_unidadesestoque = new Gedave.MeuMskTextBox();
            this.msk_unidpedidas = new Gedave.MeuMskTextBox();
            this.dsGedave = new Persistencia.dsGedave();
            this.dsGedaveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fornecedoresTableAdapter = new Gedave.dsComboBoxTableAdapters.FornecedoresTableAdapter();
            this.tableAdapterManager = new Gedave.dsComboBoxTableAdapters.TableAdapterManager();
            this.categoriasTableAdapter = new Gedave.dsComboBoxTableAdapters.CategoriasTableAdapter();
            this.txt_qtdeunidade = new Gedave.MeuTextBox();
            this.lbl_codigo2 = new System.Windows.Forms.Label();
            this.lbl_visualizar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbt_indisponiveis = new System.Windows.Forms.RadioButton();
            this.rbt_disponiveis = new System.Windows.Forms.RadioButton();
            this.rbt_todas = new System.Windows.Forms.RadioButton();
            this.btn_novoforn = new System.Windows.Forms.Button();
            this.btn_novacatg = new System.Windows.Forms.Button();
            this.tlt_btnformulario = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            this.pl_descont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsGedave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGedaveBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_TituloForm
            // 
            this.lbl_TituloForm.Size = new System.Drawing.Size(331, 44);
            this.lbl_TituloForm.Text = "Gerenciar Produto";
            // 
            // dgv_dados
            // 
            this.dgv_dados.AllowUserToAddRows = false;
            this.dgv_dados.AllowUserToDeleteRows = false;
            this.dgv_dados.AllowUserToOrderColumns = true;
            this.dgv_dados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_dados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_dados.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dados.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_dados.Location = new System.Drawing.Point(0, 191);
            this.dgv_dados.Name = "dgv_dados";
            this.dgv_dados.ReadOnly = true;
            this.dgv_dados.Size = new System.Drawing.Size(884, 321);
            this.dgv_dados.TabIndex = 3;
            this.dgv_dados.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_dados_CellMouseClick);
            // 
            // lbl_codigo1
            // 
            this.lbl_codigo1.AutoSize = true;
            this.lbl_codigo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo1.Location = new System.Drawing.Point(16, 67);
            this.lbl_codigo1.Name = "lbl_codigo1";
            this.lbl_codigo1.Size = new System.Drawing.Size(63, 20);
            this.lbl_codigo1.TabIndex = 4;
            this.lbl_codigo1.Text = "Código:";
            this.lbl_codigo1.Visible = false;
            // 
            // lbl_descont
            // 
            this.lbl_descont.AutoSize = true;
            this.lbl_descont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descont.Location = new System.Drawing.Point(504, 158);
            this.lbl_descont.Name = "lbl_descont";
            this.lbl_descont.Size = new System.Drawing.Size(121, 20);
            this.lbl_descont.TabIndex = 7;
            this.lbl_descont.Text = "Descontinuado:";
            // 
            // lbl_nivelrepos
            // 
            this.lbl_nivelrepos.AutoSize = true;
            this.lbl_nivelrepos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nivelrepos.Location = new System.Drawing.Point(251, 129);
            this.lbl_nivelrepos.Name = "lbl_nivelrepos";
            this.lbl_nivelrepos.Size = new System.Drawing.Size(148, 20);
            this.lbl_nivelrepos.TabIndex = 8;
            this.lbl_nivelrepos.Text = "Nível de Reposição:";
            // 
            // lbl_unidpedida
            // 
            this.lbl_unidpedida.AutoSize = true;
            this.lbl_unidpedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_unidpedida.Location = new System.Drawing.Point(257, 161);
            this.lbl_unidpedida.Name = "lbl_unidpedida";
            this.lbl_unidpedida.Size = new System.Drawing.Size(142, 20);
            this.lbl_unidpedida.TabIndex = 9;
            this.lbl_unidpedida.Text = "Unidades Pedidas:";
            // 
            // lbl_unidestocada
            // 
            this.lbl_unidestocada.AutoSize = true;
            this.lbl_unidestocada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_unidestocada.Location = new System.Drawing.Point(24, 161);
            this.lbl_unidestocada.Name = "lbl_unidestocada";
            this.lbl_unidestocada.Size = new System.Drawing.Size(159, 20);
            this.lbl_unidestocada.TabIndex = 10;
            this.lbl_unidestocada.Text = "Unidades estacadas:";
            // 
            // lbl_precounit
            // 
            this.lbl_precounit.AutoSize = true;
            this.lbl_precounit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precounit.Location = new System.Drawing.Point(24, 129);
            this.lbl_precounit.Name = "lbl_precounit";
            this.lbl_precounit.Size = new System.Drawing.Size(113, 20);
            this.lbl_precounit.TabIndex = 11;
            this.lbl_precounit.Text = "Preço Unitário:";
            // 
            // lbl_qtdeunidade
            // 
            this.lbl_qtdeunidade.AutoSize = true;
            this.lbl_qtdeunidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qtdeunidade.Location = new System.Drawing.Point(473, 129);
            this.lbl_qtdeunidade.Name = "lbl_qtdeunidade";
            this.lbl_qtdeunidade.Size = new System.Drawing.Size(152, 20);
            this.lbl_qtdeunidade.TabIndex = 12;
            this.lbl_qtdeunidade.Text = "Quant. por Unidade:";
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categoria.Location = new System.Drawing.Point(543, 96);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(82, 20);
            this.lbl_categoria.TabIndex = 13;
            this.lbl_categoria.Text = "Categoria:";
            // 
            // lbl_fornecedor
            // 
            this.lbl_fornecedor.AutoSize = true;
            this.lbl_fornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fornecedor.Location = new System.Drawing.Point(250, 96);
            this.lbl_fornecedor.Name = "lbl_fornecedor";
            this.lbl_fornecedor.Size = new System.Drawing.Size(95, 20);
            this.lbl_fornecedor.TabIndex = 14;
            this.lbl_fornecedor.Text = "Fornecedor:";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(24, 96);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(55, 20);
            this.lbl_nome.TabIndex = 15;
            this.lbl_nome.Text = "Nome:";
            // 
            // txt_nomeproduto
            // 
            this.txt_nomeproduto.Location = new System.Drawing.Point(79, 95);
            this.txt_nomeproduto.Name = "txt_nomeproduto";
            this.txt_nomeproduto.Size = new System.Drawing.Size(161, 20);
            this.txt_nomeproduto.TabIndex = 0;
            // 
            // cbo_fornecedor
            // 
            this.cbo_fornecedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbo_fornecedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_fornecedor.DataSource = this.fornecedoresBindingSource;
            this.cbo_fornecedor.DisplayMember = "NomeDaEmpresa";
            this.cbo_fornecedor.FormattingEnabled = true;
            this.cbo_fornecedor.Location = new System.Drawing.Point(344, 94);
            this.cbo_fornecedor.Name = "cbo_fornecedor";
            this.cbo_fornecedor.Size = new System.Drawing.Size(167, 21);
            this.cbo_fornecedor.TabIndex = 1;
            this.cbo_fornecedor.ValueMember = "CódigoDoFornecedor";
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
            // cbo_categoria
            // 
            this.cbo_categoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbo_categoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_categoria.DataSource = this.categoriasBindingSource;
            this.cbo_categoria.DisplayMember = "NomeDaCategoria";
            this.cbo_categoria.FormattingEnabled = true;
            this.cbo_categoria.Location = new System.Drawing.Point(622, 94);
            this.cbo_categoria.Name = "cbo_categoria";
            this.cbo_categoria.Size = new System.Drawing.Size(121, 21);
            this.cbo_categoria.TabIndex = 2;
            this.cbo_categoria.ValueMember = "CódigoDaCategoria";
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataMember = "Categorias";
            this.categoriasBindingSource.DataSource = this.dsComboBox;
            // 
            // msk_precounit
            // 
            this.msk_precounit.HidePromptOnLeave = true;
            this.msk_precounit.HideSelection = false;
            this.msk_precounit.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.msk_precounit.Location = new System.Drawing.Point(133, 128);
            this.msk_precounit.Mask = "$0000.00";
            this.msk_precounit.Name = "msk_precounit";
            this.msk_precounit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.msk_precounit.Size = new System.Drawing.Size(71, 20);
            this.msk_precounit.TabIndex = 3;
            this.msk_precounit.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // msk_nivelrepos
            // 
            this.msk_nivelrepos.Location = new System.Drawing.Point(396, 128);
            this.msk_nivelrepos.Name = "msk_nivelrepos";
            this.msk_nivelrepos.Size = new System.Drawing.Size(38, 20);
            this.msk_nivelrepos.TabIndex = 4;
            // 
            // pl_descont
            // 
            this.pl_descont.Controls.Add(this.rbt_nao);
            this.pl_descont.Controls.Add(this.rbt_sim);
            this.pl_descont.Location = new System.Drawing.Point(620, 150);
            this.pl_descont.Name = "pl_descont";
            this.pl_descont.Size = new System.Drawing.Size(138, 35);
            this.pl_descont.TabIndex = 21;
            // 
            // rbt_nao
            // 
            this.rbt_nao.AutoSize = true;
            this.rbt_nao.Checked = true;
            this.rbt_nao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_nao.Location = new System.Drawing.Point(3, 6);
            this.rbt_nao.Name = "rbt_nao";
            this.rbt_nao.Size = new System.Drawing.Size(56, 24);
            this.rbt_nao.TabIndex = 0;
            this.rbt_nao.TabStop = true;
            this.rbt_nao.Text = "Não";
            this.rbt_nao.UseVisualStyleBackColor = true;
            // 
            // rbt_sim
            // 
            this.rbt_sim.AutoSize = true;
            this.rbt_sim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_sim.Location = new System.Drawing.Point(65, 7);
            this.rbt_sim.Name = "rbt_sim";
            this.rbt_sim.Size = new System.Drawing.Size(54, 24);
            this.rbt_sim.TabIndex = 1;
            this.rbt_sim.Text = "Sim";
            this.rbt_sim.UseVisualStyleBackColor = true;
            // 
            // msk_unidadesestoque
            // 
            this.msk_unidadesestoque.Location = new System.Drawing.Point(179, 160);
            this.msk_unidadesestoque.Name = "msk_unidadesestoque";
            this.msk_unidadesestoque.Size = new System.Drawing.Size(25, 20);
            this.msk_unidadesestoque.TabIndex = 6;
            // 
            // msk_unidpedidas
            // 
            this.msk_unidpedidas.Location = new System.Drawing.Point(396, 161);
            this.msk_unidpedidas.Name = "msk_unidpedidas";
            this.msk_unidpedidas.Size = new System.Drawing.Size(38, 20);
            this.msk_unidpedidas.TabIndex = 7;
            // 
            // dsGedave
            // 
            this.dsGedave.DataSetName = "dsGedave";
            this.dsGedave.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsGedaveBindingSource
            // 
            this.dsGedaveBindingSource.DataSource = this.dsGedave;
            this.dsGedaveBindingSource.Position = 0;
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
            this.tableAdapterManager.FuncionáriosTableAdapter = null;
            this.tableAdapterManager.ProdutosTableAdapter = null;
            this.tableAdapterManager.TransportadorasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Gedave.dsComboBoxTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // categoriasTableAdapter
            // 
            this.categoriasTableAdapter.ClearBeforeFill = true;
            // 
            // txt_qtdeunidade
            // 
            this.txt_qtdeunidade.Location = new System.Drawing.Point(623, 127);
            this.txt_qtdeunidade.Name = "txt_qtdeunidade";
            this.txt_qtdeunidade.Size = new System.Drawing.Size(120, 20);
            this.txt_qtdeunidade.TabIndex = 5;
            // 
            // lbl_codigo2
            // 
            this.lbl_codigo2.AutoSize = true;
            this.lbl_codigo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo2.Location = new System.Drawing.Point(74, 67);
            this.lbl_codigo2.Name = "lbl_codigo2";
            this.lbl_codigo2.Size = new System.Drawing.Size(27, 20);
            this.lbl_codigo2.TabIndex = 26;
            this.lbl_codigo2.Text = "00";
            this.lbl_codigo2.Visible = false;
            // 
            // lbl_visualizar
            // 
            this.lbl_visualizar.AutoSize = true;
            this.lbl_visualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_visualizar.Location = new System.Drawing.Point(123, 64);
            this.lbl_visualizar.Name = "lbl_visualizar";
            this.lbl_visualizar.Size = new System.Drawing.Size(81, 20);
            this.lbl_visualizar.TabIndex = 27;
            this.lbl_visualizar.Text = "Visualizar:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbt_indisponiveis);
            this.panel1.Controls.Add(this.rbt_disponiveis);
            this.panel1.Controls.Add(this.rbt_todas);
            this.panel1.Location = new System.Drawing.Point(200, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 37);
            this.panel1.TabIndex = 28;
            // 
            // rbt_indisponiveis
            // 
            this.rbt_indisponiveis.AutoSize = true;
            this.rbt_indisponiveis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_indisponiveis.Location = new System.Drawing.Point(187, 7);
            this.rbt_indisponiveis.Name = "rbt_indisponiveis";
            this.rbt_indisponiveis.Size = new System.Drawing.Size(118, 24);
            this.rbt_indisponiveis.TabIndex = 2;
            this.rbt_indisponiveis.Text = "Indisponíveis";
            this.rbt_indisponiveis.UseVisualStyleBackColor = true;
            this.rbt_indisponiveis.CheckedChanged += new System.EventHandler(this.rbt_indisponiveis_CheckedChanged);
            // 
            // rbt_disponiveis
            // 
            this.rbt_disponiveis.AutoSize = true;
            this.rbt_disponiveis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_disponiveis.Location = new System.Drawing.Point(81, 7);
            this.rbt_disponiveis.Name = "rbt_disponiveis";
            this.rbt_disponiveis.Size = new System.Drawing.Size(107, 24);
            this.rbt_disponiveis.TabIndex = 1;
            this.rbt_disponiveis.Text = "Disponíveis";
            this.rbt_disponiveis.UseVisualStyleBackColor = true;
            this.rbt_disponiveis.CheckedChanged += new System.EventHandler(this.rbt_disponiveis_CheckedChanged);
            // 
            // rbt_todas
            // 
            this.rbt_todas.AutoSize = true;
            this.rbt_todas.Checked = true;
            this.rbt_todas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_todas.Location = new System.Drawing.Point(4, 7);
            this.rbt_todas.Name = "rbt_todas";
            this.rbt_todas.Size = new System.Drawing.Size(71, 24);
            this.rbt_todas.TabIndex = 0;
            this.rbt_todas.TabStop = true;
            this.rbt_todas.Text = "Todos";
            this.rbt_todas.UseVisualStyleBackColor = true;
            this.rbt_todas.CheckedChanged += new System.EventHandler(this.rbt_todas_CheckedChanged);
            // 
            // btn_novoforn
            // 
            this.btn_novoforn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_novoforn.Location = new System.Drawing.Point(512, 93);
            this.btn_novoforn.Name = "btn_novoforn";
            this.btn_novoforn.Size = new System.Drawing.Size(24, 23);
            this.btn_novoforn.TabIndex = 29;
            this.btn_novoforn.Text = "...";
            this.tlt_btnformulario.SetToolTip(this.btn_novoforn, "Clique para adicionar novo fornecedor.");
            this.btn_novoforn.UseVisualStyleBackColor = false;
            this.btn_novoforn.Click += new System.EventHandler(this.btn_novoforn_Click);
            // 
            // btn_novacatg
            // 
            this.btn_novacatg.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_novacatg.Location = new System.Drawing.Point(744, 92);
            this.btn_novacatg.Name = "btn_novacatg";
            this.btn_novacatg.Size = new System.Drawing.Size(24, 23);
            this.btn_novacatg.TabIndex = 30;
            this.btn_novacatg.Text = "...";
            this.tlt_btnformulario.SetToolTip(this.btn_novacatg, "Clique para adicionar nova categoria.");
            this.btn_novacatg.UseVisualStyleBackColor = false;
            this.btn_novacatg.Click += new System.EventHandler(this.btn_novacatg_Click);
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(884, 512);
            this.Controls.Add(this.btn_novacatg);
            this.Controls.Add(this.btn_novoforn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_visualizar);
            this.Controls.Add(this.lbl_codigo2);
            this.Controls.Add(this.txt_qtdeunidade);
            this.Controls.Add(this.msk_unidpedidas);
            this.Controls.Add(this.msk_unidadesestoque);
            this.Controls.Add(this.pl_descont);
            this.Controls.Add(this.msk_nivelrepos);
            this.Controls.Add(this.msk_precounit);
            this.Controls.Add(this.cbo_categoria);
            this.Controls.Add(this.cbo_fornecedor);
            this.Controls.Add(this.txt_nomeproduto);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_fornecedor);
            this.Controls.Add(this.lbl_categoria);
            this.Controls.Add(this.lbl_qtdeunidade);
            this.Controls.Add(this.lbl_precounit);
            this.Controls.Add(this.lbl_unidestocada);
            this.Controls.Add(this.lbl_unidpedida);
            this.Controls.Add(this.lbl_nivelrepos);
            this.Controls.Add(this.lbl_descont);
            this.Controls.Add(this.lbl_codigo1);
            this.Controls.Add(this.dgv_dados);
            this.Name = "frmProdutos";
            this.Load += new System.EventHandler(this.frmProdutos_Load);
            this.Controls.SetChildIndex(this.dgv_dados, 0);
            this.Controls.SetChildIndex(this.lbl_codigo1, 0);
            this.Controls.SetChildIndex(this.lbl_descont, 0);
            this.Controls.SetChildIndex(this.lbl_nivelrepos, 0);
            this.Controls.SetChildIndex(this.lbl_unidpedida, 0);
            this.Controls.SetChildIndex(this.lbl_unidestocada, 0);
            this.Controls.SetChildIndex(this.lbl_precounit, 0);
            this.Controls.SetChildIndex(this.lbl_qtdeunidade, 0);
            this.Controls.SetChildIndex(this.lbl_categoria, 0);
            this.Controls.SetChildIndex(this.lbl_fornecedor, 0);
            this.Controls.SetChildIndex(this.lbl_nome, 0);
            this.Controls.SetChildIndex(this.txt_nomeproduto, 0);
            this.Controls.SetChildIndex(this.cbo_fornecedor, 0);
            this.Controls.SetChildIndex(this.cbo_categoria, 0);
            this.Controls.SetChildIndex(this.msk_precounit, 0);
            this.Controls.SetChildIndex(this.msk_nivelrepos, 0);
            this.Controls.SetChildIndex(this.pl_descont, 0);
            this.Controls.SetChildIndex(this.msk_unidadesestoque, 0);
            this.Controls.SetChildIndex(this.msk_unidpedidas, 0);
            this.Controls.SetChildIndex(this.txt_qtdeunidade, 0);
            this.Controls.SetChildIndex(this.lbl_TituloForm, 0);
            this.Controls.SetChildIndex(this.lbl_codigo2, 0);
            this.Controls.SetChildIndex(this.lbl_visualizar, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.btn_novoforn, 0);
            this.Controls.SetChildIndex(this.btn_novacatg, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            this.pl_descont.ResumeLayout(false);
            this.pl_descont.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsGedave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGedaveBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_dados;
        private System.Windows.Forms.Label lbl_codigo1;
        private System.Windows.Forms.Label lbl_descont;
        private System.Windows.Forms.Label lbl_nivelrepos;
        private System.Windows.Forms.Label lbl_unidpedida;
        private System.Windows.Forms.Label lbl_unidestocada;
        private System.Windows.Forms.Label lbl_precounit;
        private System.Windows.Forms.Label lbl_qtdeunidade;
        private System.Windows.Forms.Label lbl_categoria;
        private System.Windows.Forms.Label lbl_fornecedor;
        private System.Windows.Forms.Label lbl_nome;
        private MeuTextBox txt_nomeproduto;
        private MeuComboBox cbo_fornecedor;
        private MeuComboBox cbo_categoria;
        private MeuMskTextBox msk_precounit;
        private MeuMskTextBox msk_nivelrepos;
        private System.Windows.Forms.Panel pl_descont;
        private System.Windows.Forms.RadioButton rbt_nao;
        private System.Windows.Forms.RadioButton rbt_sim;
        private MeuMskTextBox msk_unidadesestoque;
        private MeuMskTextBox msk_unidpedidas;
        private Persistencia.dsGedave dsGedave;
        private System.Windows.Forms.BindingSource dsGedaveBindingSource;
        private dsComboBox dsComboBox;
        private System.Windows.Forms.BindingSource fornecedoresBindingSource;
        private dsComboBoxTableAdapters.FornecedoresTableAdapter fornecedoresTableAdapter;
        private dsComboBoxTableAdapters.TableAdapterManager tableAdapterManager;
        private dsComboBoxTableAdapters.CategoriasTableAdapter categoriasTableAdapter;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private MeuTextBox txt_qtdeunidade;
        private System.Windows.Forms.Label lbl_codigo2;
        private System.Windows.Forms.Label lbl_visualizar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbt_indisponiveis;
        private System.Windows.Forms.RadioButton rbt_disponiveis;
        private System.Windows.Forms.RadioButton rbt_todas;
        private System.Windows.Forms.Button btn_novoforn;
        private System.Windows.Forms.Button btn_novacatg;
        private System.Windows.Forms.ToolTip tlt_btnformulario;
    }
}
