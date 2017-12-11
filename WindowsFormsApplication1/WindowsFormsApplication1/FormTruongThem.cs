using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormTruongThem : Form
    {
        public FormTruongThem(String id)
        {
            InitializeComponent();
            this.id = id;
        }        
        string id;
        SqlConnection con = conStr.GetDBConnection();
        private DataTable ketnoicsdl(string id)
        {
            con.Open();
            string sql = "select Truong.* from Truong where Truong.MaTruong='" + id + "'";  // lay het du lieu tu bang truong de dien du lieu vao form
            SqlCommand comm = new SqlCommand(sql, con); //bat dau truy van
            comm.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(comm); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            con.Close();  // đóng kết nối          
            return dt;

        }
        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTruongThem_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id))
            {
                //thêm
            }
            else
            {
                //sửa
                DataTable tb = ketnoicsdl(id);
                MaTruong.Text = tb.Rows[0][0].ToString();
                TenTruong.Text = tb.Rows[0][1].ToString();
                DiaChi.Text = tb.Rows[0][2].ToString();
                BQL.Text = tb.Rows[0][3].ToString();
                Website.Text = tb.Rows[0][4].ToString();                
            }
        }
        private string sql1()
        {
            string str;
            if (string.IsNullOrEmpty(id))
            {
                return str = "INSERT INTO Truong(MaTruong,TenTruong,DiaChi,BQL,Website) " +
                    "VALUES (N'" + MaTruong.Text + "',N'" + TenTruong.Text + "',N'" + DiaChi.Text + "',N'" + BQL.Text + "',N'" + Website.Text + "')";  // lay het du lieu tu bang truong de dien du lieu vao form
            }
            else
            {
                return str = "UPDATE [dbo].[Truong]" +
                "   SET      [TenTruong] = N'" + TenTruong.Text +
                "'          ,[DiaChi] = N'" + DiaChi.Text +
                "'          ,[BQL] = N'" + BQL.Text +
                "'          ,[Website] = N'" + Website.Text +
                "'   WHERE [MaTruong] = '" + MaTruong.Text + "'";  // lay het du lieu trong bang tuyen sinh và truong
            }
        }
        private void buttonLuu_Click(object sender, EventArgs e)
        {
            try
           {
                con.Open();
                SqlCommand command = new SqlCommand(); //bat dau truy van
                command.Connection = con;
                command.CommandText = sql1();
                int rowcount = command.ExecuteNonQuery();
                con.Close();  // đóng kết nối
                //MessageBox.Show(sql1());                
                this.Close();
                
           }
            catch
            {
                MessageBox.Show("Lỗi! Kiểm tra lại thông tin trên form.");
            }
            
        }
    }
}
