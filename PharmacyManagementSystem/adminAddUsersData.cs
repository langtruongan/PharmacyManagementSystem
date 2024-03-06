using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace PharmacyManagementSystem
{
    internal class adminAddUsersData
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ACER\OneDrive\Tài liệu\PharmacyManagementSystem.mdf"";Integrated Security=True;Connect Timeout=30";

        public int ID { set; get; }
        public string Username { set; get; }
        public string Password { set; get; }
        public string Role { set; get; }
        public string Status { set; get; }
        public string Date { set; get; }

        public List<adminAddUsersData> listAddUsersData()
        {
            List<adminAddUsersData> listData = new List<adminAddUsersData>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectData = "SELECT * FROM users";

                using (SqlCommand cmd = new SqlCommand(selectData, connection))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        adminAddUsersData aauData = new adminAddUsersData();
                        aauData.ID = (int)reader["id"];
                        aauData.Username = reader["username"].ToString();
                        aauData.Password = reader["password"].ToString();
                        aauData.Role = reader["role"].ToString();
                        aauData.Status = reader["status"].ToString();
                        if (reader["date_register"] != null)
                        {
                            aauData.Date = ((DateTime)reader["date_register"]).ToString("MM/dd/yyyy");
                        }

                        listData.Add(aauData);
                    }

                }
                return listData;
            }
        }
    }
}
