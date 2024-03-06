using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PharmacyManagementSystem
{
    internal class adminAddCategoriesData
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ACER\OneDrive\Tài liệu\PharmacyManagementSystem.mdf"";Integrated Security=True;Connect Timeout=30;";

        public int Id { set; get; }
        public string Category { set; get; }
        public string Status { set; get; }

        public string Date { set; get; }

        public List<adminAddCategoriesData> listAddCategoriesData()
        {
            List<adminAddCategoriesData> listData = new List<adminAddCategoriesData>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectData = "SELECT * FROM categories";

                using (SqlCommand cmd = new SqlCommand(selectData, connection))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        adminAddCategoriesData aacData = new adminAddCategoriesData();
                        aacData.Id = (int)reader["id"];
                        aacData.Category = reader["category"].ToString();
                        aacData.Status = reader["status"].ToString();
                        aacData.Date = ((DateTime)reader["date_insert"]).ToString("MM-dd-yyyy");

                        listData.Add(aacData);
                    }
                }
            }
            return listData;
        }
    }
}
