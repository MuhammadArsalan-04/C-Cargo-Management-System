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

namespace CargoManagementSystem.Forms
{
    public partial class DashBoardWindow : Form
    {
        public DashBoardWindow()
        {
            InitializeComponent();
        }
        
        private void DashBoardWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            homeControl1.Visible = false;
            registrationForm1.Visible = true;
            orderControl1.Visible = false;
            registrationDetailsControl1.Visible = false;
            orderDetailsControl1.Visible = false;


        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            homeControl1.Visible = true;
            registrationForm1.Visible=false ;
            orderControl1.Visible = false ;
            registrationDetailsControl1.Visible = false ;
            orderDetailsControl1.Visible=false ;
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            homeControl1.Visible = false;
            registrationForm1.Visible = false;
            orderControl1.Visible = true;
            registrationDetailsControl1.Visible = false;
            orderDetailsControl1.Visible = false;

            
        }

        private void orderDetailsButton_Click(object sender, EventArgs e)
        {
            orderDetailsControl1.fillData();

            homeControl1.Visible = false;
            registrationForm1.Visible = false;
            orderControl1.Visible = false;
            registrationDetailsControl1.Visible = false;
            orderDetailsControl1.Visible = true;
        }

        private void registrationDetailsButton_Click(object sender, EventArgs e)
        {
            registrationDetailsControl1.fillData();

            homeControl1.Visible = false;
            registrationForm1.Visible = false;
            orderControl1.Visible = false;
            registrationDetailsControl1.Visible = true;
            orderDetailsControl1.Visible = false;
        }

        private void logoutButon_Click(object sender, EventArgs e)
        {
            DashBoardWindow.ActiveForm.Hide();
            loginForm loginForm = new loginForm();
            loginForm.Show();
        }

        private void HomeButton_MouseHover(object sender, EventArgs e)
        {
            colorHoverChanger(HomeButton);
        }

        private void colorLeaveChanger(Button name)
        {
            name.BackColor = Color.FromArgb(51, 51, 76);
            name.Cursor = Cursors.Default;
            name.ForeColor = Color.White;
        }

        private void colorHoverChanger(Button name)
        {
            name.BackColor = Color.DarkOrange;
            name.Cursor = Cursors.Hand;
            name.ForeColor = Color.White;
        }

        private void HomeButton_MouseLeave(object sender, EventArgs e)
        {
            colorLeaveChanger(HomeButton);
        }

        private void RegistrationButton_MouseHover(object sender, EventArgs e)
        {
            colorHoverChanger(RegistrationButton);
        }

        private void RegistrationButton_MouseLeave(object sender, EventArgs e)
        {
            colorLeaveChanger(RegistrationButton);
        }

        private void orderButton_MouseHover(object sender, EventArgs e)
        {
            colorHoverChanger(orderButton);
        }

        private void orderButton_MouseLeave(object sender, EventArgs e)
        {
            colorLeaveChanger(orderButton);
        }

        private void orderDetailsButton_MouseHover(object sender, EventArgs e)
        {
            colorHoverChanger(orderDetailsButton);
        }

        private void orderDetailsButton_MouseLeave(object sender, EventArgs e)
        {
            colorLeaveChanger(orderDetailsButton);
        }

        private void registrationDetailsButton_MouseHover(object sender, EventArgs e)
        {
            colorHoverChanger(registrationDetailsButton);
        }

        private void registrationDetailsButton_MouseLeave(object sender, EventArgs e)
        {
            colorLeaveChanger(registrationDetailsButton);
        }

        private void logoutButon_MouseHover(object sender, EventArgs e)
        {
            colorHoverChanger(logoutButon);
        }

        private void logoutButon_MouseLeave(object sender, EventArgs e)
        {
            colorLeaveChanger(logoutButon);
        }
    }
}
