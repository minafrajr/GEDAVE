namespace Gedave
{
    partial class frmFuncionario
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
            this.lbl_codigo1 = new System.Windows.Forms.Label();
            this.lbl_codigo2 = new System.Windows.Forms.Label();
            this.lbl_dataaniv = new System.Windows.Forms.Label();
            this.lbl_dataadmissao = new System.Windows.Forms.Label();
            this.lbl_tratamento = new System.Windows.Forms.Label();
            this.lbl_cargo = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_sobrenome = new System.Windows.Forms.Label();
            this.txt_nome = new Gedave.MeuTextBox();
            this.txt_sobrenome = new Gedave.MeuTextBox();
            this.txt_cargo = new Gedave.MeuTextBox();
            this.cbo_tratamento = new Gedave.MeuComboBox();
            this.dtp_aniversario = new System.Windows.Forms.DateTimePicker();
            this.dtp_admissao = new System.Windows.Forms.DateTimePicker();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.txt_numero = new Gedave.MeuTextBox();
            this.cbo_regiao = new Gedave.MeuComboBox();
            this.txt_bairro = new Gedave.MeuTextBox();
            this.lbl_logradouro = new System.Windows.Forms.Label();
            this.lbl_bairro = new System.Windows.Forms.Label();
            this.cbo_pais = new Gedave.MeuComboBox();
            this.cbo_tipolograd = new Gedave.MeuComboBox();
            this.msk_ramal = new Gedave.MeuMskTextBox();
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
            this.lbl_endereco = new System.Windows.Forms.Label();
            this.btn_busca = new System.Windows.Forms.Button();
            this.lbl_cep = new System.Windows.Forms.Label();
            this.dgv_dados = new System.Windows.Forms.DataGridView();
            this.btn_addfoto = new System.Windows.Forms.Button();
            this.ptb_fotofunc = new System.Windows.Forms.PictureBox();
            this.lbl_observ = new System.Windows.Forms.Label();
            this.txt_observacao = new Gedave.MeuTextBox();
            this.lbl_foto = new System.Windows.Forms.Label();
            this.ofd_abrirfotofunc = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_fotofunc)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_TituloForm
            // 
            this.lbl_TituloForm.Size = new System.Drawing.Size(397, 44);
            this.lbl_TituloForm.Text = "Gerenciar Funcionário";
            // 
            // lbl_codigo1
            // 
            this.lbl_codigo1.AutoSize = true;
            this.lbl_codigo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo1.Location = new System.Drawing.Point(39, 67);
            this.lbl_codigo1.Name = "lbl_codigo1";
            this.lbl_codigo1.Size = new System.Drawing.Size(63, 20);
            this.lbl_codigo1.TabIndex = 3;
            this.lbl_codigo1.Text = "Codigo:";
            this.lbl_codigo1.Visible = false;
            // 
            // lbl_codigo2
            // 
            this.lbl_codigo2.AutoSize = true;
            this.lbl_codigo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo2.Location = new System.Drawing.Point(95, 67);
            this.lbl_codigo2.Name = "lbl_codigo2";
            this.lbl_codigo2.Size = new System.Drawing.Size(27, 20);
            this.lbl_codigo2.TabIndex = 4;
            this.lbl_codigo2.Text = "00";
            this.lbl_codigo2.Visible = false;
            // 
            // lbl_dataaniv
            // 
            this.lbl_dataaniv.AutoSize = true;
            this.lbl_dataaniv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dataaniv.Location = new System.Drawing.Point(380, 129);
            this.lbl_dataaniv.Name = "lbl_dataaniv";
            this.lbl_dataaniv.Size = new System.Drawing.Size(47, 20);
            this.lbl_dataaniv.TabIndex = 5;
            this.lbl_dataaniv.Text = "Aniv.:";
            // 
            // lbl_dataadmissao
            // 
            this.lbl_dataadmissao.AutoSize = true;
            this.lbl_dataadmissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dataadmissao.Location = new System.Drawing.Point(345, 159);
            this.lbl_dataadmissao.Name = "lbl_dataadmissao";
            this.lbl_dataadmissao.Size = new System.Drawing.Size(83, 20);
            this.lbl_dataadmissao.TabIndex = 6;
            this.lbl_dataadmissao.Text = "Admissão:";
            // 
            // lbl_tratamento
            // 
            this.lbl_tratamento.AutoSize = true;
            this.lbl_tratamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tratamento.Location = new System.Drawing.Point(7, 128);
            this.lbl_tratamento.Name = "lbl_tratamento";
            this.lbl_tratamento.Size = new System.Drawing.Size(95, 20);
            this.lbl_tratamento.TabIndex = 7;
            this.lbl_tratamento.Text = "Tratamento:";
            // 
            // lbl_cargo
            // 
            this.lbl_cargo.AutoSize = true;
            this.lbl_cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cargo.Location = new System.Drawing.Point(150, 128);
            this.lbl_cargo.Name = "lbl_cargo";
            this.lbl_cargo.Size = new System.Drawing.Size(56, 20);
            this.lbl_cargo.TabIndex = 8;
            this.lbl_cargo.Text = "Cargo:";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(47, 94);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(55, 20);
            this.lbl_nome.TabIndex = 9;
            this.lbl_nome.Text = "Nome:";
            // 
            // lbl_sobrenome
            // 
            this.lbl_sobrenome.AutoSize = true;
            this.lbl_sobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sobrenome.Location = new System.Drawing.Point(258, 95);
            this.lbl_sobrenome.Name = "lbl_sobrenome";
            this.lbl_sobrenome.Size = new System.Drawing.Size(96, 20);
            this.lbl_sobrenome.TabIndex = 10;
            this.lbl_sobrenome.Text = "Sobrenome:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(99, 94);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(153, 20);
            this.txt_nome.TabIndex = 0;
            // 
            // txt_sobrenome
            // 
            this.txt_sobrenome.Location = new System.Drawing.Point(353, 95);
            this.txt_sobrenome.Name = "txt_sobrenome";
            this.txt_sobrenome.Size = new System.Drawing.Size(153, 20);
            this.txt_sobrenome.TabIndex = 1;
            // 
            // txt_cargo
            // 
            this.txt_cargo.Location = new System.Drawing.Point(203, 129);
            this.txt_cargo.Name = "txt_cargo";
            this.txt_cargo.Size = new System.Drawing.Size(171, 20);
            this.txt_cargo.TabIndex = 3;
            // 
            // cbo_tratamento
            // 
            this.cbo_tratamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbo_tratamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_tratamento.FormattingEnabled = true;
            this.cbo_tratamento.Items.AddRange(new object[] {
            "Sr.",
            "Sra.",
            "Srta.",
            "Dr.",
            "Dra."});
            this.cbo_tratamento.Location = new System.Drawing.Point(99, 126);
            this.cbo_tratamento.Name = "cbo_tratamento";
            this.cbo_tratamento.Size = new System.Drawing.Size(45, 21);
            this.cbo_tratamento.TabIndex = 2;
            // 
            // dtp_aniversario
            // 
            this.dtp_aniversario.Enabled = false;
            this.dtp_aniversario.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_aniversario.Location = new System.Drawing.Point(427, 128);
            this.dtp_aniversario.Name = "dtp_aniversario";
            this.dtp_aniversario.Size = new System.Drawing.Size(79, 20);
            this.dtp_aniversario.TabIndex = 4;
            // 
            // dtp_admissao
            // 
            this.dtp_admissao.Enabled = false;
            this.dtp_admissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_admissao.Location = new System.Drawing.Point(427, 159);
            this.dtp_admissao.Name = "dtp_admissao";
            this.dtp_admissao.Size = new System.Drawing.Size(79, 20);
            this.dtp_admissao.TabIndex = 5;
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numero.Location = new System.Drawing.Point(512, 226);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(30, 20);
            this.lbl_numero.TabIndex = 51;
            this.lbl_numero.Text = "Nº:";
            this.lbl_numero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(545, 223);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(48, 20);
            this.txt_numero.TabIndex = 10;
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
            this.cbo_regiao.Location = new System.Drawing.Point(545, 249);
            this.cbo_regiao.Name = "cbo_regiao";
            this.cbo_regiao.Size = new System.Drawing.Size(65, 21);
            this.cbo_regiao.TabIndex = 13;
            // 
            // txt_bairro
            // 
            this.txt_bairro.Location = new System.Drawing.Point(97, 246);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(139, 20);
            this.txt_bairro.TabIndex = 11;
            // 
            // lbl_logradouro
            // 
            this.lbl_logradouro.AutoSize = true;
            this.lbl_logradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logradouro.Location = new System.Drawing.Point(187, 223);
            this.lbl_logradouro.Name = "lbl_logradouro";
            this.lbl_logradouro.Size = new System.Drawing.Size(49, 20);
            this.lbl_logradouro.TabIndex = 46;
            this.lbl_logradouro.Text = "Logr.:";
            this.lbl_logradouro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_bairro
            // 
            this.lbl_bairro.AutoSize = true;
            this.lbl_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bairro.Location = new System.Drawing.Point(41, 250);
            this.lbl_bairro.Name = "lbl_bairro";
            this.lbl_bairro.Size = new System.Drawing.Size(55, 20);
            this.lbl_bairro.TabIndex = 47;
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
            this.cbo_pais.Location = new System.Drawing.Point(97, 275);
            this.cbo_pais.Name = "cbo_pais";
            this.cbo_pais.Size = new System.Drawing.Size(112, 21);
            this.cbo_pais.TabIndex = 14;
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
            this.cbo_tipolograd.Location = new System.Drawing.Point(97, 221);
            this.cbo_tipolograd.Name = "cbo_tipolograd";
            this.cbo_tipolograd.Size = new System.Drawing.Size(79, 21);
            this.cbo_tipolograd.TabIndex = 8;
            // 
            // msk_ramal
            // 
            this.msk_ramal.Location = new System.Drawing.Point(482, 278);
            this.msk_ramal.Name = "msk_ramal";
            this.msk_ramal.Size = new System.Drawing.Size(64, 20);
            this.msk_ramal.TabIndex = 16;
            // 
            // msk_telefone
            // 
            this.msk_telefone.Location = new System.Drawing.Point(334, 276);
            this.msk_telefone.Mask = "(00) 0000-0000";
            this.msk_telefone.Name = "msk_telefone";
            this.msk_telefone.Size = new System.Drawing.Size(75, 20);
            this.msk_telefone.TabIndex = 15;
            // 
            // lbl_fax
            // 
            this.lbl_fax.AutoSize = true;
            this.lbl_fax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fax.Location = new System.Drawing.Point(423, 276);
            this.lbl_fax.Name = "lbl_fax";
            this.lbl_fax.Size = new System.Drawing.Size(59, 20);
            this.lbl_fax.TabIndex = 41;
            this.lbl_fax.Text = "Ramal:";
            this.lbl_fax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefone.Location = new System.Drawing.Point(259, 276);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(75, 20);
            this.lbl_telefone.TabIndex = 40;
            this.lbl_telefone.Text = "Telefone:";
            this.lbl_telefone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_pais
            // 
            this.lbl_pais.AutoSize = true;
            this.lbl_pais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pais.Location = new System.Drawing.Point(52, 274);
            this.lbl_pais.Name = "lbl_pais";
            this.lbl_pais.Size = new System.Drawing.Size(43, 20);
            this.lbl_pais.TabIndex = 39;
            this.lbl_pais.Text = "País:";
            this.lbl_pais.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_regiao
            // 
            this.lbl_regiao.AutoSize = true;
            this.lbl_regiao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_regiao.Location = new System.Drawing.Point(482, 250);
            this.lbl_regiao.Name = "lbl_regiao";
            this.lbl_regiao.Size = new System.Drawing.Size(64, 20);
            this.lbl_regiao.TabIndex = 38;
            this.lbl_regiao.Text = "Região:";
            this.lbl_regiao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(334, 249);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(133, 20);
            this.txt_cidade.TabIndex = 12;
            // 
            // lbl_cidade
            // 
            this.lbl_cidade.AutoSize = true;
            this.lbl_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cidade.Location = new System.Drawing.Point(267, 250);
            this.lbl_cidade.Name = "lbl_cidade";
            this.lbl_cidade.Size = new System.Drawing.Size(63, 20);
            this.lbl_cidade.TabIndex = 36;
            this.lbl_cidade.Text = "Cidade:";
            this.lbl_cidade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_logradouro
            // 
            this.txt_logradouro.Location = new System.Drawing.Point(237, 223);
            this.txt_logradouro.Name = "txt_logradouro";
            this.txt_logradouro.Size = new System.Drawing.Size(269, 20);
            this.txt_logradouro.TabIndex = 9;
            // 
            // lbl_tipolograd
            // 
            this.lbl_tipolograd.AutoSize = true;
            this.lbl_tipolograd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipolograd.Location = new System.Drawing.Point(51, 223);
            this.lbl_tipolograd.Name = "lbl_tipolograd";
            this.lbl_tipolograd.Size = new System.Drawing.Size(43, 20);
            this.lbl_tipolograd.TabIndex = 34;
            this.lbl_tipolograd.Text = "Tipo:";
            this.lbl_tipolograd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // msk_cep
            // 
            this.msk_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_cep.HidePromptOnLeave = true;
            this.msk_cep.Location = new System.Drawing.Point(99, 194);
            this.msk_cep.Margin = new System.Windows.Forms.Padding(0);
            this.msk_cep.Mask = "99999-999";
            this.msk_cep.Name = "msk_cep";
            this.msk_cep.Size = new System.Drawing.Size(63, 20);
            this.msk_cep.TabIndex = 6;
            this.msk_cep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lbl_endereco
            // 
            this.lbl_endereco.AutoSize = true;
            this.lbl_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_endereco.Location = new System.Drawing.Point(12, 181);
            this.lbl_endereco.Name = "lbl_endereco";
            this.lbl_endereco.Size = new System.Drawing.Size(53, 13);
            this.lbl_endereco.TabIndex = 32;
            this.lbl_endereco.Text = "Endereço";
            this.lbl_endereco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_busca
            // 
            this.btn_busca.Location = new System.Drawing.Point(164, 192);
            this.btn_busca.Name = "btn_busca";
            this.btn_busca.Size = new System.Drawing.Size(68, 25);
            this.btn_busca.TabIndex = 7;
            this.btn_busca.Text = "Buscar";
            this.btn_busca.UseVisualStyleBackColor = true;
            this.btn_busca.Click += new System.EventHandler(this.btn_busca_Click);
            // 
            // lbl_cep
            // 
            this.lbl_cep.AutoSize = true;
            this.lbl_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cep.Location = new System.Drawing.Point(51, 194);
            this.lbl_cep.Name = "lbl_cep";
            this.lbl_cep.Size = new System.Drawing.Size(45, 20);
            this.lbl_cep.TabIndex = 30;
            this.lbl_cep.Text = "CEP:";
            this.lbl_cep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgv_dados
            // 
            this.dgv_dados.AllowUserToAddRows = false;
            this.dgv_dados.AllowUserToDeleteRows = false;
            this.dgv_dados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_dados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgv_dados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dgv_dados.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dados.Location = new System.Drawing.Point(0, 308);
            this.dgv_dados.Name = "dgv_dados";
            this.dgv_dados.ReadOnly = true;
            this.dgv_dados.Size = new System.Drawing.Size(884, 204);
            this.dgv_dados.TabIndex = 52;
            this.dgv_dados.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_dados_CellMouseClick);
            // 
            // btn_addfoto
            // 
            this.btn_addfoto.Location = new System.Drawing.Point(762, 264);
            this.btn_addfoto.Name = "btn_addfoto";
            this.btn_addfoto.Size = new System.Drawing.Size(75, 23);
            this.btn_addfoto.TabIndex = 18;
            this.btn_addfoto.Text = "Adicionar";
            this.btn_addfoto.UseVisualStyleBackColor = true;
            this.btn_addfoto.Click += new System.EventHandler(this.btn_addfoto_Click);
            // 
            // ptb_fotofunc
            // 
            this.ptb_fotofunc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptb_fotofunc.Location = new System.Drawing.Point(735, 121);
            this.ptb_fotofunc.Name = "ptb_fotofunc";
            this.ptb_fotofunc.Size = new System.Drawing.Size(121, 137);
            this.ptb_fotofunc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_fotofunc.TabIndex = 54;
            this.ptb_fotofunc.TabStop = false;
            // 
            // lbl_observ
            // 
            this.lbl_observ.AutoSize = true;
            this.lbl_observ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_observ.Location = new System.Drawing.Point(541, 96);
            this.lbl_observ.Name = "lbl_observ";
            this.lbl_observ.Size = new System.Drawing.Size(106, 20);
            this.lbl_observ.TabIndex = 55;
            this.lbl_observ.Text = "Observações:";
            // 
            // txt_observacao
            // 
            this.txt_observacao.Location = new System.Drawing.Point(545, 116);
            this.txt_observacao.Multiline = true;
            this.txt_observacao.Name = "txt_observacao";
            this.txt_observacao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_observacao.Size = new System.Drawing.Size(180, 98);
            this.txt_observacao.TabIndex = 17;
            // 
            // lbl_foto
            // 
            this.lbl_foto.AutoSize = true;
            this.lbl_foto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_foto.Location = new System.Drawing.Point(731, 98);
            this.lbl_foto.Name = "lbl_foto";
            this.lbl_foto.Size = new System.Drawing.Size(42, 20);
            this.lbl_foto.TabIndex = 57;
            this.lbl_foto.Text = "Foto";
            this.lbl_foto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ofd_abrirfotofunc
            // 
            this.ofd_abrirfotofunc.FileName = "openFileDialog1";
            // 
            // frmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(884, 512);
            this.Controls.Add(this.lbl_foto);
            this.Controls.Add(this.txt_observacao);
            this.Controls.Add(this.lbl_observ);
            this.Controls.Add(this.ptb_fotofunc);
            this.Controls.Add(this.btn_addfoto);
            this.Controls.Add(this.dgv_dados);
            this.Controls.Add(this.lbl_numero);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.cbo_regiao);
            this.Controls.Add(this.txt_bairro);
            this.Controls.Add(this.lbl_logradouro);
            this.Controls.Add(this.lbl_bairro);
            this.Controls.Add(this.cbo_pais);
            this.Controls.Add(this.cbo_tipolograd);
            this.Controls.Add(this.msk_ramal);
            this.Controls.Add(this.msk_telefone);
            this.Controls.Add(this.lbl_fax);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.lbl_pais);
            this.Controls.Add(this.lbl_regiao);
            this.Controls.Add(this.txt_cidade);
            this.Controls.Add(this.lbl_cidade);
            this.Controls.Add(this.txt_logradouro);
            this.Controls.Add(this.lbl_tipolograd);
            this.Controls.Add(this.msk_cep);
            this.Controls.Add(this.lbl_endereco);
            this.Controls.Add(this.btn_busca);
            this.Controls.Add(this.lbl_cep);
            this.Controls.Add(this.dtp_admissao);
            this.Controls.Add(this.dtp_aniversario);
            this.Controls.Add(this.cbo_tratamento);
            this.Controls.Add(this.txt_cargo);
            this.Controls.Add(this.txt_sobrenome);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_sobrenome);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_cargo);
            this.Controls.Add(this.lbl_tratamento);
            this.Controls.Add(this.lbl_dataadmissao);
            this.Controls.Add(this.lbl_dataaniv);
            this.Controls.Add(this.lbl_codigo2);
            this.Controls.Add(this.lbl_codigo1);
            this.Name = "frmFuncionario";
            this.Controls.SetChildIndex(this.lbl_codigo1, 0);
            this.Controls.SetChildIndex(this.lbl_TituloForm, 0);
            this.Controls.SetChildIndex(this.lbl_codigo2, 0);
            this.Controls.SetChildIndex(this.lbl_dataaniv, 0);
            this.Controls.SetChildIndex(this.lbl_dataadmissao, 0);
            this.Controls.SetChildIndex(this.lbl_tratamento, 0);
            this.Controls.SetChildIndex(this.lbl_cargo, 0);
            this.Controls.SetChildIndex(this.lbl_nome, 0);
            this.Controls.SetChildIndex(this.lbl_sobrenome, 0);
            this.Controls.SetChildIndex(this.txt_nome, 0);
            this.Controls.SetChildIndex(this.txt_sobrenome, 0);
            this.Controls.SetChildIndex(this.txt_cargo, 0);
            this.Controls.SetChildIndex(this.cbo_tratamento, 0);
            this.Controls.SetChildIndex(this.dtp_aniversario, 0);
            this.Controls.SetChildIndex(this.dtp_admissao, 0);
            this.Controls.SetChildIndex(this.lbl_cep, 0);
            this.Controls.SetChildIndex(this.btn_busca, 0);
            this.Controls.SetChildIndex(this.lbl_endereco, 0);
            this.Controls.SetChildIndex(this.msk_cep, 0);
            this.Controls.SetChildIndex(this.lbl_tipolograd, 0);
            this.Controls.SetChildIndex(this.txt_logradouro, 0);
            this.Controls.SetChildIndex(this.lbl_cidade, 0);
            this.Controls.SetChildIndex(this.txt_cidade, 0);
            this.Controls.SetChildIndex(this.lbl_regiao, 0);
            this.Controls.SetChildIndex(this.lbl_pais, 0);
            this.Controls.SetChildIndex(this.lbl_telefone, 0);
            this.Controls.SetChildIndex(this.lbl_fax, 0);
            this.Controls.SetChildIndex(this.msk_telefone, 0);
            this.Controls.SetChildIndex(this.msk_ramal, 0);
            this.Controls.SetChildIndex(this.cbo_tipolograd, 0);
            this.Controls.SetChildIndex(this.cbo_pais, 0);
            this.Controls.SetChildIndex(this.lbl_bairro, 0);
            this.Controls.SetChildIndex(this.lbl_logradouro, 0);
            this.Controls.SetChildIndex(this.txt_bairro, 0);
            this.Controls.SetChildIndex(this.cbo_regiao, 0);
            this.Controls.SetChildIndex(this.txt_numero, 0);
            this.Controls.SetChildIndex(this.lbl_numero, 0);
            this.Controls.SetChildIndex(this.dgv_dados, 0);
            this.Controls.SetChildIndex(this.btn_addfoto, 0);
            this.Controls.SetChildIndex(this.ptb_fotofunc, 0);
            this.Controls.SetChildIndex(this.lbl_observ, 0);
            this.Controls.SetChildIndex(this.txt_observacao, 0);
            this.Controls.SetChildIndex(this.lbl_foto, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_fotofunc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_codigo1;
        private System.Windows.Forms.Label lbl_codigo2;
        private System.Windows.Forms.Label lbl_dataaniv;
        private System.Windows.Forms.Label lbl_dataadmissao;
        private System.Windows.Forms.Label lbl_tratamento;
        private System.Windows.Forms.Label lbl_cargo;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_sobrenome;
        private MeuTextBox txt_nome;
        private MeuTextBox txt_sobrenome;
        private MeuTextBox txt_cargo;
        private MeuComboBox cbo_tratamento;
        private System.Windows.Forms.DateTimePicker dtp_aniversario;
        private System.Windows.Forms.DateTimePicker dtp_admissao;
        private System.Windows.Forms.Label lbl_numero;
        private MeuTextBox txt_numero;
        private MeuComboBox cbo_regiao;
        private MeuTextBox txt_bairro;
        private System.Windows.Forms.Label lbl_logradouro;
        private System.Windows.Forms.Label lbl_bairro;
        private MeuComboBox cbo_pais;
        private MeuComboBox cbo_tipolograd;
        private MeuMskTextBox msk_ramal;
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
        private System.Windows.Forms.Label lbl_endereco;
        private System.Windows.Forms.Button btn_busca;
        private System.Windows.Forms.Label lbl_cep;
        private System.Windows.Forms.DataGridView dgv_dados;
        private System.Windows.Forms.Button btn_addfoto;
        private System.Windows.Forms.PictureBox ptb_fotofunc;
        private System.Windows.Forms.Label lbl_observ;
        private MeuTextBox txt_observacao;
        private System.Windows.Forms.Label lbl_foto;
        private System.Windows.Forms.OpenFileDialog ofd_abrirfotofunc;
    }
}
