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
        string sql1;
        private void ketnoicsdl()
        {            
            string sql = "select * from Truong";  // Lấy dữ liệu bảng trường            
            dataGridViewTruong.DataSource = ExcuteSql.connectDB(sql); ; //đổ dữ liệu vào datagridview
        }
        private void buttonChitiet_Click(object sender, EventArgs e)
        {

            string id = dataGridViewTruong.CurrentRow.Cells[0].Value.ToString();
            
            var formTuyenSinh = new FormTuyenSinh(id,"");
            formTuyenSinh.ShowDialog();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            var formTruongThem = new FormTruongThem(null);
            formTruongThem.FormClosing += new FormClosingEventHandler(ChildFormClosing);
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

        private void buttonSua_Click(object sender, EventArgs e)
        {
            string id = dataGridViewTruong.CurrentRow.Cells[0].Value.ToString();
            var formTruongThem = new FormTruongThem(id);
            formTruongThem.FormClosing += new FormClosingEventHandler(ChildFormClosing);
            formTruongThem.ShowDialog();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string idDel = dataGridViewTruong.CurrentRow.Cells[0].Value.ToString();
                string sql = "DELETE FROM Truong WHERE MaTruong ='" + idDel + "'"; //Xóa theo mã trường
                var confirmResult = MessageBox.Show("Bạn chắc chắn muốn xóa trường "+ dataGridViewTruong.CurrentRow.Cells[1].Value.ToString() +"?",
                                     "Xóa trường!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {                    
                    ExcuteSql.excuteCom(sql);
                    MessageBox.Show("Xóa thành công");
                    resetForm();
                }
                else
                {
                    
                }
                
            }
            catch
            {
                MessageBox.Show("Không thể xóa!");
            }
        }

        public void resetForm()
        {
            this.comboBoxTimKiem.SelectedIndex = 0;
            this.ketnoicsdl();
        }

        private void ChildFormClosing(object sender, FormClosingEventArgs e)
        {
            resetForm();
   
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            if(comboBoxTimKiem.SelectedIndex == 0)
            {
                // Tìm kiếm với mã trường
                sql1 = "select * from Truong where MaTruong like '%" + textBoxTimKiem.Text+"%'";               
            }
            else
            {
                // Tìm kiếm với tên trường
                sql1 = "select * from Truong where TenTruong like N'%" + textBoxTimKiem.Text + "%'";
            }
            dataGridViewTruong.DataSource = ExcuteSql.connectDB(sql1); ; //đổ dữ liệu vào datagridview
        }
    }
}
