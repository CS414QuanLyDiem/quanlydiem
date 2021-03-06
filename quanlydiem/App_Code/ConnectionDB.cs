﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlydiem.App_Code
{
    class ConnectionDB
    {
        private SqlConnection sqlConnection;
        public static string PATH = @"Data Source=localhost;Initial Catalog=QL_Diem;Integrated Security=True";
        public ConnectionDB() {
            sqlConnection = new SqlConnection(PATH);
        }

        private void open()
        {
            if (sqlConnection.State == ConnectionState.Closed)
                sqlConnection.Open();
        }

        private void close()
        {
            if (sqlConnection.State == ConnectionState.Open)
                sqlConnection.Close();
        }

        public int NonQueryCommand(string sql)
        {
            int temp = 0;
            this.open();
            try
            {
               temp = new SqlCommand(sql, sqlConnection).ExecuteNonQuery();
            }catch(System.Data.SqlClient.SqlException){
            }
            this.close();
            return temp;
        }

        public T ScalaCommand<T>(string sql)
        {
            this.open();
            Object ob = new SqlCommand(sql, sqlConnection).ExecuteScalar();
            this.close();
            return (T)ob;
        }

        public DataTable fillDataTable(String sql)
        {
            DataTable dataTable = new DataTable();
            new SqlDataAdapter(sql, sqlConnection).Fill(dataTable);
            return dataTable;
        }
    }
}
