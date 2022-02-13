namespace CargoManagementSystem.Forms
{
    partial class DashBoardWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoardWindow));
            this.dashBoardDrawer = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.registrationDetailsButton = new System.Windows.Forms.Button();
            this.orderDetailsButton = new System.Windows.Forms.Button();
            this.logoutButon = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.dashBoardPanel = new System.Windows.Forms.Panel();
            this.homeControl1 = new CargoManagementSystem.Forms.HomeControl();
            this.registrationDetailsControl1 = new CargoManagementSystem.Forms.RegistrationDetailsControl();
            this.orderDetailsControl1 = new CargoManagementSystem.Forms.OrderDetailsControl();
            this.orderControl1 = new CargoManagementSystem.Forms.orderControl();
            this.registrationForm1 = new CargoManagementSystem.Forms.RegistrationForm();
            this.dashBoardDrawer.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.guna2GradientPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.dashBoardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashBoardDrawer
            // 
            this.dashBoardDrawer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.dashBoardDrawer.Controls.Add(this.registrationDetailsButton);
            this.dashBoardDrawer.Controls.Add(this.orderDetailsButton);
            this.dashBoardDrawer.Controls.Add(this.logoutButon);
            this.dashBoardDrawer.Controls.Add(this.orderButton);
            this.dashBoardDrawer.Controls.Add(this.RegistrationButton);
            this.dashBoardDrawer.Controls.Add(this.HomeButton);
            this.dashBoardDrawer.Controls.Add(this.guna2GradientPanel1);
            this.dashBoardDrawer.CustomBorderColor = System.Drawing.Color.White;
            this.dashBoardDrawer.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.dashBoardDrawer.Dock = System.Windows.Forms.DockStyle.Left;
            this.dashBoardDrawer.Location = new System.Drawing.Point(0, 0);
            this.dashBoardDrawer.Name = "dashBoardDrawer";
            this.dashBoardDrawer.ShadowDecoration.Parent = this.dashBoardDrawer;
            this.dashBoardDrawer.Size = new System.Drawing.Size(267, 579);
            this.dashBoardDrawer.TabIndex = 0;
            // 
            // registrationDetailsButton
            // 
            this.registrationDetailsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.registrationDetailsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.registrationDetailsButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.registrationDetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrationDetailsButton.ForeColor = System.Drawing.Color.White;
            this.registrationDetailsButton.Location = new System.Drawing.Point(0, 306);
            this.registrationDetailsButton.Name = "registrationDetailsButton";
            this.registrationDetailsButton.Size = new System.Drawing.Size(267, 56);
            this.registrationDetailsButton.TabIndex = 7;
            this.registrationDetailsButton.Text = "Registration Details";
            this.registrationDetailsButton.UseVisualStyleBackColor = true;
            this.registrationDetailsButton.Click += new System.EventHandler(this.registrationDetailsButton_Click);
            this.registrationDetailsButton.MouseLeave += new System.EventHandler(this.registrationDetailsButton_MouseLeave);
            this.registrationDetailsButton.MouseHover += new System.EventHandler(this.registrationDetailsButton_MouseHover);
            // 
            // orderDetailsButton
            // 
            this.orderDetailsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.orderDetailsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.orderDetailsButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.orderDetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderDetailsButton.ForeColor = System.Drawing.Color.White;
            this.orderDetailsButton.Location = new System.Drawing.Point(0, 250);
            this.orderDetailsButton.Name = "orderDetailsButton";
            this.orderDetailsButton.Size = new System.Drawing.Size(267, 56);
            this.orderDetailsButton.TabIndex = 6;
            this.orderDetailsButton.Text = "Order Details";
            this.orderDetailsButton.UseVisualStyleBackColor = true;
            this.orderDetailsButton.Click += new System.EventHandler(this.orderDetailsButton_Click);
            this.orderDetailsButton.MouseLeave += new System.EventHandler(this.orderDetailsButton_MouseLeave);
            this.orderDetailsButton.MouseHover += new System.EventHandler(this.orderDetailsButton_MouseHover);
            // 
            // logoutButon
            // 
            this.logoutButon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.logoutButon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logoutButon.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.logoutButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButon.ForeColor = System.Drawing.Color.White;
            this.logoutButon.Location = new System.Drawing.Point(0, 523);
            this.logoutButon.Name = "logoutButon";
            this.logoutButon.Size = new System.Drawing.Size(267, 56);
            this.logoutButon.TabIndex = 5;
            this.logoutButon.Text = "LogOut";
            this.logoutButon.UseVisualStyleBackColor = true;
            this.logoutButon.Click += new System.EventHandler(this.logoutButon_Click);
            this.logoutButon.MouseLeave += new System.EventHandler(this.logoutButon_MouseLeave);
            this.logoutButon.MouseHover += new System.EventHandler(this.logoutButon_MouseHover);
            // 
            // orderButton
            // 
            this.orderButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.orderButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.orderButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.orderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderButton.ForeColor = System.Drawing.Color.White;
            this.orderButton.Location = new System.Drawing.Point(0, 194);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(267, 56);
            this.orderButton.TabIndex = 4;
            this.orderButton.Text = "Order";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            this.orderButton.MouseLeave += new System.EventHandler(this.orderButton_MouseLeave);
            this.orderButton.MouseHover += new System.EventHandler(this.orderButton_MouseHover);
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RegistrationButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.RegistrationButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.RegistrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistrationButton.ForeColor = System.Drawing.Color.White;
            this.RegistrationButton.Location = new System.Drawing.Point(0, 138);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(267, 56);
            this.RegistrationButton.TabIndex = 3;
            this.RegistrationButton.Text = "Registration";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            this.RegistrationButton.MouseLeave += new System.EventHandler(this.RegistrationButton_MouseLeave);
            this.RegistrationButton.MouseHover += new System.EventHandler(this.RegistrationButton_MouseHover);
            // 
            // HomeButton
            // 
            this.HomeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HomeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomeButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.ForeColor = System.Drawing.Color.White;
            this.HomeButton.Location = new System.Drawing.Point(0, 82);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(267, 56);
            this.HomeButton.TabIndex = 2;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            this.HomeButton.MouseLeave += new System.EventHandler(this.HomeButton_MouseLeave);
            this.HomeButton.MouseHover += new System.EventHandler(this.HomeButton_MouseHover);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.guna2GradientPanel1.Controls.Add(this.pictureBox1);
            this.guna2GradientPanel1.CustomBorderColor = System.Drawing.Color.White;
            this.guna2GradientPanel1.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(267, 82);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.guna2GradientPanel2.Controls.Add(this.panel1);
            this.guna2GradientPanel2.CustomBorderColor = System.Drawing.Color.White;
            this.guna2GradientPanel2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.guna2GradientPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel2.Location = new System.Drawing.Point(267, 0);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.ShadowDecoration.Parent = this.guna2GradientPanel2;
            this.guna2GradientPanel2.Size = new System.Drawing.Size(1215, 82);
            this.guna2GradientPanel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.title);
            this.panel1.Location = new System.Drawing.Point(455, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 76);
            this.panel1.TabIndex = 3;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.title.Font = new System.Drawing.Font("Monotype Corsiva", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(466, 53);
            this.title.TabIndex = 2;
            this.title.Text = "Cargo Management System";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dashBoardPanel
            // 
            this.dashBoardPanel.AutoSize = true;
            this.dashBoardPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.dashBoardPanel.Controls.Add(this.homeControl1);
            this.dashBoardPanel.Controls.Add(this.registrationDetailsControl1);
            this.dashBoardPanel.Controls.Add(this.orderDetailsControl1);
            this.dashBoardPanel.Controls.Add(this.orderControl1);
            this.dashBoardPanel.Controls.Add(this.registrationForm1);
            this.dashBoardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashBoardPanel.Location = new System.Drawing.Point(267, 82);
            this.dashBoardPanel.Name = "dashBoardPanel";
            this.dashBoardPanel.Padding = new System.Windows.Forms.Padding(5);
            this.dashBoardPanel.Size = new System.Drawing.Size(1215, 497);
            this.dashBoardPanel.TabIndex = 2;
            // 
            // homeControl1
            // 
            this.homeControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.homeControl1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.homeControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeControl1.Location = new System.Drawing.Point(5, 5);
            this.homeControl1.Name = "homeControl1";
            this.homeControl1.Size = new System.Drawing.Size(1205, 487);
            this.homeControl1.TabIndex = 0;
            // 
            // registrationDetailsControl1
            // 
            this.registrationDetailsControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.registrationDetailsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registrationDetailsControl1.Location = new System.Drawing.Point(5, 5);
            this.registrationDetailsControl1.Name = "registrationDetailsControl1";
            this.registrationDetailsControl1.Size = new System.Drawing.Size(1205, 487);
            this.registrationDetailsControl1.TabIndex = 4;
            // 
            // orderDetailsControl1
            // 
            this.orderDetailsControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.orderDetailsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderDetailsControl1.Location = new System.Drawing.Point(5, 5);
            this.orderDetailsControl1.Name = "orderDetailsControl1";
            this.orderDetailsControl1.Size = new System.Drawing.Size(1205, 487);
            this.orderDetailsControl1.TabIndex = 3;
            // 
            // orderControl1
            // 
            this.orderControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.orderControl1.BackColor = System.Drawing.Color.White;
            this.orderControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderControl1.Location = new System.Drawing.Point(5, 5);
            this.orderControl1.Name = "orderControl1";
            this.orderControl1.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderControl1.Size = new System.Drawing.Size(1205, 487);
            this.orderControl1.TabIndex = 2;
            this.orderControl1.Visible = false;
            // 
            // registrationForm1
            // 
            this.registrationForm1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.registrationForm1.BackColor = System.Drawing.Color.White;
            this.registrationForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registrationForm1.Location = new System.Drawing.Point(5, 5);
            this.registrationForm1.Name = "registrationForm1";
            this.registrationForm1.Size = new System.Drawing.Size(1205, 487);
            this.registrationForm1.TabIndex = 1;
            // 
            // DashBoardWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1482, 579);
            this.Controls.Add(this.dashBoardPanel);
            this.Controls.Add(this.guna2GradientPanel2);
            this.Controls.Add(this.dashBoardDrawer);
            this.Name = "DashBoardWindow";
            this.Text = "DashBoard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DashBoardWindow_FormClosed);
            this.dashBoardDrawer.ResumeLayout(false);
            this.guna2GradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.guna2GradientPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.dashBoardPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel dashBoardDrawer;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button logoutButon;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.Button orderDetailsButton;
        private System.Windows.Forms.Button registrationDetailsButton;
        private System.Windows.Forms.Panel dashBoardPanel;
        private HomeControl homeControl1;
        private RegistrationForm registrationForm1;
        private orderControl orderControl1;
        private RegistrationDetailsControl registrationDetailsControl1;
        private OrderDetailsControl orderDetailsControl1;
    }
}