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
using CargoManagementSystem.Forms;

namespace CargoManagementSystem.Forms
{
    public partial class RegistrationDetailsControl : UserControl
    {

        int deletionId = 0;
        string fullName = "";
        string email = "";
        string nationality = "";
        string country = "";
        string gender = "";
        string phoneNumber = "";
        string transtype = "";
        string transName ="";
        string transSize = "";
        string dateTime = "";
        public RegistrationDetailsControl()
        {
            InitializeComponent();
            fillData();
        }

        public void fillData()
        {
            DataConnection.createConnection();
            string query = "Select * From RegistrationDatabase";
            string srcTable = "RegistrationDatabase";
            DataSet ds = DataConnection.getData(query, srcTable);
            registrationDetailsDataGridView.DataSource = ds.Tables[srcTable];
            updateRegistrationDataGridView.DataSource = ds.Tables[srcTable];
            deleteRegistrationDataGridView.DataSource = ds.Tables[srcTable];
        }

        private void RegistrationDetailsControl_Load(object sender, EventArgs e)
        {
            fillData();

        }

        private void tabControl1_Enter(object sender, EventArgs e)
        {
            fillData();
        }

        private void deleteRegistrationDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            deleteRegBtn.Enabled = true;
            deletionId = int.Parse(deleteRegistrationDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            
        }

        private void deleteRegBtn_Click(object sender, EventArgs e)
        {
            DataConnection.createConnection();
            string query = "DELETE FROM RegistrationDatabase WHERE id = " + deletionId + "";
            DataConnection.deleteData(query);
            RegistrationDetailsControl_Load(this, null);


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

        public void refillForm()
        {
            fullNameBox.Text = fullName;
            emailBox.Text = email;
            countryBox.Text = country;
            nationalityBox.Text = nationality;
            phoneBox.Text = phoneNumber;
            genderBox.Text = gender;
            transNameBox.Text = transName;
            transportSizeBox.Text = transSize;
            transportTypeBox.Text = transtype;
            dateTimePickerBox.Text = dateTime;
        }

        private void updateRegBtn_Click(object sender, EventArgs e)
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


            string query = "UPDATE  RegistrationDatabase SET FullName = '" + fullNameBox.Text + "' , Email = '" + emailBox.Text + "' , Country = '" + countryBox.Text + "', Nationality = '" + nationalityBox.Text + "'" +
                ", PhoneNumber = '" + phoneBox.Text + "', Gender = '" + genderBox.Text + "', TransportName = '" + transNameBox.Text + "', " +
                "TransportSize = '" + transportSizeBox.Text + "' , TransportType = '" + transportTypeBox.Text + "' , RegistrationDate = '" + dateTimePickerBox.Text.ToString() + "' WHERE Id = '" + deletionId + "'";
            DataConnection.updateData(query);
            RegistrationDetailsControl_Load(this, null);
            transportRegFormClear();
        }

        private void updateRegistrationDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            deletionId = int.Parse(updateRegistrationDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            fullName = updateRegistrationDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            email = updateRegistrationDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            nationality = updateRegistrationDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            country = updateRegistrationDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            gender = updateRegistrationDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
            phoneNumber = updateRegistrationDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            transtype = updateRegistrationDataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
            transName = updateRegistrationDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
            transSize = updateRegistrationDataGridView.Rows[e.RowIndex].Cells[9].Value.ToString();
            dateTime = updateRegistrationDataGridView.Rows[e.RowIndex].Cells[10].Value.ToString();

            refillForm();
        }
    }
}
//deletionId, fullName, email, nationality, country, gender, phoneNumber, transtype, transName, transSize, dateTime