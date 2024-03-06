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
using System.IO;


namespace PharmacyManagementSystem
{
    public partial class adminAddProducts : UserControl
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ACER\OneDrive\Tài liệu\PharmacyManagementSystem.mdf"";Integrated Security=True;Connect Timeout=30;";

        public adminAddProducts()
        {
            InitializeComponent();

            displayCategories();
            displayProducts();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayCategories();
            displayProducts();
        }

        public void displayProducts()
        {
            adminAddProductsData aapData = new adminAddProductsData();
            List<adminAddProductsData> listData = aapData.addProductsList();

            dataGridView1.DataSource = listData;
        }

        public void displayCategories()
        {
            addProducts_category.Items.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectCategories = "SELECT * FROM categories WHERE status = 'Active'";

                using (SqlCommand cmd = new SqlCommand(selectCategories, connection))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        addProducts_category.Items.Add(reader["category"]);
                    }
                }
            }
        }

        private void addProducts_importBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png | *.jpg; *.jng)";

                string imagePath = "";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    addProducts_imageView.ImageLocation = imagePath;
                }
            } catch(Exception ex)
            {
                MessageBox.Show("Error " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addProducts_addBtn_Click(object sender, EventArgs e)
        {
            if(addProducts_prodID.Text == "" || addProducts_productname.Text == "" || addProducts_category.SelectedIndex == -1 
                || addProducts_price.Text == "" || addProducts_stock.Text == "" || addProducts_status.SelectedIndex == -1
                || addProducts_imageView.Image == null)
            {
                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string chechProdID = "SELECT * FROM products WHERE prod_id = @prodID";

                    using(SqlCommand checkPID = new SqlCommand(chechProdID, connection))
                    {
                        checkPID.Parameters.AddWithValue("@prodID", addProducts_prodID.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(checkPID);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if(table.Rows.Count > 0)
                        {
                            MessageBox.Show(addProducts_prodID.Text.Trim() + " is taken already", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        } else
                        {
                            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

                            string insertData = "INSERT INTO products (prod_id, prod_name, category, price, stock, image, status, date_insert) VALUES (@prodID, @prodName,@category, @price, @stock, @image, @status, @date)";

                            string relativePath = Path.Combine("products_directory", addProducts_prodID.Text.Trim() + ".jpg");
                            string path = Path.Combine(baseDirectory, relativePath);

                            string directoryPath = Path.GetDirectoryName(path);

                            if (!Directory.Exists(directoryPath))
                            {
                                Directory.CreateDirectory(directoryPath);
                            }

                            File.Copy(addProducts_imageView.ImageLocation, path, true);

                            using (SqlCommand cmd = new SqlCommand(insertData, connection))
                            {
                                cmd.Parameters.AddWithValue("@prodID", addProducts_prodID.Text.Trim());
                                cmd.Parameters.AddWithValue("@prodName", addProducts_productname.Text.Trim());
                                cmd.Parameters.AddWithValue("@category", addProducts_category.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@price", addProducts_price.Text.Trim());
                                cmd.Parameters.AddWithValue("@stock", addProducts_stock.Text.Trim());
                                cmd.Parameters.AddWithValue("@image", path);
                                cmd.Parameters.AddWithValue("@status", addProducts_status.SelectedItem.ToString());

                                DateTime today = DateTime.Today;
                                cmd.Parameters.AddWithValue("@date", today);

                                cmd.ExecuteNonQuery();
                                clearFields();
                                MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    connection.Close();
                }
            }
            displayProducts();
        }

        public void clearFields()
        {
            addProducts_prodID.Text = "";
            addProducts_productname.Text = "";
            addProducts_category.SelectedIndex = -1;
            addProducts_price.Text = "";
            addProducts_stock.Text = "";
            addProducts_status.SelectedIndex = -1;
            addProducts_imageView.Image = null;
        }

        private int getID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;
                addProducts_prodID.Text = row.Cells[1].Value.ToString();
                addProducts_productname.Text = row.Cells[2].Value.ToString();
                addProducts_category.SelectedItem = row.Cells[3].Value.ToString();
                addProducts_price.Text = row.Cells[4].Value.ToString();
                addProducts_stock.Text = row.Cells[5].Value.ToString();
                addProducts_status.SelectedItem = row.Cells[7].Value.ToString();

                string imagePath = row.Cells[6].Value.ToString();

                try
                {
                    if (imagePath != null)
                    {
                        addProducts_imageView.Image = Image.FromFile(imagePath);
                    } else
                    {
                        addProducts_imageView.Image = null;
                    }
                } catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void addProducts_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void addProducts_updateBtn_Click(object sender, EventArgs e)
        {
            if (addProducts_prodID.Text == "" || addProducts_productname.Text == "" || addProducts_category.SelectedIndex == -1
                || addProducts_price.Text == "" || addProducts_stock.Text == "" || addProducts_status.SelectedIndex == -1
                || addProducts_imageView.Image == null)
            {
                MessageBox.Show("Please select item first", "Message Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string checkProdID = "SELECT * FROM products WHERE prod_id = @prod_id and id != @id";

                    using (SqlCommand checkID = new SqlCommand(checkProdID, connection))
                    {
                        checkID.Parameters.AddWithValue("@prod_id", addProducts_prodID.Text.Trim());
                        checkID.Parameters.AddWithValue("@id", getID);

                        SqlDataAdapter adapter = new SqlDataAdapter(checkID);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            string tempID = addProducts_prodID.Text.Substring(0, 1).ToUpper() + addProducts_prodID.Text.Substring(1);
                            MessageBox.Show(tempID + " is existing already", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (MessageBox.Show("Are you sure you want to Update ID: " + getID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                string updateData = "UPDATE products SET prod_id = @prodID, prod_name = @prodName, category = @category, price = @price, stock = @stock, status = @status WHERE id = @id";

                                using (SqlCommand cmd = new SqlCommand(updateData, connection))
                                {
                                    cmd.Parameters.AddWithValue("@prodID", addProducts_prodID.Text.Trim());
                                    cmd.Parameters.AddWithValue("@prodName", addProducts_productname.Text.Trim());
                                    cmd.Parameters.AddWithValue("@category", addProducts_category.SelectedItem.ToString());
                                    cmd.Parameters.AddWithValue("@price", addProducts_price.Text.Trim());
                                    cmd.Parameters.AddWithValue("@stock", addProducts_stock.Text.Trim());
                                    cmd.Parameters.AddWithValue("@status", addProducts_status.SelectedItem.ToString());
                                    cmd.Parameters.AddWithValue("@id", getID);

                                    cmd.ExecuteNonQuery();
                                    clearFields();
                                    MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }     
                }
            }
            displayProducts();
        }

        private void addProducts_deleteBtn_Click(object sender, EventArgs e)
        {
            if (addProducts_prodID.Text == "" || addProducts_productname.Text == "" || addProducts_category.SelectedIndex == -1
                || addProducts_price.Text == "" || addProducts_stock.Text == "" || addProducts_status.SelectedIndex == -1
                || addProducts_imageView.Image == null)
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

                        string deleteData = "DELETE FROM products WHERE id = @id";

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
            displayProducts();
        }
    }
}
