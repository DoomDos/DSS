using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormTuyenSinhThem : Form
    {
        public FormTuyenSinhThem(string id,string nam)
        {
            InitializeComponent();
            this.id = id;
            this.nam = nam;
        }
        string id;
        string nam;
        
        private DataTable ketnoicsdlThem(string id)
        {
            string sql = "select Truong.TenTruong, TuyenSinh.* from Truong,TuyenSinh where TuyenSinh.MaTruong='" + id + "' AND Truong.MaTruong='" + id + "'";
            return ExcuteSql.connectDB(sql);
        }
        private DataTable ketnoicsdlSua(string id)
        {
            // Lấy dữ liệu trường theo mã trường
            string sql = "select Truong.TenTruong, TuyenSinh.* from Truong,TuyenSinh where TuyenSinh.MaTruong='" + id + "' AND Truong.MaTruong='" + id + "' AND TuyenSinh.Nam = '" + nam +"'";
            return ExcuteSql.connectDB(sql);

        }
        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTuyenSinhThem_Load(object sender, EventArgs e)
        {
            DataTable them = ketnoicsdlThem(id);
            DataTable sua = ketnoicsdlSua(id);
            MaTruong.Text = them.Rows[0][1].ToString();
            TenTruong.Text = them.Rows[0][0].ToString();
            if (string.IsNullOrEmpty(nam))
            {
                //thêm
            }
            else
            {
                //sửa
                Nam.Text = sua.Rows[0][2].ToString();
                ChiTieu.Text = sua.Rows[0][3].ToString();
                DaTuyen.Text = sua.Rows[0][4].ToString();
            }
        }
        private string sql1()
        {
            string str;
            if (string.IsNullOrEmpty(nam))
            {
                // Thêm theo form
                return str = "INSERT INTO TuyenSinh(MaTruong,Nam,ChiTieu,SLDaTuyen) " +
                    "VALUES ('" + MaTruong.Text + "','" + Nam.Text + "','" + ChiTieu.Text + "','" + DaTuyen.Text + "')";
            }
            else
            {
                // Sửa theo form
                return str = "UPDATE [dbo].[TuyenSinh]" +
                "   SET      [ChiTieu] = '" + ChiTieu.Text +
                "'          ,[SLDaTuyen] = '" + DaTuyen.Text +
                "'   WHERE MaTruong = '" + MaTruong.Text + "' AND Nam = '" + nam +"'";
            }
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            try
            {
                ExcuteSql.excuteCom(sql1());                
                MessageBox.Show("Lưu thành công.");
                FormTuyenSinh fts = new FormTuyenSinh(id, Nam.Text);               
                this.Close();

            }
            catch
            {
                MessageBox.Show("Lỗi! Kiểm tra lại thông tin trên form.");
            } 
        }
    }
}
