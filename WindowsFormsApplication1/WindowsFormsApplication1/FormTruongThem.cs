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
        private DataTable ketnoicsdl(string id)
        {    
            // Lấy dữ liệu trường theo mã trường
            string sql = "select Truong.* from Truong where Truong.MaTruong='" + id + "'";                   
            return ExcuteSql.connectDB(sql);

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
                // Thêm theo form
                return str = "INSERT INTO Truong(MaTruong,TenTruong,DiaChi,BQL,Website) " +
                    "VALUES (N'" + MaTruong.Text + "',N'" + TenTruong.Text + "',N'" + DiaChi.Text + "',N'" + BQL.Text + "',N'" + Website.Text + "')";  // lay het du lieu tu bang truong de dien du lieu vao form
            }
            else
            {
                // Sửa theo form
                return str = "UPDATE [dbo].[Truong]" +
                "   SET      [TenTruong] = N'" + TenTruong.Text +
                "'          ,[DiaChi] = N'" + DiaChi.Text +
                "'          ,[BQL] = N'" + BQL.Text +
                "'          ,[Website] = N'" + Website.Text +
                "'   WHERE [MaTruong] = '" + MaTruong.Text + "'";
            }
        }
        private void buttonLuu_Click(object sender, EventArgs e)
        {
            try
           {
                if (string.IsNullOrEmpty(MaTruong.Text) || string.IsNullOrEmpty(TenTruong.Text) || string.IsNullOrEmpty(DiaChi.Text) || string.IsNullOrEmpty(BQL.Text) || string.IsNullOrEmpty(Website.Text))
                    MessageBox.Show("Các thông tin phải nhập đầy đủ.");
                else
                {
                    ExcuteSql.excuteCom(sql1());
                    MessageBox.Show("Lưu thành công");
                    this.Close();
                }
                
           }
            catch
            {
                MessageBox.Show("Lỗi! Kiểm tra lại thông tin trên form.");
            }
            
        }
    }
}
