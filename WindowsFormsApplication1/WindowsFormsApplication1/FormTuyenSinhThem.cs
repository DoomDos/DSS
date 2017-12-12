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
        private DataTable ketnoicsdl(string id)
        {
            // Lấy dữ liệu trường theo mã trường
            string sql = "select Truong.TenTruong, TuyenSinh.* from Truong,TuyenSinh where TuyenSinh.MaTruong='" + id + "' AND Truong.MaTruong='" + id + "'";
            return ExcuteSql.connectDB(sql);

        }
        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTuyenSinhThem_Load(object sender, EventArgs e)
        {
            DataTable tb = ketnoicsdl(id);
            MaTruong.Text = tb.Rows[0][1].ToString();
            TenTruong.Text = tb.Rows[0][0].ToString();
            if (string.IsNullOrEmpty(nam))
            {
                //thêm
            }
            else
            {
                //sửa
                Nam.Text = tb.Rows[0][2].ToString();
                ChiTieu.Text = tb.Rows[0][3].ToString();
                DaTuyen.Text = tb.Rows[0][4].ToString();
            }
        }
        private string sql1()
        {
            string str;
            if (string.IsNullOrEmpty(nam))
            {
                // Thêm theo form
                int chitieu = Convert.ToUInt16(ChiTieu.Text);
                int datuyen = Convert.ToUInt16(DaTuyen.Text);
                int idnam = Convert.ToUInt16(Nam.Text);
                return str = "INSERT INTO TuyenSinh(MaTruong,Nam,ChiTieu,SLDaTuyen) " +
                    "VALUES (N'" + MaTruong.Text + "'," + idnam + "," + chitieu + "," + datuyen + ")";
            }
            else
            {
                // Sửa theo form
                int chitieu = Convert.ToUInt16(ChiTieu.Text);
                int datuyen = Convert.ToUInt16(DaTuyen.Text);
                int idnam = Convert.ToUInt16(nam);
                return str = "UPDATE [dbo].[TuyenSinh]" +
                "   SET      [ChiTieu] = " + chitieu +
                "          ,[SLDaTuyen] = " + datuyen +
                "   WHERE MaTruong = '" + MaTruong.Text + "' AND Nam = " + idnam;
            }
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
      //      try
     //       {
                ExcuteSql.excuteCom(sql1());                
                MessageBox.Show("Lưu thành công.");
                int idnam = Convert.ToInt16(nam);
                Console.WriteLine(MaTruong.Text);
                this.Close();

   /*         }
            catch
            {
                MessageBox.Show("Lỗi! Kiểm tra lại thông tin trên form.");
            } */
        }
    }
}
