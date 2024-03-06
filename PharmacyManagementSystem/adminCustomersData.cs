using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PharmacyManagementSystem
{
    internal class adminCustomersData
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ACER\OneDrive\Tài liệu\PharmacyManagementSystem.mdf"";Integrated Security=True;Connect Timeout=30";

        public int CID { set; get; }
        public int CustomerID { set; get; }
        public string TotalPrice { set; get; }
        public string Status { set; get; }
        public string DateTransaction { set; get; }
        public List<adminCustomersData> customerDataList()
        {
            List<adminCustomersData> listData = new List<adminCustomersData>();

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectData = "SELECT * FROM transactions";

                using (SqlCommand cmd = new SqlCommand(selectData, connection))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        adminCustomersData acData = new adminCustomersData();

                        acData.CID = (int)reader["id"];
                        acData.CustomerID = (int)reader["customer_id"];
                        acData.TotalPrice = reader["total_price"].ToString();
                        acData.Status = reader["status"].ToString();
                        acData.DateTransaction = ((DateTime)reader["date_trans"]).ToString("MM-dd-yyyy");

                        listData.Add(acData);
                    }
                }
            }
            return listData;
        }
    }
}
