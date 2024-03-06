using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PharmacyManagementSystem
{
    internal class cashierOrdersData
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ACER\OneDrive\Tài liệu\PharmacyManagementSystem.mdf"";Integrated Security=True;Connect Timeout=30;";

        public int ID { set; get; }
        public int customerID { set; get; }
        public string ProdID { set; get; }
        public string ProdName { set; get; }
        public string Category { set; get; }
        public string RegPrice { set; get; }
        public string Quantity { set; get; }
        public List<cashierOrdersData> cashierOrdersList()
        {
            List<cashierOrdersData> listData = new List<cashierOrdersData>();
            int getCIDData = 0;
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string getCID = "SELECT MAX(customer_id) as cID FROM orders";

                using(SqlCommand getCustomerID = new SqlCommand(getCID,connection))
                {
                    using (SqlDataReader readCID = getCustomerID.ExecuteReader())
                    {
                        if (readCID.Read())
                        {
                            if (readCID["cID"] != DBNull.Value)
                            {
                                getCIDData = (int)readCID["cID"];
                            }
                        }
                    }
                }

                string getOrders = "SELECT * FROM orders WHERE customer_id = " + getCIDData;

                using(SqlCommand cmd = new SqlCommand(getOrders, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cashierOrdersData coData = new cashierOrdersData();

                            coData.ID = (int)reader["id"];
                            coData.customerID = (int)reader["customer_id"];
                            coData.ProdID = reader["prod_id"].ToString();
                            coData.ProdName = reader["prod_name"].ToString();
                            coData.Category = reader["category"].ToString();
                            coData.RegPrice = reader["regular_price"].ToString();
                            coData.Quantity = reader["quantity"].ToString();

                            listData.Add(coData);
                        }
                    }
                }
            }
            return listData;
        }
    }
}
