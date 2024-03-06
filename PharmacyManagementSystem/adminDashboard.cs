using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace PharmacyManagementSystem
{
    public partial class adminDashboard : UserControl
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ACER\OneDrive\Tài liệu\PharmacyManagementSystem.mdf"";Integrated Security=True;Connect Timeout=30;";

        public adminDashboard()
        {
            InitializeComponent();

            displayTotalCashier();
            displayTotalOrders();
            displayTodaysRevenue();
            displayTodaysRevenue();
            displayTotalRevenue();
            displayCustomers();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayTotalCashier();
            displayTotalOrders();
            displayTodaysRevenue();
            displayTodaysRevenue();
            displayTotalRevenue();
            displayCustomers();
        }

        public void displayCustomers()
        {
            adminCustomersData acData = new adminCustomersData();

            dataGridView1.DataSource = acData.customerDataList();
        }

        public void displayTotalCashier()
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectData = "SELECT COUNT(id) as totalCashier FROM users WHERE role = 'Cashier'";

                using (SqlCommand cmd = new SqlCommand(selectData, connection))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if(reader.Read())
                    {
                        if (reader["totalCashier"] != DBNull.Value)
                        {
                            int totalCash = (int)reader["totalCashier"];

                            totalCashier.Text = totalCash.ToString();
                        }
                    }
                }
            }
        }

        public void displayTotalOrders()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectData = "SELECT COUNT(id) as totalOrders FROM transactions";

                using (SqlCommand cmd = new SqlCommand(selectData, connection))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        if (reader["totalOrders"] != DBNull.Value)
                        {
                            int totalOrder = (int)reader["totalOrders"];

                            totalOrders.Text = totalOrder.ToString();
                        }
                    }
                }
            }
        }

        public void displayTodaysRevenue()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                DateTime today = DateTime.Today;
                string selectData = "SELECT SUM(total_price) as todaysRevenue FROM transactions WHERE date_trans = '"+today+"'";

                using (SqlCommand cmd = new SqlCommand(selectData, connection))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        if (reader["todaysRevenue"] != DBNull.Value)
                        {
                            decimal todayRevs = Convert.ToDecimal(reader["todaysRevenue"]);

                            todayRevenue.Text = "$" + todayRevs.ToString();
                        }
                    }
                }
            }
        }

        public void displayTotalRevenue()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                DateTime today = DateTime.Today;
                string selectData = "SELECT SUM(total_price) as totalRevenue FROM transactions";

                using (SqlCommand cmd = new SqlCommand(selectData, connection))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        if (reader["totalRevenue"] != DBNull.Value)
                        {
                            decimal totalRevs = Convert.ToDecimal(reader["totalRevenue"]);

                            totalRevenue.Text = "$" + totalRevs.ToString();
                        }
                    }
                }
            }
        }
    }
}
