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
    public partial class FormTuyenSinh : Form
    {
        public FormTuyenSinh(string id)
        {
            InitializeComponent();
            this.id = id;
        }
        string id;
        SqlConnection con = conStr.GetDBConnection();
        private void ketnoicsdl(string id)
        {
            con.Open();
            string sql = "select Truong.TenTruong, TuyenSinh.* from Truong,TuyenSinh where TuyenSinh.MaTruong='" + id +"' AND Truong.MaTruong='" + id + "'";  // lay het du lieu trong bang tuyen sinh và truong
            SqlCommand comm = new SqlCommand(sql, con); //bat dau truy van
            comm.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(comm); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            con.Close();  // đóng kết nối
            dataGridViewTS.DataSource = dt; //đổ dữ liệu vào datagridview
        }
        private void buttonThem_Click(object sender, EventArgs e)
        {
            var formTuyenSinhThem = new FormTuyenSinhThem();
            formTuyenSinhThem.ShowDialog();
        }

        private void buttonDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTuyenSinh_Load(object sender, EventArgs e)
        {
            ketnoicsdl(id);
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            string del = dataGridViewTS.CurrentRow.Cells[0].Value.ToString();
            con.Open();
            string sql = "select Truong.TenTruong, TuyenSinh.* from Truong,TuyenSinh where TuyenSinh.MaTruong='" + id + "' AND Truong.MaTruong='" + id + "'";  // lay het du lieu trong bang tuyen sinh và truong
            SqlCommand comm = new SqlCommand(sql, con); //bat dau truy van
            con.Close();
        }

        private void comboBoxNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nam = comboBoxNam.GetItemText(comboBoxNam.SelectedItem);
            if (nam != "Tất cả")
            {      
                con.Open();
                string sql = "select Truong.TenTruong, TuyenSinh.* from Truong,TuyenSinh where TuyenSinh.Nam='" + nam + "' AND Truong.MaTruong='" + id + "' AND TuyenSinh.MaTruong='" + id + "'";  // lay het du lieu trong bang tuyen sinh và truong
                SqlCommand comm = new SqlCommand(sql, con); //bat dau truy van
                comm.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(comm); //chuyen du lieu ve
                DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
                da.Fill(dt);  // đổ dữ liệu vào kho
                con.Close();  // đóng kết nối
                dataGridViewTS.DataSource = dt; //đổ dữ liệu vào datagridview
            }
            else {
                ketnoicsdl(id);
            }
        }
    }
}
