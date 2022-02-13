using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CargoManagementSystem.Forms;

namespace CargoManagementSystem
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void closeApp_MouseHover_1(object sender, EventArgs e)
        {
            closeApp.ForeColor = Color.Red;
        }

        private void closeApp_MouseLeave_1(object sender, EventArgs e)
        {
            closeApp.ForeColor = Color.Black;
        }

        private void closeApp_MouseClick_1(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void forgotPassword_MouseHover(object sender, EventArgs e)
        {
            forgotPassword.ForeColor = Color.Gray;
            forgotPassword.Cursor = Cursors.Hand;

        }

        private void forgotPassword_MouseLeave(object sender, EventArgs e)
        {
            forgotPassword.ForeColor = Color.Black;
            forgotPassword.Cursor=Cursors.Default;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            SignUpForm register = new SignUpForm();
            loginForm.ActiveForm.Hide();
            register.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (loginEmailBox.Text == string.Empty || loginPasswordBox.Text == string.Empty)
            {
                MessageBox.Show("Fields Can't Be Empty");
                return;
            }

            loginForm.ActiveForm.Hide();
            DashBoardWindow db = new DashBoardWindow();
            db.Show();

        }

        
    }
}
