namespace CargoManagementSystem.Forms
{
    partial class OrderDetailsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.orderDetailsLabel = new System.Windows.Forms.Label();
            this.orderDetialsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.orderDetailPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.deleteOrderTab = new System.Windows.Forms.TabControl();
            this.orderDetailsPage = new System.Windows.Forms.TabPage();
            this.orderDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.updateOrderBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.fromLabel = new System.Windows.Forms.Label();
            this.fromBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.toLabel = new System.Windows.Forms.Label();
            this.toBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.transSizeBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.transNameBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.transOwnerBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.transTypeBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.orderDateLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.nationalityLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.orderDatePickerBox = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.phoneNoBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.customerNameBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.addressBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.weightBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.nationalityBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.itemNameBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.countryBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.emailBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.quantityBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.deleteOrderButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.deleteOrderDataGridView = new System.Windows.Forms.DataGridView();
            this.orderDetialsPanel.SuspendLayout();
            this.orderDetailPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.deleteOrderTab.SuspendLayout();
            this.orderDetailsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteOrderDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // orderDetailsLabel
            // 
            this.orderDetailsLabel.AutoSize = true;
            this.orderDetailsLabel.Font = new System.Drawing.Font("Monotype Corsiva", 30F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDetailsLabel.ForeColor = System.Drawing.Color.White;
            this.orderDetailsLabel.Location = new System.Drawing.Point(3, 0);
            this.orderDetailsLabel.Name = "orderDetailsLabel";
            this.orderDetailsLabel.Size = new System.Drawing.Size(277, 60);
            this.orderDetailsLabel.TabIndex = 10;
            this.orderDetailsLabel.Text = "Order Details";
            // 
            // orderDetialsPanel
            // 
            this.orderDetialsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.orderDetialsPanel.Controls.Add(this.orderDetailsLabel);
            this.orderDetialsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.orderDetialsPanel.Location = new System.Drawing.Point(0, 0);
            this.orderDetialsPanel.Name = "orderDetialsPanel";
            this.orderDetialsPanel.Size = new System.Drawing.Size(1429, 100);
            this.orderDetialsPanel.TabIndex = 11;
            // 
            // orderDetailPanel
            // 
            this.orderDetailPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.orderDetailPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.orderDetailPanel.Controls.Add(this.panel1);
            this.orderDetailPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderDetailPanel.Location = new System.Drawing.Point(0, 100);
            this.orderDetailPanel.Name = "orderDetailPanel";
            this.orderDetailPanel.Size = new System.Drawing.Size(1429, 665);
            this.orderDetailPanel.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1429, 665);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.deleteOrderTab);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1429, 665);
            this.panel2.TabIndex = 0;
            // 
            // deleteOrderTab
            // 
            this.deleteOrderTab.Controls.Add(this.orderDetailsPage);
            this.deleteOrderTab.Controls.Add(this.tabPage2);
            this.deleteOrderTab.Controls.Add(this.tabPage3);
            this.deleteOrderTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteOrderTab.Location = new System.Drawing.Point(0, 0);
            this.deleteOrderTab.Name = "deleteOrderTab";
            this.deleteOrderTab.SelectedIndex = 0;
            this.deleteOrderTab.Size = new System.Drawing.Size(1429, 665);
            this.deleteOrderTab.TabIndex = 15;
            this.deleteOrderTab.Enter += new System.EventHandler(this.deleteOrderTab_Enter);
            // 
            // orderDetailsPage
            // 
            this.orderDetailsPage.Controls.Add(this.orderDetailsDataGridView);
            this.orderDetailsPage.Location = new System.Drawing.Point(4, 25);
            this.orderDetailsPage.Name = "orderDetailsPage";
            this.orderDetailsPage.Padding = new System.Windows.Forms.Padding(3);
            this.orderDetailsPage.Size = new System.Drawing.Size(1421, 636);
            this.orderDetailsPage.TabIndex = 0;
            this.orderDetailsPage.Text = "Order Detials";
            this.orderDetailsPage.UseVisualStyleBackColor = true;
            // 
            // orderDetailsDataGridView
            // 
            this.orderDetailsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.orderDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDetailsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderDetailsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.orderDetailsDataGridView.Name = "orderDetailsDataGridView";
            this.orderDetailsDataGridView.RowHeadersWidth = 51;
            this.orderDetailsDataGridView.RowTemplate.Height = 24;
            this.orderDetailsDataGridView.Size = new System.Drawing.Size(1415, 630);
            this.orderDetailsDataGridView.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.updateOrderBtn);
            this.tabPage2.Controls.Add(this.fromLabel);
            this.tabPage2.Controls.Add(this.fromBox);
            this.tabPage2.Controls.Add(this.toLabel);
            this.tabPage2.Controls.Add(this.toBox);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.transSizeBox);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.transNameBox);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.transOwnerBox);
            this.tabPage2.Controls.Add(this.transTypeBox);
            this.tabPage2.Controls.Add(this.orderDateLabel);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.addressLabel);
            this.tabPage2.Controls.Add(this.nationalityLabel);
            this.tabPage2.Controls.Add(this.countryLabel);
            this.tabPage2.Controls.Add(this.emailLabel);
            this.tabPage2.Controls.Add(this.customerNameLabel);
            this.tabPage2.Controls.Add(this.orderDatePickerBox);
            this.tabPage2.Controls.Add(this.phoneNoBox);
            this.tabPage2.Controls.Add(this.customerNameBox);
            this.tabPage2.Controls.Add(this.addressBox);
            this.tabPage2.Controls.Add(this.weightBox);
            this.tabPage2.Controls.Add(this.nationalityBox);
            this.tabPage2.Controls.Add(this.itemNameBox);
            this.tabPage2.Controls.Add(this.countryBox);
            this.tabPage2.Controls.Add(this.emailBox);
            this.tabPage2.Controls.Add(this.quantityBox);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1421, 636);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Update Order";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // updateOrderBtn
            // 
            this.updateOrderBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.updateOrderBtn.BorderRadius = 20;
            this.updateOrderBtn.CheckedState.Parent = this.updateOrderBtn;
            this.updateOrderBtn.CustomImages.Parent = this.updateOrderBtn;
            this.updateOrderBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateOrderBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateOrderBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateOrderBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateOrderBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateOrderBtn.DisabledState.Parent = this.updateOrderBtn;
            this.updateOrderBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.updateOrderBtn.FillColor2 = System.Drawing.Color.DarkRed;
            this.updateOrderBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.updateOrderBtn.ForeColor = System.Drawing.Color.White;
            this.updateOrderBtn.HoverState.Parent = this.updateOrderBtn;
            this.updateOrderBtn.Location = new System.Drawing.Point(1190, 557);
            this.updateOrderBtn.Name = "updateOrderBtn";
            this.updateOrderBtn.ShadowDecoration.Parent = this.updateOrderBtn;
            this.updateOrderBtn.Size = new System.Drawing.Size(180, 45);
            this.updateOrderBtn.TabIndex = 113;
            this.updateOrderBtn.Text = "Update";
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromLabel.Location = new System.Drawing.Point(884, 357);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(131, 20);
            this.fromLabel.TabIndex = 112;
            this.fromLabel.Text = "From (Source)";
            // 
            // fromBox
            // 
            this.fromBox.BackColor = System.Drawing.Color.Transparent;
            this.fromBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.fromBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fromBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fromBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fromBox.FocusedState.Parent = this.fromBox;
            this.fromBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.fromBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.fromBox.HoverState.Parent = this.fromBox;
            this.fromBox.ItemHeight = 30;
            this.fromBox.Items.AddRange(new object[] {
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua and Barbuda",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Austrian Empire*",
            "Azerbaijan",
            "Baden*",
            "Bahamas, The",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Bavaria*",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin (Dahomey)",
            "Bolivia",
            "Bosnia and Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei",
            "Brunswick and Lüneburg",
            "Bulgaria",
            "Burkina Faso (Upper Volta)",
            "Burma",
            "Burundi",
            "Cabo Verde",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Cayman Islands, The",
            "Central African Republic",
            "Central American Federation*",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo Free State, The",
            "Costa Rica",
            "Cote d’Ivoire (Ivory Coast)",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czechia",
            "Czechoslovakia",
            "Democratic Republic of the Congo",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "Duchy of Parma, ",
            "East Germany (German Democratic Republic)*",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Eswatini",
            "Ethiopia",
            "Federal Government of Germany (1848-49)*",
            "Fiji",
            "Finland",
            "France",
            "Gabon",
            "Gambia, The",
            "Georgia",
            "Germany",
            "Ghana",
            "Grand Duchy of Tuscany, The*",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Hanover",
            "Hanseatic Republics*",
            "Hawaii",
            "Hesse",
            "Holy See",
            "Honduras",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Israel",
            "Italy",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kingdom of Serbia/Yugoslavia*",
            "Kiribati",
            "Korea",
            "Kosovo",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Lew Chew (Loochoo)*",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Mauritania",
            "Mauritius",
            "Mecklenburg-Schwerin*",
            "Mecklenburg-Strelitz*",
            "Mexico",
            "Micronesia",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Morocco",
            "Mozambique",
            "Namibia",
            "Nassau*",
            "Nauru",
            "Nepal",
            "Netherlands, The",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "North German Confederation*",
            "North German Union*",
            "North Macedonia",
            "Norway",
            "Oldenburg*",
            "Oman",
            "Orange Free State*",
            "Pakistan",
            "Palau",
            "Panama",
            "Papal States*",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Piedmont-Sardinia*",
            "Poland",
            "Portugal",
            "Qatar",
            "Republic of Genoa*",
            "Republic of Korea (South Korea)",
            "Republic of the Congo",
            "Romania",
            "Russia",
            "Rwanda",
            "Saint Kitts and Nevis",
            "Saint Lucia",
            "Saint Vincent and the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome and Principe",
            "Saudi Arabia",
            "Schaumburg-Lippe*",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Solomon Islands, The",
            "Somalia",
            "South Africa",
            "South Sudan",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Suriname",
            "Sweden",
            "Switzerland",
            "Syria",
            "Tajikistan",
            "Tanzania",
            "Texas*",
            "Thailand",
            "Timor-Leste",
            "Togo",
            "Tonga",
            "Trinidad and Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Tuvalu",
            "Two Sicilies",
            "Uganda",
            "Ukraine",
            "Union of Soviet Socialist Republics*",
            "United Arab Emirates, The",
            "United Kingdom, The",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Venezuela",
            "Vietnam",
            "Württemberg",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
            this.fromBox.ItemsAppearance.Parent = this.fromBox;
            this.fromBox.Location = new System.Drawing.Point(888, 380);
            this.fromBox.Name = "fromBox";
            this.fromBox.ShadowDecoration.Parent = this.fromBox;
            this.fromBox.Size = new System.Drawing.Size(233, 36);
            this.fromBox.TabIndex = 111;
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toLabel.Location = new System.Drawing.Point(884, 429);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(146, 20);
            this.toLabel.TabIndex = 110;
            this.toLabel.Text = "To (Destination)";
            // 
            // toBox
            // 
            this.toBox.BackColor = System.Drawing.Color.Transparent;
            this.toBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.toBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toBox.FocusedState.Parent = this.toBox;
            this.toBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.toBox.HoverState.Parent = this.toBox;
            this.toBox.ItemHeight = 30;
            this.toBox.Items.AddRange(new object[] {
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua and Barbuda",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Austrian Empire*",
            "Azerbaijan",
            "Baden*",
            "Bahamas, The",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Bavaria*",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin (Dahomey)",
            "Bolivia",
            "Bosnia and Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei",
            "Brunswick and Lüneburg",
            "Bulgaria",
            "Burkina Faso (Upper Volta)",
            "Burma",
            "Burundi",
            "Cabo Verde",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Cayman Islands, The",
            "Central African Republic",
            "Central American Federation*",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo Free State, The",
            "Costa Rica",
            "Cote d’Ivoire (Ivory Coast)",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czechia",
            "Czechoslovakia",
            "Democratic Republic of the Congo",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "Duchy of Parma, ",
            "East Germany (German Democratic Republic)*",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Eswatini",
            "Ethiopia",
            "Federal Government of Germany (1848-49)*",
            "Fiji",
            "Finland",
            "France",
            "Gabon",
            "Gambia, The",
            "Georgia",
            "Germany",
            "Ghana",
            "Grand Duchy of Tuscany, The*",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Hanover",
            "Hanseatic Republics*",
            "Hawaii",
            "Hesse",
            "Holy See",
            "Honduras",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Israel",
            "Italy",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kingdom of Serbia/Yugoslavia*",
            "Kiribati",
            "Korea",
            "Kosovo",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Lew Chew (Loochoo)*",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Mauritania",
            "Mauritius",
            "Mecklenburg-Schwerin*",
            "Mecklenburg-Strelitz*",
            "Mexico",
            "Micronesia",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Morocco",
            "Mozambique",
            "Namibia",
            "Nassau*",
            "Nauru",
            "Nepal",
            "Netherlands, The",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "North German Confederation*",
            "North German Union*",
            "North Macedonia",
            "Norway",
            "Oldenburg*",
            "Oman",
            "Orange Free State*",
            "Pakistan",
            "Palau",
            "Panama",
            "Papal States*",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Piedmont-Sardinia*",
            "Poland",
            "Portugal",
            "Qatar",
            "Republic of Genoa*",
            "Republic of Korea (South Korea)",
            "Republic of the Congo",
            "Romania",
            "Russia",
            "Rwanda",
            "Saint Kitts and Nevis",
            "Saint Lucia",
            "Saint Vincent and the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome and Principe",
            "Saudi Arabia",
            "Schaumburg-Lippe*",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Solomon Islands, The",
            "Somalia",
            "South Africa",
            "South Sudan",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Suriname",
            "Sweden",
            "Switzerland",
            "Syria",
            "Tajikistan",
            "Tanzania",
            "Texas*",
            "Thailand",
            "Timor-Leste",
            "Togo",
            "Tonga",
            "Trinidad and Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Tuvalu",
            "Two Sicilies",
            "Uganda",
            "Ukraine",
            "Union of Soviet Socialist Republics*",
            "United Arab Emirates, The",
            "United Kingdom, The",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Venezuela",
            "Vietnam",
            "Württemberg",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
            this.toBox.ItemsAppearance.Parent = this.toBox;
            this.toBox.Location = new System.Drawing.Point(888, 452);
            this.toBox.Name = "toBox";
            this.toBox.ShadowDecoration.Parent = this.toBox;
            this.toBox.Size = new System.Drawing.Size(233, 36);
            this.toBox.TabIndex = 109;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(591, 582);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(193, 20);
            this.label14.TabIndex = 108;
            this.label14.Text = "Owner Transport Size";
            // 
            // transSizeBox
            // 
            this.transSizeBox.AutoSize = true;
            this.transSizeBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transSizeBox.DefaultText = "";
            this.transSizeBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.transSizeBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.transSizeBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.transSizeBox.DisabledState.Parent = this.transSizeBox;
            this.transSizeBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.transSizeBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.transSizeBox.FocusedState.Parent = this.transSizeBox;
            this.transSizeBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.transSizeBox.ForeColor = System.Drawing.Color.Black;
            this.transSizeBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.transSizeBox.HoverState.Parent = this.transSizeBox;
            this.transSizeBox.Location = new System.Drawing.Point(595, 605);
            this.transSizeBox.Name = "transSizeBox";
            this.transSizeBox.PasswordChar = '\0';
            this.transSizeBox.PlaceholderText = "";
            this.transSizeBox.SelectedText = "";
            this.transSizeBox.ShadowDecoration.Parent = this.transSizeBox;
            this.transSizeBox.Size = new System.Drawing.Size(233, 36);
            this.transSizeBox.TabIndex = 107;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(591, 503);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(204, 20);
            this.label13.TabIndex = 106;
            this.label13.Text = "Owner Transport Name";
            // 
            // transNameBox
            // 
            this.transNameBox.AutoSize = true;
            this.transNameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transNameBox.DefaultText = "";
            this.transNameBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.transNameBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.transNameBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.transNameBox.DisabledState.Parent = this.transNameBox;
            this.transNameBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.transNameBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.transNameBox.FocusedState.Parent = this.transNameBox;
            this.transNameBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.transNameBox.ForeColor = System.Drawing.Color.Black;
            this.transNameBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.transNameBox.HoverState.Parent = this.transNameBox;
            this.transNameBox.Location = new System.Drawing.Point(595, 526);
            this.transNameBox.Name = "transNameBox";
            this.transNameBox.PasswordChar = '\0';
            this.transNameBox.PlaceholderText = "";
            this.transNameBox.SelectedText = "";
            this.transNameBox.ShadowDecoration.Parent = this.transNameBox;
            this.transNameBox.Size = new System.Drawing.Size(233, 36);
            this.transNameBox.TabIndex = 105;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(591, 429);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(204, 20);
            this.label12.TabIndex = 104;
            this.label12.Text = "Transport Owner Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(591, 357);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 20);
            this.label11.TabIndex = 103;
            this.label11.Text = "Transport Type";
            // 
            // transOwnerBox
            // 
            this.transOwnerBox.BackColor = System.Drawing.Color.Transparent;
            this.transOwnerBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.transOwnerBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.transOwnerBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.transOwnerBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.transOwnerBox.FocusedState.Parent = this.transOwnerBox;
            this.transOwnerBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.transOwnerBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.transOwnerBox.HoverState.Parent = this.transOwnerBox;
            this.transOwnerBox.ItemHeight = 30;
            this.transOwnerBox.ItemsAppearance.Parent = this.transOwnerBox;
            this.transOwnerBox.Location = new System.Drawing.Point(595, 452);
            this.transOwnerBox.Name = "transOwnerBox";
            this.transOwnerBox.ShadowDecoration.Parent = this.transOwnerBox;
            this.transOwnerBox.Size = new System.Drawing.Size(233, 36);
            this.transOwnerBox.TabIndex = 102;
            // 
            // transTypeBox
            // 
            this.transTypeBox.BackColor = System.Drawing.Color.Transparent;
            this.transTypeBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.transTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.transTypeBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.transTypeBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.transTypeBox.FocusedState.Parent = this.transTypeBox;
            this.transTypeBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.transTypeBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.transTypeBox.HoverState.Parent = this.transTypeBox;
            this.transTypeBox.ItemHeight = 30;
            this.transTypeBox.Items.AddRange(new object[] {
            "Airplane",
            "Ship",
            "Vehicle"});
            this.transTypeBox.ItemsAppearance.Parent = this.transTypeBox;
            this.transTypeBox.Location = new System.Drawing.Point(595, 379);
            this.transTypeBox.Name = "transTypeBox";
            this.transTypeBox.ShadowDecoration.Parent = this.transTypeBox;
            this.transTypeBox.Size = new System.Drawing.Size(233, 36);
            this.transTypeBox.TabIndex = 101;
            // 
            // orderDateLabel
            // 
            this.orderDateLabel.AutoSize = true;
            this.orderDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDateLabel.Location = new System.Drawing.Point(884, 503);
            this.orderDateLabel.Name = "orderDateLabel";
            this.orderDateLabel.Size = new System.Drawing.Size(103, 20);
            this.orderDateLabel.TabIndex = 100;
            this.orderDateLabel.Text = "Order Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(295, 575);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 20);
            this.label9.TabIndex = 99;
            this.label9.Text = "Item Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(295, 501);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 20);
            this.label8.TabIndex = 98;
            this.label8.Text = "item Weight (Kg)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(295, 429);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 97;
            this.label7.Text = "Item Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(295, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 20);
            this.label6.TabIndex = 96;
            this.label6.Text = "Mobile Number";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(1155, 357);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(78, 20);
            this.addressLabel.TabIndex = 95;
            this.addressLabel.Text = "Address";
            // 
            // nationalityLabel
            // 
            this.nationalityLabel.AutoSize = true;
            this.nationalityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nationalityLabel.Location = new System.Drawing.Point(5, 582);
            this.nationalityLabel.Name = "nationalityLabel";
            this.nationalityLabel.Size = new System.Drawing.Size(98, 20);
            this.nationalityLabel.TabIndex = 94;
            this.nationalityLabel.Text = "Nationality";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLabel.Location = new System.Drawing.Point(5, 503);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(74, 20);
            this.countryLabel.TabIndex = 93;
            this.countryLabel.Text = "Country";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(5, 429);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(63, 20);
            this.emailLabel.TabIndex = 92;
            this.emailLabel.Text = "E-mail";
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.Location = new System.Drawing.Point(5, 357);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(144, 20);
            this.customerNameLabel.TabIndex = 91;
            this.customerNameLabel.Text = "Customer Name";
            // 
            // orderDatePickerBox
            // 
            this.orderDatePickerBox.Checked = true;
            this.orderDatePickerBox.CheckedState.Parent = this.orderDatePickerBox;
            this.orderDatePickerBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.orderDatePickerBox.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.orderDatePickerBox.HoverState.Parent = this.orderDatePickerBox;
            this.orderDatePickerBox.Location = new System.Drawing.Point(888, 531);
            this.orderDatePickerBox.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.orderDatePickerBox.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.orderDatePickerBox.Name = "orderDatePickerBox";
            this.orderDatePickerBox.ShadowDecoration.Parent = this.orderDatePickerBox;
            this.orderDatePickerBox.Size = new System.Drawing.Size(233, 36);
            this.orderDatePickerBox.TabIndex = 90;
            this.orderDatePickerBox.Value = new System.DateTime(2022, 1, 27, 12, 36, 38, 846);
            // 
            // phoneNoBox
            // 
            this.phoneNoBox.AutoSize = true;
            this.phoneNoBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneNoBox.DefaultText = "";
            this.phoneNoBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phoneNoBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phoneNoBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneNoBox.DisabledState.Parent = this.phoneNoBox;
            this.phoneNoBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneNoBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneNoBox.FocusedState.Parent = this.phoneNoBox;
            this.phoneNoBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.phoneNoBox.ForeColor = System.Drawing.Color.Black;
            this.phoneNoBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneNoBox.HoverState.Parent = this.phoneNoBox;
            this.phoneNoBox.Location = new System.Drawing.Point(299, 380);
            this.phoneNoBox.Name = "phoneNoBox";
            this.phoneNoBox.PasswordChar = '\0';
            this.phoneNoBox.PlaceholderText = "Mobile Number";
            this.phoneNoBox.SelectedText = "";
            this.phoneNoBox.ShadowDecoration.Parent = this.phoneNoBox;
            this.phoneNoBox.Size = new System.Drawing.Size(233, 36);
            this.phoneNoBox.TabIndex = 89;
            // 
            // customerNameBox
            // 
            this.customerNameBox.AutoSize = true;
            this.customerNameBox.BackColor = System.Drawing.Color.White;
            this.customerNameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customerNameBox.DefaultText = "";
            this.customerNameBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.customerNameBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.customerNameBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerNameBox.DisabledState.Parent = this.customerNameBox;
            this.customerNameBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerNameBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerNameBox.FocusedState.Parent = this.customerNameBox;
            this.customerNameBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.customerNameBox.ForeColor = System.Drawing.Color.Black;
            this.customerNameBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerNameBox.HoverState.Parent = this.customerNameBox;
            this.customerNameBox.Location = new System.Drawing.Point(9, 380);
            this.customerNameBox.Name = "customerNameBox";
            this.customerNameBox.PasswordChar = '\0';
            this.customerNameBox.PlaceholderText = "Name";
            this.customerNameBox.SelectedText = "";
            this.customerNameBox.ShadowDecoration.Parent = this.customerNameBox;
            this.customerNameBox.Size = new System.Drawing.Size(233, 36);
            this.customerNameBox.TabIndex = 88;
            // 
            // addressBox
            // 
            this.addressBox.AutoSize = true;
            this.addressBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addressBox.DefaultText = "";
            this.addressBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addressBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addressBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addressBox.DisabledState.Parent = this.addressBox;
            this.addressBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addressBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addressBox.FocusedState.Parent = this.addressBox;
            this.addressBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addressBox.ForeColor = System.Drawing.Color.Black;
            this.addressBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addressBox.HoverState.Parent = this.addressBox;
            this.addressBox.Location = new System.Drawing.Point(1159, 380);
            this.addressBox.Name = "addressBox";
            this.addressBox.PasswordChar = '\0';
            this.addressBox.PlaceholderText = "Address";
            this.addressBox.SelectedText = "";
            this.addressBox.ShadowDecoration.Parent = this.addressBox;
            this.addressBox.Size = new System.Drawing.Size(233, 143);
            this.addressBox.TabIndex = 87;
            // 
            // weightBox
            // 
            this.weightBox.AutoSize = true;
            this.weightBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.weightBox.DefaultText = "";
            this.weightBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.weightBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.weightBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.weightBox.DisabledState.Parent = this.weightBox;
            this.weightBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.weightBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.weightBox.FocusedState.Parent = this.weightBox;
            this.weightBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.weightBox.ForeColor = System.Drawing.Color.Black;
            this.weightBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.weightBox.HoverState.Parent = this.weightBox;
            this.weightBox.Location = new System.Drawing.Point(299, 526);
            this.weightBox.Name = "weightBox";
            this.weightBox.PasswordChar = '\0';
            this.weightBox.PlaceholderText = "Weight in Kg";
            this.weightBox.SelectedText = "";
            this.weightBox.ShadowDecoration.Parent = this.weightBox;
            this.weightBox.Size = new System.Drawing.Size(233, 36);
            this.weightBox.TabIndex = 86;
            // 
            // nationalityBox
            // 
            this.nationalityBox.AutoSize = true;
            this.nationalityBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nationalityBox.DefaultText = "";
            this.nationalityBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nationalityBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nationalityBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nationalityBox.DisabledState.Parent = this.nationalityBox;
            this.nationalityBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nationalityBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nationalityBox.FocusedState.Parent = this.nationalityBox;
            this.nationalityBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nationalityBox.ForeColor = System.Drawing.Color.Black;
            this.nationalityBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nationalityBox.HoverState.Parent = this.nationalityBox;
            this.nationalityBox.Location = new System.Drawing.Point(9, 605);
            this.nationalityBox.Name = "nationalityBox";
            this.nationalityBox.PasswordChar = '\0';
            this.nationalityBox.PlaceholderText = "Nationality";
            this.nationalityBox.SelectedText = "";
            this.nationalityBox.ShadowDecoration.Parent = this.nationalityBox;
            this.nationalityBox.Size = new System.Drawing.Size(233, 36);
            this.nationalityBox.TabIndex = 85;
            // 
            // itemNameBox
            // 
            this.itemNameBox.AutoSize = true;
            this.itemNameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.itemNameBox.DefaultText = "";
            this.itemNameBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.itemNameBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.itemNameBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.itemNameBox.DisabledState.Parent = this.itemNameBox;
            this.itemNameBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.itemNameBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.itemNameBox.FocusedState.Parent = this.itemNameBox;
            this.itemNameBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.itemNameBox.ForeColor = System.Drawing.Color.Black;
            this.itemNameBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.itemNameBox.HoverState.Parent = this.itemNameBox;
            this.itemNameBox.Location = new System.Drawing.Point(299, 452);
            this.itemNameBox.Name = "itemNameBox";
            this.itemNameBox.PasswordChar = '\0';
            this.itemNameBox.PlaceholderText = "item Name";
            this.itemNameBox.SelectedText = "";
            this.itemNameBox.ShadowDecoration.Parent = this.itemNameBox;
            this.itemNameBox.Size = new System.Drawing.Size(233, 36);
            this.itemNameBox.TabIndex = 84;
            // 
            // countryBox
            // 
            this.countryBox.AutoSize = true;
            this.countryBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.countryBox.DefaultText = "";
            this.countryBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.countryBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.countryBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.countryBox.DisabledState.Parent = this.countryBox;
            this.countryBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.countryBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.countryBox.FocusedState.Parent = this.countryBox;
            this.countryBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.countryBox.ForeColor = System.Drawing.Color.Black;
            this.countryBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.countryBox.HoverState.Parent = this.countryBox;
            this.countryBox.Location = new System.Drawing.Point(9, 526);
            this.countryBox.Name = "countryBox";
            this.countryBox.PasswordChar = '\0';
            this.countryBox.PlaceholderText = "Country";
            this.countryBox.SelectedText = "";
            this.countryBox.ShadowDecoration.Parent = this.countryBox;
            this.countryBox.Size = new System.Drawing.Size(233, 36);
            this.countryBox.TabIndex = 83;
            // 
            // emailBox
            // 
            this.emailBox.AutoSize = true;
            this.emailBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailBox.DefaultText = "";
            this.emailBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailBox.DisabledState.Parent = this.emailBox;
            this.emailBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailBox.FocusedState.Parent = this.emailBox;
            this.emailBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emailBox.ForeColor = System.Drawing.Color.Black;
            this.emailBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailBox.HoverState.Parent = this.emailBox;
            this.emailBox.Location = new System.Drawing.Point(9, 452);
            this.emailBox.Name = "emailBox";
            this.emailBox.PasswordChar = '\0';
            this.emailBox.PlaceholderText = "Email";
            this.emailBox.SelectedText = "";
            this.emailBox.ShadowDecoration.Parent = this.emailBox;
            this.emailBox.Size = new System.Drawing.Size(233, 36);
            this.emailBox.TabIndex = 82;
            // 
            // quantityBox
            // 
            this.quantityBox.AutoSize = true;
            this.quantityBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quantityBox.DefaultText = "";
            this.quantityBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.quantityBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.quantityBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.quantityBox.DisabledState.Parent = this.quantityBox;
            this.quantityBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.quantityBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quantityBox.FocusedState.Parent = this.quantityBox;
            this.quantityBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.quantityBox.ForeColor = System.Drawing.Color.Black;
            this.quantityBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quantityBox.HoverState.Parent = this.quantityBox;
            this.quantityBox.Location = new System.Drawing.Point(299, 605);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.PasswordChar = '\0';
            this.quantityBox.PlaceholderText = "Quantity in No";
            this.quantityBox.SelectedText = "";
            this.quantityBox.ShadowDecoration.Parent = this.quantityBox;
            this.quantityBox.Size = new System.Drawing.Size(233, 36);
            this.quantityBox.TabIndex = 81;
            // 
            // panel3
            // 
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.Color.Turquoise;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1415, 344);
            this.panel3.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1415, 344);
            this.dataGridView1.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.deleteOrderButton);
            this.tabPage3.Controls.Add(this.panel4);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1421, 636);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Delete Order";
            // 
            // deleteOrderButton
            // 
            this.deleteOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteOrderButton.BorderRadius = 20;
            this.deleteOrderButton.CheckedState.Parent = this.deleteOrderButton;
            this.deleteOrderButton.CustomImages.Parent = this.deleteOrderButton;
            this.deleteOrderButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteOrderButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteOrderButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteOrderButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteOrderButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteOrderButton.DisabledState.Parent = this.deleteOrderButton;
            this.deleteOrderButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.deleteOrderButton.FillColor2 = System.Drawing.Color.DarkRed;
            this.deleteOrderButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deleteOrderButton.ForeColor = System.Drawing.Color.White;
            this.deleteOrderButton.HoverState.Parent = this.deleteOrderButton;
            this.deleteOrderButton.Location = new System.Drawing.Point(1228, 510);
            this.deleteOrderButton.Name = "deleteOrderButton";
            this.deleteOrderButton.ShadowDecoration.Parent = this.deleteOrderButton;
            this.deleteOrderButton.Size = new System.Drawing.Size(180, 45);
            this.deleteOrderButton.TabIndex = 114;
            this.deleteOrderButton.Text = "Delete";
            this.deleteOrderButton.Click += new System.EventHandler(this.deleteOrderButton_Click);
            // 
            // panel4
            // 
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.BackColor = System.Drawing.Color.Violet;
            this.panel4.Controls.Add(this.deleteOrderDataGridView);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1421, 448);
            this.panel4.TabIndex = 0;
            // 
            // deleteOrderDataGridView
            // 
            this.deleteOrderDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.deleteOrderDataGridView.ColumnHeadersHeight = 29;
            this.deleteOrderDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteOrderDataGridView.Location = new System.Drawing.Point(0, 0);
            this.deleteOrderDataGridView.Name = "deleteOrderDataGridView";
            this.deleteOrderDataGridView.RowHeadersWidth = 51;
            this.deleteOrderDataGridView.Size = new System.Drawing.Size(1421, 448);
            this.deleteOrderDataGridView.TabIndex = 1;
            this.deleteOrderDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.deleteOrderDataGridView_CellClick_1);
            // 
            // OrderDetailsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.orderDetailPanel);
            this.Controls.Add(this.orderDetialsPanel);
            this.Name = "OrderDetailsControl";
            this.Size = new System.Drawing.Size(1429, 765);
            this.Load += new System.EventHandler(this.OrderDetailsControl_Load);
            this.orderDetialsPanel.ResumeLayout(false);
            this.orderDetialsPanel.PerformLayout();
            this.orderDetailPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.deleteOrderTab.ResumeLayout(false);
            this.orderDetailsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deleteOrderDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label orderDetailsLabel;
        private System.Windows.Forms.FlowLayoutPanel orderDetialsPanel;
        private System.Windows.Forms.Panel orderDetailPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl deleteOrderTab;
        private System.Windows.Forms.TabPage orderDetailsPage;
        private System.Windows.Forms.DataGridView orderDetailsDataGridView;
        private System.Windows.Forms.TabPage tabPage2;
        private Guna.UI2.WinForms.Guna2GradientButton updateOrderBtn;
        private System.Windows.Forms.Label fromLabel;
        private Guna.UI2.WinForms.Guna2ComboBox fromBox;
        private System.Windows.Forms.Label toLabel;
        private Guna.UI2.WinForms.Guna2ComboBox toBox;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2TextBox transSizeBox;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2TextBox transNameBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2ComboBox transOwnerBox;
        private Guna.UI2.WinForms.Guna2ComboBox transTypeBox;
        private System.Windows.Forms.Label orderDateLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label nationalityLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label customerNameLabel;
        private Guna.UI2.WinForms.Guna2DateTimePicker orderDatePickerBox;
        private Guna.UI2.WinForms.Guna2TextBox phoneNoBox;
        private Guna.UI2.WinForms.Guna2TextBox customerNameBox;
        private Guna.UI2.WinForms.Guna2TextBox addressBox;
        private Guna.UI2.WinForms.Guna2TextBox weightBox;
        private Guna.UI2.WinForms.Guna2TextBox nationalityBox;
        private Guna.UI2.WinForms.Guna2TextBox itemNameBox;
        private Guna.UI2.WinForms.Guna2TextBox countryBox;
        private Guna.UI2.WinForms.Guna2TextBox emailBox;
        private Guna.UI2.WinForms.Guna2TextBox quantityBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage3;
        private Guna.UI2.WinForms.Guna2GradientButton deleteOrderButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView deleteOrderDataGridView;
    }
}
