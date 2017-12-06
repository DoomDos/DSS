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
    public partial class FormTruong : Form
    {
        public FormTruong()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-38C3K9H\SQLEXPRESS;Initial Catalog=TuVanTuyenSinh;Integrated Security=True");
        private void ketnoicsdl()
        {
            con.Open();
            string sql = "select * from Truong";  // lay het du lieu trong bang truong
            SqlCommand comm = new SqlCommand(sql, con); //bat dau truy van
            comm.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(comm); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            con.Close();  // đóng kết nối
            dataGridViewTruong.DataSource = dt; //đổ dữ liệu vào datagridview
        }
        private void buttonChitiet_Click(object sender, EventArgs e)
        {

            string id = dataGridViewTruong.CurrentRow.Cells[0].Value.ToString();
            
            var formTuyenSinh = new FormTuyenSinh(id);
            formTuyenSinh.ShowDialog();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            var formTruongThem = new FormTruongThem();
            formTruongThem.ShowDialog();
        }

        private void buttonDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTruong_Load(object sender, EventArgs e)
        {

            comboBoxTimKiem.SelectedIndex = 0;
            ketnoicsdl();
        }
    }
}
