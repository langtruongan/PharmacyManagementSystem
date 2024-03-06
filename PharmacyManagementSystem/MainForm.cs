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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                loginForm logForm = new loginForm();
                logForm.Show();

                this.Hide();
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            
            adminDashboard1.Visible = true;
            adminAddUsers1.Visible = false;
            adminCustomers1.Visible = false;
            adminAddCategories1.Visible = false;
            adminAddProducts1.Visible = false;

            adminDashboard aDashboard = adminDashboard1 as adminDashboard;

            if (aDashboard != null)
            {
                aDashboard.refreshData();
            }

        }

        private void addUsers_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddUsers1.Visible = true;
            adminCustomers1.Visible = false;
            adminAddCategories1.Visible = false;
            adminAddProducts1.Visible = false;

            adminAddUsers aAddUsers = adminAddUsers1 as adminAddUsers;

            if (aAddUsers != null)
            {
                aAddUsers.refreshData();
            }
        }

        private void customers_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddUsers1.Visible = false;
            adminCustomers1.Visible = true;
            adminAddCategories1.Visible = false;
            adminAddProducts1.Visible = false;

            adminCustomers aCustomers = adminCustomers1 as adminCustomers;

            if (aCustomers != null)
            {
                aCustomers.refreshData();
            }
        }

        private void addCategory_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddUsers1.Visible = false;
            adminCustomers1.Visible = false;
            adminAddCategories1.Visible = true;
            adminAddProducts1.Visible = false;

            adminAddCategories aAddCategories = adminAddCategories1 as adminAddCategories;

            if (aAddCategories != null)
            {
                aAddCategories.refreshData();
            }
        }

        private void addProducts_btn_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = false;
            adminAddUsers1.Visible = false;
            adminCustomers1.Visible = false;
            adminAddCategories1.Visible = false;
            adminAddProducts1.Visible = true;

            adminAddProducts aAddProducts = adminAddProducts1 as adminAddProducts;

            if (aAddProducts != null)
            {
                aAddProducts.refreshData();
            }
        }
    }
}
