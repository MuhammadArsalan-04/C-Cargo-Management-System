using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CargoManagementSystem.Classes;

namespace CargoManagementSystem.Forms
{
    public partial class RegistrationForm : UserControl
    {
        int id = 0;
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void transportRegisterBtn_Click(object sender, EventArgs e)
        {
            if (fullNameBox.Text == string.Empty || emailBox.Text == string.Empty || countryBox.Text == string.Empty || nationalityBox.Text == string.Empty || genderBox.Text == string.Empty
                || phoneBox.Text == string.Empty || transNameBox.Text == string.Empty
                || transportTypeBox.Text == string.Empty || transportSizeBox.Text == string.Empty
                || dateTimePickerBox.Text == string.Empty)
            {
                MessageBox.Show("Fields Can't Be Empty");
                return;
            }

            DataConnection.createConnection();


            string query = "INSERT INTO RegistrationDatabase(FullName , Email , Country , Nationality , PhoneNumber , Gender , TransportName , TransportSize , TransportType , RegistrationDate) " +
                "VALUES ('" + fullNameBox.Text + "' , '" + emailBox.Text + "' , '" + countryBox.Text + "' , '" + nationalityBox.Text + "' , '" + phoneBox.Text + "' , '" + genderBox.Text + "' , '" + transNameBox.Text + "'" +
                ", '" + transportSizeBox.Text + "' , '" + transportTypeBox.Text + "' , '" + dateTimePickerBox.Text.ToString() + "')";
            DataConnection.insertData(query);

            transportRegFormClear();
        }

        public void transportRegFormClear()
        {
            fullNameBox.Clear();
            emailBox.Clear();
            countryBox.SelectedItem = null;
            nationalityBox.Clear();
            phoneBox.Clear();
            genderBox.SelectedItem = null;
            transNameBox.Clear();
            transportSizeBox.SelectedItem = null;
            transportTypeBox.SelectedItem = null;
            dateTimePickerBox.Value = DateTime.Now;
        }

    }
}
