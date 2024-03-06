using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PharmacyManagementSystem
{
    internal class adminAddProductsData
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ACER\OneDrive\Tài liệu\PharmacyManagementSystem.mdf"";Integrated Security=True;Connect Timeout=30;";
   
        public int ID { set; get; }
        public string ProductID { set; get; }
        public string ProductName { set; get; }
        public string Category { set; get; }
        public string Price { set; get; }
        public string Stock { set; get; }
        public string Image { set; get; }
        public string Status { set; get; }
        public string Date { set; get; }

        public List<adminAddProductsData> addProductsList()
        {
            List<adminAddProductsData> listData = new List<adminAddProductsData>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectData = "SELECT * FROM products";

                using (SqlCommand cmd = new SqlCommand(selectData, connection))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        adminAddProductsData aapData = new adminAddProductsData();
                        aapData.ID = (int)reader["id"];
                        aapData.ProductID = reader["prod_id"].ToString();
                        aapData.ProductName = reader["prod_name"].ToString();
                        aapData.Category = reader["category"].ToString();
                        aapData.Price = reader["price"].ToString();
                        aapData.Stock = reader["stock"].ToString();
                        aapData.Image = reader["image"].ToString();
                        aapData.Status = reader["status"].ToString();
                        aapData.Date = ((DateTime)reader["date_insert"]).ToString("MM-dd-yyyy");

                        listData.Add(aapData);
                    }
                }
            }
            return listData;
        }
    }
}
