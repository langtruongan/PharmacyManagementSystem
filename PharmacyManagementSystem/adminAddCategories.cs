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
    public partial class adminAddCategories : UserControl
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ACER\OneDrive\Tài liệu\PharmacyManagementSystem.mdf"";Integrated Security=True;Connect Timeout=30;";
        
        public adminAddCategories()
        {
            InitializeComponent();
            displayCaterogiesData();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayCaterogiesData();
        }

        public void displayCaterogiesData()
        {
            adminAddCategoriesData aacData = new adminAddCategoriesData();
            List<adminAddCategoriesData> listData = aacData.listAddCategoriesData();

            dataGridView1.DataSource = listData;
        }

        private void addCategories_addBtn_Click(object sender, EventArgs e)
        {
            if(addCategories_category.Text == "" || addCategories_status.SelectedIndex == -1)
            {
                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string checkCategoryName = "SELECT * FROM categories WHERE category = @categoryn";

                    using (SqlCommand checkCategory = new SqlCommand(checkCategoryName, connection))
                    {
                        checkCategory.Parameters.AddWithValue("@categoryn", addCategories_category.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(checkCategory);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            string tempCategoryn = addCategories_category.Text.Substring(0, 1).ToUpper() + addCategories_category.Text.Substring(1);
                            MessageBox.Show(tempCategoryn + " is existing already", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        } else
                        {
                            string insertCategory = "INSERT INTO categories (category, status, date_insert) VALUES(@category, @status, @date)";
                            using (SqlCommand cmd = new SqlCommand(insertCategory, connection))
                            {
                                cmd.Parameters.AddWithValue("@category", addCategories_category.Text.Trim());
                                cmd.Parameters.AddWithValue("@status", addCategories_status.SelectedItem.ToString());

                                DateTime today = DateTime.Today;
                                cmd.Parameters.AddWithValue("@Date", today);

                                cmd.ExecuteNonQuery();
                                clearFields();

                                MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            displayCaterogiesData();
        }

        public void clearFields()
        {
            addCategories_category.Text = "";
            addCategories_status.SelectedIndex = -1;
        }

        private void addCategories_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void addCategories_updateBtn_Click(object sender, EventArgs e)
        {
            if (addCategories_category.Text == "" || addCategories_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please select item first", "Message Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string checkCategoryname = "SELECT * FROM categories WHERE category = @category and id != @id";

                    using (SqlCommand checkCategory = new SqlCommand(checkCategoryname, connection))
                    {
                        checkCategory.Parameters.AddWithValue("@category", addCategories_category.Text.Trim());
                        checkCategory.Parameters.AddWithValue("@id", getID);

                        SqlDataAdapter adapter = new SqlDataAdapter(checkCategory);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            string tempCategoryn = addCategories_category.Text.Substring(0, 1).ToUpper() + addCategories_category.Text.Substring(1);
                            MessageBox.Show(tempCategoryn + " is existing already", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (MessageBox.Show("Are you sure you want to Update ID: " + getID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                string updateData = "UPDATE categories SET category = @category, status = @status WHERE id = @id";
                                using (SqlCommand cmd = new SqlCommand(updateData, connection))
                                {
                                    cmd.Parameters.AddWithValue("@category", addCategories_category.Text.Trim());
                                    cmd.Parameters.AddWithValue("@status", addCategories_status.SelectedItem.ToString());
                                    cmd.Parameters.AddWithValue("@id", getID);

                                    cmd.ExecuteNonQuery();
                                    clearFields();

                                    MessageBox.Show("Updated successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                }
            }
            displayCaterogiesData();
        }

        private int getID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = Convert.ToInt32(row.Cells[0].Value);
                addCategories_category.Text = row.Cells[1].Value.ToString();
                addCategories_status.SelectedItem = row.Cells[2].Value.ToString();
            }
        }

        private void addCategories_deleteBtn_Click(object sender, EventArgs e)
        {
            if (addCategories_category.Text == "" || addCategories_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please select item first", "Message Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Delete ID: " + getID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string deleteData = "DELETE FROM categories WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(deleteData, connection))
                        {
                            cmd.Parameters.AddWithValue("@id", getID);

                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show("Deleted successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            displayCaterogiesData();
        }
    }
}
