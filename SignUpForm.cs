using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CargoManagementSystem.Classes;

namespace CargoManagementSystem.Forms
{
    public partial class SignUpForm : Form
    {
        int signUpIdCounter = 0;
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            
            if(fullNameBox.Text == string.Empty || emailBox.Text == string.Empty || passwordBox.Text == string.Empty || confirmPasswordBox.Text == string.Empty)
            {
                MessageBox.Show("Fields Can't Be Empty");
                return;
            }

            if(passwordBox.Text != confirmPasswordBox.Text)
            {
                MessageBox.Show("Password Not Matched");
                return;
            }


            DataConnection.createConnection();
            signUpIdCounter += 1;

            string query = "INSERT INTO SignUpDatabase(FullName , Email , Password) VALUES ('"+fullNameBox.Text+ "' , '" + emailBox.Text + "' , '" + passwordBox.Text + "')";
            DataConnection.insertData(query);

            fullNameBox.Clear();
            emailBox.Clear();
            passwordBox.Clear();
            confirmPasswordBox.Clear();
        }

        private void goBackSignInLabel_Click(object sender, EventArgs e)
        {
            SignUpForm.ActiveForm.Hide();
            loginForm login = new loginForm();
            login.Show();
        }

        private void goBackSignInLabel_MouseHover(object sender, EventArgs e)
        {
            goBackSignInLabel.ForeColor = Color.Gray;
            goBackSignInLabel.Cursor = Cursors.Hand;
        }

        private void goBackSignInLabel_MouseLeave(object sender, EventArgs e)
        {
            goBackSignInLabel.ForeColor = Color.Black;
            goBackSignInLabel.Cursor = Cursors.Default;
        }

        private void closeApp_Click(object sender, EventArgs e)
        {
            closeApp.Hide();
            loginForm login = new loginForm();
            login.Show();
        }

        private void closeApp_MouseHover(object sender, EventArgs e)
        {
            closeApp.ForeColor = Color.Red;

        }

        private void closeApp_MouseLeave(object sender, EventArgs e)
        {
            closeApp.ForeColor= Color.Black;
        }
    }
}
