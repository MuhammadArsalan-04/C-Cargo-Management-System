using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CargoManagementSystem.Classes
{
    static class DataConnection
    {
        private static SqlConnection connection = new SqlConnection();
        private static DataSet ds = new DataSet();
        public static void createConnection()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CargoManagementSystem;Integrated Security=True";
            connection = new SqlConnection(connectionString);

        }

        public static void insertData(string query)
        {
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query,connection);
                int rowsAffected = command.ExecuteNonQuery();
                if(rowsAffected > 0)
                {
                    MessageBox.Show("Entry Successfull");
                }
                else
                {
                    MessageBox.Show("Entry Failed!");
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show("Connection Failed With Server Please Try Again After A Minute!" + exception.Message);
            }

            finally
            {
                if(connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public static DataSet getData(string query , string srcTable)
        {
            DataSet ds = new DataSet();
            try {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query,connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(ds , srcTable);
                
            }
            catch(Exception exception)
            {
                MessageBox.Show("Could Not Establish Connection With Database" + exception.Message);
            }
            finally
            {
                connection.Close();
            }
            

            return ds;
        }

        public static void deleteData(string query)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query , connection);
                int rowsAffected =  cmd.ExecuteNonQuery ();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Deletion Successfull");
                }
                else
                {
                    MessageBox.Show("Deletion Failed!");
                }
            }

            catch(Exception exception)
            {
                MessageBox.Show("Could Not Establish Connection With Database" + exception.Message);

            }
            finally
            {
                connection.Close ();
            }
        }

        public static void updateData(string query)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Updated Successfull");
                }
                else
                {
                    MessageBox.Show("Updation Failed!");
                }
            }

            catch (Exception exception)
            {
                MessageBox.Show("Could Not Establish Connection With Database" + exception.Message);

            }
            finally
            {
                connection.Close();
            }
        }

    }
}
