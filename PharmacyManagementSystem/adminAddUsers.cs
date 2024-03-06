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
    public partial class adminAddUsers : UserControl
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ACER\OneDrive\Tài liệu\PharmacyManagementSystem.mdf"";Integrated Security=True;Connect Timeout=30;";

        public adminAddUsers()
        {
            InitializeComponent();
            displayAddUsers();

        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayAddUsers();
        }

        public void displayAddUsers()
        {
            adminAddUsersData aauData = new adminAddUsersData();
            List<adminAddUsersData> listData = aauData.listAddUsersData();

            dataGridView1.DataSource = listData;
        }

        private void addUsers_addBtn_Click(object sender, EventArgs e)
        {
            if(addUsers_username.Text == "" || addUsers_password.Text == "" || 
                addUsers_role.SelectedIndex == -1 || addUsers_status.SelectedIndex == -1)
            {
                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string checkUsername = "SELECT * FROM users WHERE username = @usern";

                    using(SqlCommand checkUsern = new SqlCommand(checkUsername, connection))
                    {
                        checkUsern.Parameters.AddWithValue("@usern", addUsers_username.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(checkUsern);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if(table.Rows.Count > 0)
                        {
                            string tempUsern = addUsers_username.Text.Substring(0, 1).ToUpper() + addUsers_username.Text.Substring(1);
                            MessageBox.Show(tempUsern + " is existing already", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (addUsers_password.Text.Length < 8)
                        {
                            MessageBox.Show("Invalid password, at least 8 characters are needed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        } 
                        else
                        {
                            string insertData = "INSERT INTO users (username, password, role, status, date_register) VALUES (@usern, @pass, @role, @status, @date)";
                            using (SqlCommand cmd = new SqlCommand(insertData, connection))
                            {
                                cmd.Parameters.AddWithValue("@usern", addUsers_username.Text.Trim());
                                cmd.Parameters.AddWithValue("@pass", addUsers_password.Text.Trim());
                                cmd.Parameters.AddWithValue("@role", addUsers_role.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@status", addUsers_status.SelectedItem.ToString());

                                DateTime today = DateTime.Today;
                                cmd.Parameters.AddWithValue("@date", today);


                                cmd.ExecuteNonQuery();
                                clearFields(); 

                                MessageBox.Show("Added successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            displayAddUsers();
        }

        public void clearFields()
        {
            addUsers_username.Text = "";
            addUsers_password.Text = "";
            addUsers_role.SelectedIndex = -1;
            addUsers_status.SelectedIndex = -1;
        }

        private void addUsers_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void addUsers_updateBtn_Click(object sender, EventArgs e)
        {
            if(addUsers_username.Text == "" || addUsers_password.Text == "" || addUsers_role.SelectedIndex == -1 || addUsers_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please select item first", "Message Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string checkUsername = "SELECT * FROM users WHERE username = @usern and id != @id";

                    using (SqlCommand checkUsern = new SqlCommand(checkUsername, connection))
                    {
                        checkUsern.Parameters.AddWithValue("@usern", addUsers_username.Text.Trim());
                        checkUsern.Parameters.AddWithValue("@id", getID);

                        SqlDataAdapter adapter = new SqlDataAdapter(checkUsern);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            string tempUsern = addUsers_username.Text.Substring(0, 1).ToUpper() + addUsers_username.Text.Substring(1);
                            MessageBox.Show(tempUsern + " is existing already", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (addUsers_password.Text.Length < 8)
                        {
                            MessageBox.Show("Invalid password, at least 8 characters are needed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (MessageBox.Show("Are you sure you want to Update ID: " + getID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                string updateData = "UPDATE users SET username = @usern, password = @pass, role = @role, status = @status WHERE id = @id";
                                using (SqlCommand cmd = new SqlCommand(updateData, connection))
                                {
                                    cmd.Parameters.AddWithValue("@usern", addUsers_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pass", addUsers_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@role", addUsers_role.SelectedItem.ToString());
                                    cmd.Parameters.AddWithValue("@status", addUsers_status.SelectedItem.ToString());
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
            displayAddUsers();
        }

        private int getID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = Convert.ToInt32(row.Cells[0].Value);
                addUsers_username.Text = row.Cells[1].Value.ToString();
                addUsers_password.Text = row.Cells[2].Value.ToString();
                addUsers_role.SelectedItem = row.Cells[3].Value.ToString();
                addUsers_status.SelectedItem = row.Cells[4].Value.ToString();
            }
        }

        private void addUsers_deleteBtn_Click(object sender, EventArgs e)
        {
            if (addUsers_username.Text == "" || addUsers_password.Text == "" || addUsers_role.SelectedIndex == -1 || addUsers_status.SelectedIndex == -1)
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

                        string updateData = "DELETE FROM users WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(updateData, connection))
                        {
                            cmd.Parameters.AddWithValue("@id", getID);

                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show("Deleted successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            displayAddUsers();
        }
    }
}
