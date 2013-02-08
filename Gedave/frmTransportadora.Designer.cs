namespace Gedave
{
    partial class frmTransportadora
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
            this.txt_nome = new Gedave.MeuTextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_codigo2 = new System.Windows.Forms.Label();
            this.lbl_codigo1 = new System.Windows.Forms.Label();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.msk_telefone = new Gedave.MeuMskTextBox();
            this.dgv_dados = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_numero = new Gedave.MeuTextBox();
            this.cbo_regiao = new Gedave.MeuComboBox();
            this.txt_bairro = new Gedave.MeuTextBox();
            this.lbl_logradouro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_pais = new Gedave.MeuComboBox();
            this.cbo_tipolograd = new Gedave.MeuComboBox();
            this.lbl_pais = new System.Windows.Forms.Label();
            this.lbl_regiao = new System.Windows.Forms.Label();
            this.txt_cidade = new Gedave.MeuTextBox();
            this.lbl_cidade = new System.Windows.Forms.Label();
            this.txt_logradouro = new Gedave.MeuTextBox();
            this.lbl_tipolograd = new System.Windows.Forms.Label();
            this.msk_cep = new Gedave.MeuMskTextBox();
            this.btn_busca = new System.Windows.Forms.Button();
            this.lbl_cep = new System.Windows.Forms.Label();
            this.lbl_endereco = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dados)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_TituloForm
            // 
            this.lbl_TituloForm.Size = new System.Drawing.Size(458, 44);
            this.lbl_TituloForm.Text = "Gerenciar Transportadora";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(87, 94);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(153, 20);
            this.txt_nome.TabIndex = 0;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(35, 94);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(55, 20);
            this.lbl_nome.TabIndex = 14;
            this.lbl_nome.Text = "Nome:";
            // 
            // lbl_codigo2
            // 
            this.lbl_codigo2.AutoSize = true;
            this.lbl_codigo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo2.Location = new System.Drawing.Point(83, 67);
            this.lbl_codigo2.Name = "lbl_codigo2";
            this.lbl_codigo2.Size = new System.Drawing.Size(27, 20);
            this.lbl_codigo2.TabIndex = 13;
            this.lbl_codigo2.Text = "00";
            this.lbl_codigo2.Visible = false;
            // 
            // lbl_codigo1
            // 
            this.lbl_codigo1.AutoSize = true;
            this.lbl_codigo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo1.Location = new System.Drawing.Point(27, 67);
            this.lbl_codigo1.Name = "lbl_codigo1";
            this.lbl_codigo1.Size = new System.Drawing.Size(63, 20);
            this.lbl_codigo1.TabIndex = 12;
            this.lbl_codigo1.Text = "Codigo:";
            this.lbl_codigo1.Visible = false;
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefone.Location = new System.Drawing.Point(12, 118);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(75, 20);
            this.lbl_telefone.TabIndex = 16;
            this.lbl_telefone.Text = "Telefone:";
            // 
            // msk_telefone
            // 
            this.msk_telefone.HidePromptOnLeave = true;
            this.msk_telefone.Location = new System.Drawing.Point(87, 118);
            this.msk_telefone.Mask = "(99) 0000-0000";
            this.msk_telefone.Name = "msk_telefone";
            this.msk_telefone.Size = new System.Drawing.Size(80, 20);
            this.msk_telefone.TabIndex = 1;
            // 
            // dgv_dados
            // 
            this.dgv_dados.AllowUserToAddRows = false;
            this.dgv_dados.AllowUserToDeleteRows = false;
            this.dgv_dados.AllowUserToOrderColumns = true;
            this.dgv_dados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_dados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_dados.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dados.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_dados.Location = new System.Drawing.Point(0, 278);
            this.dgv_dados.Name = "dgv_dados";
            this.dgv_dados.ReadOnly = true;
            this.dgv_dados.Size = new System.Drawing.Size(884, 234);
            this.dgv_dados.TabIndex = 18;
            this.dgv_dados.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_dados_CellMouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(481, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 82;
            this.label2.Text = "Nº:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(513, 194);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(48, 20);
            this.txt_numero.TabIndex = 6;
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
            this.cbo_regiao.Location = new System.Drawing.Point(287, 223);
            this.cbo_regiao.Name = "cbo_regiao";
            this.cbo_regiao.Size = new System.Drawing.Size(65, 21);
            this.cbo_regiao.TabIndex = 9;
            // 
            // txt_bairro
            // 
            this.txt_bairro.Location = new System.Drawing.Point(622, 194);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(155, 20);
            this.txt_bairro.TabIndex = 7;
            // 
            // lbl_logradouro
            // 
            this.lbl_logradouro.AutoSize = true;
            this.lbl_logradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logradouro.Location = new System.Drawing.Point(177, 195);
            this.lbl_logradouro.Name = "lbl_logradouro";
            this.lbl_logradouro.Size = new System.Drawing.Size(49, 20);
            this.lbl_logradouro.TabIndex = 77;
            this.lbl_logradouro.Text = "Logr.:";
            this.lbl_logradouro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(566, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 78;
            this.label1.Text = "Bairro:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            "Brazil",
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
            "Brazil",
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
            this.cbo_pais.Location = new System.Drawing.Point(401, 222);
            this.cbo_pais.Name = "cbo_pais";
            this.cbo_pais.Size = new System.Drawing.Size(112, 21);
            this.cbo_pais.TabIndex = 10;
            this.cbo_pais.Text = "Brazil";
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
            this.cbo_tipolograd.Location = new System.Drawing.Point(89, 194);
            this.cbo_tipolograd.Name = "cbo_tipolograd";
            this.cbo_tipolograd.Size = new System.Drawing.Size(79, 21);
            this.cbo_tipolograd.TabIndex = 4;
            // 
            // lbl_pais
            // 
            this.lbl_pais.AutoSize = true;
            this.lbl_pais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pais.Location = new System.Drawing.Point(357, 223);
            this.lbl_pais.Name = "lbl_pais";
            this.lbl_pais.Size = new System.Drawing.Size(43, 20);
            this.lbl_pais.TabIndex = 74;
            this.lbl_pais.Text = "País:";
            this.lbl_pais.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_regiao
            // 
            this.lbl_regiao.AutoSize = true;
            this.lbl_regiao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_regiao.Location = new System.Drawing.Point(224, 224);
            this.lbl_regiao.Name = "lbl_regiao";
            this.lbl_regiao.Size = new System.Drawing.Size(64, 20);
            this.lbl_regiao.TabIndex = 73;
            this.lbl_regiao.Text = "Região:";
            this.lbl_regiao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(89, 223);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(133, 20);
            this.txt_cidade.TabIndex = 8;
            // 
            // lbl_cidade
            // 
            this.lbl_cidade.AutoSize = true;
            this.lbl_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cidade.Location = new System.Drawing.Point(22, 224);
            this.lbl_cidade.Name = "lbl_cidade";
            this.lbl_cidade.Size = new System.Drawing.Size(63, 20);
            this.lbl_cidade.TabIndex = 71;
            this.lbl_cidade.Text = "Cidade:";
            this.lbl_cidade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_logradouro
            // 
            this.txt_logradouro.Location = new System.Drawing.Point(227, 195);
            this.txt_logradouro.Name = "txt_logradouro";
            this.txt_logradouro.Size = new System.Drawing.Size(243, 20);
            this.txt_logradouro.TabIndex = 5;
            // 
            // lbl_tipolograd
            // 
            this.lbl_tipolograd.AutoSize = true;
            this.lbl_tipolograd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipolograd.Location = new System.Drawing.Point(41, 195);
            this.lbl_tipolograd.Name = "lbl_tipolograd";
            this.lbl_tipolograd.Size = new System.Drawing.Size(43, 20);
            this.lbl_tipolograd.TabIndex = 69;
            this.lbl_tipolograd.Text = "Tipo:";
            this.lbl_tipolograd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // msk_cep
            // 
            this.msk_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_cep.HidePromptOnLeave = true;
            this.msk_cep.Location = new System.Drawing.Point(89, 166);
            this.msk_cep.Margin = new System.Windows.Forms.Padding(0);
            this.msk_cep.Mask = "99999-999";
            this.msk_cep.Name = "msk_cep";
            this.msk_cep.Size = new System.Drawing.Size(63, 20);
            this.msk_cep.TabIndex = 2;
            this.msk_cep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btn_busca
            // 
            this.btn_busca.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_busca.Location = new System.Drawing.Point(154, 164);
            this.btn_busca.Name = "btn_busca";
            this.btn_busca.Size = new System.Drawing.Size(68, 25);
            this.btn_busca.TabIndex = 3;
            this.btn_busca.Text = "Buscar";
            this.btn_busca.UseVisualStyleBackColor = false;
            this.btn_busca.Click += new System.EventHandler(this.btn_busca_Click);
            // 
            // lbl_cep
            // 
            this.lbl_cep.AutoSize = true;
            this.lbl_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cep.Location = new System.Drawing.Point(41, 166);
            this.lbl_cep.Name = "lbl_cep";
            this.lbl_cep.Size = new System.Drawing.Size(45, 20);
            this.lbl_cep.TabIndex = 66;
            this.lbl_cep.Text = "CEP:";
            this.lbl_cep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_endereco
            // 
            this.lbl_endereco.AutoSize = true;
            this.lbl_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_endereco.Location = new System.Drawing.Point(31, 147);
            this.lbl_endereco.Name = "lbl_endereco";
            this.lbl_endereco.Size = new System.Drawing.Size(53, 13);
            this.lbl_endereco.TabIndex = 65;
            this.lbl_endereco.Text = "Endereço";
            this.lbl_endereco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmTransportadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(884, 512);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.cbo_regiao);
            this.Controls.Add(this.txt_bairro);
            this.Controls.Add(this.lbl_logradouro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_pais);
            this.Controls.Add(this.cbo_tipolograd);
            this.Controls.Add(this.lbl_pais);
            this.Controls.Add(this.lbl_regiao);
            this.Controls.Add(this.txt_cidade);
            this.Controls.Add(this.lbl_cidade);
            this.Controls.Add(this.txt_logradouro);
            this.Controls.Add(this.lbl_tipolograd);
            this.Controls.Add(this.msk_cep);
            this.Controls.Add(this.btn_busca);
            this.Controls.Add(this.lbl_cep);
            this.Controls.Add(this.lbl_endereco);
            this.Controls.Add(this.dgv_dados);
            this.Controls.Add(this.msk_telefone);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_codigo2);
            this.Controls.Add(this.lbl_codigo1);
            this.Name = "frmTransportadora";
            this.Controls.SetChildIndex(this.lbl_TituloForm, 0);
            this.Controls.SetChildIndex(this.lbl_codigo1, 0);
            this.Controls.SetChildIndex(this.lbl_codigo2, 0);
            this.Controls.SetChildIndex(this.lbl_nome, 0);
            this.Controls.SetChildIndex(this.txt_nome, 0);
            this.Controls.SetChildIndex(this.lbl_telefone, 0);
            this.Controls.SetChildIndex(this.msk_telefone, 0);
            this.Controls.SetChildIndex(this.dgv_dados, 0);
            this.Controls.SetChildIndex(this.lbl_endereco, 0);
            this.Controls.SetChildIndex(this.lbl_cep, 0);
            this.Controls.SetChildIndex(this.btn_busca, 0);
            this.Controls.SetChildIndex(this.msk_cep, 0);
            this.Controls.SetChildIndex(this.lbl_tipolograd, 0);
            this.Controls.SetChildIndex(this.txt_logradouro, 0);
            this.Controls.SetChildIndex(this.lbl_cidade, 0);
            this.Controls.SetChildIndex(this.txt_cidade, 0);
            this.Controls.SetChildIndex(this.lbl_regiao, 0);
            this.Controls.SetChildIndex(this.lbl_pais, 0);
            this.Controls.SetChildIndex(this.cbo_tipolograd, 0);
            this.Controls.SetChildIndex(this.cbo_pais, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lbl_logradouro, 0);
            this.Controls.SetChildIndex(this.txt_bairro, 0);
            this.Controls.SetChildIndex(this.cbo_regiao, 0);
            this.Controls.SetChildIndex(this.txt_numero, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MeuTextBox txt_nome;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_codigo2;
        private System.Windows.Forms.Label lbl_codigo1;
        private System.Windows.Forms.Label lbl_telefone;
        private MeuMskTextBox msk_telefone;
        private System.Windows.Forms.DataGridView dgv_dados;
        private System.Windows.Forms.Label label2;
        private MeuTextBox txt_numero;
        private MeuComboBox cbo_regiao;
        private MeuTextBox txt_bairro;
        private System.Windows.Forms.Label lbl_logradouro;
        private System.Windows.Forms.Label label1;
        private MeuComboBox cbo_pais;
        private MeuComboBox cbo_tipolograd;
        private System.Windows.Forms.Label lbl_pais;
        private System.Windows.Forms.Label lbl_regiao;
        private MeuTextBox txt_cidade;
        private System.Windows.Forms.Label lbl_cidade;
        private MeuTextBox txt_logradouro;
        private System.Windows.Forms.Label lbl_tipolograd;
        private MeuMskTextBox msk_cep;
        private System.Windows.Forms.Button btn_busca;
        private System.Windows.Forms.Label lbl_cep;
        private System.Windows.Forms.Label lbl_endereco;
    }
}
