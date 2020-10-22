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
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            int temp = sqlCommand.ExecuteNonQuery();
            this.close();
            return temp;
        }

        public T ScalaCommand<T>(string sql)
        {
            this.open();
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            Object ob = sqlCommand.ExecuteScalar();
            this.close();
            return (T)ob;
        }

        public DataTable fillDataTable(String sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, sqlConnection);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            return dataTable;
        }

        public DataTable getDataTableProcedure(String nameProcedure, SqlParameter[] pr)
        {
            this.open();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = nameProcedure;
            if (pr != null)
                sqlCommand.Parameters.AddRange(pr);
            SqlDataAdapter adp = new SqlDataAdapter(sqlCommand);
            DataTable tb = new DataTable();
            adp.Fill(tb);
            sqlCommand.Parameters.Clear();
            this.close();
            return tb;
        }
    }
}
