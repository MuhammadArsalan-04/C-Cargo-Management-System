namespace CargoManagementSystem.Forms
{
    partial class RegistrationDetailsControl
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
            this.registrationLabel = new System.Windows.Forms.Label();
            this.registrationPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.registrationDetailPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.registrationDetailsTab = new System.Windows.Forms.TabPage();
            this.registrationDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.updateRegistrationTab = new System.Windows.Forms.TabPage();
            this.countryBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.updateRegBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.genderBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.updateRegDataGridPanel = new System.Windows.Forms.Panel();
            this.updateRegistrationDataGridView = new System.Windows.Forms.DataGridView();
            this.countryLabel = new System.Windows.Forms.Label();
            this.ownerNameLabel = new System.Windows.Forms.Label();
            this.transportTypeLabel = new System.Windows.Forms.Label();
            this.transportTypeBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.transportSizeLabel = new System.Windows.Forms.Label();
            this.transportSizeBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.regDateLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.dateTimePickerBox = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.nationalityLabel = new System.Windows.Forms.Label();
            this.transNameBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.genderLabel = new System.Windows.Forms.Label();
            this.transportNameLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.fullNameBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.emailBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.nationalityBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.deleteRegistrationTab = new System.Windows.Forms.TabPage();
            this.deleteRegBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.deleteRegDataGridPanel = new System.Windows.Forms.Panel();
            this.deleteRegistrationDataGridView = new System.Windows.Forms.DataGridView();
            this.registrationForm1 = new CargoManagementSystem.Forms.RegistrationForm();
            this.registrationPanel.SuspendLayout();
            this.registrationDetailPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.registrationDetailsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registrationDetailsDataGridView)).BeginInit();
            this.updateRegistrationTab.SuspendLayout();
            this.updateRegDataGridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updateRegistrationDataGridView)).BeginInit();
            this.deleteRegistrationTab.SuspendLayout();
            this.deleteRegDataGridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteRegistrationDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // registrationLabel
            // 
            this.registrationLabel.AutoSize = true;
            this.registrationLabel.Font = new System.Drawing.Font("Monotype Corsiva", 30F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationLabel.ForeColor = System.Drawing.Color.White;
            this.registrationLabel.Location = new System.Drawing.Point(3, 0);
            this.registrationLabel.Name = "registrationLabel";
            this.registrationLabel.Size = new System.Drawing.Size(403, 60);
            this.registrationLabel.TabIndex = 10;
            this.registrationLabel.Text = "Registration Details";
            // 
            // registrationPanel
            // 
            this.registrationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.registrationPanel.Controls.Add(this.registrationLabel);
            this.registrationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.registrationPanel.Location = new System.Drawing.Point(0, 0);
            this.registrationPanel.Name = "registrationPanel";
            this.registrationPanel.Size = new System.Drawing.Size(1298, 100);
            this.registrationPanel.TabIndex = 11;
            // 
            // registrationDetailPanel
            // 
            this.registrationDetailPanel.BackColor = System.Drawing.Color.White;
            this.registrationDetailPanel.Controls.Add(this.panel1);
            this.registrationDetailPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registrationDetailPanel.Location = new System.Drawing.Point(0, 100);
            this.registrationDetailPanel.Name = "registrationDetailPanel";
            this.registrationDetailPanel.Size = new System.Drawing.Size(1298, 637);
            this.registrationDetailPanel.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.registrationForm1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1298, 637);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.registrationDetailsTab);
            this.tabControl1.Controls.Add(this.updateRegistrationTab);
            this.tabControl1.Controls.Add(this.deleteRegistrationTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1298, 637);
            this.tabControl1.TabIndex = 14;
            // 
            // registrationDetailsTab
            // 
            this.registrationDetailsTab.Controls.Add(this.registrationDetailsDataGridView);
            this.registrationDetailsTab.Location = new System.Drawing.Point(4, 25);
            this.registrationDetailsTab.Name = "registrationDetailsTab";
            this.registrationDetailsTab.Padding = new System.Windows.Forms.Padding(3);
            this.registrationDetailsTab.Size = new System.Drawing.Size(1290, 608);
            this.registrationDetailsTab.TabIndex = 0;
            this.registrationDetailsTab.Text = "Registration Details";
            this.registrationDetailsTab.UseVisualStyleBackColor = true;
            // 
            // registrationDetailsDataGridView
            // 
            this.registrationDetailsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.registrationDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registrationDetailsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registrationDetailsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.registrationDetailsDataGridView.Name = "registrationDetailsDataGridView";
            this.registrationDetailsDataGridView.RowHeadersWidth = 51;
            this.registrationDetailsDataGridView.RowTemplate.Height = 24;
            this.registrationDetailsDataGridView.Size = new System.Drawing.Size(1284, 602);
            this.registrationDetailsDataGridView.TabIndex = 1;
            // 
            // updateRegistrationTab
            // 
            this.updateRegistrationTab.Controls.Add(this.countryBox);
            this.updateRegistrationTab.Controls.Add(this.updateRegBtn);
            this.updateRegistrationTab.Controls.Add(this.genderBox);
            this.updateRegistrationTab.Controls.Add(this.updateRegDataGridPanel);
            this.updateRegistrationTab.Controls.Add(this.countryLabel);
            this.updateRegistrationTab.Controls.Add(this.ownerNameLabel);
            this.updateRegistrationTab.Controls.Add(this.transportTypeLabel);
            this.updateRegistrationTab.Controls.Add(this.transportTypeBox);
            this.updateRegistrationTab.Controls.Add(this.transportSizeLabel);
            this.updateRegistrationTab.Controls.Add(this.transportSizeBox);
            this.updateRegistrationTab.Controls.Add(this.regDateLabel);
            this.updateRegistrationTab.Controls.Add(this.emailLabel);
            this.updateRegistrationTab.Controls.Add(this.dateTimePickerBox);
            this.updateRegistrationTab.Controls.Add(this.nationalityLabel);
            this.updateRegistrationTab.Controls.Add(this.transNameBox);
            this.updateRegistrationTab.Controls.Add(this.genderLabel);
            this.updateRegistrationTab.Controls.Add(this.transportNameLabel);
            this.updateRegistrationTab.Controls.Add(this.phoneLabel);
            this.updateRegistrationTab.Controls.Add(this.phoneBox);
            this.updateRegistrationTab.Controls.Add(this.fullNameBox);
            this.updateRegistrationTab.Controls.Add(this.emailBox);
            this.updateRegistrationTab.Controls.Add(this.nationalityBox);
            this.updateRegistrationTab.Location = new System.Drawing.Point(4, 25);
            this.updateRegistrationTab.Name = "updateRegistrationTab";
            this.updateRegistrationTab.Padding = new System.Windows.Forms.Padding(3);
            this.updateRegistrationTab.Size = new System.Drawing.Size(1290, 608);
            this.updateRegistrationTab.TabIndex = 1;
            this.updateRegistrationTab.Text = "Update Registration";
            this.updateRegistrationTab.UseVisualStyleBackColor = true;
            // 
            // countryBox
            // 
            this.countryBox.BackColor = System.Drawing.Color.Transparent;
            this.countryBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.countryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countryBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.countryBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.countryBox.FocusedState.Parent = this.countryBox;
            this.countryBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.countryBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.countryBox.HoverState.Parent = this.countryBox;
            this.countryBox.ItemHeight = 30;
            this.countryBox.Items.AddRange(new object[] {
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
            this.countryBox.ItemsAppearance.Parent = this.countryBox;
            this.countryBox.Location = new System.Drawing.Point(665, 561);
            this.countryBox.Name = "countryBox";
            this.countryBox.ShadowDecoration.Parent = this.countryBox;
            this.countryBox.Size = new System.Drawing.Size(237, 36);
            this.countryBox.TabIndex = 88;
            // 
            // updateRegBtn
            // 
            this.updateRegBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.updateRegBtn.BorderRadius = 20;
            this.updateRegBtn.CheckedState.Parent = this.updateRegBtn;
            this.updateRegBtn.CustomImages.Parent = this.updateRegBtn;
            this.updateRegBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateRegBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateRegBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateRegBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateRegBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateRegBtn.DisabledState.Parent = this.updateRegBtn;
            this.updateRegBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.updateRegBtn.FillColor2 = System.Drawing.Color.DarkRed;
            this.updateRegBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.updateRegBtn.ForeColor = System.Drawing.Color.White;
            this.updateRegBtn.HoverState.Parent = this.updateRegBtn;
            this.updateRegBtn.Location = new System.Drawing.Point(1091, 526);
            this.updateRegBtn.Name = "updateRegBtn";
            this.updateRegBtn.ShadowDecoration.Parent = this.updateRegBtn;
            this.updateRegBtn.Size = new System.Drawing.Size(180, 45);
            this.updateRegBtn.TabIndex = 78;
            this.updateRegBtn.Text = "Update";
            this.updateRegBtn.Click += new System.EventHandler(this.updateRegBtn_Click);
            // 
            // genderBox
            // 
            this.genderBox.AllowDrop = true;
            this.genderBox.BackColor = System.Drawing.Color.Transparent;
            this.genderBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.genderBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.genderBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.genderBox.FocusedState.Parent = this.genderBox;
            this.genderBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.genderBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.genderBox.HoverState.Parent = this.genderBox;
            this.genderBox.ItemHeight = 30;
            this.genderBox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.genderBox.ItemsAppearance.Parent = this.genderBox;
            this.genderBox.Location = new System.Drawing.Point(343, 484);
            this.genderBox.Name = "genderBox";
            this.genderBox.ShadowDecoration.Parent = this.genderBox;
            this.genderBox.Size = new System.Drawing.Size(237, 36);
            this.genderBox.TabIndex = 87;
            // 
            // updateRegDataGridPanel
            // 
            this.updateRegDataGridPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.updateRegDataGridPanel.BackColor = System.Drawing.Color.IndianRed;
            this.updateRegDataGridPanel.Controls.Add(this.updateRegistrationDataGridView);
            this.updateRegDataGridPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.updateRegDataGridPanel.Location = new System.Drawing.Point(3, 3);
            this.updateRegDataGridPanel.Name = "updateRegDataGridPanel";
            this.updateRegDataGridPanel.Size = new System.Drawing.Size(1284, 385);
            this.updateRegDataGridPanel.TabIndex = 3;
            // 
            // updateRegistrationDataGridView
            // 
            this.updateRegistrationDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.updateRegistrationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.updateRegistrationDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateRegistrationDataGridView.Location = new System.Drawing.Point(0, 0);
            this.updateRegistrationDataGridView.Name = "updateRegistrationDataGridView";
            this.updateRegistrationDataGridView.RowHeadersWidth = 51;
            this.updateRegistrationDataGridView.RowTemplate.Height = 24;
            this.updateRegistrationDataGridView.Size = new System.Drawing.Size(1284, 385);
            this.updateRegistrationDataGridView.TabIndex = 2;
            this.updateRegistrationDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.updateRegistrationDataGridView_CellClick);
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLabel.Location = new System.Drawing.Point(662, 542);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(59, 16);
            this.countryLabel.TabIndex = 86;
            this.countryLabel.Text = "Country";
            // 
            // ownerNameLabel
            // 
            this.ownerNameLabel.AutoSize = true;
            this.ownerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ownerNameLabel.Location = new System.Drawing.Point(6, 391);
            this.ownerNameLabel.Name = "ownerNameLabel";
            this.ownerNameLabel.Size = new System.Drawing.Size(120, 16);
            this.ownerNameLabel.TabIndex = 71;
            this.ownerNameLabel.Text = "Owner FullName";
            // 
            // transportTypeLabel
            // 
            this.transportTypeLabel.AutoSize = true;
            this.transportTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transportTypeLabel.Location = new System.Drawing.Point(962, 391);
            this.transportTypeLabel.Name = "transportTypeLabel";
            this.transportTypeLabel.Size = new System.Drawing.Size(110, 16);
            this.transportTypeLabel.TabIndex = 85;
            this.transportTypeLabel.Text = "TransportType";
            // 
            // transportTypeBox
            // 
            this.transportTypeBox.BackColor = System.Drawing.Color.Transparent;
            this.transportTypeBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.transportTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.transportTypeBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.transportTypeBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.transportTypeBox.FocusedState.Parent = this.transportTypeBox;
            this.transportTypeBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.transportTypeBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.transportTypeBox.HoverState.Parent = this.transportTypeBox;
            this.transportTypeBox.ItemHeight = 30;
            this.transportTypeBox.Items.AddRange(new object[] {
            "AirPlane",
            "Ship",
            "Vehicle"});
            this.transportTypeBox.ItemsAppearance.Parent = this.transportTypeBox;
            this.transportTypeBox.Location = new System.Drawing.Point(965, 410);
            this.transportTypeBox.Name = "transportTypeBox";
            this.transportTypeBox.ShadowDecoration.Parent = this.transportTypeBox;
            this.transportTypeBox.Size = new System.Drawing.Size(237, 36);
            this.transportTypeBox.TabIndex = 69;
            // 
            // transportSizeLabel
            // 
            this.transportSizeLabel.AutoSize = true;
            this.transportSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transportSizeLabel.Location = new System.Drawing.Point(662, 391);
            this.transportSizeLabel.Name = "transportSizeLabel";
            this.transportSizeLabel.Size = new System.Drawing.Size(108, 16);
            this.transportSizeLabel.TabIndex = 84;
            this.transportSizeLabel.Text = "Transport Size";
            // 
            // transportSizeBox
            // 
            this.transportSizeBox.BackColor = System.Drawing.Color.Transparent;
            this.transportSizeBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.transportSizeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.transportSizeBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.transportSizeBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.transportSizeBox.FocusedState.Parent = this.transportSizeBox;
            this.transportSizeBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.transportSizeBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.transportSizeBox.HoverState.Parent = this.transportSizeBox;
            this.transportSizeBox.ItemHeight = 30;
            this.transportSizeBox.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.transportSizeBox.ItemsAppearance.Parent = this.transportSizeBox;
            this.transportSizeBox.Location = new System.Drawing.Point(665, 410);
            this.transportSizeBox.Name = "transportSizeBox";
            this.transportSizeBox.ShadowDecoration.Parent = this.transportSizeBox;
            this.transportSizeBox.Size = new System.Drawing.Size(237, 36);
            this.transportSizeBox.TabIndex = 70;
            // 
            // regDateLabel
            // 
            this.regDateLabel.AutoSize = true;
            this.regDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regDateLabel.Location = new System.Drawing.Point(662, 465);
            this.regDateLabel.Name = "regDateLabel";
            this.regDateLabel.Size = new System.Drawing.Size(147, 16);
            this.regDateLabel.TabIndex = 83;
            this.regDateLabel.Text = "Date Of Registration";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(6, 465);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(51, 16);
            this.emailLabel.TabIndex = 72;
            this.emailLabel.Text = "E-Mail";
            // 
            // dateTimePickerBox
            // 
            this.dateTimePickerBox.Checked = true;
            this.dateTimePickerBox.CheckedState.Parent = this.dateTimePickerBox;
            this.dateTimePickerBox.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.dateTimePickerBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePickerBox.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePickerBox.HoverState.Parent = this.dateTimePickerBox;
            this.dateTimePickerBox.Location = new System.Drawing.Point(665, 484);
            this.dateTimePickerBox.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerBox.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerBox.Name = "dateTimePickerBox";
            this.dateTimePickerBox.ShadowDecoration.Parent = this.dateTimePickerBox;
            this.dateTimePickerBox.Size = new System.Drawing.Size(237, 36);
            this.dateTimePickerBox.TabIndex = 82;
            this.dateTimePickerBox.Value = new System.DateTime(2022, 1, 27, 0, 51, 54, 41);
            // 
            // nationalityLabel
            // 
            this.nationalityLabel.AutoSize = true;
            this.nationalityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nationalityLabel.Location = new System.Drawing.Point(6, 542);
            this.nationalityLabel.Name = "nationalityLabel";
            this.nationalityLabel.Size = new System.Drawing.Size(81, 16);
            this.nationalityLabel.TabIndex = 73;
            this.nationalityLabel.Text = "Nationality";
            // 
            // transNameBox
            // 
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
            this.transNameBox.Location = new System.Drawing.Point(343, 561);
            this.transNameBox.Name = "transNameBox";
            this.transNameBox.PasswordChar = '\0';
            this.transNameBox.PlaceholderText = "Transport Name";
            this.transNameBox.SelectedText = "";
            this.transNameBox.ShadowDecoration.Parent = this.transNameBox;
            this.transNameBox.Size = new System.Drawing.Size(237, 36);
            this.transNameBox.TabIndex = 81;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.Location = new System.Drawing.Point(340, 465);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(58, 16);
            this.genderLabel.TabIndex = 74;
            this.genderLabel.Text = "Gender";
            // 
            // transportNameLabel
            // 
            this.transportNameLabel.AutoSize = true;
            this.transportNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transportNameLabel.Location = new System.Drawing.Point(340, 542);
            this.transportNameLabel.Name = "transportNameLabel";
            this.transportNameLabel.Size = new System.Drawing.Size(115, 16);
            this.transportNameLabel.TabIndex = 80;
            this.transportNameLabel.Text = "TransportName";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(340, 391);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(105, 16);
            this.phoneLabel.TabIndex = 75;
            this.phoneLabel.Text = "PhoneNumber";
            // 
            // phoneBox
            // 
            this.phoneBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneBox.DefaultText = "";
            this.phoneBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phoneBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phoneBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneBox.DisabledState.Parent = this.phoneBox;
            this.phoneBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneBox.FocusedState.Parent = this.phoneBox;
            this.phoneBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.phoneBox.ForeColor = System.Drawing.Color.Black;
            this.phoneBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneBox.HoverState.Parent = this.phoneBox;
            this.phoneBox.Location = new System.Drawing.Point(343, 410);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.PasswordChar = '\0';
            this.phoneBox.PlaceholderText = "Phone Number";
            this.phoneBox.SelectedText = "";
            this.phoneBox.ShadowDecoration.Parent = this.phoneBox;
            this.phoneBox.Size = new System.Drawing.Size(237, 36);
            this.phoneBox.TabIndex = 79;
            // 
            // fullNameBox
            // 
            this.fullNameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fullNameBox.DefaultText = "";
            this.fullNameBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fullNameBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fullNameBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fullNameBox.DisabledState.Parent = this.fullNameBox;
            this.fullNameBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fullNameBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fullNameBox.FocusedState.Parent = this.fullNameBox;
            this.fullNameBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fullNameBox.ForeColor = System.Drawing.Color.Black;
            this.fullNameBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fullNameBox.HoverState.Parent = this.fullNameBox;
            this.fullNameBox.Location = new System.Drawing.Point(9, 410);
            this.fullNameBox.Name = "fullNameBox";
            this.fullNameBox.PasswordChar = '\0';
            this.fullNameBox.PlaceholderText = "FullName";
            this.fullNameBox.SelectedText = "";
            this.fullNameBox.ShadowDecoration.Parent = this.fullNameBox;
            this.fullNameBox.Size = new System.Drawing.Size(237, 36);
            this.fullNameBox.TabIndex = 76;
            // 
            // emailBox
            // 
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
            this.emailBox.Location = new System.Drawing.Point(9, 484);
            this.emailBox.Name = "emailBox";
            this.emailBox.PasswordChar = '\0';
            this.emailBox.PlaceholderText = "E-mail";
            this.emailBox.SelectedText = "";
            this.emailBox.ShadowDecoration.Parent = this.emailBox;
            this.emailBox.Size = new System.Drawing.Size(237, 36);
            this.emailBox.TabIndex = 78;
            // 
            // nationalityBox
            // 
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
            this.nationalityBox.Location = new System.Drawing.Point(9, 561);
            this.nationalityBox.Name = "nationalityBox";
            this.nationalityBox.PasswordChar = '\0';
            this.nationalityBox.PlaceholderText = "Nationality";
            this.nationalityBox.SelectedText = "";
            this.nationalityBox.ShadowDecoration.Parent = this.nationalityBox;
            this.nationalityBox.Size = new System.Drawing.Size(237, 36);
            this.nationalityBox.TabIndex = 77;
            // 
            // deleteRegistrationTab
            // 
            this.deleteRegistrationTab.Controls.Add(this.deleteRegBtn);
            this.deleteRegistrationTab.Controls.Add(this.deleteRegDataGridPanel);
            this.deleteRegistrationTab.Location = new System.Drawing.Point(4, 25);
            this.deleteRegistrationTab.Name = "deleteRegistrationTab";
            this.deleteRegistrationTab.Size = new System.Drawing.Size(1290, 608);
            this.deleteRegistrationTab.TabIndex = 2;
            this.deleteRegistrationTab.Text = "Delete Registration";
            this.deleteRegistrationTab.UseVisualStyleBackColor = true;
            // 
            // deleteRegBtn
            // 
            this.deleteRegBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteRegBtn.BorderRadius = 20;
            this.deleteRegBtn.CheckedState.Parent = this.deleteRegBtn;
            this.deleteRegBtn.CustomImages.Parent = this.deleteRegBtn;
            this.deleteRegBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteRegBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteRegBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteRegBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteRegBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteRegBtn.DisabledState.Parent = this.deleteRegBtn;
            this.deleteRegBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.deleteRegBtn.FillColor2 = System.Drawing.Color.DarkRed;
            this.deleteRegBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deleteRegBtn.ForeColor = System.Drawing.Color.White;
            this.deleteRegBtn.HoverState.Parent = this.deleteRegBtn;
            this.deleteRegBtn.Location = new System.Drawing.Point(1107, 470);
            this.deleteRegBtn.Name = "deleteRegBtn";
            this.deleteRegBtn.ShadowDecoration.Parent = this.deleteRegBtn;
            this.deleteRegBtn.Size = new System.Drawing.Size(180, 45);
            this.deleteRegBtn.TabIndex = 77;
            this.deleteRegBtn.Text = "Delete";
            // 
            // deleteRegDataGridPanel
            // 
            this.deleteRegDataGridPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteRegDataGridPanel.BackColor = System.Drawing.Color.RosyBrown;
            this.deleteRegDataGridPanel.Controls.Add(this.deleteRegistrationDataGridView);
            this.deleteRegDataGridPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.deleteRegDataGridPanel.Location = new System.Drawing.Point(0, 0);
            this.deleteRegDataGridPanel.Name = "deleteRegDataGridPanel";
            this.deleteRegDataGridPanel.Size = new System.Drawing.Size(1290, 388);
            this.deleteRegDataGridPanel.TabIndex = 3;
            // 
            // deleteRegistrationDataGridView
            // 
            this.deleteRegistrationDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.deleteRegistrationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deleteRegistrationDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteRegistrationDataGridView.Location = new System.Drawing.Point(0, 0);
            this.deleteRegistrationDataGridView.Name = "deleteRegistrationDataGridView";
            this.deleteRegistrationDataGridView.RowHeadersWidth = 51;
            this.deleteRegistrationDataGridView.RowTemplate.Height = 24;
            this.deleteRegistrationDataGridView.Size = new System.Drawing.Size(1290, 388);
            this.deleteRegistrationDataGridView.TabIndex = 2;
            // 
            // registrationForm1
            // 
            this.registrationForm1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.registrationForm1.BackColor = System.Drawing.Color.White;
            this.registrationForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registrationForm1.Location = new System.Drawing.Point(0, 0);
            this.registrationForm1.Name = "registrationForm1";
            this.registrationForm1.Size = new System.Drawing.Size(1298, 637);
            this.registrationForm1.TabIndex = 0;
            // 
            // RegistrationDetailsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.registrationDetailPanel);
            this.Controls.Add(this.registrationPanel);
            this.Name = "RegistrationDetailsControl";
            this.Size = new System.Drawing.Size(1298, 737);
            this.Load += new System.EventHandler(this.RegistrationDetailsControl_Load);
            this.registrationPanel.ResumeLayout(false);
            this.registrationPanel.PerformLayout();
            this.registrationDetailPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.registrationDetailsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.registrationDetailsDataGridView)).EndInit();
            this.updateRegistrationTab.ResumeLayout(false);
            this.updateRegistrationTab.PerformLayout();
            this.updateRegDataGridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.updateRegistrationDataGridView)).EndInit();
            this.deleteRegistrationTab.ResumeLayout(false);
            this.deleteRegDataGridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deleteRegistrationDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label registrationLabel;
        private System.Windows.Forms.FlowLayoutPanel registrationPanel;
        private System.Windows.Forms.Panel registrationDetailPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage registrationDetailsTab;
        private System.Windows.Forms.DataGridView registrationDetailsDataGridView;
        private System.Windows.Forms.TabPage updateRegistrationTab;
        private Guna.UI2.WinForms.Guna2GradientButton updateRegBtn;
        private System.Windows.Forms.Panel updateRegDataGridPanel;
        private System.Windows.Forms.DataGridView updateRegistrationDataGridView;
        private System.Windows.Forms.TabPage deleteRegistrationTab;
        private Guna.UI2.WinForms.Guna2GradientButton deleteRegBtn;
        private System.Windows.Forms.Panel deleteRegDataGridPanel;
        private System.Windows.Forms.DataGridView deleteRegistrationDataGridView;
        private RegistrationForm registrationForm1;
        private Guna.UI2.WinForms.Guna2ComboBox countryBox;
        private Guna.UI2.WinForms.Guna2ComboBox genderBox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label ownerNameLabel;
        private System.Windows.Forms.Label transportTypeLabel;
        private Guna.UI2.WinForms.Guna2ComboBox transportTypeBox;
        private System.Windows.Forms.Label transportSizeLabel;
        private Guna.UI2.WinForms.Guna2ComboBox transportSizeBox;
        private System.Windows.Forms.Label regDateLabel;
        private System.Windows.Forms.Label emailLabel;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerBox;
        private System.Windows.Forms.Label nationalityLabel;
        private Guna.UI2.WinForms.Guna2TextBox transNameBox;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label transportNameLabel;
        private System.Windows.Forms.Label phoneLabel;
        private Guna.UI2.WinForms.Guna2TextBox phoneBox;
        private Guna.UI2.WinForms.Guna2TextBox fullNameBox;
        private Guna.UI2.WinForms.Guna2TextBox emailBox;
        private Guna.UI2.WinForms.Guna2TextBox nationalityBox;
    }
}
