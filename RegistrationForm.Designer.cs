namespace CargoManagementSystem.Forms
{
    partial class RegistrationForm
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
            this.transportRegistrationLabel = new System.Windows.Forms.Label();
            this.registrationPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.registrationFormPanel = new System.Windows.Forms.Panel();
            this.transportRegisterBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.countryBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.genderBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.transportTypeLabel = new System.Windows.Forms.Label();
            this.transportSizeLabel = new System.Windows.Forms.Label();
            this.regDateLabel = new System.Windows.Forms.Label();
            this.dateTimePickerBox = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.transNameBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.transportNameLabel = new System.Windows.Forms.Label();
            this.phoneBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.emailBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.nationalityBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.fullNameBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.nationalityLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.ownerNameLabel = new System.Windows.Forms.Label();
            this.transportSizeBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.transportTypeBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.updateButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.registrationPanel.SuspendLayout();
            this.registrationFormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // transportRegistrationLabel
            // 
            this.transportRegistrationLabel.AutoSize = true;
            this.transportRegistrationLabel.Font = new System.Drawing.Font("Monotype Corsiva", 30F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transportRegistrationLabel.ForeColor = System.Drawing.Color.White;
            this.transportRegistrationLabel.Location = new System.Drawing.Point(3, 0);
            this.transportRegistrationLabel.Name = "transportRegistrationLabel";
            this.transportRegistrationLabel.Size = new System.Drawing.Size(560, 60);
            this.transportRegistrationLabel.TabIndex = 10;
            this.transportRegistrationLabel.Text = "Transport Registration Form";
            // 
            // registrationPanel
            // 
            this.registrationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.registrationPanel.Controls.Add(this.transportRegistrationLabel);
            this.registrationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.registrationPanel.Location = new System.Drawing.Point(0, 0);
            this.registrationPanel.Name = "registrationPanel";
            this.registrationPanel.Size = new System.Drawing.Size(954, 100);
            this.registrationPanel.TabIndex = 9;
            // 
            // registrationFormPanel
            // 
            this.registrationFormPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.registrationFormPanel.BackColor = System.Drawing.Color.Transparent;
            this.registrationFormPanel.Controls.Add(this.transportRegisterBtn);
            this.registrationFormPanel.Controls.Add(this.countryBox);
            this.registrationFormPanel.Controls.Add(this.genderBox);
            this.registrationFormPanel.Controls.Add(this.countryLabel);
            this.registrationFormPanel.Controls.Add(this.transportTypeLabel);
            this.registrationFormPanel.Controls.Add(this.transportSizeLabel);
            this.registrationFormPanel.Controls.Add(this.regDateLabel);
            this.registrationFormPanel.Controls.Add(this.dateTimePickerBox);
            this.registrationFormPanel.Controls.Add(this.transNameBox);
            this.registrationFormPanel.Controls.Add(this.transportNameLabel);
            this.registrationFormPanel.Controls.Add(this.phoneBox);
            this.registrationFormPanel.Controls.Add(this.emailBox);
            this.registrationFormPanel.Controls.Add(this.nationalityBox);
            this.registrationFormPanel.Controls.Add(this.fullNameBox);
            this.registrationFormPanel.Controls.Add(this.phoneLabel);
            this.registrationFormPanel.Controls.Add(this.genderLabel);
            this.registrationFormPanel.Controls.Add(this.nationalityLabel);
            this.registrationFormPanel.Controls.Add(this.emailLabel);
            this.registrationFormPanel.Controls.Add(this.ownerNameLabel);
            this.registrationFormPanel.Controls.Add(this.transportSizeBox);
            this.registrationFormPanel.Controls.Add(this.transportTypeBox);
            this.registrationFormPanel.Controls.Add(this.updateButton);
            this.registrationFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registrationFormPanel.Location = new System.Drawing.Point(0, 100);
            this.registrationFormPanel.Name = "registrationFormPanel";
            this.registrationFormPanel.Size = new System.Drawing.Size(954, 411);
            this.registrationFormPanel.TabIndex = 10;
            // 
            // transportRegisterBtn
            // 
            this.transportRegisterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.transportRegisterBtn.BorderRadius = 20;
            this.transportRegisterBtn.CheckedState.Parent = this.transportRegisterBtn;
            this.transportRegisterBtn.CustomImages.Parent = this.transportRegisterBtn;
            this.transportRegisterBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.transportRegisterBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.transportRegisterBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.transportRegisterBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.transportRegisterBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.transportRegisterBtn.DisabledState.Parent = this.transportRegisterBtn;
            this.transportRegisterBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.transportRegisterBtn.FillColor2 = System.Drawing.Color.DarkRed;
            this.transportRegisterBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.transportRegisterBtn.ForeColor = System.Drawing.Color.White;
            this.transportRegisterBtn.HoverState.Parent = this.transportRegisterBtn;
            this.transportRegisterBtn.Location = new System.Drawing.Point(732, 300);
            this.transportRegisterBtn.Name = "transportRegisterBtn";
            this.transportRegisterBtn.ShadowDecoration.Parent = this.transportRegisterBtn;
            this.transportRegisterBtn.Size = new System.Drawing.Size(180, 55);
            this.transportRegisterBtn.TabIndex = 69;
            this.transportRegisterBtn.Text = "Register";
            this.transportRegisterBtn.Click += new System.EventHandler(this.transportRegisterBtn_Click);
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
            this.countryBox.Location = new System.Drawing.Point(32, 300);
            this.countryBox.Name = "countryBox";
            this.countryBox.ShadowDecoration.Parent = this.countryBox;
            this.countryBox.Size = new System.Drawing.Size(237, 36);
            this.countryBox.TabIndex = 68;
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
            this.genderBox.Location = new System.Drawing.Point(366, 149);
            this.genderBox.Name = "genderBox";
            this.genderBox.ShadowDecoration.Parent = this.genderBox;
            this.genderBox.Size = new System.Drawing.Size(237, 36);
            this.genderBox.TabIndex = 67;
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLabel.Location = new System.Drawing.Point(29, 281);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(59, 16);
            this.countryLabel.TabIndex = 66;
            this.countryLabel.Text = "Country";
            // 
            // transportTypeLabel
            // 
            this.transportTypeLabel.AutoSize = true;
            this.transportTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transportTypeLabel.Location = new System.Drawing.Point(363, 281);
            this.transportTypeLabel.Name = "transportTypeLabel";
            this.transportTypeLabel.Size = new System.Drawing.Size(110, 16);
            this.transportTypeLabel.TabIndex = 65;
            this.transportTypeLabel.Text = "TransportType";
            // 
            // transportSizeLabel
            // 
            this.transportSizeLabel.AutoSize = true;
            this.transportSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transportSizeLabel.Location = new System.Drawing.Point(685, 56);
            this.transportSizeLabel.Name = "transportSizeLabel";
            this.transportSizeLabel.Size = new System.Drawing.Size(108, 16);
            this.transportSizeLabel.TabIndex = 64;
            this.transportSizeLabel.Text = "Transport Size";
            // 
            // regDateLabel
            // 
            this.regDateLabel.AutoSize = true;
            this.regDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regDateLabel.Location = new System.Drawing.Point(685, 130);
            this.regDateLabel.Name = "regDateLabel";
            this.regDateLabel.Size = new System.Drawing.Size(147, 16);
            this.regDateLabel.TabIndex = 63;
            this.regDateLabel.Text = "Date Of Registration";
            // 
            // dateTimePickerBox
            // 
            this.dateTimePickerBox.Checked = true;
            this.dateTimePickerBox.CheckedState.Parent = this.dateTimePickerBox;
            this.dateTimePickerBox.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.dateTimePickerBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePickerBox.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePickerBox.HoverState.Parent = this.dateTimePickerBox;
            this.dateTimePickerBox.Location = new System.Drawing.Point(688, 149);
            this.dateTimePickerBox.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerBox.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerBox.Name = "dateTimePickerBox";
            this.dateTimePickerBox.ShadowDecoration.Parent = this.dateTimePickerBox;
            this.dateTimePickerBox.Size = new System.Drawing.Size(237, 36);
            this.dateTimePickerBox.TabIndex = 62;
            this.dateTimePickerBox.Value = new System.DateTime(2022, 1, 27, 0, 51, 54, 41);
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
            this.transNameBox.Location = new System.Drawing.Point(366, 226);
            this.transNameBox.Name = "transNameBox";
            this.transNameBox.PasswordChar = '\0';
            this.transNameBox.PlaceholderText = "Transport Name";
            this.transNameBox.SelectedText = "";
            this.transNameBox.ShadowDecoration.Parent = this.transNameBox;
            this.transNameBox.Size = new System.Drawing.Size(237, 36);
            this.transNameBox.TabIndex = 61;
            // 
            // transportNameLabel
            // 
            this.transportNameLabel.AutoSize = true;
            this.transportNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transportNameLabel.Location = new System.Drawing.Point(363, 207);
            this.transportNameLabel.Name = "transportNameLabel";
            this.transportNameLabel.Size = new System.Drawing.Size(115, 16);
            this.transportNameLabel.TabIndex = 60;
            this.transportNameLabel.Text = "TransportName";
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
            this.phoneBox.Location = new System.Drawing.Point(366, 75);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.PasswordChar = '\0';
            this.phoneBox.PlaceholderText = "Phone Number";
            this.phoneBox.SelectedText = "";
            this.phoneBox.ShadowDecoration.Parent = this.phoneBox;
            this.phoneBox.Size = new System.Drawing.Size(237, 36);
            this.phoneBox.TabIndex = 59;
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
            this.emailBox.Location = new System.Drawing.Point(32, 149);
            this.emailBox.Name = "emailBox";
            this.emailBox.PasswordChar = '\0';
            this.emailBox.PlaceholderText = "E-mail";
            this.emailBox.SelectedText = "";
            this.emailBox.ShadowDecoration.Parent = this.emailBox;
            this.emailBox.Size = new System.Drawing.Size(237, 36);
            this.emailBox.TabIndex = 58;
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
            this.nationalityBox.Location = new System.Drawing.Point(32, 226);
            this.nationalityBox.Name = "nationalityBox";
            this.nationalityBox.PasswordChar = '\0';
            this.nationalityBox.PlaceholderText = "Nationality";
            this.nationalityBox.SelectedText = "";
            this.nationalityBox.ShadowDecoration.Parent = this.nationalityBox;
            this.nationalityBox.Size = new System.Drawing.Size(237, 36);
            this.nationalityBox.TabIndex = 57;
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
            this.fullNameBox.Location = new System.Drawing.Point(32, 75);
            this.fullNameBox.Name = "fullNameBox";
            this.fullNameBox.PasswordChar = '\0';
            this.fullNameBox.PlaceholderText = "FullName";
            this.fullNameBox.SelectedText = "";
            this.fullNameBox.ShadowDecoration.Parent = this.fullNameBox;
            this.fullNameBox.Size = new System.Drawing.Size(237, 36);
            this.fullNameBox.TabIndex = 56;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(363, 56);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(105, 16);
            this.phoneLabel.TabIndex = 55;
            this.phoneLabel.Text = "PhoneNumber";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.Location = new System.Drawing.Point(363, 130);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(58, 16);
            this.genderLabel.TabIndex = 54;
            this.genderLabel.Text = "Gender";
            // 
            // nationalityLabel
            // 
            this.nationalityLabel.AutoSize = true;
            this.nationalityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nationalityLabel.Location = new System.Drawing.Point(29, 207);
            this.nationalityLabel.Name = "nationalityLabel";
            this.nationalityLabel.Size = new System.Drawing.Size(81, 16);
            this.nationalityLabel.TabIndex = 53;
            this.nationalityLabel.Text = "Nationality";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(29, 130);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(51, 16);
            this.emailLabel.TabIndex = 52;
            this.emailLabel.Text = "E-Mail";
            // 
            // ownerNameLabel
            // 
            this.ownerNameLabel.AutoSize = true;
            this.ownerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ownerNameLabel.Location = new System.Drawing.Point(29, 56);
            this.ownerNameLabel.Name = "ownerNameLabel";
            this.ownerNameLabel.Size = new System.Drawing.Size(120, 16);
            this.ownerNameLabel.TabIndex = 51;
            this.ownerNameLabel.Text = "Owner FullName";
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
            this.transportSizeBox.Location = new System.Drawing.Point(688, 75);
            this.transportSizeBox.Name = "transportSizeBox";
            this.transportSizeBox.ShadowDecoration.Parent = this.transportSizeBox;
            this.transportSizeBox.Size = new System.Drawing.Size(237, 36);
            this.transportSizeBox.TabIndex = 50;
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
            this.transportTypeBox.Location = new System.Drawing.Point(366, 300);
            this.transportTypeBox.Name = "transportTypeBox";
            this.transportTypeBox.ShadowDecoration.Parent = this.transportTypeBox;
            this.transportTypeBox.Size = new System.Drawing.Size(237, 36);
            this.transportTypeBox.TabIndex = 49;
            // 
            // updateButton
            // 
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.updateButton.BorderRadius = 20;
            this.updateButton.CheckedState.Parent = this.updateButton;
            this.updateButton.CustomImages.Parent = this.updateButton;
            this.updateButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateButton.DisabledState.Parent = this.updateButton;
            this.updateButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.updateButton.FillColor2 = System.Drawing.Color.DarkRed;
            this.updateButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.updateButton.ForeColor = System.Drawing.Color.White;
            this.updateButton.HoverState.Parent = this.updateButton;
            this.updateButton.Location = new System.Drawing.Point(732, 300);
            this.updateButton.Name = "updateButton";
            this.updateButton.ShadowDecoration.Parent = this.updateButton;
            this.updateButton.Size = new System.Drawing.Size(180, 55);
            this.updateButton.TabIndex = 70;
            this.updateButton.Text = "Update";
            this.updateButton.Visible = false;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.registrationFormPanel);
            this.Controls.Add(this.registrationPanel);
            this.Name = "RegistrationForm";
            this.Size = new System.Drawing.Size(954, 511);
            this.registrationPanel.ResumeLayout(false);
            this.registrationPanel.PerformLayout();
            this.registrationFormPanel.ResumeLayout(false);
            this.registrationFormPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label transportRegistrationLabel;
        private System.Windows.Forms.FlowLayoutPanel registrationPanel;
        private System.Windows.Forms.Panel registrationFormPanel;
        private Guna.UI2.WinForms.Guna2GradientButton transportRegisterBtn;
        private Guna.UI2.WinForms.Guna2ComboBox countryBox;
        private Guna.UI2.WinForms.Guna2ComboBox genderBox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label transportTypeLabel;
        private System.Windows.Forms.Label transportSizeLabel;
        private System.Windows.Forms.Label regDateLabel;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerBox;
        private Guna.UI2.WinForms.Guna2TextBox transNameBox;
        private System.Windows.Forms.Label transportNameLabel;
        private Guna.UI2.WinForms.Guna2TextBox phoneBox;
        private Guna.UI2.WinForms.Guna2TextBox emailBox;
        private Guna.UI2.WinForms.Guna2TextBox nationalityBox;
        private Guna.UI2.WinForms.Guna2TextBox fullNameBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label nationalityLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label ownerNameLabel;
        private Guna.UI2.WinForms.Guna2ComboBox transportSizeBox;
        private Guna.UI2.WinForms.Guna2ComboBox transportTypeBox;
        private Guna.UI2.WinForms.Guna2GradientButton updateButton;
    }
}
