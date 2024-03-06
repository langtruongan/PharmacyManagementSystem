using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class cashierMainForm : Form
    {
        public cashierMainForm()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                loginForm logForm = new loginForm();
                logForm.Show();

                this.Hide();
            }
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = true;
            cashierOders1.Visible = false;
            adminCustomers1.Visible = false;

            adminDashboard aDashboard = adminDashboard1 as adminDashboard;

            if(aDashboard != null)
            {
                aDashboard.refreshData();
            }
        }

        private void orders_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            cashierOders1.Visible = true;
            adminCustomers1.Visible = false;

            cashierOders cOrders = cashierOders1 as cashierOders;

            if (cOrders != null)
            {
                 cOrders.refreshData();
            }
        }

        private void customers_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            cashierOders1.Visible = false;
            adminCustomers1.Visible = true;

            adminCustomers aCustomers = adminCustomers1 as adminCustomers;

            if (aCustomers != null)
            {
                aCustomers.refreshData();
            }
        }

    }
}
