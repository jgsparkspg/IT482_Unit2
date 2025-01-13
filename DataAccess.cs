using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class DataAccess
    {
        private string connection;
        public DataAccess(string connectionString)
        {
            connection = connectionString;
        }

        public DataTable GetNames()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                SqlCommand cmd = new SqlCommand("EXECUTE GetNames");
                cmd.Connection = sqlConnection;
                sqlConnection.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                dataTable.Load(reader);
                return dataTable;
            }


        }
    }
}
