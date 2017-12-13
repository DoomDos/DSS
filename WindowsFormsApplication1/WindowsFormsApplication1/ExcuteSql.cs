using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication1
{
    class ExcuteSql
    {
        public static DataTable connectDB(string sql)
        {
            SqlConnection con = conStr.GetDBConnection();
            con.Open();
            SqlCommand comm = new SqlCommand(sql, con); //bat dau truy van
            comm.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(comm); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            con.Close();  // đóng kết nối
            return dt;
        }
        public static void excuteCom(string sql1)
        {
            SqlConnection conn = conStr.GetDBConnection();
            conn.Open();
            SqlCommand command = new SqlCommand(); //bat dau truy van
            command.Connection = conn;
            command.CommandText = sql1;
            int rowcount = command.ExecuteNonQuery();
            conn.Close();  // đóng kết nối            
        }
        public static SqlDataReader excuteSqlReader(string sql)
        {
            SqlConnection conn = conStr.GetDBConnection();
            conn.Open();
            SqlCommand command = new SqlCommand(); //bat dau truy van
            command.Connection = conn;
            command.CommandText = sql;
            command.ExecuteNonQuery();
            SqlDataReader dr = command.ExecuteReader();
            return dr;
        }
    }
}
