using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCafe.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;      // đóng gói Ctrl + R + E

        public static DataProvider Instantce        // singer talk
        { 
            get 
            {
                if (instance == null)
                {
                    instance = new DataProvider();
                }
                return DataProvider.instance;
            }
            private set
            {
                DataProvider.instance = value;
            }
        }

        private DataProvider() {    ; }

        private string connecttionString = "Data Source=LAPTOP-8JB7NP47\\SQLEXPRESS;Initial Catalog=QuanLyCafe1;Integrated Security=True";

        public DataTable ExecuteQuery(string query, object[] paramater = null)
        {
            DataTable data = new DataTable();          // khoi tao data Table

            using (SqlConnection sqlConnection = new SqlConnection(connecttionString))      // giai phong bo nho moi khi lay data xong
            {

                sqlConnection.Open();               // mo ket noi

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);    // gui lenh truy van den database

                if (paramater != null) 
                {
                    string[] listParamater = query.Split(' ');
                    int i = 0;
                    foreach (string str in listParamater)
                    {
                        if (str.Contains('@'))
                        {
                            sqlCommand.Parameters.AddWithValue(str, paramater[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);             // lenh trung gian lay data tu database

                sqlDataAdapter.Fill(data);         // gan data vao dataTable

                sqlConnection.Close();                  // ngat ket noi
            }

            return data;
        }

//-------------------------------------------------------------------------------------------------//

        public int ExecuteNonQuery(string query, object[] paramater = null)
        {
            int data = 0;          // khoi tao data Table

            using (SqlConnection sqlConnection = new SqlConnection(connecttionString))      // giai phong bo nho moi khi lay data xong
            {

                sqlConnection.Open();               // mo ket noi

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);    // gui lenh truy van den database

                if (paramater != null)
                {
                    string[] listParamater = query.Split(' ');
                    int i = 0;
                    foreach (string str in listParamater)
                    {
                        if (str.Contains('@'))
                        {
                            sqlCommand.Parameters.AddWithValue(str, paramater[i]);
                            i++;
                        }
                    }
                }

                data = sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();                  // ngat ket noi
            }

            return data;
        }

//------------------------------------------------------------------------------------//
        public object ExecuteScalar(string query, object[] paramater = null)
        {
            object data = 0;          // khoi tao data Table

            using (SqlConnection sqlConnection = new SqlConnection(connecttionString))      // giai phong bo nho moi khi lay data xong
            {

                sqlConnection.Open();               // mo ket noi

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);    // gui lenh truy van den database

                if (paramater != null)
                {
                    string[] listParamater = query.Split(' ');
                    int i = 0;
                    foreach (string str in listParamater)
                    {
                        if (str.Contains('@'))
                        {
                            sqlCommand.Parameters.AddWithValue(str, paramater[i]);
                            i++;
                        }
                    }
                }

                data = sqlCommand.ExecuteScalar();

                sqlConnection.Close();                  // ngat ket noi
            }

            return data;
        }
    }
}
