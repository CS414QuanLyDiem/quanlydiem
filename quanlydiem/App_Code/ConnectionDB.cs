using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlydiem.App_Code
{
    class ConnectionDB
    {
        //E:\GitHub\quanlydiem\quanlydiem\App_Data\QLDIEM.mdf
        private SqlConnection sqlConnection;
        public static string PATH = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+ Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\App_Data\QLDIEM.mdf;Integrated Security=True";
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
            this.open();
            int temp = new SqlCommand(sql, sqlConnection).ExecuteNonQuery();
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
