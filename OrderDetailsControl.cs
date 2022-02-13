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
    public partial class OrderDetailsControl : UserControl
    {

        int deletionId = 0;
        public OrderDetailsControl()
        {
            InitializeComponent();
            fillData();
        }
        public void fillData()
        {
            DataConnection.createConnection();
            string query = "Select * From OrderDatabase";
            string srcTable = "OrderDatabase";
            DataSet ds = DataConnection.getData(query, srcTable);
            orderDetailsDataGridView.DataSource = ds.Tables[srcTable];
            dataGridView1.DataSource = ds.Tables[srcTable];
            deleteOrderDataGridView.DataSource = ds.Tables[srcTable];
        }

        private void OrderDetailsControl_Load(object sender, EventArgs e)
        {
            fillData();
        }


        private void deleteOrderButton_Click(object sender, EventArgs e)
        {
            DataConnection.createConnection();
            string query = "DELETE FROM OrderDatabase WHERE Id = " + deletionId + "";
            DataConnection.deleteData(query);
            OrderDetailsControl_Load(this, null);
        }

        private void deleteOrderTab_Enter(object sender, EventArgs e)
        {
            fillData();
        }

        private void deleteOrderDataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            deletionId = int.Parse(deleteOrderDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
    }
}
