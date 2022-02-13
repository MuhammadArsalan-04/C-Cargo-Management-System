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
    public partial class orderControl : UserControl
    {
        public orderControl()
        {
            InitializeComponent();
        }

        private void transportRegBtn_Click(object sender, EventArgs e)
        {
            if (customerNameBox.Text == string.Empty || emailBox.Text == string.Empty || countryBox.Text == string.Empty || nationalityBox.Text == string.Empty || addressBox.Text == string.Empty
                || phoneNoBox.Text == string.Empty || itemNameBox.Text == string.Empty || transNameBox.Text == string.Empty
                || weightBox.Text == string.Empty || quantityBox.Text == string.Empty || transSizeBox.Text == string.Empty || transTypeBox.Text == string.Empty
                || orderDatePickerBox.Text == string.Empty || fromBox.Text == string.Empty || toBox.Text == string.Empty)
            {
                MessageBox.Show("Fields Can't Be Empty");
                return;
            }

            DataConnection.createConnection();


            string query = "INSERT INTO OrderDatabase(CustomerName , Email , Country , Nationality , MobileNumber , ItemName , ItemWeight , ItemQuantity , OrderDate ,TransportType , OwnerTransportName , OwnerTransportSize , Source , Destination , Address) " +
                "VALUES('" + customerNameBox.Text + "' , '" + emailBox.Text + "' , '" + countryBox.Text + "' , '" + nationalityBox.Text + "' , '" + phoneNoBox.Text + "' , '" + itemNameBox.Text + "' , '" + weightBox.Text + "'" + ", '" + quantityBox.Text + "' , '" + orderDatePickerBox.Text.ToString() + "' , '" + transTypeBox.Text.ToString() + "' , '" + transNameBox.Text + "' , '" + transSizeBox.Text + "' , '" + fromBox.Text.ToString() + "' , '" + toBox.Text.ToString() + "' , '"+ addressBox.Text +"')";
                DataConnection.insertData(query);
            clearOrderForm();
        }

        public void clearOrderForm()
        {
            customerNameBox.Clear();
            emailBox.Clear();
            countryBox.Clear();
            nationalityBox.Clear();
            phoneNoBox.Clear(); 
            itemNameBox.Clear();
            weightBox.Clear();
            quantityBox.Clear();
            orderDatePickerBox.Value = DateTime.Now;
            transTypeBox.SelectedText = null;
            transNameBox.Clear();
           transSizeBox.Clear();
            fromBox.SelectedText = null;
            toBox.SelectedText = null;
        }

       


    }
}
//CustomerName , Email , Country , Nationality , MobileNumber , ItemName , ItemWeight , ItemQuantity , OrderDate ,TransportType , OwnerTransportName , OwnerTransportSize , From , To
//'" + customerNameBox.Text + "' , '" + emailBox.Text + "' , '" + countryBox.Text + "' , '" + nationalityBox.Text + "' , '" + phoneNoBox.Text + "' , '" + itemNameBox.Text + "' , '" + weightBox.Text + "'" +
//", '" + quantityBox.Text + "' , '" + orderDatePickerBox.Text.ToString() + "' , '" + transTypeBox.Text.ToString() + "' , '" + transNameBox.Text + "' , '" + transSizeBox.Text + "' , '" + fromBox.Text.ToString() + "' , '" + toBox.Text.ToString() + "'