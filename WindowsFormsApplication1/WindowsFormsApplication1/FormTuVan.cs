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
    public partial class FormTuVan : Form
    {
        public FormTuVan()
        {
            InitializeComponent();
        }

        private void buttonDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTuVan_Load(object sender, EventArgs e)
        {
            comboBoxTuVan.SelectedIndex = 0;
        }

        private void textBoxTruong_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(textBoxTruong.Text);
            SqlConnection con = conStr.GetDBConnection();
            con.Open();
            String sql;
            if (comboBoxTuVan.SelectedIndex == 0)
            {

                sql = "select * from Truong where MaTruong like '%" + textBoxTruong.Text + "%'";  // lay het du lieu trong bang truong                
            }
            else
            {
                sql = "select * from Truong where TenTruong like N'%" + textBoxTruong.Text + "%'";  // lay het du lieu trong bang truong 
            }
            SqlCommand comm = new SqlCommand(sql, con); //bat dau truy van
            comm.ExecuteNonQuery();
            SqlDataReader dr = comm.ExecuteReader();
            Console.WriteLine(sql);
            AutoCompleteStringCollection autoCom = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                if (comboBoxTuVan.SelectedIndex == 0)
                    autoCom.Add(dr.GetString(0));
                else
                    autoCom.Add(dr.GetString(1));
            }
            textBoxTruong.AutoCompleteCustomSource = autoCom;

            con.Close();  // đóng kết nối

        }
    }
}
